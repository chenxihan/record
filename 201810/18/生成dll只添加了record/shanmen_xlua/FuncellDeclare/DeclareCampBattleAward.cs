//文件是自动生成,请勿手动修改.来自数据文件:CampBattleAward
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareCampBattleAward")]
  public class DeclareCampBattleAward
  {
    #region //私有变量定义
    //道具奖励(@;@_@)
    private string _awards1;
    //道具奖励(@;@_@)
    private string _awards2;
    //道具奖励(@;@_@)
    private string _awards3;
    //奖励ID
    private int _level;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Awards1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Awards1 { get{ return _awards1; } set{ _awards1=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Awards2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Awards2 { get{ return _awards2; } set{ _awards2=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Awards3", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Awards3 { get{ return _awards3; } set{ _awards3=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareCampBattleAward Create( string in_awards1, string in_awards2, string in_awards3, int in_level )
    {
      DeclareCampBattleAward tmp = new DeclareCampBattleAward();
      tmp._awards1 = in_awards1;
      tmp._awards2 = in_awards2;
      tmp._awards3 = in_awards3;
      tmp._level = in_level;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareCampBattleAward> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareCampBattleAward> _dataCaches = null;
    public static Dictionary<int, DeclareCampBattleAward> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataCampBattleAward");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataCampBattleAward = require 'Lua/Config/DataCampBattleAward'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataCampBattleAward");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareCampBattleAward>(400);
                     foreach (var item in dic)
                     {
                         DeclareCampBattleAward tmp = new DeclareCampBattleAward();
                       tmp.Awards1 = CfgStringLua.Get(item.Value[0]);
                       tmp.Awards2 = CfgStringLua.Get(item.Value[1]);
                       tmp.Awards3 = CfgStringLua.Get(item.Value[2]);
                       tmp.Level = item.Value[3];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"CampBattleAward");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareCampBattleAward>(400);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"CampBattleAward");
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
    public static DeclareCampBattleAward Get(int id)
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
    public static void Transform(Dictionary<int, DeclareCampBattleAward> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
