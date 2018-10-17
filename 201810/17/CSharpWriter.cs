using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Data;
using System.Collections;
using System.Threading;

namespace DLLComplierEditor
{
    /// <summary>
    /// 配置文件的C#生成工具类
    /// </summary>
    public class CSharpWriter
    {
        private static object _lock = new object();
        //所有的文本        
        private static Dictionary<string, int> _allTexts = new Dictionary<string, int>(10240);
        private static List<DataTable> _tableList = new List<DataTable>();
        private static Dictionary<string, List<ColumnInfo>>  _columnInfoAry = new Dictionary<string, List<ColumnInfo>>();

        // Data类中填充数据的阀值，超过这个值就分函数填充数据
        private static readonly int CN_SPLIT_THRESHOLD = 8000;

        public static void ClearData()
        {
            _allTexts.Clear();
            _tableList.Clear();
            _columnInfoAry.Clear();
        }

        /// <summary>
        /// 公共接口,用于写C#的自动生成文件
        /// </summary>
        /// <param name="declareDir"></param>
        /// <param name="dataDir"></param>
        public static void WriteCSharpData(string declareDir, string dataDir)
        {
            //数据转换文件
            string cfgfile = dataDir + "/DataConverter.cs";
            cfgfile = cfgfile.Replace('\\', '/');
            WriteFile(cfgfile, GetConvertString());

            //1、加载所有lua配置数据的类
            string cfgfile2 = Defines.CN_CONFIG_DATA_CODE_SOURCE_PATH_LUA + "/LuaDataConverter.lua";
            cfgfile2 = cfgfile2.Replace('\\', '/');
            WriteFile(cfgfile2, GetConvertString2());

            //写定义文件
            string definefile = dataDir + "/StringDefines.cs";
            definefile = definefile.Replace('\\', '/');
            WriteFile(definefile, GetStringDefinesString());

            //2、所有配置中的所有文字lua表
            string definefile2 = Defines.CN_CONFIG_DATA_CODE_SOURCE_PATH_LUA + "/StringDefines.lua";
            definefile2 = definefile2.Replace('\\', '/');
            WriteFile(definefile2, GetStringDefinesString2());

            //3、用于c#的Declare类,根据id获取lua文字表中的值
            string definefile3 = dataDir + "/CfgStringLua.cs";
            definefile3 = definefile3.Replace('\\', '/');
            WriteFile(definefile3, GetStringDefinesString3());

            //写所有定义文件的列表文件
            string declareListFile = declareDir + "/DeclareList.cs";
            declareListFile = declareListFile.Replace('\\', '/');
            WriteFile(declareListFile, GetDeclareListString());

            string declareVersionFile = declareDir + "/DeclareSvnVersion.cs";
            declareVersionFile = declareVersionFile.Replace('\\', '/');
            WriteFile(declareVersionFile, GetSvnVersionString());

            //File.Copy(definefile3, "Assets/Plugins/FuncellData/CfgStringLua.cs");
            //File.Copy(cfgfile2, "Assets/StreamingAssets/Lua/LuaDataConverter.lua");
            //File.Copy(definefile2, "Assets/StreamingAssets/Lua/Config/StringDefines.lua");
        }

        // 根据读Excel出来的数据来生成CS文件
        public static void WriteDataDeclareCSEx(string declareDir, string dataDir, DataTable dt, List<ColumnInfo> fieldTypeRawAry)
        {
            try
            {
                lock (_tableList)
                {
                    // 把表先放进来，后面需要遍历生成DataConverter.cs，需要用到每个表的名字
                    _tableList.Add(dt);
                    _columnInfoAry[dt.TableName] = fieldTypeRawAry;
                }
                
                //数据结构声明文件
                string formatedTableUpName = FormartName(dt.TableName);
                
                //4、数据定义文件（更新了从lua端调用数据）
                string fileH = declareDir + "/Declare" + formatedTableUpName + ".cs";
                fileH = fileH.Replace('\\', '/');
                WriteFile(fileH, string.Equals(formatedTableUpName, "messagestring", StringComparison.OrdinalIgnoreCase) ? GetMessageStringDeclareClass(dt, formatedTableUpName) : GetDeclareString(dt, formatedTableUpName, fieldTypeRawAry));

                var starttick11 = Environment.TickCount;
                //数据文件
                string file = dataDir + "/Data" + formatedTableUpName + ".cs";
                file = file.Replace('\\', '/');
                WriteFile(file, string.Equals(formatedTableUpName, "messagestring", StringComparison.OrdinalIgnoreCase) ? GetMessageStringImplementClass(dt, formatedTableUpName) : GetImplementString(dt, formatedTableUpName, fieldTypeRawAry));

                //5、创建每个配置lua表
                string file2 = Defines.CN_CONFIG_DATA_CODE_SOURCE_PATH_LUA + "/Data" + formatedTableUpName + ".lua";
                file2 = file2.Replace('\\', '/');
                WriteFile(file2, GetImplementString2(dt, formatedTableUpName, fieldTypeRawAry));

                //宏定义文件
                string defineFile = declareDir + "/" + formatedTableUpName + "Define" + ".cs";
                defineFile = defineFile.Replace('\\', '/');
                string defineString = GetDefineString(dt, formatedTableUpName, fieldTypeRawAry);
                if (!string.IsNullOrEmpty(defineString))
                {
                    WriteFile(defineFile, defineString);
                    //File.Copy(defineFile, "Assets/Plugins/FuncellDeclare/" + formatedTableUpName + "Define.cs");
                }
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogException(ex);
            }
        }

        //写CS文件
        private static void WriteFile(string fileName, string cSharpString)
        {
            try
            {
                if (!Directory.Exists(Defines.CN_CONFIG_DECLARE_CODE_SOURCE_PATH))
                {
                    Directory.CreateDirectory(Defines.CN_CONFIG_DECLARE_CODE_SOURCE_PATH);
                }
                if (!Directory.Exists(Defines.CN_CONFIG_DATA_CODE_SOURCE_PATH))
                {
                    Directory.CreateDirectory(Defines.CN_CONFIG_DATA_CODE_SOURCE_PATH);
                }
                if (!Directory.Exists(Defines.CN_CONFIG_DATA_CODE_SOURCE_PATH_LUA))
                {
                    Directory.CreateDirectory(Defines.CN_CONFIG_DATA_CODE_SOURCE_PATH_LUA);
                }
                using (Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    UTF8Encoding coding = new System.Text.UTF8Encoding(false);
                    StreamWriter writer = new StreamWriter(stream, coding);
                    writer.BaseStream.Seek(0, SeekOrigin.End);
                    Byte[] encodedBytes = coding.GetBytes(cSharpString);
                    cSharpString = coding.GetString(encodedBytes);
                    writer.Write(cSharpString);
                    writer.Flush();
                }
            }
            catch (Exception ex)
            {
                //Log.Write("写C#文件错误： {0},{1}", fileName, ex.Message);
                UnityEngine.Debug.LogError(string.Format("写C#文件错误： {0},{1}", fileName, ex.Message));
            }
        }

