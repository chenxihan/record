//文件是自动生成,请勿手动修改.来自数据文件:elementRuneSuit
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareElementRuneSuit")]
  public class DeclareElementRuneSuit
  {
    #region //私有变量定义
    //2件套基础属性提升(@;@_@)
    private string _attribute_2;
    //4件套基础属性提升(@;@_@)
    private string _attribute_4;
    //5件套基础属性提升(@;@_@)
    private string _attribute_5;
    //6件套基础属性提升(@;@_@)
    private string _attribute_6;
    //2件套符文属性提升(@;@_@)
    //符文部位ID_属性比例（万分比）
    private string _elementAttribute_2;
    //4件套符文属性提升(@;@_@)
    //符文部位ID_属性比例（万分比）
    private string _elementAttribute_4;
    //5件套符文属性提升(@;@_@)
    //符文部位ID_属性比例（万分比）
    private string _elementAttribute_5;
    //6件套符文属性提升(@;@_@)
    //符文部位ID_属性比例（万分比）
    private string _elementAttribute_6;
    //套装唯一ID
    private int _id;
    //套装等级
    private int _level;
    //对应符文阶数
    private int _need_degree;
    //激活所需符文ID(@_@)
    private string _need_element;
    //需求部位(@_@)(1勇气、2专注、3信念、4谦卑、5智慧、6戒律、7灾厄、8恐惧、9贪婪、10愤怒、11毁灭)
    private string _need_parts;
    //需求的品质
    private int _need_quality;
    //套装前缀
    private string _prefix;
    //套装参考评分
    private int _score;
    //1、秩序符文套装
    //2、混沌符文套装
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Attribute2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Attribute2 { get{ return _attribute_2; } set{ _attribute_2=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Attribute4", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Attribute4 { get{ return _attribute_4; } set{ _attribute_4=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Attribute5", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Attribute5 { get{ return _attribute_5; } set{ _attribute_5=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Attribute6", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Attribute6 { get{ return _attribute_6; } set{ _attribute_6=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"ElementAttribute2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ElementAttribute2 { get{ return _elementAttribute_2; } set{ _elementAttribute_2=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"ElementAttribute4", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ElementAttribute4 { get{ return _elementAttribute_4; } set{ _elementAttribute_4=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"ElementAttribute5", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ElementAttribute5 { get{ return _elementAttribute_5; } set{ _elementAttribute_5=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"ElementAttribute6", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ElementAttribute6 { get{ return _elementAttribute_6; } set{ _elementAttribute_6=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"NeedDegree", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NeedDegree { get{ return _need_degree; } set{ _need_degree=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"NeedElement", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string NeedElement { get{ return _need_element; } set{ _need_element=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"NeedParts", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string NeedParts { get{ return _need_parts; } set{ _need_parts=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"NeedQuality", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NeedQuality { get{ return _need_quality; } set{ _need_quality=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"Prefix", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Prefix { get{ return _prefix; } set{ _prefix=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"Score", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Score { get{ return _score; } set{ _score=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareElementRuneSuit Create( string in_attribute_2, string in_attribute_4, string in_attribute_5, string in_attribute_6, string in_elementAttribute_2, string in_elementAttribute_4, string in_elementAttribute_5, string in_elementAttribute_6, int in_id, int in_level, int in_need_degree, string in_need_element, string in_need_parts, int in_need_quality, string in_prefix, int in_score, int in_type )
    {
      DeclareElementRuneSuit tmp = new DeclareElementRuneSuit();
      tmp._attribute_2 = in_attribute_2;
      tmp._attribute_4 = in_attribute_4;
      tmp._attribute_5 = in_attribute_5;
      tmp._attribute_6 = in_attribute_6;
      tmp._elementAttribute_2 = in_elementAttribute_2;
      tmp._elementAttribute_4 = in_elementAttribute_4;
      tmp._elementAttribute_5 = in_elementAttribute_5;
      tmp._elementAttribute_6 = in_elementAttribute_6;
      tmp._id = in_id;
      tmp._level = in_level;
      tmp._need_degree = in_need_degree;
      tmp._need_element = in_need_element;
      tmp._need_parts = in_need_parts;
      tmp._need_quality = in_need_quality;
      tmp._prefix = in_prefix;
      tmp._score = in_score;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareElementRuneSuit> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareElementRuneSuit> _dataCaches = null;
    public static Dictionary<int, DeclareElementRuneSuit> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataElementRuneSuit");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataElementRuneSuit = require 'Lua/Config/DataElementRuneSuit'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataElementRuneSuit");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareElementRuneSuit>(32);
                     foreach (var item in dic)
                     {
                         DeclareElementRuneSuit tmp = new DeclareElementRuneSuit();
                       tmp.Attribute2 = CfgStringLua.Get(item.Value[0]);
                       tmp.Attribute4 = CfgStringLua.Get(item.Value[1]);
                       tmp.Attribute5 = CfgStringLua.Get(item.Value[2]);
                       tmp.Attribute6 = CfgStringLua.Get(item.Value[3]);
                       tmp.ElementAttribute2 = CfgStringLua.Get(item.Value[4]);
                       tmp.ElementAttribute4 = CfgStringLua.Get(item.Value[5]);
                       tmp.ElementAttribute5 = CfgStringLua.Get(item.Value[6]);
                       tmp.ElementAttribute6 = CfgStringLua.Get(item.Value[7]);
                       tmp.Id = item.Value[8];
                       tmp.Level = item.Value[9];
                       tmp.NeedDegree = item.Value[10];
                       tmp.NeedElement = CfgStringLua.Get(item.Value[11]);
                       tmp.NeedParts = CfgStringLua.Get(item.Value[12]);
                       tmp.NeedQuality = item.Value[13];
                       tmp.Prefix = CfgStringLua.Get(item.Value[14]);
                       tmp.Score = item.Value[15];
                       tmp.Type = item.Value[16];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"ElementRuneSuit");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareElementRuneSuit>(32);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"ElementRuneSuit");
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
    public static DeclareElementRuneSuit Get(int id)
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
    public static void Transform(Dictionary<int, DeclareElementRuneSuit> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
