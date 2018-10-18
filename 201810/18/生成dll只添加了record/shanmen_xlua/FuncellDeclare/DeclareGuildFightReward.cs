//文件是自动生成,请勿手动修改.来自数据文件:guild_fight_reward
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareGuildFightReward")]
  public class DeclareGuildFightReward
  {
    #region //私有变量定义
    //战区（1为巅峰战区第一场，2为精英战区，3为普通战区，10为巅峰战区的第二场）
    private int _area;
    //进入竞拍的掉落ID,（世界等级_世界等级_掉落ID；世界等级_世界等级_掉落ID）(@;@_@)
    private string _auction;
    //编号
    private int _num;
    //胜负（1为胜利，2为失败）
    private int _outcome;
    //奖励道具（货币），用;间隔(@;@_@)
    private string _reward_item;
    //获取称号ID
    private int _reward_title;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Area", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Area { get{ return _area; } set{ _area=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Auction", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Auction { get{ return _auction; } set{ _auction=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Num { get{ return _num; } set{ _num=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Outcome", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Outcome { get{ return _outcome; } set{ _outcome=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"RewardItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string RewardItem { get{ return _reward_item; } set{ _reward_item=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"RewardTitle", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int RewardTitle { get{ return _reward_title; } set{ _reward_title=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareGuildFightReward Create( int in_area, string in_auction, int in_num, int in_outcome, string in_reward_item, int in_reward_title )
    {
      DeclareGuildFightReward tmp = new DeclareGuildFightReward();
      tmp._area = in_area;
      tmp._auction = in_auction;
      tmp._num = in_num;
      tmp._outcome = in_outcome;
      tmp._reward_item = in_reward_item;
      tmp._reward_title = in_reward_title;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareGuildFightReward> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareGuildFightReward> _dataCaches = null;
    public static Dictionary<int, DeclareGuildFightReward> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGuildFightReward");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataGuildFightReward = require 'Lua/Config/DataGuildFightReward'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGuildFightReward");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareGuildFightReward>(8);
                     foreach (var item in dic)
                     {
                         DeclareGuildFightReward tmp = new DeclareGuildFightReward();
                       tmp.Area = item.Value[0];
                       tmp.Auction = CfgStringLua.Get(item.Value[1]);
                       tmp.Num = item.Value[2];
                       tmp.Outcome = item.Value[3];
                       tmp.RewardItem = CfgStringLua.Get(item.Value[4]);
                       tmp.RewardTitle = item.Value[5];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"GuildFightReward");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareGuildFightReward>(8);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"GuildFightReward");
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
    public static DeclareGuildFightReward Get(int id)
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
    public static void Transform(Dictionary<int, DeclareGuildFightReward> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
