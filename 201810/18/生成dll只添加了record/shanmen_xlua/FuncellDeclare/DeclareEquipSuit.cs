//文件是自动生成,请勿手动修改.来自数据文件:Equip_suit
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareEquipSuit")]
  public class DeclareEquipSuit
  {
    #region //私有变量定义
    //套装属性1(@;@_@)
    private string _attribute_1;
    //套装属性2(@;@_@)
    private string _attribute_2;
    //套装属性4(@;@_@)
    private string _attribute_4;
    //套装属性6(@;@_@)
    private string _attribute_6;
    //套装唯一ID
    private int _id;
    //套装等级
    private int _level;
    //套装名字
    private string _name;
    //需求装备阶数(@_@)
    private string _need_degree;
    //是否要带钻
    private int _need_diamonds;
    //职业限制
    //0-执笔者；1-拳师；2-大锤；3-太刀；4-卡牌；5-枪手(@_@)
    private string _need_gender;
    //锻造所需材料（部位_ID_num）(@;@_@)
    private string _need_items;
    //需求部位(@_@)
    private string _need_parts;
    //需求的品质
    private int _need_quality;
    //父类ID，填写神怒套上层天怒套ID用于套装石返还
    private int _parent_ID;
    //套装前缀
    private string _prefix;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Attribute1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Attribute1 { get{ return _attribute_1; } set{ _attribute_1=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Attribute2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Attribute2 { get{ return _attribute_2; } set{ _attribute_2=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Attribute4", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Attribute4 { get{ return _attribute_4; } set{ _attribute_4=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Attribute6", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Attribute6 { get{ return _attribute_6; } set{ _attribute_6=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"NeedDegree", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string NeedDegree { get{ return _need_degree; } set{ _need_degree=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"NeedDiamonds", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NeedDiamonds { get{ return _need_diamonds; } set{ _need_diamonds=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"NeedGender", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string NeedGender { get{ return _need_gender; } set{ _need_gender=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"NeedItems", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string NeedItems { get{ return _need_items; } set{ _need_items=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"NeedParts", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string NeedParts { get{ return _need_parts; } set{ _need_parts=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"NeedQuality", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NeedQuality { get{ return _need_quality; } set{ _need_quality=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"ParentID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ParentID { get{ return _parent_ID; } set{ _parent_ID=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"Prefix", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Prefix { get{ return _prefix; } set{ _prefix=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareEquipSuit Create( string in_attribute_1, string in_attribute_2, string in_attribute_4, string in_attribute_6, int in_id, int in_level, string in_name, string in_need_degree, int in_need_diamonds, string in_need_gender, string in_need_items, string in_need_parts, int in_need_quality, int in_parent_ID, string in_prefix )
    {
      DeclareEquipSuit tmp = new DeclareEquipSuit();
      tmp._attribute_1 = in_attribute_1;
      tmp._attribute_2 = in_attribute_2;
      tmp._attribute_4 = in_attribute_4;
      tmp._attribute_6 = in_attribute_6;
      tmp._id = in_id;
      tmp._level = in_level;
      tmp._name = in_name;
      tmp._need_degree = in_need_degree;
      tmp._need_diamonds = in_need_diamonds;
      tmp._need_gender = in_need_gender;
      tmp._need_items = in_need_items;
      tmp._need_parts = in_need_parts;
      tmp._need_quality = in_need_quality;
      tmp._parent_ID = in_parent_ID;
      tmp._prefix = in_prefix;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareEquipSuit> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareEquipSuit> _dataCaches = null;
    public static Dictionary<int, DeclareEquipSuit> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataEquipSuit");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataEquipSuit = require 'Lua/Config/DataEquipSuit'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataEquipSuit");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareEquipSuit>(50);
                     foreach (var item in dic)
                     {
                         DeclareEquipSuit tmp = new DeclareEquipSuit();
                       tmp.Attribute1 = CfgStringLua.Get(item.Value[0]);
                       tmp.Attribute2 = CfgStringLua.Get(item.Value[1]);
                       tmp.Attribute4 = CfgStringLua.Get(item.Value[2]);
                       tmp.Attribute6 = CfgStringLua.Get(item.Value[3]);
                       tmp.Id = item.Value[4];
                       tmp.Level = item.Value[5];
                       tmp.Name = CfgStringLua.Get(item.Value[6]);
                       tmp.NeedDegree = CfgStringLua.Get(item.Value[7]);
                       tmp.NeedDiamonds = item.Value[8];
                       tmp.NeedGender = CfgStringLua.Get(item.Value[9]);
                       tmp.NeedItems = CfgStringLua.Get(item.Value[10]);
                       tmp.NeedParts = CfgStringLua.Get(item.Value[11]);
                       tmp.NeedQuality = item.Value[12];
                       tmp.ParentID = item.Value[13];
                       tmp.Prefix = CfgStringLua.Get(item.Value[14]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"EquipSuit");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareEquipSuit>(50);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"EquipSuit");
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
    public static DeclareEquipSuit Get(int id)
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
    public static void Transform(Dictionary<int, DeclareEquipSuit> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
