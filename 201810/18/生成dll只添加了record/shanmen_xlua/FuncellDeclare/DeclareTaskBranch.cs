//文件是自动生成,请勿手动修改.来自数据文件:task_branch
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareTaskBranch")]
  public class DeclareTaskBranch
  {
    #region //私有变量定义
    //开启副本ID
    private int _back_group_id;
    //任务编号
    private int _branchId;
    //任务目标描述hide
    private string _conditions_describe;
    //任务条件6:开启功能面板
    private int _conditions_type;
    //领取条件值(@;@)
    private string _conditions_value;
    //任务需求具体值X_X具体参看支线任务文档(@;@_@)
    private string _demand_value;
    //领取条件（1为等级，2为任务,3为开服时间,等级)
    private int _gain_conditions;
    //使用道具的道具ID
    private int _itemID;
    //任务名称
    private string _name;
    //开启界面hide
    private int _open_panel;
    //任务奖励(物品_数量；物品_数量；)[@;@_@]
    private string _task_reward;
    //任务描述hide
    private string _tsak_describe;
    //任务类型名称
    private string _type_name;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"BackGroupId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BackGroupId { get{ return _back_group_id; } set{ _back_group_id=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"BranchId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BranchId { get{ return _branchId; } set{ _branchId=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"ConditionsDescribe", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ConditionsDescribe { get{ return _conditions_describe; } set{ _conditions_describe=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"ConditionsType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ConditionsType { get{ return _conditions_type; } set{ _conditions_type=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"ConditionsValue", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ConditionsValue { get{ return _conditions_value; } set{ _conditions_value=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"DemandValue", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DemandValue { get{ return _demand_value; } set{ _demand_value=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"GainConditions", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int GainConditions { get{ return _gain_conditions; } set{ _gain_conditions=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"ItemID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ItemID { get{ return _itemID; } set{ _itemID=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"OpenPanel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OpenPanel { get{ return _open_panel; } set{ _open_panel=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"TaskReward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TaskReward { get{ return _task_reward; } set{ _task_reward=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"TsakDescribe", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TsakDescribe { get{ return _tsak_describe; } set{ _tsak_describe=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"TypeName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TypeName { get{ return _type_name; } set{ _type_name=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareTaskBranch Create( int in_back_group_id, int in_branchId, string in_conditions_describe, int in_conditions_type, string in_conditions_value, string in_demand_value, int in_gain_conditions, int in_itemID, string in_name, int in_open_panel, string in_task_reward, string in_tsak_describe, string in_type_name )
    {
      DeclareTaskBranch tmp = new DeclareTaskBranch();
      tmp._back_group_id = in_back_group_id;
      tmp._branchId = in_branchId;
      tmp._conditions_describe = in_conditions_describe;
      tmp._conditions_type = in_conditions_type;
      tmp._conditions_value = in_conditions_value;
      tmp._demand_value = in_demand_value;
      tmp._gain_conditions = in_gain_conditions;
      tmp._itemID = in_itemID;
      tmp._name = in_name;
      tmp._open_panel = in_open_panel;
      tmp._task_reward = in_task_reward;
      tmp._tsak_describe = in_tsak_describe;
      tmp._type_name = in_type_name;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareTaskBranch> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareTaskBranch> _dataCaches = null;
    public static Dictionary<int, DeclareTaskBranch> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTaskBranch");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataTaskBranch = require 'Lua/Config/DataTaskBranch'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTaskBranch");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareTaskBranch>(34);
                     foreach (var item in dic)
                     {
                         DeclareTaskBranch tmp = new DeclareTaskBranch();
                       tmp.BackGroupId = item.Value[0];
                       tmp.BranchId = item.Value[1];
                       tmp.ConditionsDescribe = CfgStringLua.Get(item.Value[2]);
                       tmp.ConditionsType = item.Value[3];
                       tmp.ConditionsValue = CfgStringLua.Get(item.Value[4]);
                       tmp.DemandValue = CfgStringLua.Get(item.Value[5]);
                       tmp.GainConditions = item.Value[6];
                       tmp.ItemID = item.Value[7];
                       tmp.Name = CfgStringLua.Get(item.Value[8]);
                       tmp.OpenPanel = item.Value[9];
                       tmp.TaskReward = CfgStringLua.Get(item.Value[10]);
                       tmp.TsakDescribe = CfgStringLua.Get(item.Value[11]);
                       tmp.TypeName = CfgStringLua.Get(item.Value[12]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"TaskBranch");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareTaskBranch>(34);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"TaskBranch");
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
    public static DeclareTaskBranch Get(int id)
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
    public static void Transform(Dictionary<int, DeclareTaskBranch> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
