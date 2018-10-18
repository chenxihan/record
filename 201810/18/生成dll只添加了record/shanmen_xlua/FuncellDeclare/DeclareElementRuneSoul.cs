//文件是自动生成,请勿手动修改.来自数据文件:elementRuneSoul
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareElementRuneSoul")]
  public class DeclareElementRuneSoul
  {
    #region //私有变量定义
    //基础属性加成万分比
    private int _addAtt;
    //每次成长属性(@;@_@)
    private string _attribute;
    //精粹ICON
    private int _icon;
    //精粹唯一ID
    private int _id;
    //可使用上限（等级_数量）(@;@_@)
    private string _level;
    //精粹名字
    private string _name;
    //每次强化所需道具_数量(@;@_@)
    private string _need_item;
    //对应符文类型(@_@)
    private string _runeType;
    //每次成长特殊属性(@;@_@)
    private string _specialAtt;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"AddAtt", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int AddAtt { get{ return _addAtt; } set{ _addAtt=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Attribute", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Attribute { get{ return _attribute; } set{ _attribute=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"NeedItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string NeedItem { get{ return _need_item; } set{ _need_item=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"RuneType", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string RuneType { get{ return _runeType; } set{ _runeType=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"SpecialAtt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SpecialAtt { get{ return _specialAtt; } set{ _specialAtt=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareElementRuneSoul Create( int in_addAtt, string in_attribute, int in_icon, int in_id, string in_level, string in_name, string in_need_item, string in_runeType, string in_specialAtt )
    {
      DeclareElementRuneSoul tmp = new DeclareElementRuneSoul();
      tmp._addAtt = in_addAtt;
      tmp._attribute = in_attribute;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._level = in_level;
      tmp._name = in_name;
      tmp._need_item = in_need_item;
      tmp._runeType = in_runeType;
      tmp._specialAtt = in_specialAtt;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareElementRuneSoul> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareElementRuneSoul> _dataCaches = null;
    public static Dictionary<int, DeclareElementRuneSoul> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataElementRuneSoul");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataElementRuneSoul = require 'Lua/Config/DataElementRuneSoul'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataElementRuneSoul");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareElementRuneSoul>(4);
                     foreach (var item in dic)
                     {
                         DeclareElementRuneSoul tmp = new DeclareElementRuneSoul();
                       tmp.AddAtt = item.Value[0];
                       tmp.Attribute = CfgStringLua.Get(item.Value[1]);
                       tmp.Icon = item.Value[2];
                       tmp.Id = item.Value[3];
                       tmp.Level = CfgStringLua.Get(item.Value[4]);
                       tmp.Name = CfgStringLua.Get(item.Value[5]);
                       tmp.NeedItem = CfgStringLua.Get(item.Value[6]);
                       tmp.RuneType = CfgStringLua.Get(item.Value[7]);
                       tmp.SpecialAtt = CfgStringLua.Get(item.Value[8]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"ElementRuneSoul");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareElementRuneSoul>(4);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"ElementRuneSoul");
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
    public static DeclareElementRuneSoul Get(int id)
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
    public static void Transform(Dictionary<int, DeclareElementRuneSoul> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
