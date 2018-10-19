using System.IO;
using System.Text;
using UnityEngine;

namespace DLLComplierEditor
{
    /// <summary>
    /// 通过扫描Shader的目录,来生成Shader的一些定义信息,包括名字,属性,类型等.
    /// </summary>
    public class ShaderDefineGenerator
    {
        /// <summary>
        /// 执行
        /// </summary>
        public static void Execute()
        {
            ShaderScanner.DoScan(Defines.CN_SHADER_PATH);
            string code = GenerateCodeEx();
            if (!string.IsNullOrEmpty(code))
            {
                File.WriteAllText(Defines.CN_SHADER_DEFINE_CS_FILE, code);
            }
        }

        /// <summary>
        /// 生成代码
        /// </summary>
        /// <returns></returns>
        private static string GenerateCodeEx()
        {
            if (ShaderScanner.ShaderList.Count == 0)
            {
                Debug.LogError("Shader还没有扫描或者扫描的目录中没有Shader文件.");
                return string.Empty;
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("//******************************************************//");
                sb.AppendLine("//此类文件自动生成,用于获取Shader的各种定义。             //");
                sb.AppendLine("//扫描文件目录: Assets/GameAssets/Resources/Shader/Ares  //");
                sb.AppendLine("//******************************************************//");
                sb.AppendLine("using System.Collections.Generic;");
                sb.AppendLine("using UnityEngine;");
                sb.AppendLine("namespace Funcell.Core.Asset");
                sb.AppendLine("{");
                GenerateShadersDefine(sb);
                sb.AppendLine();
                GenerateShaderNameDefine(sb);
                sb.AppendLine();
                GenerateShaderPropertyNameDefine(sb);
                sb.AppendLine();
                GenerateShaderPropertyDefine(sb);
                sb.AppendLine("}");
                return sb.ToString();
            }
        }

        //生成ShadersDefine
        private static void GenerateShadersDefine(StringBuilder sb)
        {
            sb.AppendLine("    //所有Shader属性信息的定义");
            sb.AppendLine("    public class ShadersDefine");
            sb.AppendLine("    {");
            sb.AppendLine("        private static Dictionary<string, ShaderInfo> _dict = null;");

            sb.AppendLine("        static ShadersDefine()");
            sb.AppendLine("        {");
            sb.AppendLine("            if (_dict == null)");
            sb.AppendLine("            {");
            sb.AppendLine("                _dict = new Dictionary<string, ShaderInfo>();");
            foreach (var s in ShaderScanner.ShaderList)
            {
                string nameList = "";
                for (int i = 0; i < s.Value.Length; i++)
                {
                    nameList += "\"" + s.Value[i] + "\",";
                }
                string valueList = "";
                var pvals = ShaderScanner.ShaderPropertValueList[s.Key];
                for (int i = 0; i < pvals.Length; i++)
                {
                    var v = pvals[i];
                    valueList += "new Vector4("+v.x+"f,"+v.y+"f,"+v.z+"f,"+v.w+ "f),";
                }
                sb.AppendLine("                _dict.Add(\"" + s.Key + "\", new ShaderInfo() { Name = \"" + s.Key + "\", PropertyNameArray = new string[] {" + nameList + "},PropertyValueArray = new Vector4[] {"+ valueList + "} });");
            }
            sb.AppendLine("            }");
            sb.AppendLine("        }");

            sb.AppendLine("        public static ShaderInfo GetShaderDefine(string name)");
            sb.AppendLine("        {");
            sb.AppendLine("            ShaderInfo result;");
            sb.AppendLine("            _dict.TryGetValue(name, out result);");
            sb.AppendLine("            return result;");
            sb.AppendLine("        }");

            sb.AppendLine("    }");

        }
        //生成ShaderNameDefine代码
        private static void GenerateShaderNameDefine(StringBuilder sb)
        {
            sb.AppendLine("    //Shader的名字定义");
            sb.AppendLine("    public class ShaderNameDefine");
            sb.AppendLine("    {");
            foreach (var p in ShaderScanner.ShaderList)
            {
                sb.AppendLine("         public const string " + GetConstShaderName(p.Key) + " = \"" + p.Key + "\";");
            }
            sb.AppendLine("    }");
        }

        //生成ShaderPropertyNameDefine代码
        private static void GenerateShaderPropertyNameDefine(StringBuilder sb)
        {
            sb.AppendLine("    //属性的名字定义");
            sb.AppendLine("    public class ShaderPropertyNameDefine");
            sb.AppendLine("    {");
            foreach (var p in ShaderScanner.PropertyInfoDict)
            {
                sb.AppendLine("         public const string " + GetConstPropertyName(p.Key) + " = \"" + p.Key + "\";");
            }
            sb.AppendLine("    }");
        }

        //生成ShaderPropertyDefine的代码
        private static void GenerateShaderPropertyDefine(StringBuilder sb)
        {
            sb.AppendLine("    //属性信息包含类型的定义");
            sb.AppendLine("    public class ShaderPropertyDefine");
            sb.AppendLine("    {");
            sb.AppendLine("        public readonly static Dictionary<string, int> PropertyDict;");

            //根据索引获取类型名字
            sb.AppendLine("        public static int GetPropertyType(string name)");
            sb.AppendLine("        {");
            sb.AppendLine("            if (PropertyDict.ContainsKey(name)) return PropertyDict[name];");
            sb.AppendLine("            UnityEngine.Debug.LogError(\"请求的Shader属性名字不在范围中!Name:\" + name);");
            sb.AppendLine("            return -1;");
            sb.AppendLine("        }");

            //静态定义
            sb.AppendLine("        static ShaderPropertyDefine()");
            sb.AppendLine("        {");
            sb.AppendLine("            if (PropertyDict == null)");
            sb.AppendLine("            {");
            sb.AppendLine("                PropertyDict = new Dictionary<string, int>();");
            //循环添加属性名字
            foreach (var p in ShaderScanner.PropertyInfoDict)
            {
                sb.AppendLine("                PropertyDict.Add(\"" + p.Key + "\"," + p.Value + ");");
            }

            sb.AppendLine("            }");
            sb.AppendLine("        }");

            sb.AppendLine("    }");
        }

        //获取常量名字
        private static string GetConstPropertyName(string pName)
        {
            return "CN_SPN_" + pName.TrimStart('_').ToUpper();
        }

        //Shader名字
        private static string GetConstShaderName(string sName)
        {
            return "CN_SN_" + sName.Replace("/","_").Replace(" ","_").Replace("-","_").Replace("(","").Replace(")", "").TrimStart('_').ToUpper();
        }


    }
}
