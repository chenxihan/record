//文件是自动生成,请勿手动修改.来自数据文件:Equip_fuse
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareEquipFuse")]
  public class DeclareEquipFuse
  {
    #region //私有变量定义
    //放入一键普通增加概率(万分比)
    private int _basic_probability;
    //放入一键极品增加概率(万分比)
    private int _best_probability;
    //每次熔炼消耗(@;@_@)
    private string _consume;
    //培养增加概率(万分比)
    private int _culture_probability;
    //产出装备(@;@)
    private string _equip;
    //一键放入装备等级
    private int _equip_level;
    //失败产出极品装备(@;@)
    private string _fail_best;
    //失败产出普通装备(@;@)
    private string _fail_ordinary;
    //编号
    private int _id;
    //玩家等级(等级段)
    private int _level;
    //需求公会军械库等级
    private int _ordnance_level;
    //产出完美装备(@;@)
    private string _perfect_Equip;
    //放入5件极品装备后，产出完美品质装备概率（万分比）
    private int _perfect_probability;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"BasicProbability", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BasicProbability { get{ return _basic_probability; } set{ _basic_probability=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"BestProbability", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BestProbability { get{ return _best_probability; } set{ _best_probability=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Consume", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Consume { get{ return _consume; } set{ _consume=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"CultureProbability", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CultureProbability { get{ return _culture_probability; } set{ _culture_probability=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Equip", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Equip { get{ return _equip; } set{ _equip=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"EquipLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int EquipLevel { get{ return _equip_level; } set{ _equip_level=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"FailBest", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string FailBest { get{ return _fail_best; } set{ _fail_best=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"FailOrdinary", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string FailOrdinary { get{ return _fail_ordinary; } set{ _fail_ordinary=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"OrdnanceLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OrdnanceLevel { get{ return _ordnance_level; } set{ _ordnance_level=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"PerfectEquip", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string PerfectEquip { get{ return _perfect_Equip; } set{ _perfect_Equip=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"PerfectProbability", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PerfectProbability { get{ return _perfect_probability; } set{ _perfect_probability=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareEquipFuse Create( int in_basic_probability, int in_best_probability, string in_consume, int in_culture_probability, string in_equip, int in_equip_level, string in_fail_best, string in_fail_ordinary, int in_id, int in_level, int in_ordnance_level, string in_perfect_Equip, int in_perfect_probability )
    {
      DeclareEquipFuse tmp = new DeclareEquipFuse();
      tmp._basic_probability = in_basic_probability;
      tmp._best_probability = in_best_probability;
      tmp._consume = in_consume;
      tmp._culture_probability = in_culture_probability;
      tmp._equip = in_equip;
      tmp._equip_level = in_equip_level;
      tmp._fail_best = in_fail_best;
      tmp._fail_ordinary = in_fail_ordinary;
      tmp._id = in_id;
      tmp._level = in_level;
      tmp._ordnance_level = in_ordnance_level;
      tmp._perfect_Equip = in_perfect_Equip;
      tmp._perfect_probability = in_perfect_probability;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareEquipFuse> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareEquipFuse> _dataCaches = null;
    public static Dictionary<int, DeclareEquipFuse> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataEquipFuse");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataEquipFuse = require 'Lua/Config/DataEquipFuse'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataEquipFuse");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareEquipFuse>(4);
                     foreach (var item in dic)
                     {
                         DeclareEquipFuse tmp = new DeclareEquipFuse();
                       tmp.BasicProbability = item.Value[0];
                       tmp.BestProbability = item.Value[1];
                       tmp.Consume = CfgStringLua.Get(item.Value[2]);
                       tmp.CultureProbability = item.Value[3];
                       tmp.Equip = CfgStringLua.Get(item.Value[4]);
                       tmp.EquipLevel = item.Value[5];
                       tmp.FailBest = CfgStringLua.Get(item.Value[6]);
                       tmp.FailOrdinary = CfgStringLua.Get(item.Value[7]);
                       tmp.Id = item.Value[8];
                       tmp.Level = item.Value[9];
                       tmp.OrdnanceLevel = item.Value[10];
                       tmp.PerfectEquip = CfgStringLua.Get(item.Value[11]);
                       tmp.PerfectProbability = item.Value[12];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"EquipFuse");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareEquipFuse>(4);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"EquipFuse");
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
    public static DeclareEquipFuse Get(int id)
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
    public static void Transform(Dictionary<int, DeclareEquipFuse> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
