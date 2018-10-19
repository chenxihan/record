using UnityEditor;

namespace DLLComplierEditor
{
    /// <summary>
    /// 所有菜单项都从这里出口
    /// </summary>
    public class MenuItems
    {
        //只生成基础的dll
        [MenuItem("Funcell/Complier/BaseDllGen",false,9801)]
        public static void ExecuteBase()
        {
            Complier.UseProfiler = false;
            Main.ExecuteBase(BuildTarget.Android);
        }

        //生成配置文件dll
        [MenuItem("Funcell/Complier/ConfigGen", false, 9802)]
        public static void ExecuteCfg()
        {
            //Complier.UseProfiler = false;
            //Main.ExecuteCfg(BuildTarget.Android, string.Empty);

            LanuageVersionSelectWindow.ShowWindow();
        }

        //生成Logic
        [MenuItem("Funcell/Complier/LogicDllGen", false, 9803)]
        public static void ExecuteLogic()
        {
            Complier.UseProfiler = false;
            Main.ExecuteLogic(BuildTarget.Android, string.Empty);
        }

        [MenuItem("Funcell/Complier/LogicDllGen_Profiler", false, 9804)]
        public static void ExecuteLogicProfler()
        {
            Complier.UseProfiler = true;
            Main.ExecuteLogic(BuildTarget.Android, string.Empty);
        }

        //生成所有的dll
        [MenuItem("Funcell/Complier/AllDllGen", false, 9805)]
        public static void ExecuteAll()
        {
            Complier.UseProfiler = false;
            Main.Execute(BuildTarget.Android, string.Empty);
        }
        //生成Shader定义文件
        [MenuItem("Funcell/Complier/ShaderDefineGen", false, 9806)]
        public static void GenerateShaderDefine()
        {
            ShaderDefineGenerator.Execute();
        }

        //生成Shader变体集合
        [MenuItem("Funcell/Complier/ShaderVariantCollectionGen", false, 9807)]
        public static void GenerateShaderVariantCollection()
        {
            ShaderVariantCollectionGenerator.Execute();
        }

        //单独导出一张表
        [MenuItem("Funcell/Complier/ConfigGenSingle", false, 9808)]
        public static void ConfigGenSingle()
        {
            ExportExcelSingle.ExcuteExport();
        }
    }
}
