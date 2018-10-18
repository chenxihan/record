//文件是自动生成,请勿手动修改.来自数据文件:diamondinvest_level
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareDiamondinvestLevel")]
  public class DeclareDiamondinvestLevel
  {
    #region //私有变量定义
    //所需钻石
    private int _diamond;
    //投资档次
    private int _investLevel;
    //等级限制
    private int _level;
    //VIP限制
    private int _vip;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Diamond", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Diamond { get{ return _diamond; } set{ _diamond=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"InvestLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int InvestLevel { get{ return _investLevel; } set{ _investLevel=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Vip", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Vip { get{ return _vip; } set{ _vip=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareDiamondinvestLevel Create( int in_diamond, int in_investLevel, int in_level, int in_vip )
    {
      DeclareDiamondinvestLevel tmp = new DeclareDiamondinvestLevel();
      tmp._diamond = in_diamond;
      tmp._investLevel = in_investLevel;
      tmp._level = in_level;
      tmp._vip = in_vip;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareDiamondinvestLevel> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareDiamondinvestLevel> _dataCaches = null;
    public static Dictionary<int, DeclareDiamondinvestLevel> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataDiamondinvestLevel");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataDiamondinvestLevel = require 'Lua/Config/DataDiamondinvestLevel'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataDiamondinvestLevel");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareDiamondinvestLevel>(3);
                     foreach (var item in dic)
                     {
                         DeclareDiamondinvestLevel tmp = new DeclareDiamondinvestLevel();
                       tmp.Diamond = item.Value[0];
                       tmp.InvestLevel = item.Value[1];
                       tmp.Level = item.Value[2];
                       tmp.Vip = item.Value[3];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"DiamondinvestLevel");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareDiamondinvestLevel>(3);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"DiamondinvestLevel");
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
    public static DeclareDiamondinvestLevel Get(int id)
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
    public static void Transform(Dictionary<int, DeclareDiamondinvestLevel> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
