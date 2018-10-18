//文件是自动生成,请勿手动修改.来自数据文件:wing_up
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareWingUp")]
  public class DeclareWingUp
  {
    #region //私有变量定义
    //本级属性(@;@_@)
    private string _attr;
    //祝福值上限值
    private int _blessnum_limit;
    //每次失败增加祝福值区间max
    private int _blessnum_max;
    //每次失败增加祝福值区间min
    private int _blessnum_min;
    //幻化需要的条件(@_@)
    private string _condition;
    //幻化条件的描述 hide
    private string _condition_info;
    //翅膀幻化等级
    private int _id;
    //幻化成功是否全服公告（0不公告，1公告）
    private int _notice;
    //幻化消耗物品及数量(格式：物品ID，数量：多个物品以；隔开）(@;@_@)
    private string _up_item_info;
    //幻化成功所需幻化次数max
    private int _up_num_max;
    //幻化成功所需幻化次数min
    private int _up_num_min;
    //服务器端计算用幻化成功几率（万分比）
    private int _up_probability;
    //幻化操作所需人物等级
    private int _up_role_level;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Attr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Attr { get{ return _attr; } set{ _attr=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"BlessnumLimit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BlessnumLimit { get{ return _blessnum_limit; } set{ _blessnum_limit=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"BlessnumMax", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BlessnumMax { get{ return _blessnum_max; } set{ _blessnum_max=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"BlessnumMin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BlessnumMin { get{ return _blessnum_min; } set{ _blessnum_min=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Condition", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Condition { get{ return _condition; } set{ _condition=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"ConditionInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ConditionInfo { get{ return _condition_info; } set{ _condition_info=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Notice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Notice { get{ return _notice; } set{ _notice=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"UpItemInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string UpItemInfo { get{ return _up_item_info; } set{ _up_item_info=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"UpNumMax", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UpNumMax { get{ return _up_num_max; } set{ _up_num_max=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"UpNumMin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UpNumMin { get{ return _up_num_min; } set{ _up_num_min=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"UpProbability", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UpProbability { get{ return _up_probability; } set{ _up_probability=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"UpRoleLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UpRoleLevel { get{ return _up_role_level; } set{ _up_role_level=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareWingUp Create( string in_attr, int in_blessnum_limit, int in_blessnum_max, int in_blessnum_min, string in_condition, string in_condition_info, int in_id, int in_notice, string in_up_item_info, int in_up_num_max, int in_up_num_min, int in_up_probability, int in_up_role_level )
    {
      DeclareWingUp tmp = new DeclareWingUp();
      tmp._attr = in_attr;
      tmp._blessnum_limit = in_blessnum_limit;
      tmp._blessnum_max = in_blessnum_max;
      tmp._blessnum_min = in_blessnum_min;
      tmp._condition = in_condition;
      tmp._condition_info = in_condition_info;
      tmp._id = in_id;
      tmp._notice = in_notice;
      tmp._up_item_info = in_up_item_info;
      tmp._up_num_max = in_up_num_max;
      tmp._up_num_min = in_up_num_min;
      tmp._up_probability = in_up_probability;
      tmp._up_role_level = in_up_role_level;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareWingUp> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareWingUp> _dataCaches = null;
    public static Dictionary<int, DeclareWingUp> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataWingUp");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataWingUp = require 'Lua/Config/DataWingUp'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataWingUp");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareWingUp>(10);
                     foreach (var item in dic)
                     {
                         DeclareWingUp tmp = new DeclareWingUp();
                       tmp.Attr = CfgStringLua.Get(item.Value[0]);
                       tmp.BlessnumLimit = item.Value[1];
                       tmp.BlessnumMax = item.Value[2];
                       tmp.BlessnumMin = item.Value[3];
                       tmp.Condition = CfgStringLua.Get(item.Value[4]);
                       tmp.ConditionInfo = CfgStringLua.Get(item.Value[5]);
                       tmp.Id = item.Value[6];
                       tmp.Notice = item.Value[7];
                       tmp.UpItemInfo = CfgStringLua.Get(item.Value[8]);
                       tmp.UpNumMax = item.Value[9];
                       tmp.UpNumMin = item.Value[10];
                       tmp.UpProbability = item.Value[11];
                       tmp.UpRoleLevel = item.Value[12];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"WingUp");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareWingUp>(10);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"WingUp");
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
    public static DeclareWingUp Get(int id)
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
    public static void Transform(Dictionary<int, DeclareWingUp> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
