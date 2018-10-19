//文件是自动生成,请勿手动修改.此类用于定义通用数据.
using System;
namespace XLua
{
    //所有的字符串(从lua表获取)
    public class CfgStringLua
    {
        private static string[] strArr;
        public static string Get(int id)
        {
            if (strArr == null)
            {
                long startTime = DateTime.Now.Ticks;
                strArr = LuaEnv.SharedLuaEnv.Global.Get<string[]>("StringDefines");
                if (strArr == null)
                {
                    LuaEnv.SharedLuaEnv.DoString("StringDefines = require'Lua/Config/StringDefines'");
                    strArr = LuaEnv.SharedLuaEnv.Global.Get<string[]>("StringDefines");
                }
                Record(startTime, DateTime.Now.Ticks, "StringDefines");
            }
            if (id < 0 || id >= strArr.Length)
                return null;
            return strArr[id];
        }
        private static void Record(long startTime, long stopTime, string name)
        {
            System.IO.FileStream fs = new System.IO.FileStream("E:/Config.txt", System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);
            int r = fs.Read(new byte[102400], 0, 102400);
            if (r > 0)
            {
                fs.WriteByte(13);
                fs.WriteByte(10);
            }
            byte[] buffer = System.Text.Encoding.Default.GetBytes(name + "	" + ",	" + ((float)(stopTime - startTime)) / 10000000);
            fs.Write(buffer, 0, buffer.Length);
            fs.Close();
        }
    }
}
