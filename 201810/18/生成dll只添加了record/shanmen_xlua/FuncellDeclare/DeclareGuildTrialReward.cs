//文件是自动生成,请勿手动修改.来自数据文件:guild_trial_reward
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareGuildTrialReward")]
  public class DeclareGuildTrialReward
  {
    #region //私有变量定义
    //编号
    private int _num;
    //排名最大区间
    private int _ranking_interval_max;
    //排名最小区间
    private int _ranking_interval_mini;
    //奖励道具（货币），用;间隔(@;@_@)
    private string _reward_item;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Num { get{ return _num; } set{ _num=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"RankingIntervalMax", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int RankingIntervalMax { get{ return _ranking_interval_max; } set{ _ranking_interval_max=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"RankingIntervalMini", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int RankingIntervalMini { get{ return _ranking_interval_mini; } set{ _ranking_interval_mini=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"RewardItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string RewardItem { get{ return _reward_item; } set{ _reward_item=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareGuildTrialReward Create( int in_num, int in_ranking_interval_max, int in_ranking_interval_mini, string in_reward_item )
    {
      DeclareGuildTrialReward tmp = new DeclareGuildTrialReward();
      tmp._num = in_num;
      tmp._ranking_interval_max = in_ranking_interval_max;
      tmp._ranking_interval_mini = in_ranking_interval_mini;
      tmp._reward_item = in_reward_item;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareGuildTrialReward> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareGuildTrialReward> _dataCaches = null;
    public static Dictionary<int, DeclareGuildTrialReward> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGuildTrialReward");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataGuildTrialReward = require 'Lua/Config/DataGuildTrialReward'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGuildTrialReward");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareGuildTrialReward>(4);
                     foreach (var item in dic)
                     {
                         DeclareGuildTrialReward tmp = new DeclareGuildTrialReward();
                       tmp.Num = item.Value[0];
                       tmp.RankingIntervalMax = item.Value[1];
                       tmp.RankingIntervalMini = item.Value[2];
                       tmp.RewardItem = CfgStringLua.Get(item.Value[3]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"GuildTrialReward");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareGuildTrialReward>(4);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"GuildTrialReward");
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
    public static DeclareGuildTrialReward Get(int id)
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
    public static void Transform(Dictionary<int, DeclareGuildTrialReward> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