        #region //类文件字符串生成函数
        private static string GetSvnVersionString()
        {
            // 用当前的时间来当version
            string version = DateTime.Now.ToString("yyyyMMddhhmm");
            UnityEngine.Debug.Log("This version = " + version);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("//文件是自动生成,请勿手动修改.此类用于定义通用数据.");
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("namespace Funcell.Cfg.Data");
            sb.AppendLine("{");
            sb.AppendLine("    //所有的数据配置版本号");
            sb.AppendLine("    public class DeclareSvnVersion");
            sb.AppendLine("    {");
            sb.AppendLine("         public static long Version = "+version+";");
            sb.AppendLine("    }");
            sb.AppendLine("}");
            return sb.ToString();
        }

        //转换类的实现 DataConverter
        private static string GetConvertString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("//文件是自动生成,请勿手动修改.此类只有一个接口用于填充字典数据.");
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("namespace Funcell.Cfg.Data");
            sb.AppendLine("{");
            sb.AppendLine("  public class DataConverter");
            sb.AppendLine("  {");
            sb.AppendLine("    private static bool _isLoaded = false;");
            sb.AppendLine("    public static bool IsLoaded()");
            sb.AppendLine("    {");
            sb.AppendLine("        return _isLoaded;");
            sb.AppendLine("    }");
            sb.AppendLine("    public static void Load()");
            sb.AppendLine("    {");
            sb.AppendLine("        _isLoaded = false;");
            sb.AppendLine("        return;");
            string tableName = string.Empty;
            //各个数据处理
            foreach (DataTable dt in _tableList)
            {
                tableName = FormartName(dt.TableName);
                sb.AppendLine("       Declare" + tableName + ".SetFillDataCallBack(Data" + FormartName(dt.TableName) + ".Convert);");
            }
            sb.AppendLine("        _isLoaded = true;");
            sb.AppendLine("    }");
            sb.AppendLine("    public static void FillData(bool needSleep = true,int sleepLen = 2)");
            sb.AppendLine("    {");
            sb.AppendLine("        ");
            //各个数据处理
            foreach (DataTable dt in _tableList)
            {
                tableName = FormartName(dt.TableName);
                sb.AppendLine("       var " + tableName + "Dict = Declare" + tableName + ".CacheData;");
                sb.AppendLine("       " + tableName + "Dict = null;");
                sb.AppendLine("       if(needSleep) System.Threading.Thread.Sleep(sleepLen);");
            }
            sb.AppendLine("        ");
            sb.AppendLine("    }");
            sb.AppendLine("  }");
            sb.AppendLine("}");
            return sb.ToString();
        }

        //转换类的实现 DataConverter
        private static string GetConvertString2()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--文件是自动生成,请勿手动修改.此类只有一个接口用于填充字典数据.");

