using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using UnityEditor;

namespace DLLComplierEditor
{
    /// <summary>
    /// 编译代码
    /// </summary>
    internal class Complier
    {
        //是否使用Profiler
        public static bool UseProfiler = false;

        //编译的进程
        private static Process _compileProcess;

        //完成之后的回调
        private static Action _callBack;

        private static string _solution;

        //生成执行Base的解决方案
        public static void ExecuteBase(BuildTarget buildTarget, Action callBack)
        {
            ShaderDefineGenerator.Execute();
            Execute(buildTarget, Defines.CN_BASE_SOLUTION_PATH, callBack);
        }

        //执行DataConfig的解决方案
        public static void ExecuteCfg(BuildTarget buildTarget, Action callBack)
        {
            Execute(buildTarget, Defines.CN_DATA_SOLUTION_PATH, callBack);
        }

        //执行All的解决方案
        public static void Execute(BuildTarget buildTarget, Action callBack)
        {
            ShaderDefineGenerator.Execute();
            Execute(buildTarget, Defines.CN_CORE_SOLUTION_PATH, callBack);
        }


        //执行代码编译
        private static void Execute( BuildTarget buildTarget,string solution, Action callBack)
        {
            _callBack = callBack;
            _solution = solution;

            switch (buildTarget)
            {
                case BuildTarget.Android:
                    if(!UseProfiler)
                        DoCompileSolution("/t:Rebuild /property:Configuration=Android " + solution);
                    else
                        DoCompileSolution("/t:Rebuild /property:Configuration=Android_Profiler " + solution);

                    break;
                case BuildTarget.iOS:
                    DoCompileSolution("/t:Rebuild /property:Configuration=IOS " + solution);
                    break;
                case BuildTarget.StandaloneWindows:
                case BuildTarget.StandaloneWindows64:
                    DoCompileSolution("/t:Rebuild /property:Configuration=STANDALONE_WIN " + solution);
                    break;
                default:
                    DoCompileSolution("/t:Rebuild /property:Configuration=DEBUG " + solution);
                    break;
            }

        }

        //对解决方案进行编译
        private static void DoCompileSolution(string argument)
        {
            //UnityEditor.EditorUtility.DisplayProgressBar("编译解决方案", "开始编译解决方案...", 0.2f);

            //删除Bin目录
            if (Directory.Exists(Defines.CN_DLL_BIN_PATH))
            {
                Directory.Delete(Defines.CN_DLL_BIN_PATH, true);
            }

            UnityEngine.Debug.Log("编译解决方案:" + argument);
            ProcessStartInfo start = new ProcessStartInfo(@"C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe");
            start.Arguments = argument;
            start.WorkingDirectory = Defines.WorkDir;

            start.CreateNoWindow = false;
            start.ErrorDialog = true;
            start.UseShellExecute = true;
            

            start.RedirectStandardInput = false;
            start.RedirectStandardOutput = false;
            start.RedirectStandardError = false;
            //start.StandardOutputEncoding = System.Text.UTF8Encoding.UTF8;
            //start.StandardErrorEncoding = System.Text.UTF8Encoding.UTF8;
            


            _compileProcess = new Process();
            _compileProcess.EnableRaisingEvents = true;

            _compileProcess.Exited += CompileFinished;
            //_compileProcess.ErrorDataReceived += ErrorDataReceived;
            //_compileProcess.OutputDataReceived += OutputDataReceived;

            _compileProcess.StartInfo = start;
            _compileProcess.Start();
        }

        private static void OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            UnityEngine.Debug.Log(e.Data);
        }

        private static void ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            UnityEngine.Debug.LogError(e.Data);
        }

        //编译完成后
        private static void CompileFinished(object sender, EventArgs e)
        {
            
            if (_compileProcess == null) return;

            if (!_compileProcess.HasExited)
            {
                _compileProcess.WaitForExit();
            }

            //如果编译程序正常退出
            if (_compileProcess.ExitCode == 0)
            {
                UnityEngine.Debug.Log("动态库代码编译成功!");
                if (_callBack != null) _callBack();
               
            }
            else
            {
                UnityEngine.Debug.LogError("自动编译失败.请手动打开解决方案"+ _solution + "编译;失败代码:"+_compileProcess.ExitCode);
            }
            _compileProcess = null;
        }
    }
}
