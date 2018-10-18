//文件是自动生成,请勿手动修改.来自数据文件:PlayerGodHead
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclarePlayerGodHead")]
  public class DeclarePlayerGodHead
  {
    #region //私有变量定义
    //称号颜色(填写颜色表内ID)hide
    private string _color;
    //称号ID
    private int _id;
    //称号名称
    private string _name;
    //需求战斗力
    private int _need_fight_power;
    //激活称号需求道具(@;@_@)
    private string _need_item;
    //是否公告1公告0否
    private int _notice;
    //战斗力(hide)
    private int _power;
    //称号属性(@;@_@)
    private string _propetry;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Color", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Color { get{ return _color; } set{ _color=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"NeedFightPower", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NeedFightPower { get{ return _need_fight_power; } set{ _need_fight_power=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"NeedItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string NeedItem { get{ return _need_item; } set{ _need_item=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Notice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Notice { get{ return _notice; } set{ _notice=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Power", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Power { get{ return _power; } set{ _power=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Propetry", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Propetry { get{ return _propetry; } set{ _propetry=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclarePlayerGodHead Create( string in_color, int in_id, string in_name, int in_need_fight_power, string in_need_item, int in_notice, int in_power, string in_propetry )
    {
      DeclarePlayerGodHead tmp = new DeclarePlayerGodHead();
      tmp._color = in_color;
      tmp._id = in_id;
      tmp._name = in_name;
      tmp._need_fight_power = in_need_fight_power;
      tmp._need_item = in_need_item;
      tmp._notice = in_notice;
      tmp._power = in_power;
      tmp._propetry = in_propetry;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclarePlayerGodHead> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclarePlayerGodHead> _dataCaches = null;
    public static Dictionary<int, DeclarePlayerGodHead> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPlayerGodHead");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataPlayerGodHead = require 'Lua/Config/DataPlayerGodHead'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPlayerGodHead");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclarePlayerGodHead>(15);
                     foreach (var item in dic)
                     {
                         DeclarePlayerGodHead tmp = new DeclarePlayerGodHead();
                       tmp.Color = CfgStringLua.Get(item.Value[0]);
                       tmp.Id = item.Value[1];
                       tmp.Name = CfgStringLua.Get(item.Value[2]);
                       tmp.NeedFightPower = item.Value[3];
                       tmp.NeedItem = CfgStringLua.Get(item.Value[4]);
                       tmp.Notice = item.Value[5];
                       tmp.Power = item.Value[6];
                       tmp.Propetry = CfgStringLua.Get(item.Value[7]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"PlayerGodHead");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclarePlayerGodHead>(15);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"PlayerGodHead");
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
    public static DeclarePlayerGodHead Get(int id)
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
    public static void Transform(Dictionary<int, DeclarePlayerGodHead> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
