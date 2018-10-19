using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;
using System.Data;
using System.Threading;

namespace DLLComplierEditor
{
    public enum ColumnDataType
    {
        INT_DATA,
        INT64_DATA,
        STRING,
        DEFINE, // 枚举类型
    }
    // 列信息描述
    public class ColumnInfo
    {
        public string m_name;
        public Type m_type;             // 列类型                   
        public bool m_isKey;            // 是否是主键
        public bool m_isRef;            // 是否是参考键
        public bool m_isComplex;        // 是否是复合列
        public bool m_isArray;          // 是否数组类型
        public string m_param;          // 复杂列的参数 

        public ColumnDataType m_dataType; //列数据类型
        public bool m_isIndex;            // 是否是索引

        public string m_comment = string.Empty;             // 注释
        public Dictionary<string, string> m_splitDic = null;// 用于复合类型，复合元素描述
        public int m_columnIndex; //索引信息
    }

    /*
     * 加载excel数据，并初始化列信息
     * 加载表的主键信息
     */
    class ExcelReader
    {
        public const int CN_MAX_THREAD_NUM = 10;

        public static int sheetRow = 4; //内容所在行
        public static int sheetHeadRow = 1; //表头所在行
        public static int sheetDataTypeRow = 2; //数据类型所在行
        public static int sheetKeyRow = 0; //key描述所在行

        public static bool ignore = false;

        
        private static int _threadCount = 0;
        private static readonly object _lock = new object();

        //记录每个文件处理的消耗
        private static Queue<KeyValuePair<string, int>> _records = new Queue<KeyValuePair<string, int>>();


        private static ExcelReader _instance = null;
        public static ExcelReader Instance()
        {
            if (_instance == null)
            {
                _instance = new ExcelReader();
            }
            return _instance;
        }
        private ExcelReader()
        {
            GetExcelDatas = new DataSet();      
        }

        #region LoadExcel
        public DataSet GetExcelDatas = new DataSet();
      


        public void LoadExcelFromFolder(string path, string declareDir, string dataDir)
        {
            if (path == null)
                return;
            UnityEngine.Debug.Log("开始加载配置表");
            //遍历文件
            path = path.Replace('\\', '/');
            DirectoryInfo theFolder = new DirectoryInfo(path);
            FileInfo[] fileInfo = theFolder.GetFiles("*.xls*", SearchOption.AllDirectories);
            int i = 0;
            int sum = fileInfo.Length;
            
            List<FileInfo> needWriteExcels = new List<FileInfo>();
            List<FileInfo> serverExcels = new List<FileInfo>();
            needWriteExcels.Clear();

            foreach (FileInfo f in fileInfo)
            {
                i++;
                UnityEditor.EditorUtility.DisplayProgressBar("配置信息", "读取配置表:"+f.Name, (float)i/ (float)sum);
                FileAttributes fa = f.Attributes & FileAttributes.Hidden;
                if (fa != FileAttributes.Hidden && f.Name.IndexOf('~') == -1 && !f.Name.Contains("server_"))
                {
                    needWriteExcels.Add(f);
                }

                //server表单独存放
                if(fa != FileAttributes.Hidden && f.Name.IndexOf('~') == -1 && f.Name.Contains("server_"))
                {
                    serverExcels.Add(f);
                }
            }

            try
            {
                _records.Clear();
                CSharpWriter.ClearData();
                int len = needWriteExcels.Count;

                //根据文件大小进行排序,这样能让每个线程的负载比较均衡
                needWriteExcels.Sort((x, y) => { return (int)(y.Length - x.Length); });
               
                Thread[] thread = new Thread[CN_MAX_THREAD_NUM];
                Dictionary<int, List<FileInfo>> xlsxFileDict = new Dictionary<int, List<FileInfo>>();

                for (int dataIndex = 0; dataIndex < len; dataIndex++)
                {
                    AddToDict(xlsxFileDict, dataIndex % CN_MAX_THREAD_NUM, needWriteExcels[dataIndex]);
                }
                _threadCount = xlsxFileDict.Count;

                foreach (var index in xlsxFileDict.Keys)
                {
                    thread[index] = new Thread(new ThreadStart(() => LoadExcelWriteCs(xlsxFileDict[index], declareDir, dataDir)));
                    thread[index].Name = index.ToString();
                    thread[index].Start();
                }

                // 让主线程等待导表执行完成然后生成工程
                while (_records.Count != len)
                {
                    UnityEditor.EditorUtility.DisplayProgressBar("配置信息", string.Format("请稍等,正在努力把表格导出为代码文件... ...{0}/{1}", _records.Count, len), (float)_records.Count / (float)len);
                    Thread.Sleep(1000);
                }

                int readServerCount = 0;
                UnityEditor.EditorUtility.DisplayProgressBar("配置信息", string.Format("请稍等,提取Server表的中文{0}/{1}", readServerCount, serverExcels.Count), 0);
                foreach (var info in serverExcels)
                {
                    PeekStringToLanguageConverter(info);
                    readServerCount++;
                    UnityEditor.EditorUtility.DisplayProgressBar("配置信息", string.Format("请稍等,提取{2}表的中文{0}/{1}", readServerCount, serverExcels.Count, info.Name), readServerCount/(float)serverExcels.Count);
                }

                /*
                //打印每个表导出的时间消耗
                while (_records.Count > 0)
                {
                    var kv = _records.Dequeue();
                    UnityEngine.Debug.LogError("file:" + kv.Key + ";;;tick:" + kv.Value);
                }
                */
                CSharpWriter.WriteCSharpData(declareDir, dataDir);                
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogException(ex);
            }
            UnityEditor.EditorUtility.ClearProgressBar();
        }

