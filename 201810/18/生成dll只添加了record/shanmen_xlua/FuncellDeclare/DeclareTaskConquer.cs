//文件是自动生成,请勿手动修改.来自数据文件:task_conquer
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareTaskConquer")]
  public class DeclareTaskConquer
  {
    #region //私有变量定义
    //领取任务的NPC
    private int _conditions_npc;
    //双倍奖励(双倍奖励货币类型_值)(@_@)
    private string _double_currency;
    //任务目标(任务模型/NPC_数量)(@_@)
    private string _goal_npc;
    //任务ID
    private int _id;
    //完成单次货币(完成任务货币类型_值)(@_@)
    private string _over_currency;
    //提交任务NPC
    private int _over_npc;
    //到达目标点位置的ICON配置(只在达到目标位置生效)hide
    private int _prompt_icon;
    //任务奖励(奖励_数量;奖励_数量）[@;@_@]
    private string _rewards;
    //任务标题名称hide
    private string _tape_name;
    //任务名称
    private string _task_name;
    //完成任务对话
    private int _task_talk_over;
    //领取任务对话
    private int _task_talk_start;
    //任务类型参看Sheet1
    private int _task_type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ConditionsNpc", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ConditionsNpc { get{ return _conditions_npc; } set{ _conditions_npc=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"DoubleCurrency", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DoubleCurrency { get{ return _double_currency; } set{ _double_currency=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"GoalNpc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string GoalNpc { get{ return _goal_npc; } set{ _goal_npc=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"OverCurrency", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OverCurrency { get{ return _over_currency; } set{ _over_currency=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"OverNpc", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OverNpc { get{ return _over_npc; } set{ _over_npc=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"PromptIcon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PromptIcon { get{ return _prompt_icon; } set{ _prompt_icon=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Rewards", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Rewards { get{ return _rewards; } set{ _rewards=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"TapeName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TapeName { get{ return _tape_name; } set{ _tape_name=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"TaskName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TaskName { get{ return _task_name; } set{ _task_name=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"TaskTalkOver", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TaskTalkOver { get{ return _task_talk_over; } set{ _task_talk_over=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"TaskTalkStart", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TaskTalkStart { get{ return _task_talk_start; } set{ _task_talk_start=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"TaskType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TaskType { get{ return _task_type; } set{ _task_type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareTaskConquer Create( int in_conditions_npc, string in_double_currency, string in_goal_npc, int in_id, string in_over_currency, int in_over_npc, int in_prompt_icon, string in_rewards, string in_tape_name, string in_task_name, int in_task_talk_over, int in_task_talk_start, int in_task_type )
    {
      DeclareTaskConquer tmp = new DeclareTaskConquer();
      tmp._conditions_npc = in_conditions_npc;
      tmp._double_currency = in_double_currency;
      tmp._goal_npc = in_goal_npc;
      tmp._id = in_id;
      tmp._over_currency = in_over_currency;
      tmp._over_npc = in_over_npc;
      tmp._prompt_icon = in_prompt_icon;
      tmp._rewards = in_rewards;
      tmp._tape_name = in_tape_name;
      tmp._task_name = in_task_name;
      tmp._task_talk_over = in_task_talk_over;
      tmp._task_talk_start = in_task_talk_start;
      tmp._task_type = in_task_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareTaskConquer> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareTaskConquer> _dataCaches = null;
    public static Dictionary<int, DeclareTaskConquer> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTaskConquer");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataTaskConquer = require 'Lua/Config/DataTaskConquer'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTaskConquer");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareTaskConquer>(354);
                     foreach (var item in dic)
                     {
                         DeclareTaskConquer tmp = new DeclareTaskConquer();
                       tmp.ConditionsNpc = item.Value[0];
                       tmp.DoubleCurrency = CfgStringLua.Get(item.Value[1]);
                       tmp.GoalNpc = CfgStringLua.Get(item.Value[2]);
                       tmp.Id = item.Value[3];
                       tmp.OverCurrency = CfgStringLua.Get(item.Value[4]);
                       tmp.OverNpc = item.Value[5];
                       tmp.PromptIcon = item.Value[6];
                       tmp.Rewards = CfgStringLua.Get(item.Value[7]);
                       tmp.TapeName = CfgStringLua.Get(item.Value[8]);
                       tmp.TaskName = CfgStringLua.Get(item.Value[9]);
                       tmp.TaskTalkOver = item.Value[10];
                       tmp.TaskTalkStart = item.Value[11];
                       tmp.TaskType = item.Value[12];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"TaskConquer");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareTaskConquer>(354);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"TaskConquer");
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
    public static DeclareTaskConquer Get(int id)
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
    public static void Transform(Dictionary<int, DeclareTaskConquer> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
