//文件是自动生成,请勿手动修改.来自数据文件:guild_fight_continuous_reward
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareGuildFightContinuousReward")]
  public class DeclareGuildFightContinuousReward
  {
    #region //私有变量定义
    //连胜次数
    private int _continuous_num;
    //世界等级段(@;@_@)
    private string _level;
    //编号
    private int _num;
    //奖励道具（货币），用;间隔(@;@_@)
    private string _reward_item;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ContinuousNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ContinuousNum { get{ return _continuous_num; } set{ _continuous_num=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Num { get{ return _num; } set{ _num=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"RewardItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string RewardItem { get{ return _reward_item; } set{ _reward_item=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareGuildFightContinuousReward Create( int in_continuous_num, string in_level, int in_num, string in_reward_item )
    {
      DeclareGuildFightContinuousReward tmp = new DeclareGuildFightContinuousReward();
      tmp._continuous_num = in_continuous_num;
      tmp._level = in_level;
      tmp._num = in_num;
      tmp._reward_item = in_reward_item;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareGuildFightContinuousReward> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareGuildFightContinuousReward> _dataCaches = null;
    public static Dictionary<int, DeclareGuildFightContinuousReward> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGuildFightContinuousReward");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataGuildFightContinuousReward = require 'Lua/Config/DataGuildFightContinuousReward'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGuildFightContinuousReward");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareGuildFightContinuousReward>(475);
                     foreach (var item in dic)
                     {
                         DeclareGuildFightContinuousReward tmp = new DeclareGuildFightContinuousReward();
                       tmp.ContinuousNum = item.Value[0];
                       tmp.Level = CfgStringLua.Get(item.Value[1]);
                       tmp.Num = item.Value[2];
                       tmp.RewardItem = CfgStringLua.Get(item.Value[3]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"GuildFightContinuousReward");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareGuildFightContinuousReward>(475);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"GuildFightContinuousReward");
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
    public static DeclareGuildFightContinuousReward Get(int id)
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
    public static void Transform(Dictionary<int, DeclareGuildFightContinuousReward> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
