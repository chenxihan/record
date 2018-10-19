using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace DLLComplierEditor
{
    /// <summary>
    /// 配置文件生成
    /// </summary>
    public class CfgData
    {
        //执行完毕后的回调
        private static Action _callBack;

        //配置文件的名字
        private static string _configName;

        //配置文件的版本
        private static string _configVersion;

        /// <summary>
        /// 执行配置代码生成处理
        /// </summary>
        /// <param name="configName">配置的名字比如:CN,TW,TH</param>
        /// <param name="callBack">执行完毕后的回调</param>
        internal static void Execute(string configName, string configVersion, Action callBack)
        {
            _configName = configName;
            _configVersion = configVersion;
            _callBack = callBack;
            if (string.IsNullOrEmpty(_configName))
            {
                _configName = string.Empty;
            }
            else
            {
                if (_configName[0] != '_')
                {
                    _configName = "_" + _configName;
                }
            }
            ReadExcelExcute();
            /*
            //用个线程来执行导表操作
            Thread readExcelThread = new Thread(new ThreadStart(ReadExcelExcute));
            readExcelThread.Priority = ThreadPriority.Highest;
            readExcelThread.Start();
            */
        }

        /// <summary>
        /// 这里开始进行导表的操作
        /// </summary>
        private static void ReadExcelExcute()
        {
            UnityEngine.Debug.Log("先删除所有的数据配置信息!");
            if (Directory.Exists(Defines.CN_CONFIG_DECLARE_CODE_SOURCE_PATH))
            {
                Directory.Delete(Defines.CN_CONFIG_DECLARE_CODE_SOURCE_PATH, true);
            }
            if (Directory.Exists(Defines.CN_CONFIG_DATA_CODE_SOURCE_PATH))
            {
                Directory.Delete(Defines.CN_CONFIG_DATA_CODE_SOURCE_PATH, true);
            }
            if (Directory.Exists(Defines.CN_CONFIG_PATH_LUA))
            {
                Directory.Delete(Defines.CN_CONFIG_PATH_LUA, true);
            }
            try
            {
                if (string.IsNullOrEmpty(_configName))
                {
                    ReadExcelProgram.ExcuteReadExcel(
                        Defines.CN_CONFIG_PATH,
                        Defines.CN_CONFIG_DECLARE_CODE_SOURCE_PATH,
                        Defines.CN_CONFIG_DATA_CODE_SOURCE_PATH,
                        "",
                        ""
                    );
                }
                else
                {
                    UnityEngine.Debug.Log("开始导{1,10}表!" + _configName);
                    //if (!string.IsNullOrEmpty(_configVersion))
                    {
                        ReadExcelProgram.ExcuteReadExcel(
                        Defines.CN_CONFIG_PATH,
                        Defines.CN_CONFIG_DECLARE_CODE_SOURCE_PATH,
                        Defines.CN_CONFIG_DATA_CODE_SOURCE_PATH,
                        _configName,
                        _configVersion
                        );
                    }
//                     else
//                     {
//                         UnityEngine.Debug.LogError("_configVersion版本号没有设置!!!");
//                     }
                }

                // 回调回去生成Data和Declare工程
                if (Directory.Exists(Defines.CN_CONFIG_DECLARE_CODE_SOURCE_PATH) && Directory.Exists(Defines.CN_CONFIG_DATA_CODE_SOURCE_PATH))
                {
                    UnityEngine.Debug.Log("生成配置信息成功!");
                    if (_callBack != null)
                        _callBack();
                }
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogError("生成配置文件失败.失败原因:" + ex.ToString());
            }
        }

        private static string GetFileFullPath(string path)
        {
            var fi = new FileInfo(path);
            return fi.FullName;
        }
    }
}