        private static void AddToDict(Dictionary<int, List<FileInfo>> dict, int index, FileInfo data)
        {
            if (dict.ContainsKey(index))
                dict[index].Add(data);
            else
            {
                List<FileInfo> list = new List<FileInfo>();
                list.Add(data);
                dict.Add(index, list);
            }
        }

        private static void LoadExcelWriteCs(List<FileInfo> fileList, string declareDir, string dataDir)
        {
            //UnityEngine.Debug.LogError("线程::" + Thread.CurrentThread.Name + "--- 处理文件数:" + fileList.Count);
            foreach (var fi in fileList)
            {
                
                var startTick = Environment.TickCount;
                LoadOneExcelEx(fi, declareDir, dataDir);
                var endtick = Environment.TickCount - startTick;
                _records.Enqueue(new KeyValuePair<string, int>(fi.Name, endtick));

            }
            lock (_lock)
            {
                _threadCount = _threadCount - 1;                
            }
            
        }

        private static void PeekStringToLanguageConverter(FileInfo fInfo)
        {
            try
            {
                Funcell.DIY.ExcelWorkSheet sheet = new Funcell.DIY.ExcelWorkSheet(fInfo.FullName);
                int rowLen = sheet.Cells.GetLength(0);

                //每列的类型
                Dictionary<int, ColumnDataType> dictType = new Dictionary<int, ColumnDataType>();
                //需要忽略的列
                Dictionary<int, bool> dictIgnore = new Dictionary<int, bool>();

                //每列数据类型
                if (sheetDataTypeRow < rowLen)
                {
                    int columnLen = sheet.Cells.GetColumnNum(sheetDataTypeRow);
                    for (int i = 0; i < columnLen; ++i)
                    {
                        var value = sheet.Cells[sheetDataTypeRow, i];
                        if (string.IsNullOrEmpty(value))
                            continue;
                        ColumnDataType type = ColumnDataType.INT_DATA;
                        // 分解一列的数据类型
                        if (value.Contains("varchar") || value.Contains("text"))
                        {
                            type = ColumnDataType.STRING;
                        }
                        else if (value.Contains("big"))
                        {
                            type = ColumnDataType.INT64_DATA;
                        }
                        else if (value.Contains("define"))
                        {
                            type = ColumnDataType.DEFINE;
                        }

                        dictType.Add(i, type);
                    }
                }

                //可以忽略的列
                if(sheetRow < rowLen)
                {
                    int columnLen = sheet.Cells.GetColumnNum(sheetRow);
                    for (int i = 0; i < columnLen; ++i)
                    {
                        var value = sheet.Cells[sheetRow, i];
                        dictIgnore.Add(i, value.IndexOf("ignore", StringComparison.CurrentCultureIgnoreCase) >= 0);
                    }
                }

                //提取字符串
                bool isIgnore = false;
                for(int i = sheetRow + 1; i < rowLen; ++i)
                {
                    int columnLen = sheet.Cells.GetColumnNum(i);
                    for(int j = 0; j < columnLen; ++j)
                    {
                        if(dictIgnore.TryGetValue(j, out isIgnore))
                        {
                            if (isIgnore)
                                continue;
                        }

                        ColumnDataType dataType = ColumnDataType.INT_DATA;
                        if(dictType.TryGetValue(j, out dataType))
                        {
                            if(dataType == ColumnDataType.STRING)
                            {
                                var tempValue = CSharpWriter.ProcessString(sheet.Cells[i, j]);
                                if (tempValue.IndexOf(",") < 0 && tempValue.Length > 2)
                                {
                                    tempValue = tempValue.Substring(1, tempValue.Length - 2);
                                }
                                LanguageConverter.Instance.AddText(tempValue);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogError(string.Format("加载{0}表异常： {1}", fInfo.Name, ex.ToString()));
            }
        }
        
        public static DataTable LoadOneExcelEx(FileInfo fInfo, string declareDir, string dataDir)
        {
            string name = "";
            try
            {   
                // 拼接具体的Excel路径
                string str = fInfo.DirectoryName + "/" + fInfo.Name;
                str = str.Replace('\\', '/');
                // 一张表的数据
                Dictionary<int, string[]> sheet = new Dictionary<int,string[]>();                
                sheet = ExcelFile.ReadExcel(str);                
                if (sheet == null)
                    return null;
                string[] headerRow;
                // 获取表头标题行的数据
                sheet.TryGetValue(sheetHeadRow, out headerRow);
                if (headerRow == null)
                    return null;
                //截取生成Excel的名字，用来作为CS的文件名,exsample AAA.xlsx->AAA
                name = fInfo.Name.Substring(0, fInfo.Name.IndexOf('.'));
                // 行数
                int rowCount = sheet.Count;
                // 列数
                int colCount = headerRow.Length;
                // 一张Excel表的数据
                DataTable table = new DataTable(name);              

                // 把一张表表头的数据放进来
                for (int i = 0; i < colCount; i++)
                {
                    string colName = i.ToString();
                    string col = headerRow[i].ToString();
                    if (col != null)
                        colName = col.ToString();
                    DataColumn column = new DataColumn(colName);
                    table.Columns.Add(column);
                }

                // 这里把表里面具体内容的每行数据写进数据结构，从第五行开始读取和存放数据
                for (int i = sheetRow + 1; i < rowCount; i++)
                {
                    DataRow dataRow = table.NewRow();
                    if (!sheet.ContainsKey(i)) continue;
                    // 获取每行的数据
                    var row = sheet[i];
                    // 根据列数读取一行的数据保存下来
                    for (int j = 0; j < colCount; j++)
                    {
                        string value = string.Empty;
                        if (row != null && row[j] != null)
                        {
                            value = row[j];
                        }
                        dataRow[j] = value;
                    }
                    // 每行的数据添加进数据结构
                    table.Rows.Add(dataRow);
                }

                // 初始化表头信息
                bool hasIndex = false;
                List<ColumnInfo> colInfoAry = new List<ColumnInfo>();
                for (int i = colCount - 1; i >= 0; i--)
                {
                    ColumnInfo cInfo = GetFieldInfo(i, sheet, colInfoAry, name);

                    if (cInfo != null)
                    {
                        colInfoAry.Insert(0, cInfo);
                        if (cInfo.m_isIndex)
                        {
                            hasIndex = true;
                        }
                    }
                    else
                        table.Columns.RemoveAt(i);
                }

                if (!hasIndex)
                {
                    throw new Exception("没有找到被设置为1的索引列!");
                }

                if (colInfoAry.Count > 0)
                {
                    //TableChecker.CheckOut(table,colInfoAry);

                    ReferenceHandle.ReplaceReference(table, colInfoAry);
                    // 根据数据生成CS文件
                    CSharpWriter.WriteDataDeclareCSEx(declareDir,dataDir, table, colInfoAry);
                    
                }

                sheet.Clear();
                sheet = null;
                return table;
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogError(string.Format("加载{0}表异常： {1}", fInfo.Name, ex.ToString()));
            }
            return null;
        }
        #endregion

        #region 检查和获取表头信息
        /// <summary>
        /// 相当于根据表的内容，重新组装下表头，方便写CS文件的时候处理数据
        /// </summary>
        /// <param name="aColIndex"></param>
        /// <param name="aSheet"></param>
        /// <param name="aColInfoAry"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        private static ColumnInfo GetFieldInfo(int aColIndex, Dictionary<int, string[]> aSheet, List<ColumnInfo> aColInfoAry, string tableName)
        {
            // 挨着取第一行单元格的数据
            string cellData = aSheet[sheetHeadRow][aColIndex];
            // 获得第一行每个单元格的参数名,相当于每列的名字
            string fieldName = string.Empty;
            if (cellData != null && cellData.ToString() != null)
                fieldName = cellData.ToString().Replace("\n", " ").Trim(' ');
            ColumnInfo colInfo = new ColumnInfo();
            if (!aSheet.ContainsKey(sheetDataTypeRow)) { return null; }
            // 取数据类型所在行的数据
            var row = aSheet[sheetDataTypeRow];
            string dataType = null;
            if (row != null)
            {
                dataType = row[aColIndex];
            }
            // 查找哪列是1的那列
            string keyType = aSheet[sheetKeyRow][aColIndex];
            // 这行目前有两个作用
            //1. 以前根据"[[]]"标签针对列做单独处理
            //2. 客户端可以跳过不需要处理的一列
            string commentType = aSheet[sheetRow][aColIndex];
            if (commentType != null)
            {
                string tempType = commentType.ToString();
                // 客户端可以跳过不需要处理的内容
                if (tempType.Contains("client ignore"))
                {
                    ignore = true;
                    return null;
                }
            }
            // 分解一列的数据类型
            if (dataType == null)
            {
                colInfo.m_dataType = ColumnDataType.INT_DATA;
            }
            else if (dataType.ToString().Contains("varchar") || dataType.ToString().Contains("text"))
            {
                colInfo.m_dataType = ColumnDataType.STRING;
            }
            else if (dataType.ToString().Contains("big"))
            {
                colInfo.m_dataType = ColumnDataType.INT64_DATA;
            }
            else if (dataType.ToString().Contains("define"))
            {
                colInfo.m_dataType = ColumnDataType.DEFINE;
            }
            else
            {
                colInfo.m_dataType = ColumnDataType.INT_DATA;
            }
            // 查找关键列是哪一列,第一行是1的那一列
            if (keyType != null && keyType.ToString().Equals("1") || keyType.ToString().Equals("1.0"))
            {
                colInfo.m_isIndex = true;
            }
            else
            {
                colInfo.m_isIndex = false;
            }
            // 目前这个参数在导表工程中没有应用了
            colInfo.m_param = fieldName;
            // 表的名字,cs文件的名字
            colInfo.m_name = fieldName;
            if (cellData != null && commentType != null)
            {
                colInfo.m_comment = commentType.ToString();
            }
            colInfo.m_type = null;
            colInfo.m_isKey = false;
            colInfo.m_isRef = false;
            colInfo.m_isComplex = false;
            colInfo.m_isArray = false;

            // 表头为空
            if (fieldName.Length == 0)
            {
                if (aColInfoAry.Count > 0)
                    UnityEngine.Debug.LogError(string.Format("表头格式错误，表{0}[{1}]列表头为空！", tableName, (aColIndex + 1).ToString()));
                return null;
            }

            Regex regRef = new Regex(@"^\w+\s*\{.*\}$");
            Regex regComplex = new Regex(@"^\w+\s*\{.*\}\s*\[.*\]$");
            if (regComplex.IsMatch(fieldName))     // 复合列
            {
                colInfo.m_isComplex = true;
                colInfo.m_name = fieldName.Substring(0, fieldName.IndexOf('{')).Trim(' ');
            }
            else if (regRef.IsMatch(fieldName))    // 参照列
            {
                colInfo.m_isRef = true;
                colInfo.m_name = fieldName.Substring(0, fieldName.IndexOf('{')).Trim(' ');
            }
            else                                   // 普通列
            {
                Regex re = new Regex(@"^[a-zA-Z]+\w*$");
                if (!re.IsMatch(fieldName))
                {
                    UnityEngine.Debug.LogError(string.Format("表头格式错误，表{0}[\"{1}\"]列的表头存在非法字符(用字母、数字、下划线组合的以字母开头的名称)！", tableName, fieldName));
                    return null;
                }
            }

            // 列名是否重复
            if (aColInfoAry.Exists(t => t.m_name == colInfo.m_name))
            {
                UnityEngine.Debug.LogError(string.Format("表头格式错误，表{0}[\"{1}\"]列名重复！", tableName, colInfo.m_name));
                return null;
            }
            return colInfo;
        }
        #endregion
    }
}

