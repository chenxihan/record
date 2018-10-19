using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEditor;

namespace DLLComplierEditor
{
    /// <summary>
    /// 动态库分发器
    /// </summary>
    internal class Publisher
    {
        //配置文件动态库分发
        public static void ExecuteCfg(BuildTarget build)
        {
            string[] dllNames = new string[] { "FuncellData" ,
                                               "FuncellDeclare"
                                                };

            for (int i = 0; i < dllNames.Length; i++)
            {
                //UnityEditor.EditorUtility.DisplayProgressBar("分发到项目", "正在分发:" + dllNames[i], (float)i / (float)dllNames.Length);
                CopyDll(Defines.CN_DLL_BIN_PATH, Defines.CN_MAIN_DLL_PATH, build, dllNames[i], ".dll");
            }
            //UnityEditor.EditorUtility.ClearProgressBar();
            UnityEngine.Debug.Log("配置数据分发到主项目成功!");
        }
        //所有的dll的分发
        public static void Execute(BuildTarget build)
        {
            /*
             * 1.复制某些动态库到 Main 项目中
             * 2.复制动态库到 指定的资源目录中
            */
            //复制到Main项目中
            CopyToMain(build);
            
            //复制到启动项目中
            CopyToLauncher(build);
            
            //复制到资源库中
            CopyToSubResource(build);
            
        }

        //复制到Main项目中
        public static void CopyToMain(BuildTarget build)
        {
            
            string[] dllNames = new string[] { "FuncellSDK",
                                               "FuncellUpdate",
                                               "FuncellBase",
                                               "FuncellCore" ,
                                               "FuncellData" ,
                                               "FuncellDeclare",                                              
                                                };

            for (int i = 0; i < dllNames.Length; i++)
            {
                //UnityEditor.EditorUtility.DisplayProgressBar("分发到主项目", "正在分发:"+dllNames[i], (float)i/(float)dllNames.Length);
                CopyDll(Defines.CN_DLL_BIN_PATH, Defines.CN_MAIN_DLL_PATH, build, dllNames[i],".dll");
            }
            UnityEngine.Debug.Log("分发到主项目成功!");
            //UnityEditor.EditorUtility.ClearProgressBar();
        }

        //复制到启动项目
        private static void CopyToLauncher(BuildTarget build)
        {
            string[] dllNames = new string[] {
                                               "FuncellSDK",
                                               "FuncellUpdate",
                                               "FuncellBase",                                               
                                               "FuncellUpdateForm",
                                               "FuncellCore" ,
                                               "FuncellData" ,
                                               "FuncellDeclare",                                               
                                               "FuncellLogic",
                                               "FuncellUIForm"
                                              };


            for (int i = 0; i < dllNames.Length; i++)
            {
               // UnityEditor.EditorUtility.DisplayProgressBar("分发到启动项目", "正在分发:" + dllNames[i], (float)i / (float)dllNames.Length);
                CopyDll(Defines.CN_DLL_BIN_PATH, Defines.CN_LAUNCHER_DLL_PATH, build, dllNames[i],".bytes");
                CopyDllEncrypt(Defines.CN_DLL_BIN_PATH, Defines.CN_LAUNCHER_STATIC_DLL_PATH, build, dllNames[i]);
            }

            //复制到Lanucher动态库到项目的静态引用路径中
            //CopyDll(Define.CN_DLL_BIN_PATH, Define.CN_LAUNCHER_STATIC_DLL_PATH, build, "FuncellLauncher", ".dll");
            UnityEngine.Debug.Log("分发到启动项目成功!");
            //UnityEditor.EditorUtility.ClearProgressBar();
        }

        //复制到Sub资源
        private static void CopyToSubResource(BuildTarget build)
        {
            string[] dllNames = new string[] {
                                               "FuncellSDK",
                                               "FuncellUpdate",
                                               "FuncellBase",                                               
                                               "FuncellUpdateForm",
                                               "FuncellCore" ,
                                               "FuncellData" ,
                                               "FuncellDeclare",
                                               "FuncellLogic",
                                               "FuncellUIForm"
                                              };

            for (int i = 0; i < dllNames.Length; i++)
            {
                //UnityEditor.EditorUtility.DisplayProgressBar("分发到资源库", "正在分发:" + dllNames[i], (float)i / (float)dllNames.Length);
                CopyDll(Defines.CN_DLL_BIN_PATH, Defines.CN_SUBRESOURCE_DLL_PATH, build, dllNames[i], ".bytes");
            }
            UnityEngine.Debug.Log("分发到资源库成功!");
            //UnityEditor.EditorUtility.ClearProgressBar();
        }

        //复制dll
        private static void CopyDll(string sourceDir, string targetDir, BuildTarget build, string dllName,string targetExt = ".dll")
        {
            var sourceFile = sourceDir + "/" + build.ToString() + (Complier.UseProfiler? "_Profiler/" : "/") + dllName + ".dll";
            var targetFile = targetDir + "/" + dllName + "/" + dllName + targetExt;
            if (!File.Exists(sourceFile))
            {
                UnityEngine.Debug.LogError("没有发现动态库文件:"+sourceFile);
                return;
            }

            if (!Directory.Exists(targetDir + "/" + dllName + "/"))
            {
                Directory.CreateDirectory(targetDir + "/" + dllName + "/");
            }

            File.Copy(sourceFile, targetFile,true);
        }
        //复制dll到加密状态
        private static void CopyDllEncrypt(string sourceDir, string targetDir, BuildTarget build, string dllName)
        {
            var sourceFile = sourceDir + "/" + build.ToString() + (Complier.UseProfiler ? "_Profiler/" : "/") + dllName + ".dll";
            var targetFile = targetDir + "/" + Defines.DllEncryptCodes[dllName] + ".bytes";
            if (!File.Exists(sourceFile))
            {
                UnityEngine.Debug.LogError("没有发现动态库文件:" + sourceFile);
                return;
            }

            if (!Directory.Exists(targetDir + "/"))
            {
                Directory.CreateDirectory(targetDir + "/");
            }

            File.Copy(sourceFile, targetFile, true);
        }
    }
}
