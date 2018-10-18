//文件是自动生成,请勿手动修改.来自数据文件:active_behavior
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareActiveBehavior")]
  public class DeclareActiveBehavior
  {
    #region //私有变量定义
    //进度完成所加活跃值
    private int _activeValue;
    //是否在列表中显示(0否1是)
    private int _canshow;
    //副本group_id
    private int _cloneID;
    //加活跃值需要完成的条件(@_@);
    private string _condition;
    //类型0普通1公会
    private int _conditions;
    //活动描述 hide
    private string _description;
    //寻队界面hide
    private string _foundTeam;
    //图标ID
    private int _icon;
    //活跃行为ID
    private int _id;
    //开启条件说明 hide
    private string _level;
    //可获得活跃总值（hide）
    private int _maxValue;
    //活跃行为名字
    private string _name;
    //寻路NPC的ID(阵营ID_职业ID_NPCID;阵营ID_职业ID_NPCID)
    private string _npcID;
    //功能开启等级
    private int _openLevel;
    //活动开放时间（0表示每天开放，1-7表示周一到周日的某一天）(@;@)
    private string _openTime;
    //开放时间描述 hide
    private string _openTimeDes;
    //功能开启类型（0无;1打开功能界面;2前往与NPC对话）
    private int _openType;
    //开启界面
    private int _openUI;
    //产出说明 hide
    private string _production;
    //0.日刷新；1.周刷新
    private int _refresh;
    //奖励展示
    private string _reward;
    //显示排序hide
    private int _sort;
    //推荐星级
    private int _star;
    //任务开放ID(@_@)
    private string _task;
    //组队方式描述 hide
    private string _team;
    //开放时间
    private string _time;
    //所属分类
    private string _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ActiveValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ActiveValue { get{ return _activeValue; } set{ _activeValue=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Canshow", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Canshow { get{ return _canshow; } set{ _canshow=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"CloneID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CloneID { get{ return _cloneID; } set{ _cloneID=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Condition", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Condition { get{ return _condition; } set{ _condition=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Conditions", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Conditions { get{ return _conditions; } set{ _conditions=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Description { get{ return _description; } set{ _description=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"FoundTeam", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string FoundTeam { get{ return _foundTeam; } set{ _foundTeam=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"MaxValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MaxValue { get{ return _maxValue; } set{ _maxValue=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"NpcID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string NpcID { get{ return _npcID; } set{ _npcID=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"OpenLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OpenLevel { get{ return _openLevel; } set{ _openLevel=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"OpenTime", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OpenTime { get{ return _openTime; } set{ _openTime=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"OpenTimeDes", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OpenTimeDes { get{ return _openTimeDes; } set{ _openTimeDes=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"OpenType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OpenType { get{ return _openType; } set{ _openType=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"OpenUI", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OpenUI { get{ return _openUI; } set{ _openUI=value; } }
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"Production", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Production { get{ return _production; } set{ _production=value; } }
    [global::ProtoBuf.ProtoMember(20, IsRequired = true, Name=@"Refresh", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Refresh { get{ return _refresh; } set{ _refresh=value; } }
    [global::ProtoBuf.ProtoMember(21, IsRequired = true, Name=@"Reward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Reward { get{ return _reward; } set{ _reward=value; } }
    [global::ProtoBuf.ProtoMember(22, IsRequired = true, Name=@"Sort", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Sort { get{ return _sort; } set{ _sort=value; } }
    [global::ProtoBuf.ProtoMember(23, IsRequired = true, Name=@"Star", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Star { get{ return _star; } set{ _star=value; } }
    [global::ProtoBuf.ProtoMember(24, IsRequired = true, Name=@"Task", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Task { get{ return _task; } set{ _task=value; } }
    [global::ProtoBuf.ProtoMember(25, IsRequired = true, Name=@"Team", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Team { get{ return _team; } set{ _team=value; } }
    [global::ProtoBuf.ProtoMember(26, IsRequired = true, Name=@"Time", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Time { get{ return _time; } set{ _time=value; } }
    [global::ProtoBuf.ProtoMember(27, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareActiveBehavior Create( int in_activeValue, int in_canshow, int in_cloneID, string in_condition, int in_conditions, string in_description, string in_foundTeam, int in_icon, int in_id, string in_level, int in_maxValue, string in_name, string in_npcID, int in_openLevel, string in_openTime, string in_openTimeDes, int in_openType, int in_openUI, string in_production, int in_refresh, string in_reward, int in_sort, int in_star, string in_task, string in_team, string in_time, string in_type )
    {
      DeclareActiveBehavior tmp = new DeclareActiveBehavior();
      tmp._activeValue = in_activeValue;
      tmp._canshow = in_canshow;
      tmp._cloneID = in_cloneID;
      tmp._condition = in_condition;
      tmp._conditions = in_conditions;
      tmp._description = in_description;
      tmp._foundTeam = in_foundTeam;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._level = in_level;
      tmp._maxValue = in_maxValue;
      tmp._name = in_name;
      tmp._npcID = in_npcID;
      tmp._openLevel = in_openLevel;
      tmp._openTime = in_openTime;
      tmp._openTimeDes = in_openTimeDes;
      tmp._openType = in_openType;
      tmp._openUI = in_openUI;
      tmp._production = in_production;
      tmp._refresh = in_refresh;
      tmp._reward = in_reward;
      tmp._sort = in_sort;
      tmp._star = in_star;
      tmp._task = in_task;
      tmp._team = in_team;
      tmp._time = in_time;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareActiveBehavior> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareActiveBehavior> _dataCaches = null;
    public static Dictionary<int, DeclareActiveBehavior> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataActiveBehavior");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataActiveBehavior = require 'Lua/Config/DataActiveBehavior'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataActiveBehavior");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareActiveBehavior>(31);
                     foreach (var item in dic)
                     {
                         DeclareActiveBehavior tmp = new DeclareActiveBehavior();
                       tmp.ActiveValue = item.Value[0];
                       tmp.Canshow = item.Value[1];
                       tmp.CloneID = item.Value[2];
                       tmp.Condition = CfgStringLua.Get(item.Value[3]);
                       tmp.Conditions = item.Value[4];
                       tmp.Description = CfgStringLua.Get(item.Value[5]);
                       tmp.FoundTeam = CfgStringLua.Get(item.Value[6]);
                       tmp.Icon = item.Value[7];
                       tmp.Id = item.Value[8];
                       tmp.Level = CfgStringLua.Get(item.Value[9]);
                       tmp.MaxValue = item.Value[10];
                       tmp.Name = CfgStringLua.Get(item.Value[11]);
                       tmp.NpcID = CfgStringLua.Get(item.Value[12]);
                       tmp.OpenLevel = item.Value[13];
                       tmp.OpenTime = CfgStringLua.Get(item.Value[14]);
                       tmp.OpenTimeDes = CfgStringLua.Get(item.Value[15]);
                       tmp.OpenType = item.Value[16];
                       tmp.OpenUI = item.Value[17];
                       tmp.Production = CfgStringLua.Get(item.Value[18]);
                       tmp.Refresh = item.Value[19];
                       tmp.Reward = CfgStringLua.Get(item.Value[20]);
                       tmp.Sort = item.Value[21];
                       tmp.Star = item.Value[22];
                       tmp.Task = CfgStringLua.Get(item.Value[23]);
                       tmp.Team = CfgStringLua.Get(item.Value[24]);
                       tmp.Time = CfgStringLua.Get(item.Value[25]);
                       tmp.Type = CfgStringLua.Get(item.Value[26]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"ActiveBehavior");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareActiveBehavior>(31);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"ActiveBehavior");
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
    public static DeclareActiveBehavior Get(int id)
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
    public static void Transform(Dictionary<int, DeclareActiveBehavior> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
