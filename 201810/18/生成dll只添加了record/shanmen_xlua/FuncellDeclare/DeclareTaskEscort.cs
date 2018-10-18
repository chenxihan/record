//文件是自动生成,请勿手动修改.来自数据文件:task_escort
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareTaskEscort")]
  public class DeclareTaskEscort
  {
    #region //私有变量定义
    //任务奖励(奖励1;奖励2;奖励N) 奖励模型_数量[@;@_@]
    private string _additionalRewards;
    //领取阵营（0为所有阵营）
    private int _camp;
    //任务目标描述
    private string _conditions_describe;
    //领取任务花费（不填表示免费）(@_@)
    private string _cost;
    //道具不足花费钻石（优先火钻）
    private int _costDiamond;
    //提交路径(地图id;ncpID)(@_@)
    private string _endpath;
    //接到任务最大等级
    private int _maxLevel;
    //接到任务最小等级
    private int _minLevel;
    //护送模型ID
    private int _model;
    //任务寻径地图ID
    private int _pathMap;
    //任务品质（绿、蓝、紫、橙）
    private int _quality;
    //任务奖励(奖励1;奖励2;奖励N) 奖励模型_数量[@;@_@]
    private string _rewards;
    //任务目标(NPC_数量)(@_@)
    private string _target;
    //目标类型
    private int _targetType;
    //任务id
    private int _task_id;
    //任务名称
    private string _task_name;
    //界面展示图（hide）
    private string _texture;
    //任务类型
    private string _typeName;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"AdditionalRewards", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string AdditionalRewards { get{ return _additionalRewards; } set{ _additionalRewards=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Camp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Camp { get{ return _camp; } set{ _camp=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"ConditionsDescribe", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ConditionsDescribe { get{ return _conditions_describe; } set{ _conditions_describe=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Cost", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Cost { get{ return _cost; } set{ _cost=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"CostDiamond", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CostDiamond { get{ return _costDiamond; } set{ _costDiamond=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Endpath", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Endpath { get{ return _endpath; } set{ _endpath=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"MaxLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MaxLevel { get{ return _maxLevel; } set{ _maxLevel=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"MinLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MinLevel { get{ return _minLevel; } set{ _minLevel=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Model", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Model { get{ return _model; } set{ _model=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"PathMap", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PathMap { get{ return _pathMap; } set{ _pathMap=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Quality", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Quality { get{ return _quality; } set{ _quality=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"Rewards", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Rewards { get{ return _rewards; } set{ _rewards=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"Target", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Target { get{ return _target; } set{ _target=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"TargetType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TargetType { get{ return _targetType; } set{ _targetType=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"TaskId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TaskId { get{ return _task_id; } set{ _task_id=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"TaskName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TaskName { get{ return _task_name; } set{ _task_name=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"Texture", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Texture { get{ return _texture; } set{ _texture=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"TypeName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TypeName { get{ return _typeName; } set{ _typeName=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareTaskEscort Create( string in_additionalRewards, int in_camp, string in_conditions_describe, string in_cost, int in_costDiamond, string in_endpath, int in_maxLevel, int in_minLevel, int in_model, int in_pathMap, int in_quality, string in_rewards, string in_target, int in_targetType, int in_task_id, string in_task_name, string in_texture, string in_typeName )
    {
      DeclareTaskEscort tmp = new DeclareTaskEscort();
      tmp._additionalRewards = in_additionalRewards;
      tmp._camp = in_camp;
      tmp._conditions_describe = in_conditions_describe;
      tmp._cost = in_cost;
      tmp._costDiamond = in_costDiamond;
      tmp._endpath = in_endpath;
      tmp._maxLevel = in_maxLevel;
      tmp._minLevel = in_minLevel;
      tmp._model = in_model;
      tmp._pathMap = in_pathMap;
      tmp._quality = in_quality;
      tmp._rewards = in_rewards;
      tmp._target = in_target;
      tmp._targetType = in_targetType;
      tmp._task_id = in_task_id;
      tmp._task_name = in_task_name;
      tmp._texture = in_texture;
      tmp._typeName = in_typeName;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareTaskEscort> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareTaskEscort> _dataCaches = null;
    public static Dictionary<int, DeclareTaskEscort> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTaskEscort");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataTaskEscort = require 'Lua/Config/DataTaskEscort'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTaskEscort");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareTaskEscort>(60);
                     foreach (var item in dic)
                     {
                         DeclareTaskEscort tmp = new DeclareTaskEscort();
                       tmp.AdditionalRewards = CfgStringLua.Get(item.Value[0]);
                       tmp.Camp = item.Value[1];
                       tmp.ConditionsDescribe = CfgStringLua.Get(item.Value[2]);
                       tmp.Cost = CfgStringLua.Get(item.Value[3]);
                       tmp.CostDiamond = item.Value[4];
                       tmp.Endpath = CfgStringLua.Get(item.Value[5]);
                       tmp.MaxLevel = item.Value[6];
                       tmp.MinLevel = item.Value[7];
                       tmp.Model = item.Value[8];
                       tmp.PathMap = item.Value[9];
                       tmp.Quality = item.Value[10];
                       tmp.Rewards = CfgStringLua.Get(item.Value[11]);
                       tmp.Target = CfgStringLua.Get(item.Value[12]);
                       tmp.TargetType = item.Value[13];
                       tmp.TaskId = item.Value[14];
                       tmp.TaskName = CfgStringLua.Get(item.Value[15]);
                       tmp.Texture = CfgStringLua.Get(item.Value[16]);
                       tmp.TypeName = CfgStringLua.Get(item.Value[17]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"TaskEscort");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareTaskEscort>(60);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"TaskEscort");
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
    public static DeclareTaskEscort Get(int id)
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
    public static void Transform(Dictionary<int, DeclareTaskEscort> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
