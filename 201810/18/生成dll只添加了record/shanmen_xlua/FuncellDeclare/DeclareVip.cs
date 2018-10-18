//文件是自动生成,请勿手动修改.来自数据文件:vip
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareVip")]
  public class DeclareVip
  {
    #region //私有变量定义
    //是否可以在拍卖行密码交易道具（0否.1是）
    private int _canPasswordSell;
    //是否可以在拍卖行上架道具（0否.1是）
    private int _canSell;
    //描述hide
    private string _des;
    //杀怪额外经验提升百分比
    private int _exp;
    //每日可领取奖励（物品id_物品数量;）(@;@_@)
    private string _gift;
    //textureID（hide）
    private string _icon;
    //VIP等级(99月卡.999.终身卡)
    private int _level;
    //体力上限值
    private int _max_physical;
    //名字（hide）
    private string _name;
    //需要充值的元宝数
    private int _needRecharge;
    //生效时间（天 -1为永久）
    private int _time;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"CanPasswordSell", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanPasswordSell { get{ return _canPasswordSell; } set{ _canPasswordSell=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"CanSell", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanSell { get{ return _canSell; } set{ _canSell=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Des", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Des { get{ return _des; } set{ _des=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Exp { get{ return _exp; } set{ _exp=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Gift", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Gift { get{ return _gift; } set{ _gift=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"MaxPhysical", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MaxPhysical { get{ return _max_physical; } set{ _max_physical=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"NeedRecharge", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NeedRecharge { get{ return _needRecharge; } set{ _needRecharge=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Time { get{ return _time; } set{ _time=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareVip Create( int in_canPasswordSell, int in_canSell, string in_des, int in_exp, string in_gift, string in_icon, int in_level, int in_max_physical, string in_name, int in_needRecharge, int in_time )
    {
      DeclareVip tmp = new DeclareVip();
      tmp._canPasswordSell = in_canPasswordSell;
      tmp._canSell = in_canSell;
      tmp._des = in_des;
      tmp._exp = in_exp;
      tmp._gift = in_gift;
      tmp._icon = in_icon;
      tmp._level = in_level;
      tmp._max_physical = in_max_physical;
      tmp._name = in_name;
      tmp._needRecharge = in_needRecharge;
      tmp._time = in_time;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareVip> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareVip> _dataCaches = null;
    public static Dictionary<int, DeclareVip> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataVip");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataVip = require 'Lua/Config/DataVip'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataVip");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareVip>(3);
                     foreach (var item in dic)
                     {
                         DeclareVip tmp = new DeclareVip();
                       tmp.CanPasswordSell = item.Value[0];
                       tmp.CanSell = item.Value[1];
                       tmp.Des = CfgStringLua.Get(item.Value[2]);
                       tmp.Exp = item.Value[3];
                       tmp.Gift = CfgStringLua.Get(item.Value[4]);
                       tmp.Icon = CfgStringLua.Get(item.Value[5]);
                       tmp.Level = item.Value[6];
                       tmp.MaxPhysical = item.Value[7];
                       tmp.Name = CfgStringLua.Get(item.Value[8]);
                       tmp.NeedRecharge = item.Value[9];
                       tmp.Time = item.Value[10];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Vip");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareVip>(3);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Vip");
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
    public static DeclareVip Get(int id)
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
    public static void Transform(Dictionary<int, DeclareVip> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
