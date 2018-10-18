//文件是自动生成,请勿手动修改.来自数据文件:Equip_refi
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareEquipRefi")]
  public class DeclareEquipRefi
  {
    #region //私有变量定义
    //放入普通装备消耗(@;@_@)
    private string _basic_consume;
    //放入普通装备产出极品概率（万分比）
    private int _basic_probability;
    //放入极品装备消耗(@;@_@)
    private string _best_consume;
    //放入极品装备产出完美概率（万分比）
    private int _best_probability;
    //编号
    private int _id;
    //装备等级
    private int _level;
    //放入完美装备消耗(@;@_@)
    private string _perfect_consume;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"BasicConsume", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string BasicConsume { get{ return _basic_consume; } set{ _basic_consume=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"BasicProbability", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BasicProbability { get{ return _basic_probability; } set{ _basic_probability=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"BestConsume", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string BestConsume { get{ return _best_consume; } set{ _best_consume=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"BestProbability", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BestProbability { get{ return _best_probability; } set{ _best_probability=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"PerfectConsume", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string PerfectConsume { get{ return _perfect_consume; } set{ _perfect_consume=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareEquipRefi Create( string in_basic_consume, int in_basic_probability, string in_best_consume, int in_best_probability, int in_id, int in_level, string in_perfect_consume )
    {
      DeclareEquipRefi tmp = new DeclareEquipRefi();
      tmp._basic_consume = in_basic_consume;
      tmp._basic_probability = in_basic_probability;
      tmp._best_consume = in_best_consume;
      tmp._best_probability = in_best_probability;
      tmp._id = in_id;
      tmp._level = in_level;
      tmp._perfect_consume = in_perfect_consume;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareEquipRefi> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareEquipRefi> _dataCaches = null;
    public static Dictionary<int, DeclareEquipRefi> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataEquipRefi");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataEquipRefi = require 'Lua/Config/DataEquipRefi'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataEquipRefi");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareEquipRefi>(3);
                     foreach (var item in dic)
                     {
                         DeclareEquipRefi tmp = new DeclareEquipRefi();
                       tmp.BasicConsume = CfgStringLua.Get(item.Value[0]);
                       tmp.BasicProbability = item.Value[1];
                       tmp.BestConsume = CfgStringLua.Get(item.Value[2]);
                       tmp.BestProbability = item.Value[3];
                       tmp.Id = item.Value[4];
                       tmp.Level = item.Value[5];
                       tmp.PerfectConsume = CfgStringLua.Get(item.Value[6]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"EquipRefi");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareEquipRefi>(3);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"EquipRefi");
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
    public static DeclareEquipRefi Get(int id)
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
    public static void Transform(Dictionary<int, DeclareEquipRefi> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
