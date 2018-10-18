//文件是自动生成,请勿手动修改.来自数据文件:task_gender
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareTaskGender")]
  public class DeclareTaskGender
  {
    #region //私有变量定义
    //领取阵营（0为所有阵营）
    private int _camp;
    //是否可以跳过（0否1是）
    private int _canSkip;
    //章节描述hide
    private string _chapter_desc;
    //章节名称hide
    private string _chapter_name;
    //章节进度hide
    private string _chapterprogr;
    //任务目标描述
    private string _conditions_describe;
    //领取任务的NPC
    private int _conditions_npc;
    //提交路径(地图id;ncpID)(@_@)
    private string _endpath;
    //职业限制
    //0-执笔者；1-拳师；2-大锤；3-太刀；4-卡牌；5-抢手；9-通用
    private int _gender;
    //领取任务所需转职阶数
    private int _genderClass;
    //任务目标(任务模型/NPC_数量)(@_@)
    private string _goal_npc;
    //任务ID
    private int _id;
    //任务开放等级
    private int _level;
    //打开界面ID(hide)
    private int _openUI;
    //任务寻径地图ID
    private int _pathMap;
    //完成后接取任务ID
    private int _post_task_id;
    //任务奖励(奖励_数量;奖励_数量）[@;@_@]
    private string _rewards;
    //任务顺序
    private int _sequence;
    //是否提示跳过（0否1是）
    private int _skipPrompt;
    //主面板任务描述hide
    private string _taksdesc;
    //任务标题名称hide
    private string _tape_name;
    //任务名称
    private string _task_name;
    //NPC交任务对白接
    private int _task_talk_end;
    //NPC接任务对白接
    private int _task_talk_start;
    //任务类型
    //0.对话；1.杀怪；2.收集；3.等级达到X；4.使用道具；5.采集；6.变量任务；7.卡等级；8.副本；20.打开UI；23.掉落道具；
    private int _task_type;
    //是否为真掉落（0否1是）
    private int _trueDrop;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Camp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Camp { get{ return _camp; } set{ _camp=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"CanSkip", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanSkip { get{ return _canSkip; } set{ _canSkip=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"ChapterDesc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ChapterDesc { get{ return _chapter_desc; } set{ _chapter_desc=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"ChapterName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ChapterName { get{ return _chapter_name; } set{ _chapter_name=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Chapterprogr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Chapterprogr { get{ return _chapterprogr; } set{ _chapterprogr=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"ConditionsDescribe", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ConditionsDescribe { get{ return _conditions_describe; } set{ _conditions_describe=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"ConditionsNpc", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ConditionsNpc { get{ return _conditions_npc; } set{ _conditions_npc=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Endpath", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Endpath { get{ return _endpath; } set{ _endpath=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Gender", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Gender { get{ return _gender; } set{ _gender=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"GenderClass", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int GenderClass { get{ return _genderClass; } set{ _genderClass=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"GoalNpc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string GoalNpc { get{ return _goal_npc; } set{ _goal_npc=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"OpenUI", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OpenUI { get{ return _openUI; } set{ _openUI=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"PathMap", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PathMap { get{ return _pathMap; } set{ _pathMap=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"PostTaskId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PostTaskId { get{ return _post_task_id; } set{ _post_task_id=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"Rewards", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Rewards { get{ return _rewards; } set{ _rewards=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"Sequence", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Sequence { get{ return _sequence; } set{ _sequence=value; } }
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"SkipPrompt", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SkipPrompt { get{ return _skipPrompt; } set{ _skipPrompt=value; } }
    [global::ProtoBuf.ProtoMember(20, IsRequired = true, Name=@"Taksdesc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Taksdesc { get{ return _taksdesc; } set{ _taksdesc=value; } }
    [global::ProtoBuf.ProtoMember(21, IsRequired = true, Name=@"TapeName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TapeName { get{ return _tape_name; } set{ _tape_name=value; } }
    [global::ProtoBuf.ProtoMember(22, IsRequired = true, Name=@"TaskName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TaskName { get{ return _task_name; } set{ _task_name=value; } }
    [global::ProtoBuf.ProtoMember(23, IsRequired = true, Name=@"TaskTalkEnd", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TaskTalkEnd { get{ return _task_talk_end; } set{ _task_talk_end=value; } }
    [global::ProtoBuf.ProtoMember(24, IsRequired = true, Name=@"TaskTalkStart", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TaskTalkStart { get{ return _task_talk_start; } set{ _task_talk_start=value; } }
    [global::ProtoBuf.ProtoMember(25, IsRequired = true, Name=@"TaskType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TaskType { get{ return _task_type; } set{ _task_type=value; } }
    [global::ProtoBuf.ProtoMember(26, IsRequired = true, Name=@"TrueDrop", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TrueDrop { get{ return _trueDrop; } set{ _trueDrop=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareTaskGender Create( int in_camp, int in_canSkip, string in_chapter_desc, string in_chapter_name, string in_chapterprogr, string in_conditions_describe, int in_conditions_npc, string in_endpath, int in_gender, int in_genderClass, string in_goal_npc, int in_id, int in_level, int in_openUI, int in_pathMap, int in_post_task_id, string in_rewards, int in_sequence, int in_skipPrompt, string in_taksdesc, string in_tape_name, string in_task_name, int in_task_talk_end, int in_task_talk_start, int in_task_type, int in_trueDrop )
    {
      DeclareTaskGender tmp = new DeclareTaskGender();
      tmp._camp = in_camp;
      tmp._canSkip = in_canSkip;
      tmp._chapter_desc = in_chapter_desc;
      tmp._chapter_name = in_chapter_name;
      tmp._chapterprogr = in_chapterprogr;
      tmp._conditions_describe = in_conditions_describe;
      tmp._conditions_npc = in_conditions_npc;
      tmp._endpath = in_endpath;
      tmp._gender = in_gender;
      tmp._genderClass = in_genderClass;
      tmp._goal_npc = in_goal_npc;
      tmp._id = in_id;
      tmp._level = in_level;
      tmp._openUI = in_openUI;
      tmp._pathMap = in_pathMap;
      tmp._post_task_id = in_post_task_id;
      tmp._rewards = in_rewards;
      tmp._sequence = in_sequence;
      tmp._skipPrompt = in_skipPrompt;
      tmp._taksdesc = in_taksdesc;
      tmp._tape_name = in_tape_name;
      tmp._task_name = in_task_name;
      tmp._task_talk_end = in_task_talk_end;
      tmp._task_talk_start = in_task_talk_start;
      tmp._task_type = in_task_type;
      tmp._trueDrop = in_trueDrop;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareTaskGender> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareTaskGender> _dataCaches = null;
    public static Dictionary<int, DeclareTaskGender> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTaskGender");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataTaskGender = require 'Lua/Config/DataTaskGender'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTaskGender");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareTaskGender>(347);
                     foreach (var item in dic)
                     {
                         DeclareTaskGender tmp = new DeclareTaskGender();
                       tmp.Camp = item.Value[0];
                       tmp.CanSkip = item.Value[1];
                       tmp.ChapterDesc = CfgStringLua.Get(item.Value[2]);
                       tmp.ChapterName = CfgStringLua.Get(item.Value[3]);
                       tmp.Chapterprogr = CfgStringLua.Get(item.Value[4]);
                       tmp.ConditionsDescribe = CfgStringLua.Get(item.Value[5]);
                       tmp.ConditionsNpc = item.Value[6];
                       tmp.Endpath = CfgStringLua.Get(item.Value[7]);
                       tmp.Gender = item.Value[8];
                       tmp.GenderClass = item.Value[9];
                       tmp.GoalNpc = CfgStringLua.Get(item.Value[10]);
                       tmp.Id = item.Value[11];
                       tmp.Level = item.Value[12];
                       tmp.OpenUI = item.Value[13];
                       tmp.PathMap = item.Value[14];
                       tmp.PostTaskId = item.Value[15];
                       tmp.Rewards = CfgStringLua.Get(item.Value[16]);
                       tmp.Sequence = item.Value[17];
                       tmp.SkipPrompt = item.Value[18];
                       tmp.Taksdesc = CfgStringLua.Get(item.Value[19]);
                       tmp.TapeName = CfgStringLua.Get(item.Value[20]);
                       tmp.TaskName = CfgStringLua.Get(item.Value[21]);
                       tmp.TaskTalkEnd = item.Value[22];
                       tmp.TaskTalkStart = item.Value[23];
                       tmp.TaskType = item.Value[24];
                       tmp.TrueDrop = item.Value[25];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"TaskGender");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareTaskGender>(347);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"TaskGender");
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
    public static DeclareTaskGender Get(int id)
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
    public static void Transform(Dictionary<int, DeclareTaskGender> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
