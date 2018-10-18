//文件是自动生成,请勿手动修改.来自数据文件:task_Line
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareTaskLine")]
  public class DeclareTaskLine
  {
    #region //私有变量定义
    //任务进行目标描述hide
    private string _conditions_describe;
    //任务完成目标描述hide
    private string _conditions_describe_over;
    //领取条件值(@;@)
    private string _conditions_value;
    //提交路径(地图id;ncpID)(@_@)
    private string _endpath;
    //奖励装备（格式：职业_装备ID）多个用；间隔(@;@_@)
    private string _equip;
    //奖励装备（格式：职业_装备ID）多个用；间隔，只用于客户端显示 hide
    private string _equip_hide;
    //领取条件（1为等级，2为任务,3为开服时间,等级)
    private int _gain_conditions;
    //任务环数（从1开始）
    private int _loop;
    //任务名称hide
    private string _name;
    //开启界面hide
    private int _open_panel;
    //参数
    private int _open_panel_param;
    //任务寻径地图ID
    private int _pathMap;
    //下一个任务ID，如果为0那么没有下一个任务
    private int _post_task_id;
    //到达目标点位置的ICON配置(只在达到目标位置生效)hide
    private int _prompt_icon;
    //任务奖励(奖励1;奖励2;奖励N) 奖励模型_数量[@;@_@]
    private string _rewards;
    //任务奖励(奖励1;奖励2;奖励N) 奖励模型_数量，只用于客户端显示 hide
    private string _rewards_hide;
    //激活分支（职业ID_分支ID_分支索引；职业ID_分支ID_分支索引）(@;@_@)
    private string _set_act_branch;
    //激活技能（职业ID_技能ID；职业ID_技能ID）(@;@_@)
    private string _set_act_skill;
    //任务标题名称hide
    private string _tape_name;
    //环ID，同一环任务同一个ID
    private int _tapeID;
    //任务目标(怪物ID_数量/NPCid_数量/等级/采集物品ID_数量_采集物ID/收集物品ID_数量_怪物ID/怪物ID_数量_NPCID_副本Id/飞行ID_飞行次数)(@_@)
    private string _target;
    //NPC交任务对白接
    private int _task_talk_end;
    //NPC接任务对白接
    private int _task_talk_start;
    //任务ID（任务环ID*1000+任务环数）
    private int _taskID;
    //任务描述（用于任务面板中的显示）hide
    private string _tsak_describe;
    //任务类型（0对话1杀怪2采集6完成目标8副本20打开UI7卡等级9主线徽章副本22收集任务）
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ConditionsDescribe", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ConditionsDescribe { get{ return _conditions_describe; } set{ _conditions_describe=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"ConditionsDescribeOver", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ConditionsDescribeOver { get{ return _conditions_describe_over; } set{ _conditions_describe_over=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"ConditionsValue", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ConditionsValue { get{ return _conditions_value; } set{ _conditions_value=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Endpath", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Endpath { get{ return _endpath; } set{ _endpath=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Equip", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Equip { get{ return _equip; } set{ _equip=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"EquipHide", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string EquipHide { get{ return _equip_hide; } set{ _equip_hide=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"GainConditions", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int GainConditions { get{ return _gain_conditions; } set{ _gain_conditions=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Loop", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Loop { get{ return _loop; } set{ _loop=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"OpenPanel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OpenPanel { get{ return _open_panel; } set{ _open_panel=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"OpenPanelParam", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OpenPanelParam { get{ return _open_panel_param; } set{ _open_panel_param=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"PathMap", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PathMap { get{ return _pathMap; } set{ _pathMap=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"PostTaskId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PostTaskId { get{ return _post_task_id; } set{ _post_task_id=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"PromptIcon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PromptIcon { get{ return _prompt_icon; } set{ _prompt_icon=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"Rewards", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Rewards { get{ return _rewards; } set{ _rewards=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"RewardsHide", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string RewardsHide { get{ return _rewards_hide; } set{ _rewards_hide=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"SetActBranch", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SetActBranch { get{ return _set_act_branch; } set{ _set_act_branch=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"SetActSkill", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SetActSkill { get{ return _set_act_skill; } set{ _set_act_skill=value; } }
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"TapeName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TapeName { get{ return _tape_name; } set{ _tape_name=value; } }
    [global::ProtoBuf.ProtoMember(20, IsRequired = true, Name=@"TapeID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TapeID { get{ return _tapeID; } set{ _tapeID=value; } }
    [global::ProtoBuf.ProtoMember(21, IsRequired = true, Name=@"Target", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Target { get{ return _target; } set{ _target=value; } }
    [global::ProtoBuf.ProtoMember(22, IsRequired = true, Name=@"TaskTalkEnd", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TaskTalkEnd { get{ return _task_talk_end; } set{ _task_talk_end=value; } }
    [global::ProtoBuf.ProtoMember(23, IsRequired = true, Name=@"TaskTalkStart", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TaskTalkStart { get{ return _task_talk_start; } set{ _task_talk_start=value; } }
    [global::ProtoBuf.ProtoMember(24, IsRequired = true, Name=@"TaskID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TaskID { get{ return _taskID; } set{ _taskID=value; } }
    [global::ProtoBuf.ProtoMember(25, IsRequired = true, Name=@"TsakDescribe", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TsakDescribe { get{ return _tsak_describe; } set{ _tsak_describe=value; } }
    [global::ProtoBuf.ProtoMember(26, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareTaskLine Create( string in_conditions_describe, string in_conditions_describe_over, string in_conditions_value, string in_endpath, string in_equip, string in_equip_hide, int in_gain_conditions, int in_loop, string in_name, int in_open_panel, int in_open_panel_param, int in_pathMap, int in_post_task_id, int in_prompt_icon, string in_rewards, string in_rewards_hide, string in_set_act_branch, string in_set_act_skill, string in_tape_name, int in_tapeID, string in_target, int in_task_talk_end, int in_task_talk_start, int in_taskID, string in_tsak_describe, int in_type )
    {
      DeclareTaskLine tmp = new DeclareTaskLine();
      tmp._conditions_describe = in_conditions_describe;
      tmp._conditions_describe_over = in_conditions_describe_over;
      tmp._conditions_value = in_conditions_value;
      tmp._endpath = in_endpath;
      tmp._equip = in_equip;
      tmp._equip_hide = in_equip_hide;
      tmp._gain_conditions = in_gain_conditions;
      tmp._loop = in_loop;
      tmp._name = in_name;
      tmp._open_panel = in_open_panel;
      tmp._open_panel_param = in_open_panel_param;
      tmp._pathMap = in_pathMap;
      tmp._post_task_id = in_post_task_id;
      tmp._prompt_icon = in_prompt_icon;
      tmp._rewards = in_rewards;
      tmp._rewards_hide = in_rewards_hide;
      tmp._set_act_branch = in_set_act_branch;
      tmp._set_act_skill = in_set_act_skill;
      tmp._tape_name = in_tape_name;
      tmp._tapeID = in_tapeID;
      tmp._target = in_target;
      tmp._task_talk_end = in_task_talk_end;
      tmp._task_talk_start = in_task_talk_start;
      tmp._taskID = in_taskID;
      tmp._tsak_describe = in_tsak_describe;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareTaskLine> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareTaskLine> _dataCaches = null;
    public static Dictionary<int, DeclareTaskLine> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTaskLine");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataTaskLine = require 'Lua/Config/DataTaskLine'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTaskLine");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareTaskLine>(43);
                     foreach (var item in dic)
                     {
                         DeclareTaskLine tmp = new DeclareTaskLine();
                       tmp.ConditionsDescribe = CfgStringLua.Get(item.Value[0]);
                       tmp.ConditionsDescribeOver = CfgStringLua.Get(item.Value[1]);
                       tmp.ConditionsValue = CfgStringLua.Get(item.Value[2]);
                       tmp.Endpath = CfgStringLua.Get(item.Value[3]);
                       tmp.Equip = CfgStringLua.Get(item.Value[4]);
                       tmp.EquipHide = CfgStringLua.Get(item.Value[5]);
                       tmp.GainConditions = item.Value[6];
                       tmp.Loop = item.Value[7];
                       tmp.Name = CfgStringLua.Get(item.Value[8]);
                       tmp.OpenPanel = item.Value[9];
                       tmp.OpenPanelParam = item.Value[10];
                       tmp.PathMap = item.Value[11];
                       tmp.PostTaskId = item.Value[12];
                       tmp.PromptIcon = item.Value[13];
                       tmp.Rewards = CfgStringLua.Get(item.Value[14]);
                       tmp.RewardsHide = CfgStringLua.Get(item.Value[15]);
                       tmp.SetActBranch = CfgStringLua.Get(item.Value[16]);
                       tmp.SetActSkill = CfgStringLua.Get(item.Value[17]);
                       tmp.TapeName = CfgStringLua.Get(item.Value[18]);
                       tmp.TapeID = item.Value[19];
                       tmp.Target = CfgStringLua.Get(item.Value[20]);
                       tmp.TaskTalkEnd = item.Value[21];
                       tmp.TaskTalkStart = item.Value[22];
                       tmp.TaskID = item.Value[23];
                       tmp.TsakDescribe = CfgStringLua.Get(item.Value[24]);
                       tmp.Type = item.Value[25];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"TaskLine");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareTaskLine>(43);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"TaskLine");
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
    public static DeclareTaskLine Get(int id)
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
    public static void Transform(Dictionary<int, DeclareTaskLine> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
