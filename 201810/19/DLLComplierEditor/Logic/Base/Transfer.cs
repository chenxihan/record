using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DLLComplierEditor
{
    /// <summary>
    /// 代码转移
    /// </summary>
    internal class Transfer
    {
        private static Action _callBack;

        //执行配置文件的代码转移
        public static void ExecuteCfg(string configName, string configVersion, Action callBack)
        {
            CfgData.Execute(configName, configVersion, () =>
            {
                Modify(Defines.CN_FUNCELLDATA_PROJECT);
                Modify(Defines.CN_FUNCELLDECLARE_PROJECT);
                callBack();
            });
        }

        //执行所有的代码操作
        public static void ExecuteLogic(string configName, Action callBack)
        {
            CopyCSCode(Defines.CN_CODE_SOURCE, Defines.CN_CODE_TARGET);
            CopyCSCode(Defines.CN_PLUGINS_SOURCE, Defines.CN_PLUGINS_TARGET);
            CopyCSCode(Defines.CN_UIFORM_SOURCE, Defines.CN_UIFORM_TARGET);
            CopyCSCode(Defines.CN_UPDATE_UIFORM_SOURCE, Defines.CN_UPDATE_UIFORM_TARGET);
            CopyCSCode(Defines.CN_EXTERNALLIBS_SOURCE, Defines.CN_LAUNCHER_EXTERNALLIBS_TARGET);


            Modify(Defines.CN_FUNCELLLOGIC_PROJECT);
            Modify(Defines.CN_FUNCELLUIFORM_PROJECT);
            Modify(Defines.CN_FUNCELLUPDATEFORM_PROJECT);
           
            if (callBack != null) callBack();
        }

        //执行所有的代码操作
        public static void ExecuteAll(string configName,Action callBack)
        {
            _callBack = callBack;

            ExecuteLogic(configName,null);

            ExecuteCfg(configName, "", callBack);
        }

        //把代码文件从一个目录复制到另外一个目录
        private static void CopyCSCode(string source, string target)
        {
            //首先删除目标目录,以及目录下的所有文件
            if (Directory.Exists(target))
            {
                Directory.Delete(target, true);
            }

            //从原始目录查询出所有的cs文件,然后复制过去
            var fileList = Directory.GetFiles(source, "*.cs", SearchOption.AllDirectories);
            int sum = fileList.Length;
            for (int i = 0; i < fileList.Length; ++i)
            {
                
                string toPath = fileList[i].Replace(source, target);
                string dir = new FileInfo(toPath).Directory.FullName;
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                UnityEditor.EditorUtility.DisplayProgressBar("复制代码文件", "正在处理"+ fileList[i], (float)i / (float)sum);
                File.Copy(fileList[i], toPath, true);
            }
            UnityEditor.EditorUtility.ClearProgressBar();
        }

        //修改工程配置文件，把cs文件包含在项目中
        private static void Modify(string csproject)
        {
            string csprojectParent = Path.GetDirectoryName(csproject);
            var codeFileList = Directory.GetFiles(csprojectParent, "*.cs", SearchOption.AllDirectories);
            csprojectParent = csprojectParent.Replace("/", "\\");
            StringBuilder sb = new StringBuilder();
            StreamReader sr = new StreamReader(csproject);
            string line = null;
            bool findCompileLine = false;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.IndexOf("<SubType>") >= 0)
                {
                    continue;
                }

                if (line.IndexOf("</Compile>") >= 0)
                {
                    continue;
                }

                if (line.IndexOf("<Compile Include") >= 0)
                {
                    if (findCompileLine)
                    {
                        continue;
                    }
                    findCompileLine = true;

                    for (int i = 0; i < codeFileList.Length; ++i)
                    {
                        string fulePath = codeFileList[i].Replace("/", "\\");
                        string writeToPath = fulePath.Replace(csprojectParent + "\\", "");
                        sb.AppendLine(string.Format("     <Compile Include=\"{0}\" />", writeToPath));
                    }
                }
                else
                {
                    findCompileLine = false;
                    sb.AppendLine(line);
                }
            }

            sr.Close();
            File.WriteAllText(csproject, sb.ToString());
        }
    }
}
