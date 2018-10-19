using System;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace DLLComplierEditor
{
    /// <summary>
    /// 选择要导表的xlsx窗口
    /// </summary>
    public class ExportExcelSingle : EditorWindow
    {
        Vector2 _scrollPos;
        // FuncellDeclare输出目录
        public static string _structDir;
        // FuncellDeclare输出目录
        public static string _dataDir;
        private string _fileSelectedPath = "";
        //子文件夹路径
        private string[] _childrenFolderPaths;
        //子文件路径
        private string[] _childrenXlsxFilePaths;
        //当前目录
        private static string _currentPath = Directory.GetCurrentDirectory();

        /// <summary>
        /// 单独导出一张表
        /// </summary>
        public static void ExcuteExport()
        {
            GetWindow(typeof(ExportExcelSingle), false, "选择一张表", true);
        }

        private void OnGUI()
        {
            //1. 显示选择窗口
            ShowFolder();
            //2. 根据选择结果开始进行导表操作
            GUILayout.Space(10);
            GUI.backgroundColor = Color.green;
            if (GUILayout.Button("开始导表", GUILayout.Height(50)))
            {
                if (_fileSelectedPath.EndsWith(".xlsx"))
                {
                    ExcuteExportExcelSingle(_fileSelectedPath, Defines.CN_CONFIG_DECLARE_CODE_SOURCE_PATH, Defines.CN_CONFIG_DATA_CODE_SOURCE_PATH);
                }
                else
                {
                    Debug.LogError("Opps ---->>> 还没选中xlsx的正确路径!!!");
                }
            }
        }

        private void ShowFolder()
        {
            string path = Defines.CN_CONFIG_PATH.Replace('\\', '/');
            path = Directory.GetParent(path).FullName;
            OpenFolder(path);

            GUILayout.BeginHorizontal();
            //显示当前路径
            GUILayout.Label(_currentPath);
            if (GUILayout.Button("返回上级", GUILayout.Width(200)))
            {
                _currentPath = Directory.GetParent(_currentPath).FullName;
                OpenFolder(_currentPath);
            }
            GUILayout.EndHorizontal();

            _scrollPos = GUILayout.BeginScrollView(_scrollPos, GUILayout.Height(300));
            for (int i = 0; i < _childrenFolderPaths.Length; ++i)
            {
                GUILayout.BeginHorizontal();
                if (GUILayout.Button(_childrenFolderPaths[i]))
                {
                    _currentPath = _childrenFolderPaths[i];
                    OpenFolder(_currentPath);
                }
                if (GUILayout.Button("选定目录"))
                {
                    _fileSelectedPath = _childrenFolderPaths[i];
                }
                GUILayout.EndHorizontal();
            }

            for (int i = 0; i < _childrenXlsxFilePaths.Length; ++i)
            {
                GUILayout.BeginHorizontal();
                GUILayout.Label(_childrenXlsxFilePaths[i]);
                if (GUILayout.Button("选定目录"))
                {
                    _fileSelectedPath = _childrenXlsxFilePaths[i];
                }
                GUILayout.EndHorizontal();
            }
            GUILayout.EndScrollView();
            GUILayout.Space(10);
            GUIStyle style = new GUIStyle();
            style.normal.textColor = Color.red;
            style.fontSize = 20;
            GUILayout.Label("当前选择文件路径: " + _fileSelectedPath, style);
        }

        private void OpenFolder(string path)
        {
            if (!string.IsNullOrEmpty(path))
            {
                _childrenFolderPaths = Directory.GetDirectories(_currentPath);
                _childrenXlsxFilePaths = Directory.GetFiles(_currentPath, "*.xls*", SearchOption.TopDirectoryOnly);
            }
        }

        /// <summary>
        /// 单独导出一张表生成dll文件
        /// </summary>
        public static void ExcuteExportExcelSingle(string excelPath, string structDir, string dataDir)
        {
            try
            {
                _structDir = structDir;
                _dataDir = dataDir;
                if (!File.Exists(excelPath))
                {
                    Debug.LogError(string.Format("Excel路径{0}不存在!!!", excelPath));
                    return;
                }
                if (!Directory.Exists(structDir))
                {
                    Debug.LogError(string.Format("Declare文件夹路径{0}不存在!!!", structDir));
                    return;
                }
                if (!Directory.Exists(dataDir))
                {
                    Debug.LogError(string.Format("传入的Data文件夹路径{0}有误!!!", dataDir));
                    return;
                }

                Debug.Log("导表开始！");
                int startTime = Environment.TickCount;
                // 读取配置表
                EditorUtility.DisplayProgressBar("配置信息", "读取配置表", 0);

                FileInfo fInfo = new FileInfo(excelPath);
                DeleteCsFile(fInfo);
                ExcelReader.LoadOneExcelEx(fInfo, _structDir, _dataDir);
                //代码编译
                Complier.ExecuteCfg(BuildTarget.Android, () =>
                {
                    Debug.Log("配置数据编译完毕!!,开始分发!!");
                    //编译好的动态库分发
                    Publisher.ExecuteCfg(BuildTarget.Android);
                });

                Debug.Log("导表完成！");
                int endTime = Environment.TickCount;
                int time = (endTime - startTime) / 1000;
                Debug.LogError("导表共计用时：" + time + " 秒");
            }
            finally
            {
                EditorUtility.ClearProgressBar();
            }
        }

        // 删除对应的两个文件夹中的CS文件
        private static void DeleteCsFile(FileInfo fInfo)
        {
            string tempName = fInfo.Name.Substring(0, fInfo.Name.IndexOf('.'));
            string declareName = "Declare" + FormartName(tempName) + ".cs";
            string dataName = "Data" + FormartName(tempName) + ".cs";
            string declareCsFilePath = Path.GetFullPath(_structDir + "/" + declareName);
            string dataCsFilePath = Path.GetFullPath(_dataDir + "/" + dataName);

            if (File.Exists(declareCsFilePath))
            {
                Debug.LogError(string.Format("删除{0}成功!", declareName));
                File.Delete(declareCsFilePath);
            }
            if (File.Exists(dataCsFilePath))
            {
                Debug.LogError(string.Format("删除{0}成功!", dataName));
                File.Delete(dataCsFilePath);
            }
        }

        /// <summary>
        /// 格式化名字
        /// </summary>
        /// <param name="inStr"></param>
        /// <returns></returns>
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
    }
}
