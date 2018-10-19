using System;
using System.IO;

namespace DLLComplierEditor
{
    /// <summary>
    /// 导表的进入窗口
    /// 下面的ExcuteReadExcel开始执行导表流程
    /// </summary>
    class ReadExcelProgram
    {
        // excel目录
        public static string _excelDir;

        // FuncellDeclare输出目录
        public static string _structDir;

        // FuncellDeclare输出目录
        public static string _dataDir;

        public static string _language = "CH";

        /// <summary>
        /// 执行读表导表生成两个Cs工程和LanguageConverter.xls
        /// </summary>
        /// <param name="excelDir">要读取的excel目录，进行导表用</param>
        /// <param name="structDir">FuncellDeclare输出目录</param>
        /// <param name="dataDir">FuncellDeclare输出目录</param>
        /// <param name="language">地区语言</param>
        /// <param name="version">版本号</param>
        public static void ExcuteReadExcel(string excelDir, string structDir, string dataDir, string language, string version)
        {
            try
            {
                var tempDir = string.Format("{0}{1}_{2}", excelDir, language, version);
                if (!Directory.Exists(tempDir))
                {
                    UnityEngine.Debug.LogWarning("Directory not exist: " + tempDir);
                    tempDir = string.Format("{0}_{1}", excelDir, version);
                }
                if (!Directory.Exists(tempDir))
                {
                    UnityEngine.Debug.LogWarning("Directory not exist: " + tempDir);
                    tempDir = excelDir;
                }

                _excelDir = tempDir;

                _structDir = structDir;
                _dataDir = dataDir;

                UnityEngine.Debug.Log("导表开始！");
                int startTime = Environment.TickCount;
                // 加载LanguageConverter.xlsx
                UnityEditor.EditorUtility.DisplayProgressBar("配置信息", "加载加载LanguageConverter文件", 0.2f);
                LanguageConverter.Instance.Load(Path.GetDirectoryName(_excelDir));

                // 读取配置表
                UnityEditor.EditorUtility.DisplayProgressBar("配置信息", "读取配置表", 0);
                if (Directory.Exists(_excelDir))
                {
                    UnityEngine.Debug.Log("导表文件夹路径---->>>> " + Path.GetFullPath(_excelDir));
                    ExcelReader.Instance().LoadExcelFromFolder(_excelDir, structDir, dataDir);
                }
                else
                {
                    UnityEngine.Debug.LogError(_excelDir + "路径不存在");
                    return;
                }

                //导出配置表到CS工程
                UnityEditor.EditorUtility.DisplayProgressBar("配置信息", "导出配置表到cs工程", 0f);
                UnityEngine.Debug.Log("正在生成Data和Declare工程!");
                //CSharpWriter writer = new CSharpWriter();
                //writer.WriteCSharpData(structDir, dataDir);
                //CSharpWriter.WriteCSharpData(structDir, dataDir);

                //保存语言文件
                UnityEditor.EditorUtility.DisplayProgressBar("配置信息", "保存语言文件LanguageConverter文件.", 0.2f);
                LanguageConverter.Instance.Save();
                UnityEditor.EditorUtility.DisplayProgressBar("配置信息", "保存语言文件LanguageConverter文件.", 1f);

                UnityEngine.Debug.Log("导表完成！");
                int endTime = Environment.TickCount;
                int time = (endTime - startTime) / 1000;
                UnityEngine.Debug.LogError("导表共计用时：" + time + " 秒");
            }
            finally
            {
                UnityEditor.EditorUtility.ClearProgressBar();
            }
        }
    }
}