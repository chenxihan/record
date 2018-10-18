//文件是自动生成,请勿手动修改.来自数据文件:kingAllianceSeasonAward
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareKingAllianceSeasonAward")]
  public class DeclareKingAllianceSeasonAward
  {
    #region //私有变量定义
    //奖励(@;@_@)
    private string _award;
    //id
    private int _feats;
    //需求段位等级
    private int _king_level;
    //需求最大排名
    private int _rank_max;
    //需求最小排名
    private int _rank_min;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Award", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Award { get{ return _award; } set{ _award=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Feats", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Feats { get{ return _feats; } set{ _feats=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"KingLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int KingLevel { get{ return _king_level; } set{ _king_level=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"RankMax", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int RankMax { get{ return _rank_max; } set{ _rank_max=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"RankMin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int RankMin { get{ return _rank_min; } set{ _rank_min=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareKingAllianceSeasonAward Create( string in_award, int in_feats, int in_king_level, int in_rank_max, int in_rank_min )
    {
      DeclareKingAllianceSeasonAward tmp = new DeclareKingAllianceSeasonAward();
      tmp._award = in_award;
      tmp._feats = in_feats;
      tmp._king_level = in_king_level;
      tmp._rank_max = in_rank_max;
      tmp._rank_min = in_rank_min;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareKingAllianceSeasonAward> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareKingAllianceSeasonAward> _dataCaches = null;
    public static Dictionary<int, DeclareKingAllianceSeasonAward> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataKingAllianceSeasonAward");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataKingAllianceSeasonAward = require 'Lua/Config/DataKingAllianceSeasonAward'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataKingAllianceSeasonAward");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareKingAllianceSeasonAward>(33);
                     foreach (var item in dic)
                     {
                         DeclareKingAllianceSeasonAward tmp = new DeclareKingAllianceSeasonAward();
                       tmp.Award = CfgStringLua.Get(item.Value[0]);
                       tmp.Feats = item.Value[1];
                       tmp.KingLevel = item.Value[2];
                       tmp.RankMax = item.Value[3];
                       tmp.RankMin = item.Value[4];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"KingAllianceSeasonAward");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareKingAllianceSeasonAward>(33);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"KingAllianceSeasonAward");
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
    public static DeclareKingAllianceSeasonAward Get(int id)
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
    public static void Transform(Dictionary<int, DeclareKingAllianceSeasonAward> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
