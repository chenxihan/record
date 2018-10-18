//文件是自动生成,请勿手动修改.来自数据文件:marriage_attribute
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareMarriageAttribute")]
  public class DeclareMarriageAttribute
  {
    #region //私有变量定义
    //激活属性(@;@_@)
    private string _attribute;
    //属性类型
    private int _attType;
    //描述hide
    private string _desc;
    //属性图标hide
    private int _icon;
    //key=attType*1000+level
    private int _key;
    //等级
    private int _level;
    //技能名字hide
    private string _name;
    //升级所需物品(@;@_@)
    private string _upNeedItem;
    //升级所需金币
    private int _upNeedMoney;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Attribute", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Attribute { get{ return _attribute; } set{ _attribute=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"AttType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int AttType { get{ return _attType; } set{ _attType=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Desc { get{ return _desc; } set{ _desc=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Key", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Key { get{ return _key; } set{ _key=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"UpNeedItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string UpNeedItem { get{ return _upNeedItem; } set{ _upNeedItem=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"UpNeedMoney", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UpNeedMoney { get{ return _upNeedMoney; } set{ _upNeedMoney=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareMarriageAttribute Create( string in_attribute, int in_attType, string in_desc, int in_icon, int in_key, int in_level, string in_name, string in_upNeedItem, int in_upNeedMoney )
    {
      DeclareMarriageAttribute tmp = new DeclareMarriageAttribute();
      tmp._attribute = in_attribute;
      tmp._attType = in_attType;
      tmp._desc = in_desc;
      tmp._icon = in_icon;
      tmp._key = in_key;
      tmp._level = in_level;
      tmp._name = in_name;
      tmp._upNeedItem = in_upNeedItem;
      tmp._upNeedMoney = in_upNeedMoney;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareMarriageAttribute> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareMarriageAttribute> _dataCaches = null;
    public static Dictionary<int, DeclareMarriageAttribute> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMarriageAttribute");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataMarriageAttribute = require 'Lua/Config/DataMarriageAttribute'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMarriageAttribute");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareMarriageAttribute>(200);
                     foreach (var item in dic)
                     {
                         DeclareMarriageAttribute tmp = new DeclareMarriageAttribute();
                       tmp.Attribute = CfgStringLua.Get(item.Value[0]);
                       tmp.AttType = item.Value[1];
                       tmp.Desc = CfgStringLua.Get(item.Value[2]);
                       tmp.Icon = item.Value[3];
                       tmp.Key = item.Value[4];
                       tmp.Level = item.Value[5];
                       tmp.Name = CfgStringLua.Get(item.Value[6]);
                       tmp.UpNeedItem = CfgStringLua.Get(item.Value[7]);
                       tmp.UpNeedMoney = item.Value[8];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"MarriageAttribute");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareMarriageAttribute>(200);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"MarriageAttribute");
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
    public static DeclareMarriageAttribute Get(int id)
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
    public static void Transform(Dictionary<int, DeclareMarriageAttribute> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
