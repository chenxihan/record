using System.Collections.Generic;

namespace DLLComplierEditor
{
    /// <summary>
    /// 一些常量定义
    /// 下面有一些约定:
    /// 1.目录路径最后不要带有斜杠"/"    
    /// </summary>
    internal class Defines
    {
        //设定工作目录在Client/Main目录下,并且一下所有路径的设定都是在这个目录下的相对目录
        public static string WorkDir = "Client/Main";
        

        //-----------------------------------解决方案编译,以及动态库分发----------------------------------------------------------------
        //解决方案的路径
        public const string CN_CORE_SOLUTION_PATH = "../Core/Runtime/FuncellCore.sln";
        public const string CN_DATA_SOLUTION_PATH = "../Core/Runtime/FuncellData.sln";
        public const string CN_BASE_SOLUTION_PATH = "../Core/Runtime/FuncellBase.sln";

        //解决方案生成的动态库所在路径
        public const string CN_DLL_BIN_PATH = "../Core/Runtime/bin";

        //Main项目的动态库所在路径
        public const string CN_MAIN_DLL_PATH = "./Assets/Plugins/References";
        //Main项目的lua配置所在路径
        public const string CN_CONFIG_PATH_LUA = "./Assets/StreamingAssets/Lua/Config";
        //用于Lua转换的c#类的路径
        public const string CN_CONFIG_STRING_DATA_PATH = "./Assets/XLua/Src";

        //Launcher项目的静态引用Dll的路径
        public const string CN_LAUNCHER_STATIC_DLL_PATH = "../Launcher/Assets/GameAssets/Resources/References";
        //Launcher项目的动态引用Dll所在路径
        public const string CN_LAUNCHER_DLL_PATH = "../Launcher/Assets/StreamingAssets/Assets/GameAssets/Resources/References";

        //SubResource的动态库所在路径
        public const string CN_SUBRESOURCE_DLL_PATH = "../SubResource/ResAll/Assets/GameAssets/Resources/References";

        //-------------------------------------配置信息生成以及处理---------------------------------------------------------

        //游戏配置文件所在路径
        public const string CN_CONFIG_PATH = "../../Gamedata/Config";

        //配置文件生成输出的代码路径 -- 类定义
        public const string CN_CONFIG_DECLARE_CODE_SOURCE_PATH = "../Core/Runtime/FuncellDeclare/Source";
        //配置文件生成输出的代码路径 -- 数据
        public const string CN_CONFIG_DATA_CODE_SOURCE_PATH = "../Core/Runtime/FuncellData/Source";
        //IOS配置文件生成输出的代码路径
        public const string CN_CONFIG_CODE_LOGIC_RESOURCE_PATH = "Assets/Code/Logic/GameCfgSolusion";

        //--------------------------------------Shader定义文件生成以及处理--------------------------------------------------------------

        //Shader目录
        public const string CN_SHADER_PATH = "Assets/GameAssets/Resources/Shader/Ares";
        //Shader定义的文件名称
        public const string CN_SHADER_DEFINE_CS_FILE = "../Core/Runtime/FuncellCore/Asset/Shader/ShadersDefine.cs";
        //Shader的集合文件
        public const string CN_SHADER_VARIANT_COLLECTION_PATH = "Assets/GameAssets/Resources/Shader/ShaderCollect.shadervariants";

        //--------------------------------------代码复制处理--------------------------------------------------------------

        //代码复制的原始位置
        public const string CN_CODE_SOURCE = "./Assets/Code";
        public const string CN_PLUGINS_SOURCE = "./Assets/Plugins";
        public const string CN_UIFORM_SOURCE = "./Assets/GameAssets/Resources/GameUI";
        //public const string CN_UPDATE_SOURCE = "./Assets/Launcher/LauncherUpdate";
        public const string CN_UPDATE_UIFORM_SOURCE = "./Assets/Launcher/UpdateFormDll";
        public const string CN_EXTERNALLIBS_SOURCE = "./Assets/Launcher/ExternalLibs";

        //代码复制的目标位置
        public const string CN_CODE_TARGET = "../Core/Runtime/FuncellLogic/Code";
        public const string CN_PLUGINS_TARGET = "../Core/Runtime/FuncellLogic/Plugins";
        public const string CN_UIFORM_TARGET = "../Core/Runtime/FuncellUIForm/GameUI";
        public const string CN_UPDATE_TARGET = "../Core/Runtime/FuncellUpdate/LauncherUpdate";
        public const string CN_UPDATE_UIFORM_TARGET = "../Core/Runtime/FuncellUpdateForm/UpdateFormDll";


        public const string CN_LAUNCHER_EXTERNALLIBS_TARGET = "../Launcher/Assets/Launcher/ExternalLibs";

        //--------------------------------------IOS代码复制处理--------------------------------------------------------------
        public const string CN_BASE_SOURCE = "../Core/Runtime/FuncellBase/";
        public const string CN_CORE_SOURCE = "../Core/Runtime/FuncellCore/";
        public const string CN_Declare_SOURCE = "../Core/Runtime/FuncellDeclare/";
        public const string CN_Data_SOURCE = "../Core/Runtime/FuncellData/";
        public const string CN_Update_SOURCE = "../Core/Runtime/FuncellUpdate/";



        //-------------------------------------需要重新修改项目路径------------------------------------------------------------------
        public const string CN_FUNCELLDATA_PROJECT = "../Core/Runtime/FuncellData/FuncellData.csproj";
        public const string CN_FUNCELLDECLARE_PROJECT = "../Core/Runtime/FuncellDeclare/FuncellDeclare.csproj";
        public const string CN_FUNCELLLOGIC_PROJECT = "../Core/Runtime/FuncellLogic/FuncellLogic.csproj";
        public const string CN_FUNCELLUPDATE_PROJECT = "../Core/Runtime/FuncellUpdate/FuncellUpdate.csproj";
        public const string CN_FUNCELLUIFORM_PROJECT = "../Core/Runtime/FuncellUIForm/FuncellUIForm.csproj";
        public const string CN_FUNCELLUPDATEFORM_PROJECT = "../Core/Runtime/FuncellUpdateForm/FuncellUpdateForm.csproj";
        



        public static Dictionary<string, int> DllEncryptCodes = new Dictionary<string, int>();

        //构造函数
        static Defines()
        {
            WorkDir = System.IO.Directory.GetCurrentDirectory();
            /*
             *  "FuncellSDK",
                                               "FuncellUpdate",
                                               "FuncellBase",                                               
                                               "FuncellUpdateForm",
                                               "FuncellCore" ,
                                               "FuncellData" ,
                                               "FuncellDeclare",
                                               "FuncellLogic",
                                               "FuncellUIForm"
             */

            //dll加密后动态库对应的数字
            DllEncryptCodes["FuncellDeclare"] = 0;
            DllEncryptCodes["FuncellData"] = 1;
            DllEncryptCodes["FuncellCore"] = 2;
            DllEncryptCodes["FuncellLogic"] = 3;
            DllEncryptCodes["FuncellUIForm"] = 4;
            DllEncryptCodes["FuncellUpdate"] = 5;
            DllEncryptCodes["FuncellBase"] = 6;
            DllEncryptCodes["FuncellUpdateForm"] = 7;
            DllEncryptCodes["FuncellSDK"] = 8;
        }
    }
}
