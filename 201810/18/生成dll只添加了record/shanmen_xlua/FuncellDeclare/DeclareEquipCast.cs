//文件是自动生成,请勿手动修改.来自数据文件:Equip_cast
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareEquipCast")]
  public class DeclareEquipCast
  {
    #region //私有变量定义
    //ID=阶数*10000+等级*100+部位
    private int _id;
    //等级
    private int _level;
    //普通属性（增加基础属性的万分比）
    private int _normal_attr;
    //阶数
    private int _order;
    //部位
    private int _part;
    //特殊属性(@;@_@_@)
    private string _special_attr;
    //消耗(@;@_@)
    private string _spend;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"NormalAttr", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NormalAttr { get{ return _normal_attr; } set{ _normal_attr=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Order", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Order { get{ return _order; } set{ _order=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Part", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Part { get{ return _part; } set{ _part=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"SpecialAttr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SpecialAttr { get{ return _special_attr; } set{ _special_attr=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Spend", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Spend { get{ return _spend; } set{ _spend=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareEquipCast Create( int in_id, int in_level, int in_normal_attr, int in_order, int in_part, string in_special_attr, string in_spend )
    {
      DeclareEquipCast tmp = new DeclareEquipCast();
      tmp._id = in_id;
      tmp._level = in_level;
      tmp._normal_attr = in_normal_attr;
      tmp._order = in_order;
      tmp._part = in_part;
      tmp._special_attr = in_special_attr;
      tmp._spend = in_spend;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareEquipCast> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareEquipCast> _dataCaches = null;
    public static Dictionary<int, DeclareEquipCast> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataEquipCast");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataEquipCast = require 'Lua/Config/DataEquipCast'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataEquipCast");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareEquipCast>(4400);
                     foreach (var item in dic)
                     {
                         DeclareEquipCast tmp = new DeclareEquipCast();
                       tmp.Id = item.Value[0];
                       tmp.Level = item.Value[1];
                       tmp.NormalAttr = item.Value[2];
                       tmp.Order = item.Value[3];
                       tmp.Part = item.Value[4];
                       tmp.SpecialAttr = CfgStringLua.Get(item.Value[5]);
                       tmp.Spend = CfgStringLua.Get(item.Value[6]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"EquipCast");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareEquipCast>(4400);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"EquipCast");
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
    public static DeclareEquipCast Get(int id)
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
    public static void Transform(Dictionary<int, DeclareEquipCast> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
