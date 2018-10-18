//文件是自动生成,请勿手动修改.来自数据文件:task
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareTask")]
  public class DeclareTask
  {
    #region //私有变量定义
    //领取阵营（0为所有阵营）
    private int _camp;
    //章节描述hide
    private string _chapter_desc;
    //章节名称hide
    private string _chapter_name;
    //章节进度hide
    private string _chapterprogr;
    //任务目标描述
    private string _conditions_describe;
    //提交路径(地图id;ncpID)(@_@)
    private string _endpath;
    //奖励装备（格式：职业_装备ID）多个用；间隔(@;@_@)
    private string _equip;
    //装备强化属性（强化等级）
    private string _equip_strengthening;
    //接受到任务时进行飞行传送的ID
    private int _flyteleport;
    //是否自动交接任务（0自动，1不自动）
    private int _isAuto;
    //是否加载小飞鞋特效（0否1是）
    private int _isFly;
    //是否传送（0传送，1不传送）
    private int _isTransport;
    //徽章进度(徽章ID_当前进度)(@_@)
    private string _medalJD;
    //怪物是否是隐藏的
    private int _monsterhide;
    //开启界面hide
    private int _open_panel;
    //参数
    private int _open_panel_param;
    //任务寻径地图ID
    private int _pathMap;
    //完成后接取任务ID（-1为新手村任务做完，0为主线做完）
    private int _post_task_id;
    //到达目标点位置的ICON配置(只在达到目标位置生效)hide
    private int _prompt_icon;
    //任务奖励(奖励1;奖励2;奖励N) 奖励模型_数量[@;@_@]
    private string _rewards;
    //服务器副本ID值，服务器机器人用于完成副本任务处理
    private int _servercloneId;
    //激活分支（职业ID_分支ID_分支索引；职业ID_分支ID_分支索引）(@;@_@)
    private string _set_act_branch;
    //激活技能（职业ID_技能ID；职业ID_技能ID）(@;@_@)
    private string _set_act_skill;
    //任务共享类型（0为不共享，1为共享）
    private int _share;
    //神兵展示(@_@)
    private string _show;
    //主面板任务描述hide
    private string _taksdesc;
    //任务标题名称hide
    private string _tape_name;
    //任务目标(怪物ID_数量/NPCid_数量/等级/采集物品ID_数量_采集物ID/收集物品ID_数量_怪物ID/怪物ID_数量_NPCID_副本Id/飞行ID_飞行次数)(@_@)
    private string _target;
    //任务id(第1位为章节编号后面4位为任务编号)
    private int _task_id;
    //任务名称
    private string _task_name;
    //NPC交任务对白接
    private int _task_talk_end;
    //NPC接任务对白接
    private int _task_talk_start;
    //任务类型（0对话1杀怪2采集8副本20打开UI7卡等级9主线徽章副本22收集任务）
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Camp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Camp { get{ return _camp; } set{ _camp=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"ChapterDesc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ChapterDesc { get{ return _chapter_desc; } set{ _chapter_desc=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"ChapterName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ChapterName { get{ return _chapter_name; } set{ _chapter_name=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Chapterprogr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Chapterprogr { get{ return _chapterprogr; } set{ _chapterprogr=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"ConditionsDescribe", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ConditionsDescribe { get{ return _conditions_describe; } set{ _conditions_describe=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Endpath", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Endpath { get{ return _endpath; } set{ _endpath=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Equip", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Equip { get{ return _equip; } set{ _equip=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"EquipStrengthening", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string EquipStrengthening { get{ return _equip_strengthening; } set{ _equip_strengthening=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Flyteleport", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Flyteleport { get{ return _flyteleport; } set{ _flyteleport=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"IsAuto", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int IsAuto { get{ return _isAuto; } set{ _isAuto=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"IsFly", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int IsFly { get{ return _isFly; } set{ _isFly=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"IsTransport", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int IsTransport { get{ return _isTransport; } set{ _isTransport=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"MedalJD", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string MedalJD { get{ return _medalJD; } set{ _medalJD=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"Monsterhide", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Monsterhide { get{ return _monsterhide; } set{ _monsterhide=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"OpenPanel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OpenPanel { get{ return _open_panel; } set{ _open_panel=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"OpenPanelParam", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OpenPanelParam { get{ return _open_panel_param; } set{ _open_panel_param=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"PathMap", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PathMap { get{ return _pathMap; } set{ _pathMap=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"PostTaskId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PostTaskId { get{ return _post_task_id; } set{ _post_task_id=value; } }
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"PromptIcon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PromptIcon { get{ return _prompt_icon; } set{ _prompt_icon=value; } }
    [global::ProtoBuf.ProtoMember(20, IsRequired = true, Name=@"Rewards", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Rewards { get{ return _rewards; } set{ _rewards=value; } }
    [global::ProtoBuf.ProtoMember(21, IsRequired = true, Name=@"ServercloneId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ServercloneId { get{ return _servercloneId; } set{ _servercloneId=value; } }
    [global::ProtoBuf.ProtoMember(22, IsRequired = true, Name=@"SetActBranch", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SetActBranch { get{ return _set_act_branch; } set{ _set_act_branch=value; } }
    [global::ProtoBuf.ProtoMember(23, IsRequired = true, Name=@"SetActSkill", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SetActSkill { get{ return _set_act_skill; } set{ _set_act_skill=value; } }
    [global::ProtoBuf.ProtoMember(24, IsRequired = true, Name=@"Share", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Share { get{ return _share; } set{ _share=value; } }
    [global::ProtoBuf.ProtoMember(25, IsRequired = true, Name=@"Show", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Show { get{ return _show; } set{ _show=value; } }
    [global::ProtoBuf.ProtoMember(26, IsRequired = true, Name=@"Taksdesc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Taksdesc { get{ return _taksdesc; } set{ _taksdesc=value; } }
    [global::ProtoBuf.ProtoMember(27, IsRequired = true, Name=@"TapeName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TapeName { get{ return _tape_name; } set{ _tape_name=value; } }
    [global::ProtoBuf.ProtoMember(28, IsRequired = true, Name=@"Target", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Target { get{ return _target; } set{ _target=value; } }
    [global::ProtoBuf.ProtoMember(29, IsRequired = true, Name=@"TaskId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TaskId { get{ return _task_id; } set{ _task_id=value; } }
    [global::ProtoBuf.ProtoMember(30, IsRequired = true, Name=@"TaskName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TaskName { get{ return _task_name; } set{ _task_name=value; } }
    [global::ProtoBuf.ProtoMember(31, IsRequired = true, Name=@"TaskTalkEnd", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TaskTalkEnd { get{ return _task_talk_end; } set{ _task_talk_end=value; } }
    [global::ProtoBuf.ProtoMember(32, IsRequired = true, Name=@"TaskTalkStart", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TaskTalkStart { get{ return _task_talk_start; } set{ _task_talk_start=value; } }
    [global::ProtoBuf.ProtoMember(33, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareTask Create( int in_camp, string in_chapter_desc, string in_chapter_name, string in_chapterprogr, string in_conditions_describe, string in_endpath, string in_equip, string in_equip_strengthening, int in_flyteleport, int in_isAuto, int in_isFly, int in_isTransport, string in_medalJD, int in_monsterhide, int in_open_panel, int in_open_panel_param, int in_pathMap, int in_post_task_id, int in_prompt_icon, string in_rewards, int in_servercloneId, string in_set_act_branch, string in_set_act_skill, int in_share, string in_show, string in_taksdesc, string in_tape_name, string in_target, int in_task_id, string in_task_name, int in_task_talk_end, int in_task_talk_start, int in_type )
    {
      DeclareTask tmp = new DeclareTask();
      tmp._camp = in_camp;
      tmp._chapter_desc = in_chapter_desc;
      tmp._chapter_name = in_chapter_name;
      tmp._chapterprogr = in_chapterprogr;
      tmp._conditions_describe = in_conditions_describe;
      tmp._endpath = in_endpath;
      tmp._equip = in_equip;
      tmp._equip_strengthening = in_equip_strengthening;
      tmp._flyteleport = in_flyteleport;
      tmp._isAuto = in_isAuto;
      tmp._isFly = in_isFly;
      tmp._isTransport = in_isTransport;
      tmp._medalJD = in_medalJD;
      tmp._monsterhide = in_monsterhide;
      tmp._open_panel = in_open_panel;
      tmp._open_panel_param = in_open_panel_param;
      tmp._pathMap = in_pathMap;
      tmp._post_task_id = in_post_task_id;
      tmp._prompt_icon = in_prompt_icon;
      tmp._rewards = in_rewards;
      tmp._servercloneId = in_servercloneId;
      tmp._set_act_branch = in_set_act_branch;
      tmp._set_act_skill = in_set_act_skill;
      tmp._share = in_share;
      tmp._show = in_show;
      tmp._taksdesc = in_taksdesc;
      tmp._tape_name = in_tape_name;
      tmp._target = in_target;
      tmp._task_id = in_task_id;
      tmp._task_name = in_task_name;
      tmp._task_talk_end = in_task_talk_end;
      tmp._task_talk_start = in_task_talk_start;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareTask> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareTask> _dataCaches = null;
    public static Dictionary<int, DeclareTask> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTask");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataTask = require 'Lua/Config/DataTask'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTask");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareTask>(283);
                     foreach (var item in dic)
                     {
                         DeclareTask tmp = new DeclareTask();
                       tmp.Camp = item.Value[0];
                       tmp.ChapterDesc = CfgStringLua.Get(item.Value[1]);
                       tmp.ChapterName = CfgStringLua.Get(item.Value[2]);
                       tmp.Chapterprogr = CfgStringLua.Get(item.Value[3]);
                       tmp.ConditionsDescribe = CfgStringLua.Get(item.Value[4]);
                       tmp.Endpath = CfgStringLua.Get(item.Value[5]);
                       tmp.Equip = CfgStringLua.Get(item.Value[6]);
                       tmp.EquipStrengthening = CfgStringLua.Get(item.Value[7]);
                       tmp.Flyteleport = item.Value[8];
                       tmp.IsAuto = item.Value[9];
                       tmp.IsFly = item.Value[10];
                       tmp.IsTransport = item.Value[11];
                       tmp.MedalJD = CfgStringLua.Get(item.Value[12]);
                       tmp.Monsterhide = item.Value[13];
                       tmp.OpenPanel = item.Value[14];
                       tmp.OpenPanelParam = item.Value[15];
                       tmp.PathMap = item.Value[16];
                       tmp.PostTaskId = item.Value[17];
                       tmp.PromptIcon = item.Value[18];
                       tmp.Rewards = CfgStringLua.Get(item.Value[19]);
                       tmp.ServercloneId = item.Value[20];
                       tmp.SetActBranch = CfgStringLua.Get(item.Value[21]);
                       tmp.SetActSkill = CfgStringLua.Get(item.Value[22]);
                       tmp.Share = item.Value[23];
                       tmp.Show = CfgStringLua.Get(item.Value[24]);
                       tmp.Taksdesc = CfgStringLua.Get(item.Value[25]);
                       tmp.TapeName = CfgStringLua.Get(item.Value[26]);
                       tmp.Target = CfgStringLua.Get(item.Value[27]);
                       tmp.TaskId = item.Value[28];
                       tmp.TaskName = CfgStringLua.Get(item.Value[29]);
                       tmp.TaskTalkEnd = item.Value[30];
                       tmp.TaskTalkStart = item.Value[31];
                       tmp.Type = item.Value[32];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Task");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareTask>(283);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Task");
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
    public static DeclareTask Get(int id)
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
    public static void Transform(Dictionary<int, DeclareTask> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
