//文件是自动生成,请勿手动修改.来自数据文件:task_guide
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareTaskGuide")]
  public class DeclareTaskGuide
  {
    #region //私有变量定义
    //任务编号
    private int _branchId;
    //阵营
    private int _changejob;
    //领取任务的NPC地图
    private int _conditions_map;
    //领取任务的NPC
    private int _conditions_npc;
    //领取条件（1为等级，2为任务)
    private int _gain_conditions;
    //任务目标(任务模型/NPC_数量)(@_@)
    private string _goal_npc;
    //等级max
    private int _level_max;
    //等级min
    private int _level_min;
    //任务名称
    private string _name;
    //完成任务的NPC地图
    private int _over_map;
    //提交任务NPC
    private int _over_npc;
    //职业
    private int _professional;
    //完成任务是否为雕像
    private int _statue_ID;
    //完成任务对话
    private int _task_talk_over;
    //领取任务对话
    private int _task_talk_start;
    //任务类型（0 对话 1 杀怪 2 收集 3 等级达到X 4 使用道具 5 采集）
    private int _task_type;
    //任务类型
    private int _type;
    //任务类型名称
    private string _type_name;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"BranchId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BranchId { get{ return _branchId; } set{ _branchId=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Changejob", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Changejob { get{ return _changejob; } set{ _changejob=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"ConditionsMap", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ConditionsMap { get{ return _conditions_map; } set{ _conditions_map=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"ConditionsNpc", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ConditionsNpc { get{ return _conditions_npc; } set{ _conditions_npc=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"GainConditions", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int GainConditions { get{ return _gain_conditions; } set{ _gain_conditions=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"GoalNpc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string GoalNpc { get{ return _goal_npc; } set{ _goal_npc=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"LevelMax", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int LevelMax { get{ return _level_max; } set{ _level_max=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"LevelMin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int LevelMin { get{ return _level_min; } set{ _level_min=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"OverMap", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OverMap { get{ return _over_map; } set{ _over_map=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"OverNpc", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OverNpc { get{ return _over_npc; } set{ _over_npc=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"Professional", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Professional { get{ return _professional; } set{ _professional=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"StatueID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int StatueID { get{ return _statue_ID; } set{ _statue_ID=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"TaskTalkOver", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TaskTalkOver { get{ return _task_talk_over; } set{ _task_talk_over=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"TaskTalkStart", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TaskTalkStart { get{ return _task_talk_start; } set{ _task_talk_start=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"TaskType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TaskType { get{ return _task_type; } set{ _task_type=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"TypeName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TypeName { get{ return _type_name; } set{ _type_name=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareTaskGuide Create( int in_branchId, int in_changejob, int in_conditions_map, int in_conditions_npc, int in_gain_conditions, string in_goal_npc, int in_level_max, int in_level_min, string in_name, int in_over_map, int in_over_npc, int in_professional, int in_statue_ID, int in_task_talk_over, int in_task_talk_start, int in_task_type, int in_type, string in_type_name )
    {
      DeclareTaskGuide tmp = new DeclareTaskGuide();
      tmp._branchId = in_branchId;
      tmp._changejob = in_changejob;
      tmp._conditions_map = in_conditions_map;
      tmp._conditions_npc = in_conditions_npc;
      tmp._gain_conditions = in_gain_conditions;
      tmp._goal_npc = in_goal_npc;
      tmp._level_max = in_level_max;
      tmp._level_min = in_level_min;
      tmp._name = in_name;
      tmp._over_map = in_over_map;
      tmp._over_npc = in_over_npc;
      tmp._professional = in_professional;
      tmp._statue_ID = in_statue_ID;
      tmp._task_talk_over = in_task_talk_over;
      tmp._task_talk_start = in_task_talk_start;
      tmp._task_type = in_task_type;
      tmp._type = in_type;
      tmp._type_name = in_type_name;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareTaskGuide> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareTaskGuide> _dataCaches = null;
    public static Dictionary<int, DeclareTaskGuide> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTaskGuide");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataTaskGuide = require 'Lua/Config/DataTaskGuide'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTaskGuide");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareTaskGuide>(24);
                     foreach (var item in dic)
                     {
                         DeclareTaskGuide tmp = new DeclareTaskGuide();
                       tmp.BranchId = item.Value[0];
                       tmp.Changejob = item.Value[1];
                       tmp.ConditionsMap = item.Value[2];
                       tmp.ConditionsNpc = item.Value[3];
                       tmp.GainConditions = item.Value[4];
                       tmp.GoalNpc = CfgStringLua.Get(item.Value[5]);
                       tmp.LevelMax = item.Value[6];
                       tmp.LevelMin = item.Value[7];
                       tmp.Name = CfgStringLua.Get(item.Value[8]);
                       tmp.OverMap = item.Value[9];
                       tmp.OverNpc = item.Value[10];
                       tmp.Professional = item.Value[11];
                       tmp.StatueID = item.Value[12];
                       tmp.TaskTalkOver = item.Value[13];
                       tmp.TaskTalkStart = item.Value[14];
                       tmp.TaskType = item.Value[15];
                       tmp.Type = item.Value[16];
                       tmp.TypeName = CfgStringLua.Get(item.Value[17]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"TaskGuide");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareTaskGuide>(24);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"TaskGuide");
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
    public static DeclareTaskGuide Get(int id)
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
    public static void Transform(Dictionary<int, DeclareTaskGuide> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
