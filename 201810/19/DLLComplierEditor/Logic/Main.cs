using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;
using IosToolEditor;
using System.Reflection;

namespace DLLComplierEditor
{
    /// <summary>
    /// 动态库生成工具的入口
    /// </summary>
    public class Main
    {
        //只生成基础的dll
        public static void ExecuteBase(BuildTarget target)
        {
            Defines.WorkDir = System.IO.Directory.GetCurrentDirectory();
            try
            {
                UnityEngine.Debug.Log("开始编译Base解决方案!");
                //代码编译
                Complier.ExecuteBase(target, () =>
                {
                    UnityEngine.Debug.Log("编译完毕!!,开始分发!!");
                    //编译好的动态库分发
                    Publisher.CopyToMain(target);

                });

                
            }
            catch (Exception ex)
            {
                Debug.LogException(ex);
            }
        }

        //生成配置文件
        public static void ExecuteCfg(BuildTarget target, string configName, Action onFinish = null)
        {

            Defines.WorkDir = System.IO.Directory.GetCurrentDirectory();
            try
            {
                ExportMesssageString();

                //代码转移
                Transfer.ExecuteCfg(configName, string.Empty, () =>
                {
                    UnityEngine.Debug.Log("配置数据代码生成完毕!,开始编译!");

                    PeekCHFromGameUIToLanguageConverter();

                    //代码编译
                    Complier.ExecuteCfg(target, () =>
                    {
                        UnityEngine.Debug.Log("配置数据编译完毕!!,开始分发!!");
                        //编译好的动态库分发
                        Publisher.ExecuteCfg(target);

                        //需要添加回调通知打包工具
                        if (onFinish != null)
                            onFinish();

                    });
                });
                // 生成IOS的配置文件
                GameCfgData.ToFile(IosToolEditor.Defines.CN_GAME_CFG_DATA_DIR, "CH");
            }
            catch (Exception ex)
            {
                Debug.LogException(ex);
            }
        }


        //生成配置文件
        public static void ExecuteCfg(BuildTarget target, string configName, string configVersion, bool doNotCompile = false, Action onFinish = null)
        {

            Defines.WorkDir = System.IO.Directory.GetCurrentDirectory();
            try
            {
                ExportMesssageString();

                //代码转移
                Transfer.ExecuteCfg(configName, configVersion, () =>
                {
                    UnityEngine.Debug.Log("配置数据代码生成完毕!,开始编译!" + doNotCompile);

                    PeekCHFromGameUIToLanguageConverter();

                    // 不需要编译项目
                    if (doNotCompile)
                    {
                        UnityEngine.Debug.Log("配置数据代码生成完毕!,跳过编译!");
                        return;
                    }

                    //代码编译
                    Complier.ExecuteCfg(target, () =>
                    {
                        UnityEngine.Debug.Log("配置数据编译完毕!!,开始分发!!");
                        //编译好的动态库分发
                        Publisher.ExecuteCfg(target);

                        //需要添加回调通知打包工具
                        if (onFinish != null)
                            onFinish();
                    });
                });
                // 生成IOS的配置文件
                if (string.IsNullOrEmpty(configName))
                {
                    GameCfgData.ToFile(IosToolEditor.Defines.CN_GAME_CFG_DATA_DIR, "CH");
                }
                else
                {
                    GameCfgData.ToFile(IosToolEditor.Defines.CN_GAME_CFG_DATA_DIR, configName);
                }
            }
            catch (Exception ex)
            {
                Debug.LogException(ex);
            }
        }

        //生成所有的dll
        public static void ExecuteLogic(BuildTarget target, string configName)
        {
            Defines.WorkDir = System.IO.Directory.GetCurrentDirectory();
            try
            {
                //代码转移
                Transfer.ExecuteLogic(configName, () =>
                {
                    UnityEngine.Debug.Log("代码转移完毕!,开始编译!");
                    //代码编译
                    Complier.Execute(target, () =>
                    {
                        UnityEngine.Debug.Log("编译完毕!!,开始分发!!");
                        //编译好的动态库分发
                        Publisher.Execute(target);

                    });

                });
            }
            catch (Exception ex)
            {
                Debug.LogException(ex);
            }
        }

        //生成所有的dll
        public static void Execute(BuildTarget target,string configName)
        {
            Defines.WorkDir = System.IO.Directory.GetCurrentDirectory();
            try
            {
                //代码转移
                Transfer.ExecuteAll(configName, () =>
                {
                    UnityEngine.Debug.Log("代码转移完毕!,开始编译!");
                    //代码编译
                    Complier.Execute(target,() =>
                    {
                        UnityEngine.Debug.Log("编译完毕!!,开始分发!!");
                        //编译好的动态库分发
                        Publisher.Execute(target);

                    });

                });
            }
            catch (Exception ex)
            {
                Debug.LogException(ex);
            }            
        }

        //在导表前要先导出MessageString
        public static void ExportMesssageString()
        {
            AppDomain domain = AppDomain.CurrentDomain;
            var assemblies = domain.GetAssemblies();
            for (int i = 0; i < assemblies.Length; ++i)
            {
                if (assemblies[i].FullName.IndexOf("PackageEditor") >= 0)
                {
                    var class1 = assemblies[i].GetType("Funcell.Package.CodeAndDllPackage");
                    var m1 = class1.GetMethod("ExportMessageString");
                    m1.Invoke(null, BindingFlags.Public | BindingFlags.Static, null, null, null);

                    break;
                }
            }
        }
        

        public static void PeekCHFromGameUIToLanguageConverter()
        {
            UnityEngine.Debug.LogError("提取中文开始");

            AppDomain domain = AppDomain.CurrentDomain;
            var assemblies = domain.GetAssemblies();
            for (int i = 0; i < assemblies.Length; ++i)
            {
                if (assemblies[i].FullName.IndexOf("PackageEditor") >= 0)
                {
                    /*
                    var class1 = assemblies[i].GetType("Funcell.Package.Tool.LanguageConverterExcel");
                    var class2 = assemblies[i].GetType("Funcell.Package.Tool.LanguageTool");
                    var m1 = class1.GetMethod("Initialize");
                    m1.Invoke(null, BindingFlags.Public | BindingFlags.Static, null, null, null);

                    var m2 = class2.GetMethod("PeekGameUICHText");
                    m2.Invoke(null, BindingFlags.Public | BindingFlags.Static, null, null, null);

                    var m3 = class2.GetMethod("PeekUpdateCfgChToExcel");
                    m3.Invoke(null, BindingFlags.Public | BindingFlags.Static, null, null, null);
                    */

                    var class1 = assemblies[i].GetType("Funcell.Package.PacakgeToolMenuItem");
                    var m1 = class1.GetMethod("PeekCHToExcel");
                    m1.Invoke(null, BindingFlags.Public | BindingFlags.Static, null, null, null);

                    break;
                }
            }

            UnityEngine.Debug.LogError("提取中文结束");
        }
    }
}
