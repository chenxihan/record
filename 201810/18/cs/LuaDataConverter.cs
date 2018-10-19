//文件是自动生成,请勿手动修改.此类用于定义通用数据.
using Funcell.Cfg.Data;
using System.Collections.Generic;

namespace XLua
{
    class LuaDataConverter
    {
        private static bool _isLoaded = false;
        public static bool IsLoaded()
        {
            return _isLoaded;
        }
        public static void Load()
        {
            _isLoaded = false;
            DeclareDreamlandMonster.SetLuaDataCallBack(GetLuaData);
            DeclareDreamlandMonster.SetStringCallBack(GetString);
            _isLoaded = true;
        }

        private static Dictionary<int, int[]> GetLuaData(string name)
        {
            Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>(name);
            if (dic == null)
            {
                LuaEnv.SharedLuaEnv.DoString(string.Format("{0} = require 'Lua/Config/{1}'", name, name));
                dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>(name);
            }
            return dic;
        }

        private static string GetString(int id)
        {
            return CfgStringLua.Get(id);
        }
    }
}
