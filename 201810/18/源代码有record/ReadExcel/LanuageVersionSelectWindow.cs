using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace DLLComplierEditor
{
    public class LanuageVersionSelectWindow : EditorWindow
    {
        private static int _screenWidth = 1280;
        private static int _screenHeight = 720;

        private string _lanuage = "CH";

        private string _version = "2.0.0";

        private string[] CN_LANUAGE = new string[] 
        {
            "CH",
            "CH2",
            "JP",
            "TH",
            "VIE",
            "TW",
            "KR",
            "EN",
            "EN2",
            "CH2_EN_TH",
        };

        private string[] _lanuageDef = new string[]
        {
            "中文",
            "东南亚中文",
            "日语",
            "泰语",
            "越南语",
            "繁体(港澳台)",
            "韩语",
            "英语",
            "北美英语",
            "中英泰",
        };

        private int _lanIndex = 0;

        public string Lanuage
        {
            get
            {
                return _lanuage;
            }

            set
            {
                _lanuage = value;
            }
        }

        public string Version
        {
            get
            {
                return _version;
            }

            set
            {
                _version = value;
            }
        }

        public static void ShowWindow()
        {
            var window = GetWindow(typeof(LanuageVersionSelectWindow), false, "语言与版本选择");
            window.Show();
        }

        void OnGUI()
        {
            GUILayout.Width(_screenWidth);
            GUILayout.Height(_screenHeight);

            GUILayout.BeginVertical();
            //绘制标题
            GUILayout.Space(20);
            GUILayout.BeginHorizontal();
            GUILayout.Label("导表工具", GUILayout.Height(30));
            GUILayout.EndHorizontal();

            GUILayout.Space(30);
            EditorGUILayout.LabelField("请选择语言:", GUILayout.Height(20));
            GUILayout.BeginHorizontal();
            _lanIndex = EditorGUILayout.Popup(_lanIndex, CN_LANUAGE, GUILayout.Height(30));
            _lanuage = CN_LANUAGE[_lanIndex];
            GUILayout.Space(50);
            GUILayout.EndHorizontal();

            GUILayout.Label(string.Format("当前选择语言为: {0} {1}", _lanuage, _lanuageDef[_lanIndex]), GUILayout.Height(40));

            GUILayout.BeginHorizontal();
            _version = EditorGUILayout.TextField("版本号", _version, GUILayout.Height(30));
            GUILayout.Space(20);
            GUILayout.EndHorizontal();

            GUILayout.Space(30);

            GUILayout.BeginHorizontal();
            if (GUILayout.Button(string.Format("导{0}_{1}配置表", _lanuage, _version), GUILayout.Height(30)))
            {
                Complier.UseProfiler = false;
                Main.ExecuteCfg(BuildTarget.Android, _lanuage, _version);
            }

            GUILayout.Space(5);
            if (GUILayout.Button("导默认无版本号配置表", GUILayout.Height(30)))
            {
                Complier.UseProfiler = false;
                Main.ExecuteCfg(BuildTarget.Android, string.Empty, string.Empty);
            }
            GUILayout.EndHorizontal();

            GUILayout.EndVertical();

            GUILayout.Space(50);

            if (GUILayout.Button("语言翻译调试（策划专用)", GUILayout.Height(30)))
            {
                //代码转移
                Transfer.ExecuteCfg("", "", () =>
                {
                    UnityEngine.Debug.Log("配置数据代码生成完毕!,开始编译!");

                    //转UI和StringDefine的语言
                    ChangeUIAndStringDefineLan(_lanuage);
                    //拷贝翻译后的UI到原始目录
                    CopyConvertedUIToSource(_lanuage);
                    AssetDatabase.SaveAssets();
                    AssetDatabase.Refresh(ImportAssetOptions.ForceUpdate);

                    //代码编译
                    Complier.ExecuteCfg(BuildTarget.Android, () =>
                    {
                        UnityEngine.Debug.Log("配置数据编译完毕!!,开始分发!!");
                        //编译好的动态库分发
                        Publisher.ExecuteCfg(BuildTarget.Android);
                    });
                });
            }
            
        }

        private void InvokePackageDLLFunc(string lan, bool exportConfig)
        {
            AppDomain domain = AppDomain.CurrentDomain;
            var assemblies = domain.GetAssemblies();
            for (int i = 0; i < assemblies.Length; ++i)
            {
                if (assemblies[i].FullName.IndexOf("PackageEditor") >= 0)
                {
                    var param = assemblies[i].GetType("Funcell.Package.Tool.PackageParam");
                    var version = param.GetField("Version", BindingFlags.Static | BindingFlags.Public);
                    version.SetValue(null, _version);

                    var classModel = assemblies[i].GetType("Funcell.Package.CodeAndDllPackage");
                    var method = classModel.GetMethod("Test");
                    method.Invoke(null, BindingFlags.Public | BindingFlags.Static, null, new object[] { lan, exportConfig }, null);

                    return;
                }
            }
        }

        private void ChangeUIAndStringDefineLan(string lan)
        {
            AppDomain domain = AppDomain.CurrentDomain;
            var assemblies = domain.GetAssemblies();
            for (int i = 0; i < assemblies.Length; ++i)
            {
                if (assemblies[i].FullName.IndexOf("PackageEditor") >= 0)
                {
                    var classModel = assemblies[i].GetType("Funcell.Package.Tool.ChangeUIAndAtlasFontLan");
                    var method = classModel.GetMethod("ChangeLan");
                    method.Invoke(null, BindingFlags.Public | BindingFlags.Static, null, new object[] { lan}, null);

                    var classModel2 = assemblies[i].GetType("Funcell.Package.Tool.LanguageTool");
                    var method2 = classModel2.GetMethod("ConvertStringData");
                    method2.Invoke(null, BindingFlags.Public | BindingFlags.Static, null, new object[] { lan, "../Core/Runtime/FuncellData/Source/StringDefines.cs" }, null);

                    break;
                }
            }
        }

        private void CopyConvertedUIToSource(string lan)
        {
            string convertedUIPath = string.Format("Assets/GameAssets/Resources/GameUI_{0}/Form", lan);
            string sourceUIPath = "Assets/GameAssets/Resources/GameUI/Form";

            if(System.IO.Directory.Exists(convertedUIPath))
            {
                var files = System.IO.Directory.GetFiles(convertedUIPath, "*.prefab", System.IO.SearchOption.AllDirectories);
                for (int i = 0; i < files.Length; ++i)
                {
                    var sourceFile = files[i].Replace("\\", "/").Replace(convertedUIPath, sourceUIPath);
                    System.IO.File.Copy(files[i], sourceFile, true);
                }
            }
        }
    }
}