            string tableName = string.Empty;
            //各个数据处理
            foreach (DataTable dt in _tableList)
            {
                sb.AppendFormat("require('Lua.Data{0}')", FormartName(dt.TableName));
                sb.AppendLine();
            }
            return sb.ToString();
        }

        //定义类实现 StringDefines.cs
        private static string GetStringDefinesString()
        {            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("//文件是自动生成,请勿手动修改.此类用于定义通用数据.");
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("namespace Funcell.Cfg.Data");
            sb.AppendLine("{");
            sb.AppendLine("    //所有的字符串定义");
            sb.AppendLine("    public class StringDefines");
            sb.AppendLine("    {");
            foreach (var key in _allTexts.Keys)            
            {
                sb.AppendFormat("        public const string Key_{0}= {1};", _allTexts[key], key);
                sb.AppendLine();
            }
            sb.AppendLine("    }");
            sb.AppendLine("}");
            return sb.ToString();

        }

        //定义类实现 StringDefines.lua
        private static string GetStringDefinesString2()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--文件是自动生成,请勿手动修改.此类用于定义通用数据.");
            sb.AppendLine("return");
            sb.AppendLine("{");

            foreach (var key in _allTexts.Keys)
            {
                sb.AppendFormat("   [{0}] = {1},\n", _allTexts[key]+1,key);
            }

            sb.AppendLine("}");
            return sb.ToString();

        }

        //定义类实现 CfgStringLua.cs
        private static string GetStringDefinesString3()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("//文件是自动生成,请勿手动修改.此类用于定义通用数据.");
            sb.AppendLine("using XLua;");
            sb.AppendLine("namespace Funcell.Cfg.Data");
            sb.AppendLine("{");
            sb.AppendLine("    //所有的字符串(从lua表获取)");
            sb.AppendLine("    public class CfgStringLua");
            sb.AppendLine("    {");
            sb.AppendLine("         private static string[] strArr;");
            sb.AppendLine("         public static string Get(int id)");
            sb.AppendLine("         {");
            sb.AppendLine("             if (strArr == null)");
            sb.AppendLine("             {");
            sb.AppendLine("                 strArr = LuaEnv.SharedLuaEnv.Global.Get<string[]>(\"StringDefines\");");
            sb.AppendLine("                 if (strArr == null)");
            sb.AppendLine("                 {");
            sb.AppendLine("                     LuaEnv.SharedLuaEnv.DoString(\"StringDefines = require'Lua/Config/StringDefines'\");");
            sb.AppendLine("                     strArr = LuaEnv.SharedLuaEnv.Global.Get<string[]>(\"StringDefines\");");
            sb.AppendLine("                 }");
            sb.AppendLine("             }");
            sb.AppendLine("             if (id < 0 || id >= strArr.Length)");
            sb.AppendLine("                 return null;");
            sb.AppendLine("             return strArr[id];");
            sb.AppendLine("         }");
            sb.AppendLine("    }");
            sb.AppendLine("}");
            return sb.ToString();

        }

        //数据定义类的通用实现 DeclareXXX
        private static string GetDeclareString(DataTable dt, string TableUpName, List<ColumnInfo> fieldTypeRawAry)
        {
            int KeyIndex = 0;
            string KeyType = "";
            string DataStructName = "";
            string DeclareClassName = "Declare" + TableUpName;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("//文件是自动生成,请勿手动修改.来自数据文件:" + dt.TableName);
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using XLua;");
            sb.AppendLine("namespace Funcell.Cfg.Data");
            sb.AppendLine("{");
            sb.AppendLine("  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@\"" + DeclareClassName + "\")]");
            sb.AppendLine("  public class " + DeclareClassName);
            sb.AppendLine("  {");
            
            // 记录有多少行的数据
            int count = dt.Rows.Count;
            //本表的字段类型列表
            //List<ColumnInfo> fieldTypeRawAry = ExcelReader.GetColumnInfoAry[dt.TableName];

            // 对字符段进行排序
            List<ColumnInfo> fieldTypeAry = SortDeclareStringFieldName(fieldTypeRawAry);
            //1.生成私有变量定义
            sb.AppendLine("    #region //私有变量定义");
            for (int i = 0; i < fieldTypeAry.Count; i++)
            {
                var fInfo = fieldTypeAry[i];
                if (fInfo.m_dataType == ColumnDataType.DEFINE)
                    continue;
                //1.备注
                if (!string.IsNullOrEmpty(fInfo.m_comment))
                {
                    // add noteText
                    string[] descripAry = fInfo.m_comment.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < descripAry.Length; ++j)
                        if (descripAry[j].Length > 0)
                            sb.AppendLine("    //" + descripAry[j]);
                }

                //字段类型
                var fieldType = GenFieldType(fInfo);

                sb.AppendFormat("    private {0} _{1};", fieldType, FirstLower(fInfo.m_name));
                sb.AppendLine();

                //如果当前字段是关键索引,那么就保存他的一些信息,用于以后的操作
                if (fInfo.m_isIndex)
                {
                    KeyIndex = i;
                    KeyType = fieldType;
                    DataStructName = "Dictionary<" + fieldType + ", " + DeclareClassName + ">";
                }
            }
            sb.AppendLine("    #endregion");

            //2.生成属性定义
            sb.AppendLine();
            sb.AppendLine("    #region //公共属性");
            for (int i = 0; i < fieldTypeAry.Count; i++)
            {                
                var fInfo = fieldTypeAry[i];
                if (fInfo.m_dataType == ColumnDataType.DEFINE)
                    continue;
                sb.AppendFormat("    [global::ProtoBuf.ProtoMember({0}, IsRequired = true, Name=@\"{1}\", DataFormat = global::ProtoBuf.DataFormat.{2})]", i + 1, FormartName(fInfo.m_name), GenDataFormat(fInfo));
                sb.AppendLine();
                sb.AppendFormat("    public {0} {1} {{ get{{ return _{2}; }} set{{ _{2}=value; }} }}", GenFieldType(fInfo), FormartName(fInfo.m_name), FirstLower(fInfo.m_name));
                sb.AppendLine();
            }
            sb.AppendLine("    #endregion");

            //3.生成静态处理 -- Create函数
            sb.AppendLine();
            sb.AppendLine("    #region //Create函数的定义");

            //处理参数以及内容定义
            StringBuilder paramSB = new StringBuilder();
            StringBuilder bodySB = new StringBuilder();
            paramSB.Append("(");
            for (int i = 0; i < fieldTypeAry.Count; i++)
            {
                var fInfo = fieldTypeAry[i];
                if (fInfo.m_dataType == ColumnDataType.DEFINE)
                    continue;
                var fieldName = FirstLower(fInfo.m_name);
                paramSB.AppendFormat(" {0} in_{1},", GenFieldType(fInfo), fieldName);
                bodySB.AppendFormat("      tmp._{0} = in_{0};", fieldName);
                bodySB.AppendLine();
            }
            if (paramSB.Length > 2)
            {  //删除后面的逗号
                paramSB.Remove(paramSB.Length - 1, 1);
            }
            paramSB.AppendLine(" )");

            sb.AppendFormat("    public static {0} Create{1}", DeclareClassName, paramSB.ToString());
            sb.AppendLine("    {");
            sb.AppendFormat("      {0} tmp = new {0}();", DeclareClassName);
            sb.AppendLine();
            sb.AppendLine(bodySB.ToString());
            sb.AppendLine("      return tmp;");
            sb.AppendLine("    }");
            sb.AppendLine("    #endregion");

            //4.生成静态处理 -- 定义数据缓存CacheData
            sb.AppendLine();
            sb.AppendLine("    #region //静态变量以及方法定义");
            sb.AppendLine("    //线程锁对象");
            sb.AppendLine("    private static object _lockObj = new object();");
            sb.AppendLine("    //填充数据回调");
            sb.AppendLine("    public delegate void OnFillDataHandler(" + DataStructName + " data);");
            sb.AppendLine("    private static OnFillDataHandler _fillDataCallBack = null;");
            sb.AppendLine("    //数据存储字典");
            sb.AppendLine("    private static " + DataStructName + " _dataCaches = " + "null;");
            sb.AppendLine("    public static " + DataStructName + " CacheData");
            sb.AppendLine("    {");
            sb.AppendLine("        get ");
            sb.AppendLine("        {");
            sb.AppendLine("            lock (_lockObj)");
            sb.AppendLine("            {");
            sb.AppendLine("                SetData();");
            sb.AppendLine("                return _dataCaches; ");
            sb.AppendLine("            }");
            sb.AppendLine("        }");
            sb.AppendLine("        set ");
            sb.AppendLine("        {");
            sb.AppendLine("            lock (_lockObj)");
            sb.AppendLine("            {");
            sb.AppendLine("                _dataCaches = value;");
            sb.AppendLine("            }");
            sb.AppendLine("        }");
            sb.AppendLine("    }");
            //SetData
            sb.AppendLine("    public static void SetData()");
            sb.AppendLine("         {");
            sb.AppendLine("             if(_dataCaches == null) && LuaEnv.isLoadLuaCfg");
            sb.AppendLine("             {");
            sb.AppendLine("                 long startTime = DateTime.Now.Ticks;");
          sb.AppendFormat("                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>(\"Data{0}\");", TableUpName);
            sb.AppendLine();
            sb.AppendLine("                 if (dic == null)");
            sb.AppendLine("                  {");
          sb.AppendFormat("                       LuaEnv.SharedLuaEnv.DoString(\"Data{0} = require 'Lua/Config/Data{1}'\");", TableUpName, TableUpName);
            sb.AppendLine();
          sb.AppendFormat("                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>(\"Data{0}\");", TableUpName);
            sb.AppendLine("                  }");
            sb.AppendLine();
            sb.AppendLine("                 if (dic != null)");
            sb.AppendLine("                 {");
            if (count > 0)
            {
                sb.AppendLine("                             _dataCaches = new " + DataStructName + "(" + count + ");");
            }
            else
            {
                sb.AppendLine("                              _dataCaches = new " + DataStructName + "();");
            }
            sb.AppendLine("                     foreach (var item in dic)");
            sb.AppendLine("                     {");
          sb.AppendFormat("                         {0} tmp = new {1}();", DeclareClassName, DeclareClassName);
            sb.AppendLine();
            //for
            int num = 0;
            for (int i = 0; i < fieldTypeAry.Count; i++)
            {
                var fInfo = fieldTypeAry[i];
                if (fInfo.m_dataType == ColumnDataType.DEFINE)
                    continue;
                if (GenFieldType(fInfo)=="string")
            sb.AppendFormat("                       tmp.{0} = CfgStringLua.Get(item.Value[{1}]);", FormartName(fInfo.m_name), num);
                else
            sb.AppendFormat("                       tmp.{0} = item.Value[{1}];", FormartName(fInfo.m_name), num);
            sb.AppendLine();
                num++;
            }
            sb.AppendLine();
            if (KeyType == "string")
            {
                sb.AppendLine("                         _dataCaches.Add(CfgStringLua.Get(item.Key), tmp);");
            }
            else
            {
                sb.AppendLine("                         _dataCaches.Add(item.Key, tmp);");
            }
            sb.AppendLine("                     }");
            sb.AppendLine("                 }");
            sb.AppendLine("                 Record(startTime, DateTime.Now.Ticks, "+ TableUpName + ");");
            sb.AppendLine("             }");

            sb.AppendLine("             if (_dataCaches == null && _fillDataCallBack != null)");
            sb.AppendLine("             {");
            sb.AppendLine("                 if (_dataCaches == null)");
            sb.AppendLine("                 {");
            sb.AppendLine("                     long startTime = DateTime.Now.Ticks;");
            if (count > 0)
            {
            sb.AppendLine("                      _dataCaches = new " + DataStructName + "(" + count + ");");
            }
            else
            {
            sb.AppendLine("                      _dataCaches = new " + DataStructName + "();");
            }
            sb.AppendLine("                      _fillDataCallBack(_dataCaches); ");
            sb.AppendLine("                      Record(startTime, DateTime.Now.Ticks, " + TableUpName + ");");
            sb.AppendLine("                 }");
            sb.AppendLine("             }");
            sb.AppendLine("    }");
            //Record
            sb.AppendLine("    private static void Record(long startTime,long stopTime,string name)");
            sb.AppendLine("    {");
            sb.AppendLine("         FileStream fs = new FileStream(\"E:/ Config.txt\", FileMode.OpenOrCreate, FileAccess.ReadWrite);");
            sb.AppendLine("         int r = fs.Read(new byte[10240], 0, 10240);");
            sb.AppendLine("         if (r > 0)");
            sb.AppendLine("         {");
            sb.AppendLine("             fs.WriteByte(13);");
            sb.AppendLine("             fs.WriteByte(10);");
            sb.AppendLine("         }");
            sb.AppendLine("         byte[] buffer = System.Text.Encoding.Default.GetBytes(name + \"\t\" + \",\t\" + ((float)(stopTime - startTime)) / 10000000);");
            sb.AppendLine("         fs.Write(buffer, 0, buffer.Length);");
            sb.AppendLine("         fs.Close();");
            sb.AppendLine("    }");

            sb.AppendLine("    //设置填充数据回调");
            sb.AppendLine("    public static void SetFillDataCallBack(OnFillDataHandler callBack)");
            sb.AppendLine("    {");
            sb.AppendLine("        _fillDataCallBack = callBack;");
            sb.AppendLine("    }");

            sb.AppendLine("    //根据ID获取数据");
            sb.AppendLine("    public static " + DeclareClassName + " Get(" + KeyType + " id)");
            sb.AppendLine("    {");
            sb.AppendLine("        lock (_lockObj)");
            sb.AppendLine("        {");
            sb.AppendLine("            SetData();");
            sb.AppendLine("            if (_dataCaches != null && _dataCaches.ContainsKey(id))");
            sb.AppendLine("            {");
            sb.AppendLine("                return _dataCaches[id];");
            sb.AppendLine("            }");
            sb.AppendLine("            return null;");
            sb.AppendLine("        }");
            sb.AppendLine("    }");

            sb.AppendLine("    //transForm函数，作数据填充");
            sb.AppendLine("    public static void Transform(" + DataStructName + " data)");
            sb.AppendLine("    {");
            sb.AppendLine("        lock (_lockObj)");
            sb.AppendLine("        {");
            sb.AppendLine("            _dataCaches = data;");
            sb.AppendLine("        }");
            sb.AppendLine("    }");
            sb.AppendLine("    #endregion");
            sb.AppendLine("  }");
            sb.AppendLine("}");

            return sb.ToString();
        }

        //类型定义文件
        private static string GetDefineString(DataTable dt, string TableUpName, List<ColumnInfo> fieldTypeAry)
        {
            List<int> defineCol = new List<int>();
            int keyCol = -1;
            List<string> defineColName = new List<string>();
            //List<ColumnInfo> fieldTypeAry = ExcelReader.GetColumnInfoAry[dt.TableName];
            for (int i = 0; i < fieldTypeAry.Count; ++i)
            {
                if (fieldTypeAry[i].m_dataType == ColumnDataType.DEFINE)
                {
                    defineCol.Add(i);
                    defineColName.Add(FormartName(fieldTypeAry[i].m_name));
                }
                if (fieldTypeAry[i].m_isIndex)
                {
                    keyCol = i;
                }
            }

            if (defineCol.Count <= 0)
                return string.Empty;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("//文件是自动生成,请勿手动修改.来自数据文件:" + dt.TableName);
            sb.AppendLine("namespace Funcell.Cfg.Data");
            sb.AppendLine("{");

            for (int i = 0; i < defineCol.Count; ++i)
            {
                int col = defineCol[i];
                sb.AppendLine("   public enum " + TableUpName + defineColName[i]);
                sb.AppendLine("   {");

                for (int r = 0; r < dt.Rows.Count; ++r)
                {
                    DataRow row = dt.Rows[r];
                    var enumEle = row[col].ToString();
                    var kekEle = row[keyCol].ToString();

                    var valueparams = enumEle.Split(';');
                    if (valueparams.Length > 0)
                    {
                        enumEle = valueparams[0];
                        if (!string.IsNullOrEmpty(enumEle))
                        {
                            if (valueparams.Length > 1)
                            {
                                string text = "";
                                for (int prIndex = 1; prIndex < valueparams.Length; ++prIndex)
                                {
                                    text += valueparams[prIndex];
                                }

                                sb.AppendLine("      /// <summary>");
                                string[] descripAry = text.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                                for (int j = 0; j < descripAry.Length; ++j)
                                {
                                    if (descripAry[j].Length > 0)
                                        sb.AppendLine("      ///" + descripAry[j]);
                                }
                                sb.AppendLine("      /// </summary>");
                            }
                            sb.AppendLine("      " + enumEle + " = " + kekEle + ",");
                        }
                    }
                }

                sb.AppendLine("   }");
            }
            sb.AppendLine("}");
            return sb.ToString();
        }

        //数据填充类的通用实现 DataXXX
        private static string GetImplementString(DataTable dt, string TableUpName, List<ColumnInfo> fieldTypeRawAry)
        {
            string DeclareClassName = "Declare" + TableUpName;
            string DataStructName = "";
            int KeyIndex = 0;

            //内容填充
            //List<ColumnInfo> fieldTypeRawAry = ExcelReader.GetColumnInfoAry[dt.TableName];
            List<ColumnInfo> fieldTypeAry = SortDeclareStringFieldName(fieldTypeRawAry);
            for (int i = 0; i < fieldTypeAry.Count; i++)
            {
                var fInfo = fieldTypeAry[i];
                if (fInfo.m_dataType == ColumnDataType.DEFINE)
                    continue;
                //如果当前字段是关键索引,那么就保存他的一些信息,用于以后的操作
                if (fInfo.m_isIndex)
                {
                    KeyIndex = i;
                    //字段类型
                    var fieldType = GenFieldType(fInfo);
                    DataStructName = "Dictionary<" + fieldType + ", " + DeclareClassName + ">";
                }
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("//文件是自动生成,请勿手动修改.来自数据文件:" + dt.TableName);
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("namespace Funcell.Cfg.Data");
            sb.AppendLine("{");
            sb.AppendLine("  public class Data" + TableUpName);
            sb.AppendLine("  {");
            sb.AppendLine("      #region //数据填充");

            // 1. 如果超过这个阀值就要单独处理成几个函数写数据了
            if (dt.Rows.Count > CN_SPLIT_THRESHOLD)
            {
                // 需要生成函数的数量
                int funCount = 0;
                if (dt.Rows.Count % CN_SPLIT_THRESHOLD == 0)
                    funCount = dt.Rows.Count / CN_SPLIT_THRESHOLD;
                else
                    funCount = (dt.Rows.Count - (dt.Rows.Count % CN_SPLIT_THRESHOLD)) / CN_SPLIT_THRESHOLD + 1;
                // 函数名
                string[] funcNames = new string[funCount];
                // 数据分割
                Dictionary<int, List<DataRow>> dataDict = new Dictionary<int, List<DataRow>>();
                for (int index = 0; index < dt.Rows.Count; ++index)
                {
                    AddToDict(dataDict, index % funCount, dt.Rows[index]);
                }
                // 函数生成
                foreach (var index in dataDict.Keys)
                {
                    sb.AppendLine("      public static void Convert" + index.ToString() + "(" + DataStructName + " data)");
                    sb.AppendLine("      {");
                    GenMultipleFunc(dt, dataDict[index], fieldTypeAry, sb, DeclareClassName, KeyIndex);
                    sb.AppendLine("      }");
                    funcNames[index] = "Convert" + index.ToString();
                }
                // 调用分割数据的函数
                sb.AppendLine("      public static void Convert(" + DataStructName + " data)");
                sb.AppendLine("      {");
                sb.AppendLine("          if(data == null) return;");
                sb.AppendLine("          data.Clear();");
                for (int i = 0; i < funcNames.Length; i++)
                {
                    sb.AppendLine("          " + funcNames[i] + "(data);");
                }
                sb.AppendLine("      }");
            }
            // 2. 正常情况，数据量不大的就不走分割的那套流程
            else
            {
                sb.AppendLine("      public static void Convert(" + DataStructName + " data)");
                sb.AppendLine("      {");
                sb.AppendLine("          if(data == null) return;");
                sb.AppendLine("          data.Clear();");

                string rowStr = "";
                for (int r = 0; r < dt.Rows.Count; ++r)
                {
                    DataRow row = dt.Rows[r];
                    rowStr = "";
                    for (int i = 0; i < fieldTypeAry.Count; ++i)
                    {
                        if (fieldTypeAry[i].m_dataType == ColumnDataType.DEFINE)
                            continue;
                        rowStr += GenFieldValueString(row[fieldTypeAry[i].m_columnIndex], fieldTypeAry[i], DeclareClassName) + ", ";
                    }
                    int lastDIndex = rowStr.LastIndexOf(',');
                    rowStr = rowStr.Remove(lastDIndex, 2);

                    sb.AppendFormat("          data.Add({1},{0}.Create({2}));",
                        DeclareClassName,          //数据定义类的类名
                        GenFieldValueString(row[fieldTypeAry[KeyIndex].m_columnIndex], fieldTypeAry[KeyIndex], DeclareClassName), //关键值的定义
                        rowStr          //添加Create参数值
                        );
                    sb.AppendLine();
                }

                sb.AppendLine("      }");
            }
            sb.AppendLine("      #endregion");

            sb.AppendLine("  }");
            sb.AppendLine("}");
            
            return sb.ToString();
        }

        //数据填充类的通用实现 DataXXX
        private static string GetImplementString2(DataTable dt, string TableUpName, List<ColumnInfo> fieldTypeRawAry)
        {
            string DeclareClassName = "Declare" + TableUpName;
            int KeyIndex = 0;

            List<ColumnInfo> fieldTypeAry = SortDeclareStringFieldName(fieldTypeRawAry);
            for (int i = 0; i < fieldTypeAry.Count; i++)
            {
                var fInfo = fieldTypeAry[i];
                if (fInfo.m_dataType == ColumnDataType.DEFINE)
                    continue;
                //如果当前字段是关键索引,那么就保存他的一些信息,用于以后的操作
                if (fInfo.m_isIndex)
                {
                    KeyIndex = i;
                }
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--文件是自动生成,请勿手动修改.来自数据文件:" + dt.TableName);
            sb.AppendLine("return {");

            {
                string rowStr = "";
                for (int r = 0; r < dt.Rows.Count; ++r)
                {
                    DataRow row = dt.Rows[r];
                    rowStr = "";
                    for (int i = 0; i < fieldTypeAry.Count; ++i)
                    {
                        if (fieldTypeAry[i].m_dataType == ColumnDataType.DEFINE)
                            continue;
                        rowStr += GenFieldValueString(row[fieldTypeAry[i].m_columnIndex], fieldTypeAry[i], DeclareClassName,true) + ", ";
                    }
                    int lastDIndex = rowStr.LastIndexOf(',');
                    rowStr = rowStr.Remove(lastDIndex, 2);

                    sb.AppendFormat("   [{0}] = {{{1}}},",
                    GenFieldValueString(row[fieldTypeAry[KeyIndex].m_columnIndex], fieldTypeAry[KeyIndex], DeclareClassName,true), //关键值的定义
                    rowStr //添加Create参数值
                    );
                    sb.AppendLine();
                }
            }
            sb.AppendLine("}");

            return sb.ToString();
        }

        //数据填充类的通用实现 DataXXX
        private static string GetImplementString3(DataTable dt, string TableUpName, List<ColumnInfo> fieldTypeRawAry)
        {
            string DeclareClassName = "Declare" + TableUpName;
            int KeyIndex = 0;

            List<ColumnInfo> fieldTypeAry = SortDeclareStringFieldName(fieldTypeRawAry);
            for (int i = 0; i < fieldTypeAry.Count; i++)
            {
                var fInfo = fieldTypeAry[i];
                if (fInfo.m_dataType == ColumnDataType.DEFINE)
                    continue;
                //如果当前字段是关键索引,那么就保存他的一些信息,用于以后的操作
                if (fInfo.m_isIndex)
                {
                    KeyIndex = i;
                }
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--文件是自动生成,请勿手动修改.来自数据文件:" + dt.TableName);
            sb.AppendLine("return {");

            {
                string rowStr = "";
                for (int r = 0; r < dt.Rows.Count; ++r)
                {
                    DataRow row = dt.Rows[r];
                    rowStr = "";
                    for (int i = 0; i < fieldTypeAry.Count; ++i)
                    {
                        if (fieldTypeAry[i].m_dataType == ColumnDataType.DEFINE)
                            continue;
                        rowStr += GenFieldValueString(row[fieldTypeAry[i].m_columnIndex], fieldTypeAry[i], DeclareClassName, true) + ", ";
                    }
                    int lastDIndex = rowStr.LastIndexOf(',');
                    rowStr = rowStr.Remove(lastDIndex, 2);

                    sb.AppendFormat("   [{0}] = {{{1}}},",
                    GenFieldValueString(row[fieldTypeAry[KeyIndex].m_columnIndex], fieldTypeAry[KeyIndex], DeclareClassName), //关键值的定义
                    rowStr //添加Create参数值
                    );
                    sb.AppendLine();
                }
            }
            sb.AppendLine("}");

            return sb.ToString();
        }

        private static void AddToDict(Dictionary<int, List<DataRow>> dict, int index, DataRow data)
        {
            if (dict.ContainsKey(index))
                dict[index].Add(data);
            else
            {
                List<DataRow> list = new List<DataRow>();
                list.Add(data);
                dict.Add(index, list);
            }
        }

        // 生成DataXXX中的一个ConvertX函数
        private static void GenMultipleFunc(DataTable dt, List<DataRow> dataRowList, List<ColumnInfo> fieldTypeAry, StringBuilder sb, string DeclareClassName, int KeyIndex)
        {
            string rowStr = "";
            for (int r = 0; r < dataRowList.Count; ++r)
            {
                DataRow row = dataRowList[r];
                rowStr = "";
                for (int i = 0; i < fieldTypeAry.Count; ++i)
                {
                    if (fieldTypeAry[i].m_dataType == ColumnDataType.DEFINE)
                        continue;
                    rowStr += GenFieldValueString(row[fieldTypeAry[i].m_columnIndex], fieldTypeAry[i], DeclareClassName) + ", ";
                }
                int lastDIndex = rowStr.LastIndexOf(',');
                rowStr = rowStr.Remove(lastDIndex, 2);

                sb.AppendFormat("          data.Add({1},{0}.Create({2}));",
                    DeclareClassName,          //数据定义类的类名
                    GenFieldValueString(row[fieldTypeAry[KeyIndex].m_columnIndex], fieldTypeAry[KeyIndex], DeclareClassName), //关键值的定义
                    rowStr          //添加Create参数值
                    );
                sb.AppendLine();
            }
        }

        //字符串字典定义类DeclareMessageString的特殊实现
        private static string GetMessageStringDeclareClass(DataTable dt, string TableUpName)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("//文件是自动生成,请勿手动修改.来自数据文件:" + dt.TableName);
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("namespace Funcell.Cfg.Data");
            sb.AppendLine("{");
            sb.AppendLine("  public class Declare" + TableUpName);
            sb.AppendLine("  {");
            sb.AppendLine("    #region //字符串Key的常量定义");
            //常量定义
            try
            {
                for (int r = 0; r < dt.Rows.Count; ++r)
                {
                    var row = dt.Rows[r];
                    var strKey = row[0];
                    var intKey = row[1];
                    var str = row[2];
                    var keyArray = strKey.ToString().Replace(" ", "").Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var key in keyArray)
                    {
                        var newkey = ProcessMessageStringKey(key);
                        if (newkey != null)
                        {
                            sb.AppendLine("    public const int " + newkey + " = " + Convert.ToInt32(intKey) + ";    //" + ProcessString(str.ToString()));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogError("Load Excel " + dt.TableName+".xlsx error! "+ex.ToString());
            }
            sb.AppendLine("    #endregion");
            sb.AppendLine();
            sb.AppendLine("    //填充数据回调");
            sb.AppendLine("    public delegate void OnFillDataHandler(Dictionary<int,string> data);");
            sb.AppendLine("    private static OnFillDataHandler _fillDataCallBack = null;");
            sb.AppendLine("    //存储ID与字符串对应关系的字典");
            sb.AppendLine("    private static Dictionary<int,string> _dataCaches = null;");
            sb.AppendLine("    public static Dictionary<int,string> CacheData");
            sb.AppendLine("    {");
            sb.AppendLine("        get ");
            sb.AppendLine("        {");
            sb.AppendLine("            if (_dataCaches == null && _fillDataCallBack!=null)");
            sb.AppendLine("            {");
            sb.AppendLine("                _dataCaches = new Dictionary<int,string>();");
            sb.AppendLine("                _fillDataCallBack(_dataCaches); ");
            sb.AppendLine("            }");
            sb.AppendLine("            return _dataCaches; ");
            sb.AppendLine("        }");
            sb.AppendLine("        set { _dataCaches = value; }");
            sb.AppendLine("    }");
            sb.AppendLine();
            sb.AppendLine("    //设置填充数据回调");
            sb.AppendLine("    public static void SetFillDataCallBack(OnFillDataHandler callBack)");
            sb.AppendLine("    {");
            sb.AppendLine("        _fillDataCallBack = callBack;");
            sb.AppendLine("    }");
            sb.AppendLine();
            sb.AppendLine("    //获取字符串");
            sb.AppendLine("    public static string Get(int id)");
            sb.AppendLine("    {");
            sb.AppendLine("        if (_dataCaches == null && _fillDataCallBack!=null)");
            sb.AppendLine("        {");
            sb.AppendLine("            _dataCaches = new Dictionary<int,string>();");
            sb.AppendLine("            _fillDataCallBack(_dataCaches); ");
            sb.AppendLine("        }");
            sb.AppendLine("        if (_dataCaches != null && _dataCaches.ContainsKey(id))");
            sb.AppendLine("        {");
            sb.AppendLine("            return _dataCaches[id];");
            sb.AppendLine("        }");
            sb.AppendLine("        return string.Empty;");
            sb.AppendLine("    }");
            sb.AppendLine();
            sb.AppendLine("    //直接对字符串进行格式化处理");
            sb.AppendLine("    public static string Format(int id,params object[] args)");
            sb.AppendLine("    {");
            sb.AppendLine("        if (_dataCaches == null && _fillDataCallBack!=null)");
            sb.AppendLine("        {");
            sb.AppendLine("            _dataCaches = new Dictionary<int,string>();");
            sb.AppendLine("            _fillDataCallBack(_dataCaches); ");
            sb.AppendLine("        }");
            sb.AppendLine("        if (_dataCaches != null && _dataCaches.ContainsKey(id))");
            sb.AppendLine("        {");
            sb.AppendLine("           return string.Format(_dataCaches[id], args);");
            sb.AppendLine("        }");
            sb.AppendLine("        return string.Empty;");
            sb.AppendLine("    }");
            sb.AppendLine("    //transForm函数，作数据填充");
            sb.AppendLine("    public static void Transform(Dictionary<int,string> data)");
            sb.AppendLine("    {");
            sb.AppendLine("        _dataCaches = data;");
            sb.AppendLine("    }");
            sb.AppendLine("  }");
            sb.AppendLine("}");
            return sb.ToString();
        }

        //字符串字典填充类DataMessageString的特殊实现
        private static string GetMessageStringImplementClass(DataTable dt, string TableUpName)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("//文件是自动生成,请勿手动修改.来自数据文件:" + dt.TableName);
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("namespace Funcell.Cfg.Data");
            sb.AppendLine("{");
            sb.AppendLine("  public class Data" + TableUpName);
            sb.AppendLine("  {");
            sb.AppendLine("    public static void Convert(Dictionary<int,string> data)");
            sb.AppendLine("    {");
            sb.AppendLine("        if(data == null) return;");
            sb.AppendLine("        data.Clear();");
            for (int r = 0; r < dt.Rows.Count; ++r)
            {
                var row = dt.Rows[r];
                var intKey = row[1];
                var str = row[2];
                sb.AppendLine("        data.Add(" + Convert.ToInt32(intKey) + "," + ProcessStringDefines(str.ToString(), TableUpName) + ");");
            }
            sb.AppendLine("    }");
            sb.AppendLine("  }");
            sb.AppendLine("}");
            return sb.ToString();
        }

        //所有定义列表
        private static string GetDeclareListString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("//文件是自动生成,请勿手动修改.此类只有一个接口用于填充字典数据.");
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("namespace Funcell.Cfg.Data");
            sb.AppendLine("{");
            sb.AppendLine("  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @\"DeclareList\")]");
            sb.AppendLine("  public class DeclareList");
            sb.AppendLine("  {");            
            string tableName = string.Empty;


            
            
            StringBuilder msb_1 = new StringBuilder();
            msb_1.AppendLine("   //搜集各自类中的数据到DeclareList类中");
            msb_1.AppendLine("   public static DeclareList CollectDataToList()");
            msb_1.AppendLine("   {");
            msb_1.AppendLine("      DeclareList list = new DeclareList();");


            StringBuilder msb_2 = new StringBuilder();
            msb_2.AppendLine("   //转移数据到各自的定义类中");
            msb_2.AppendLine("   public void Transfer()");
            msb_2.AppendLine("   {");

            int i = 1;
            // 对数据排个序
            Dictionary<string, string> sortedList = SortDeclareListString();
            // 各个数据处理
            foreach (var dict in sortedList)
            {
                tableName = dict.Key;
                var col = GetColumnKey(dict.Value);
                if (tableName == "MessageString")  //字符串数据
                {
                    sb.AppendLine();
                    sb.AppendFormat("    private readonly List<int> _MessageStringKeyList = new List<int>();");
                    sb.AppendLine();
                    sb.AppendFormat("    [global::ProtoBuf.ProtoMember({0}, Name = @\"MessageStringKeyList\", DataFormat = global::ProtoBuf.DataFormat.Default)]", i);
                    sb.AppendLine();
                    sb.AppendLine("    public List<int> MessageStringKeyList");
                    sb.AppendLine();
                    sb.AppendLine("    {");
                    sb.AppendLine("      get{return _MessageStringKeyList;}");
                    sb.AppendLine("    }");

                    msb_1.AppendLine("      list.MessageStringKeyList.AddRange(DeclareMessageString.CacheData.Keys);");
                    msb_1.AppendLine();

                    i++;
                    sb.AppendLine();
                    sb.AppendFormat("    private readonly List<string> _MessageStringValueList = new List<string>();");
                    sb.AppendLine();
                    sb.AppendFormat("    [global::ProtoBuf.ProtoMember({0}, Name = @\"MessageStringValueList\", DataFormat = global::ProtoBuf.DataFormat.Default)]", i);
                    sb.AppendLine();
                    sb.AppendLine("    public List<string> MessageStringValueList");
                    sb.AppendLine();
                    sb.AppendLine("    {");
                    sb.AppendLine("      get{return _MessageStringValueList;}");
                    sb.AppendLine("    }");

                    msb_1.AppendLine("      list.MessageStringValueList.AddRange(DeclareMessageString.CacheData.Values);");
                    msb_1.AppendLine();

                    msb_2.AppendLine("      DeclareMessageString.CacheData = new Dictionary<int,string>();");
                    msb_2.AppendLine("      for (int i = 0; i < MessageStringKeyList.Count; i++)");
                    msb_2.AppendLine("      {");
                    msb_2.AppendLine("         DeclareMessageString.CacheData.Add(MessageStringKeyList[i], MessageStringValueList[i]);");
                    msb_2.AppendLine("      }");

                    i++;

                }
                else
                {
                    sb.AppendLine();
                    sb.AppendFormat("    private readonly List<Declare{0}> _Declare{0}List = new List<Declare{0}>();", tableName);
                    sb.AppendLine();
                    sb.AppendFormat("    [global::ProtoBuf.ProtoMember({1}, Name = @\"Declare{0}List\", DataFormat = global::ProtoBuf.DataFormat.Default)]", tableName, i);
                    sb.AppendLine();
                    sb.AppendFormat("    public List<Declare{0}> Declare{0}List", tableName);
                    sb.AppendLine();
                    sb.AppendLine("    {");
                    sb.AppendFormat("      get{{return _Declare{0}List;}}", tableName);
                    sb.AppendLine();
                    sb.AppendLine("    }");

                    msb_1.AppendFormat("      list._Declare{0}List.AddRange(Declare{0}.CacheData.Values);", tableName);
                    msb_1.AppendLine();

                    msb_2.AppendLine();
                    msb_2.AppendFormat("      Declare{0}.CacheData = new Dictionary<{1},Declare{0}>();", tableName, GenFieldType(col));
                    msb_2.AppendLine();
                    msb_2.AppendFormat("      for (int i = 0; i < _Declare{0}List.Count; i++)", tableName);
                    msb_2.AppendLine();
                    msb_2.AppendLine("      {");
                    msb_2.AppendFormat("         Declare{0}.CacheData.Add(_Declare{0}List[i].{1}, _Declare{0}List[i]);", tableName, FormartName(col.m_name));
                    msb_2.AppendLine();
                    msb_2.AppendLine("      }");
                    i++;
                }
            }
            msb_1.AppendLine("      return list;");
            msb_1.AppendLine("   }");

            msb_2.AppendLine("   }");

            sb.AppendLine();            
            sb.AppendLine(msb_2.ToString());
            sb.AppendLine();            
            sb.AppendLine(msb_1.ToString());
            sb.AppendLine("  }");
            sb.AppendLine("}");
            return sb.ToString();
        }
        #endregion

        #region //工具函数
        //格式化名字
        //把下划线后面的字母转换为大写字母,首字母也会变成大写
        private static string FormartName(string inStr)
        {
            string temp = "";
            string[] resultStr = inStr.Split('_');
            foreach (string tempStr in resultStr)
            {
                temp += char.ToUpper(tempStr[0]) + tempStr.Substring(1);
            }
            return temp;
        }

        //把字符串首字母小写
        private static string FirstLower(string inStr)
        {
            return inStr.Substring(0, 1).ToLower() + inStr.Substring(1);
        }

        //生成字段类型
        private static string GenFieldType(ColumnInfo fInfo)
        {
            switch (fInfo.m_dataType)
            {
                case ColumnDataType.STRING:
                    return "string";
                case ColumnDataType.INT_DATA:
                    return "int";
                case ColumnDataType.INT64_DATA:
                    return "Int64";
                case ColumnDataType.DEFINE:
                    return "string";
                default:
                    return "int";
            }
        }
        //生成字段类型
        private static string GenDataFormat(ColumnInfo fInfo)
        {
            switch (fInfo.m_dataType)
            {
                case ColumnDataType.STRING:
                    return "Default";
                case ColumnDataType.INT_DATA:
                    return "TwosComplement";
                case ColumnDataType.INT64_DATA:
                    return "TwosComplement";
                case ColumnDataType.DEFINE:
                    return "Default";
                default:
                    return "Default";
            }
        }

        /// <summary>
        /// 数字科学计数法处理
        /// </summary>
        /// <param name="strData"></param>
        /// <returns></returns>
        private static Decimal ChangeToDecimal(string strData)
        {
            Decimal dData = 0.0M;
            if (strData.Contains("E"))
            {
                dData = Convert.ToDecimal(Decimal.Parse(strData.ToString(), System.Globalization.NumberStyles.Float));
            }
            else
            {
                dData = Convert.ToDecimal(strData);
            }
            return Math.Round(dData, 0);
        }
        //获取字段的值
        private static string GenFieldValueString(object rowObj, ColumnInfo fInfo, string className,bool isLua = false)
        {
            string tempValue = "0";

            if (rowObj != null)
            {
                string value = rowObj.ToString().Trim(); ;
                if (value.Length != 0)
                {
                    tempValue = value;
                }
                else
                {
                    tempValue = "0";
                }

                switch (fInfo.m_dataType)
                {
                    case ColumnDataType.INT_DATA:
                    case ColumnDataType.INT64_DATA:
                        {
                            tempValue = ChangeToDecimal(tempValue).ToString();
                        }
                        break;
                }

                if (fInfo.m_dataType == ColumnDataType.STRING)
                {
                    tempValue = ProcessStringDefines(value, className,isLua);   
                }
            }
            return tempValue;
        }

        // 处理字符串
        public static string ProcessString(string val)
        {
            if (string.IsNullOrEmpty(val))
            {
                return "\"\"";
            }
            else if (val == "NaN")  //如果是double.NaN,float.NaN,直接返回一个空
            {   
                return "\"\"";
            }
            else
            {
                //val = LanguageConverter.Instance.GetTextByLanguage(val, Program.language);
                /*
                if (val == "\\")
                {
                    return "\"" + val.Replace("\\", "\\\\")+"\"";
                }
                else*/
                //{
                //处理引号和换行
                return "\"" + val.Replace("\\\\", "\\").Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\n", "\\n").Replace("\r", "\\r").Replace("#n", "\\n") + "\"";
                //}
            }
        }

        //处理字符串数据的Key信息
        private static string ProcessMessageStringKey(string key)
        {
            //循环判断处理
            StringBuilder sb = new StringBuilder();
            foreach (var ch in key)
            {
                if (Char.IsLetterOrDigit(ch) || ch == '_')
                {
                    sb.Append(ch);
                }
            }
            //判断首个字符为字母或者下划线
            if (sb.Length > 0 && (Char.IsLetter(sb[0]) || sb[0] == '_'))
            {
                return sb.ToString();
            }
            return null;
        }

        //处理字符串定义
        private static string ProcessStringDefines(string val, string className,bool isLua = false)
        {
            var tempValue = ProcessString(val);

            lock (_allTexts)
            {
                int idx;
                if (!_allTexts.TryGetValue(tempValue, out idx))
                {
                    idx = _allTexts.Count;
                    _allTexts.Add(tempValue, idx);

                    if (tempValue.IndexOf(",") < 0 && tempValue.Length > 2)
                    {
                        tempValue = tempValue.Substring(1, tempValue.Length - 2);
                    }

                    //屏蔽字表不写入LanguageConverter
                    if(className.IndexOf("offstring", StringComparison.CurrentCultureIgnoreCase) == -1)
                        LanguageConverter.Instance.AddText(tempValue);
                }
                tempValue = isLua?idx.ToString():"StringDefines.Key_" + idx;
                return tempValue;
            }
        }

        //获取关键列
        private static ColumnInfo GetColumnKey(string tableName)
        {
            List<ColumnInfo> fieldTypeAry = _columnInfoAry[tableName];           
            if (fieldTypeAry.Count > 0)
            {
                for (int i = 0; i < fieldTypeAry.Count; i++)
                {
                    if (fieldTypeAry[i].m_isIndex)
                    {
                        return fieldTypeAry[i];
                    }
                }
                return fieldTypeAry[0];
            }
            else
            {
                return null;
            }
             
        }

        /// <summary>
        /// 给DeclareListString里面的内容排序
        /// </summary>
        private static Dictionary<string, string> SortDeclareListString()
        {
            Dictionary<string, string> tableNameDict = new Dictionary<string, string>();
            Dictionary<string, string> tempDict = new Dictionary<string, string>();
            ArrayList tableNameList = new ArrayList();
            string tableName = string.Empty;
            string formartTableName = string.Empty;
            // 遍历读Excel的数据，然后用ArrayList来根据字母顺序排个序
            //foreach (DataTable dt in ExcelReader.Instance().GetExcelDatas.Tables)
            foreach(DataTable dt in _tableList)
            {
                tableName = dt.TableName;
                formartTableName = FormartName(dt.TableName);
                tableNameList.Add(formartTableName);
                tempDict.Add(formartTableName, tableName);
                tableNameList.Sort();
            }
            //根据排序后的信息把需要用到的两个数据保存起来
            for (int i = 0; i < tableNameList.Count; i++)
            {
                string tableNameNew = string.Empty;
                tempDict.TryGetValue(tableNameList[i].ToString(), out tableNameNew);
                tableNameDict.Add(tableNameList[i].ToString(), tableNameNew);
            }
            return tableNameDict;
        }

        /// <summary>
        /// 对生成的类的字段进行排序
        /// </summary>
        private static List<ColumnInfo> SortDeclareStringFieldName(List<ColumnInfo> fieldTypeAry)
        {
            ArrayList fieldList = new ArrayList();
            List<ColumnInfo> fieldTypeNewAry = new List<ColumnInfo>();
            for (int i = 0; i < fieldTypeAry.Count; i++)
            {
                fieldTypeAry[i].m_columnIndex = i;
                string fieldName = fieldTypeAry[i].m_name;
                fieldList.Add(fieldName);
            }
            fieldList.Sort();
            foreach (string fieldName in fieldList)
            {
                for (int i = 0; i < fieldTypeAry.Count; i++)
                {
                    if (fieldName.Equals(fieldTypeAry[i].m_name))
                    {
                        fieldTypeNewAry.Add(fieldTypeAry[i]);
                    }
                }
            }
            return fieldTypeNewAry;
        }
        #endregion
    }
}

