//文件是自动生成,请勿手动修改.来自数据文件:SoulBeasts
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareSoulBeasts")]
  public class DeclareSoulBeasts
  {
    #region //私有变量定义
    //附加属性(@;@_@)
    private string _attribute;
    //是否显示(0否1是)
    private int _canShow;
    //头像ID
    private int _icon;
    //魂兽ID
    private int _id;
    //名字
    private string _name;
    //激活要求装备部位ID_品质(@;@_@)
    //1头盔、2项圈、3铠甲、4利爪、5羽翼
    private string _needEquip;
    //附加技能(@;@)
    private string _skill;
    //大图片ID
    private int _text;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Attribute", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Attribute { get{ return _attribute; } set{ _attribute=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"CanShow", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanShow { get{ return _canShow; } set{ _canShow=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"NeedEquip", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string NeedEquip { get{ return _needEquip; } set{ _needEquip=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Skill", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Skill { get{ return _skill; } set{ _skill=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Text", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Text { get{ return _text; } set{ _text=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareSoulBeasts Create( string in_attribute, int in_canShow, int in_icon, int in_id, string in_name, string in_needEquip, string in_skill, int in_text )
    {
      DeclareSoulBeasts tmp = new DeclareSoulBeasts();
      tmp._attribute = in_attribute;
      tmp._canShow = in_canShow;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._name = in_name;
      tmp._needEquip = in_needEquip;
      tmp._skill = in_skill;
      tmp._text = in_text;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareSoulBeasts> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareSoulBeasts> _dataCaches = null;
    public static Dictionary<int, DeclareSoulBeasts> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataSoulBeasts");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataSoulBeasts = require 'Lua/Config/DataSoulBeasts'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataSoulBeasts");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareSoulBeasts>(22);
                     foreach (var item in dic)
                     {
                         DeclareSoulBeasts tmp = new DeclareSoulBeasts();
                       tmp.Attribute = CfgStringLua.Get(item.Value[0]);
                       tmp.CanShow = item.Value[1];
                       tmp.Icon = item.Value[2];
                       tmp.Id = item.Value[3];
                       tmp.Name = CfgStringLua.Get(item.Value[4]);
                       tmp.NeedEquip = CfgStringLua.Get(item.Value[5]);
                       tmp.Skill = CfgStringLua.Get(item.Value[6]);
                       tmp.Text = item.Value[7];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"SoulBeasts");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareSoulBeasts>(22);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"SoulBeasts");
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
    public static DeclareSoulBeasts Get(int id)
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
    public static void Transform(Dictionary<int, DeclareSoulBeasts> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
