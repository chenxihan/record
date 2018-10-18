//文件是自动生成,请勿手动修改.来自数据文件:diamondinvest
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareDiamondinvest")]
  public class DeclareDiamondinvest
  {
    #region //私有变量定义
    //领取天数
    private int _day;
    //1档次返还
    private int _level_1;
    //2档次返还
    private int _level_2;
    //3档次返还
    private int _level_3;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Day", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Day { get{ return _day; } set{ _day=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Level1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level1 { get{ return _level_1; } set{ _level_1=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Level2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level2 { get{ return _level_2; } set{ _level_2=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Level3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level3 { get{ return _level_3; } set{ _level_3=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareDiamondinvest Create( int in_day, int in_level_1, int in_level_2, int in_level_3 )
    {
      DeclareDiamondinvest tmp = new DeclareDiamondinvest();
      tmp._day = in_day;
      tmp._level_1 = in_level_1;
      tmp._level_2 = in_level_2;
      tmp._level_3 = in_level_3;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareDiamondinvest> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareDiamondinvest> _dataCaches = null;
    public static Dictionary<int, DeclareDiamondinvest> CacheData
    {
        get 
        {
            lock (_lockObj)
            {
                SetData();
                return _dataCaches; 
            }
        }
        set 
        {
            lock (_lockObj)
            {
                _dataCaches = value;
            }
        }
    }
    public static void SetData()
         {
             if(_dataCaches == null && LuaEnv.isLoadLuaCfg)
             {
                 long startTime = DateTime.Now.Ticks;
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataDiamondinvest");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataDiamondinvest = require 'Lua/Config/DataDiamondinvest'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataDiamondinvest");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareDiamondinvest>(14);
                     foreach (var item in dic)
                     {
                         DeclareDiamondinvest tmp = new DeclareDiamondinvest();
                       tmp.Day = item.Value[0];
                       tmp.Level1 = item.Value[1];
                       tmp.Level2 = item.Value[2];
                       tmp.Level3 = item.Value[3];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Diamondinvest");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareDiamondinvest>(14);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Diamondinvest");
                 }
             }
    }
    private static void Record(long startTime,long stopTime,string name)
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
    //设置填充数据回调
    public static void SetFillDataCallBack(OnFillDataHandler callBack)
    {
        _fillDataCallBack = callBack;
    }
    //根据ID获取数据
    public static DeclareDiamondinvest Get(int id)
    {
        lock (_lockObj)
        {
            SetData();
            if (_dataCaches != null && _dataCaches.ContainsKey(id))
            {
                return _dataCaches[id];
            }
            return null;
        }
    }
    //transForm函数，作数据填充
    public static void Transform(Dictionary<int, DeclareDiamondinvest> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
