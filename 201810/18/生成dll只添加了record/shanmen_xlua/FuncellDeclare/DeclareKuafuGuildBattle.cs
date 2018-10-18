//文件是自动生成,请勿手动修改.来自数据文件:kuafu_guild_Battle
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareKuafuGuildBattle")]
  public class DeclareKuafuGuildBattle
  {
    #region //私有变量定义
    //失败可以获得积分
    private int _fail_integral;
    //失败奖励（道具ID_数量_是否绑定；道具ID_数量_是否绑定）（最多配置1个奖励）(@;@_@)
    private string _fail_reward;
    //排名
    private int _id;
    //月奖励（道具ID_数量_是否绑定；道具ID_数量_是否绑定）(@;@_@)
    private string _month_reward;
    //胜利可以获得积分
    private int _victory_integral;
    //胜利奖励（道具ID_数量_是否绑定；道具ID_数量_是否绑定）（最多配置2个奖励）(@;@_@)
    private string _victory_reward;
    //周奖励（道具ID_数量_是否绑定；道具ID_数量_是否绑定）(@;@_@)
    private string _week_reward;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"FailIntegral", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int FailIntegral { get{ return _fail_integral; } set{ _fail_integral=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"FailReward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string FailReward { get{ return _fail_reward; } set{ _fail_reward=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"MonthReward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string MonthReward { get{ return _month_reward; } set{ _month_reward=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"VictoryIntegral", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int VictoryIntegral { get{ return _victory_integral; } set{ _victory_integral=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"VictoryReward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string VictoryReward { get{ return _victory_reward; } set{ _victory_reward=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"WeekReward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string WeekReward { get{ return _week_reward; } set{ _week_reward=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareKuafuGuildBattle Create( int in_fail_integral, string in_fail_reward, int in_id, string in_month_reward, int in_victory_integral, string in_victory_reward, string in_week_reward )
    {
      DeclareKuafuGuildBattle tmp = new DeclareKuafuGuildBattle();
      tmp._fail_integral = in_fail_integral;
      tmp._fail_reward = in_fail_reward;
      tmp._id = in_id;
      tmp._month_reward = in_month_reward;
      tmp._victory_integral = in_victory_integral;
      tmp._victory_reward = in_victory_reward;
      tmp._week_reward = in_week_reward;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareKuafuGuildBattle> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareKuafuGuildBattle> _dataCaches = null;
    public static Dictionary<int, DeclareKuafuGuildBattle> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataKuafuGuildBattle");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataKuafuGuildBattle = require 'Lua/Config/DataKuafuGuildBattle'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataKuafuGuildBattle");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareKuafuGuildBattle>(16);
                     foreach (var item in dic)
                     {
                         DeclareKuafuGuildBattle tmp = new DeclareKuafuGuildBattle();
                       tmp.FailIntegral = item.Value[0];
                       tmp.FailReward = CfgStringLua.Get(item.Value[1]);
                       tmp.Id = item.Value[2];
                       tmp.MonthReward = CfgStringLua.Get(item.Value[3]);
                       tmp.VictoryIntegral = item.Value[4];
                       tmp.VictoryReward = CfgStringLua.Get(item.Value[5]);
                       tmp.WeekReward = CfgStringLua.Get(item.Value[6]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"KuafuGuildBattle");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareKuafuGuildBattle>(16);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"KuafuGuildBattle");
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
    public static DeclareKuafuGuildBattle Get(int id)
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
    public static void Transform(Dictionary<int, DeclareKuafuGuildBattle> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
