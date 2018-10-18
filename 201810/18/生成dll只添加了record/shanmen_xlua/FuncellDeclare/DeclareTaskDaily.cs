//文件是自动生成,请勿手动修改.来自数据文件:task_daily
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareTaskDaily")]
  public class DeclareTaskDaily
  {
    #region //私有变量定义
    //领取任务的NPC
    private int _conditions_npc;
    //传送位置，x_z(@_@) daily_task_x_z
    private string _daily_task_x_z;
    //双倍奖励(双倍奖励货币类型_值)(@_@)
    private string _double_currency;
    //刷星消耗(@_@)
    private string _fillStarcost;
    //任务ID
    private int _id;
    //对话的npc_id
    private int _npc_id;
    //完成单次货币(完成任务货币类型_值)(@_@)
    private string _over_currency;
    //提交任务NPC
    private int _over_npc;
    //0星任务奖励(奖励_数量;奖励_数量）[@;@_@]
    private string _rewards_0;
    //1星任务奖励(奖励_数量;奖励_数量）[@;@_@]
    private string _rewards_1;
    //2星任务奖励(奖励_数量;奖励_数量）[@;@_@]
    private string _rewards_2;
    //3星任务奖励(奖励_数量;奖励_数量）[@;@_@]
    private string _rewards_3;
    //4星任务奖励(奖励_数量;奖励_数量）[@;@_@]
    private string _rewards_4;
    //5星任务奖励(奖励_数量;奖励_数量）[@;@_@]
    private string _rewards_5;
    //星级概率（0星概率_1星概率_2星概率_3星概率…..）(@_@) daily_task_x_z
    private string _star;
    //任务名称
    private string _task_name;
    //完成任务对话
    private int _task_talk_over;
    //领取任务对话
    private int _task_talk_start;
    //任务类型（0 对话 1 杀怪 2 收集 3 等级达到X 4 使用道具 5 采集9 通关副本）
    private int _task_type;
    //任务类型
    private string _typeName;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ConditionsNpc", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ConditionsNpc { get{ return _conditions_npc; } set{ _conditions_npc=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"DailyTaskXZ", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DailyTaskXZ { get{ return _daily_task_x_z; } set{ _daily_task_x_z=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"DoubleCurrency", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DoubleCurrency { get{ return _double_currency; } set{ _double_currency=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"FillStarcost", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string FillStarcost { get{ return _fillStarcost; } set{ _fillStarcost=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"NpcId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NpcId { get{ return _npc_id; } set{ _npc_id=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"OverCurrency", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OverCurrency { get{ return _over_currency; } set{ _over_currency=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"OverNpc", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OverNpc { get{ return _over_npc; } set{ _over_npc=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Rewards0", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Rewards0 { get{ return _rewards_0; } set{ _rewards_0=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Rewards1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Rewards1 { get{ return _rewards_1; } set{ _rewards_1=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Rewards2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Rewards2 { get{ return _rewards_2; } set{ _rewards_2=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"Rewards3", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Rewards3 { get{ return _rewards_3; } set{ _rewards_3=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"Rewards4", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Rewards4 { get{ return _rewards_4; } set{ _rewards_4=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"Rewards5", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Rewards5 { get{ return _rewards_5; } set{ _rewards_5=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"Star", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Star { get{ return _star; } set{ _star=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"TaskName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TaskName { get{ return _task_name; } set{ _task_name=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"TaskTalkOver", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TaskTalkOver { get{ return _task_talk_over; } set{ _task_talk_over=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"TaskTalkStart", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TaskTalkStart { get{ return _task_talk_start; } set{ _task_talk_start=value; } }
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"TaskType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TaskType { get{ return _task_type; } set{ _task_type=value; } }
    [global::ProtoBuf.ProtoMember(20, IsRequired = true, Name=@"TypeName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TypeName { get{ return _typeName; } set{ _typeName=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareTaskDaily Create( int in_conditions_npc, string in_daily_task_x_z, string in_double_currency, string in_fillStarcost, int in_id, int in_npc_id, string in_over_currency, int in_over_npc, string in_rewards_0, string in_rewards_1, string in_rewards_2, string in_rewards_3, string in_rewards_4, string in_rewards_5, string in_star, string in_task_name, int in_task_talk_over, int in_task_talk_start, int in_task_type, string in_typeName )
    {
      DeclareTaskDaily tmp = new DeclareTaskDaily();
      tmp._conditions_npc = in_conditions_npc;
      tmp._daily_task_x_z = in_daily_task_x_z;
      tmp._double_currency = in_double_currency;
      tmp._fillStarcost = in_fillStarcost;
      tmp._id = in_id;
      tmp._npc_id = in_npc_id;
      tmp._over_currency = in_over_currency;
      tmp._over_npc = in_over_npc;
      tmp._rewards_0 = in_rewards_0;
      tmp._rewards_1 = in_rewards_1;
      tmp._rewards_2 = in_rewards_2;
      tmp._rewards_3 = in_rewards_3;
      tmp._rewards_4 = in_rewards_4;
      tmp._rewards_5 = in_rewards_5;
      tmp._star = in_star;
      tmp._task_name = in_task_name;
      tmp._task_talk_over = in_task_talk_over;
      tmp._task_talk_start = in_task_talk_start;
      tmp._task_type = in_task_type;
      tmp._typeName = in_typeName;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareTaskDaily> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareTaskDaily> _dataCaches = null;
    public static Dictionary<int, DeclareTaskDaily> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTaskDaily");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataTaskDaily = require 'Lua/Config/DataTaskDaily'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTaskDaily");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareTaskDaily>(3276);
                     foreach (var item in dic)
                     {
                         DeclareTaskDaily tmp = new DeclareTaskDaily();
                       tmp.ConditionsNpc = item.Value[0];
                       tmp.DailyTaskXZ = CfgStringLua.Get(item.Value[1]);
                       tmp.DoubleCurrency = CfgStringLua.Get(item.Value[2]);
                       tmp.FillStarcost = CfgStringLua.Get(item.Value[3]);
                       tmp.Id = item.Value[4];
                       tmp.NpcId = item.Value[5];
                       tmp.OverCurrency = CfgStringLua.Get(item.Value[6]);
                       tmp.OverNpc = item.Value[7];
                       tmp.Rewards0 = CfgStringLua.Get(item.Value[8]);
                       tmp.Rewards1 = CfgStringLua.Get(item.Value[9]);
                       tmp.Rewards2 = CfgStringLua.Get(item.Value[10]);
                       tmp.Rewards3 = CfgStringLua.Get(item.Value[11]);
                       tmp.Rewards4 = CfgStringLua.Get(item.Value[12]);
                       tmp.Rewards5 = CfgStringLua.Get(item.Value[13]);
                       tmp.Star = CfgStringLua.Get(item.Value[14]);
                       tmp.TaskName = CfgStringLua.Get(item.Value[15]);
                       tmp.TaskTalkOver = item.Value[16];
                       tmp.TaskTalkStart = item.Value[17];
                       tmp.TaskType = item.Value[18];
                       tmp.TypeName = CfgStringLua.Get(item.Value[19]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"TaskDaily");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareTaskDaily>(3276);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"TaskDaily");
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
    public static DeclareTaskDaily Get(int id)
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
    public static void Transform(Dictionary<int, DeclareTaskDaily> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
