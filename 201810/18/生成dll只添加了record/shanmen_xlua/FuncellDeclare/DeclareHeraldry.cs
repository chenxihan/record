//文件是自动生成,请勿手动修改.来自数据文件:heraldry
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareHeraldry")]
  public class DeclareHeraldry
  {
    #region //私有变量定义
    //基础属性(@;@_@)
    private string _attribute;
    //属性描述
    private string _attributeDes;
    //buff属性(@;@)
    private string _buff;
    //效果说明
    private string _des;
    //特效ID
    private int _effect;
    //生效时效(秒)
    private int _effectiveTime;
    //职业
    private int _gender;
    //图标
    private int _icon;
    //纹章ID
    private int _id;
    //物品ID
    private int _itemId;
    //纹章名称
    private string _name;
    //部位
    private int _part;
    //试用时效(秒)
    private int _probationTime;
    //续费价格(@_@)
    private string _renewPrice;
    //类型（1.经验纹章；2.守护纹章）
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Attribute", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Attribute { get{ return _attribute; } set{ _attribute=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"AttributeDes", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string AttributeDes { get{ return _attributeDes; } set{ _attributeDes=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Buff", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Buff { get{ return _buff; } set{ _buff=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Des", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Des { get{ return _des; } set{ _des=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Effect", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Effect { get{ return _effect; } set{ _effect=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"EffectiveTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int EffectiveTime { get{ return _effectiveTime; } set{ _effectiveTime=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Gender", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Gender { get{ return _gender; } set{ _gender=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"ItemId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ItemId { get{ return _itemId; } set{ _itemId=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"Part", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Part { get{ return _part; } set{ _part=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"ProbationTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ProbationTime { get{ return _probationTime; } set{ _probationTime=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"RenewPrice", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string RenewPrice { get{ return _renewPrice; } set{ _renewPrice=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareHeraldry Create( string in_attribute, string in_attributeDes, string in_buff, string in_des, int in_effect, int in_effectiveTime, int in_gender, int in_icon, int in_id, int in_itemId, string in_name, int in_part, int in_probationTime, string in_renewPrice, int in_type )
    {
      DeclareHeraldry tmp = new DeclareHeraldry();
      tmp._attribute = in_attribute;
      tmp._attributeDes = in_attributeDes;
      tmp._buff = in_buff;
      tmp._des = in_des;
      tmp._effect = in_effect;
      tmp._effectiveTime = in_effectiveTime;
      tmp._gender = in_gender;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._itemId = in_itemId;
      tmp._name = in_name;
      tmp._part = in_part;
      tmp._probationTime = in_probationTime;
      tmp._renewPrice = in_renewPrice;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareHeraldry> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareHeraldry> _dataCaches = null;
    public static Dictionary<int, DeclareHeraldry> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataHeraldry");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataHeraldry = require 'Lua/Config/DataHeraldry'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataHeraldry");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareHeraldry>(3);
                     foreach (var item in dic)
                     {
                         DeclareHeraldry tmp = new DeclareHeraldry();
                       tmp.Attribute = CfgStringLua.Get(item.Value[0]);
                       tmp.AttributeDes = CfgStringLua.Get(item.Value[1]);
                       tmp.Buff = CfgStringLua.Get(item.Value[2]);
                       tmp.Des = CfgStringLua.Get(item.Value[3]);
                       tmp.Effect = item.Value[4];
                       tmp.EffectiveTime = item.Value[5];
                       tmp.Gender = item.Value[6];
                       tmp.Icon = item.Value[7];
                       tmp.Id = item.Value[8];
                       tmp.ItemId = item.Value[9];
                       tmp.Name = CfgStringLua.Get(item.Value[10]);
                       tmp.Part = item.Value[11];
                       tmp.ProbationTime = item.Value[12];
                       tmp.RenewPrice = CfgStringLua.Get(item.Value[13]);
                       tmp.Type = item.Value[14];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Heraldry");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareHeraldry>(3);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Heraldry");
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
    public static DeclareHeraldry Get(int id)
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
    public static void Transform(Dictionary<int, DeclareHeraldry> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
