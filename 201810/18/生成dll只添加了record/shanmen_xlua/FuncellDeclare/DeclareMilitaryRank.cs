//文件是自动生成,请勿手动修改.来自数据文件:MilitaryRank
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareMilitaryRank")]
  public class DeclareMilitaryRank
  {
    #region //私有变量定义
    //属性(@;@_@)
    private string _att;
    //名字hide
    private string _camp_1_name;
    //名字hide
    private string _camp_2_name;
    //称号颜色(填写颜色表内ID)hide
    private string _color;
    //阶
    private int _degree;
    //图标hide
    private string _icon;
    //军衔等级（=阶*100+级）
    private int _id;
    //级
    private int _level;
    //需求军功
    private int _need_value;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Att", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Att { get{ return _att; } set{ _att=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Camp1Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Camp1Name { get{ return _camp_1_name; } set{ _camp_1_name=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Camp2Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Camp2Name { get{ return _camp_2_name; } set{ _camp_2_name=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Color", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Color { get{ return _color; } set{ _color=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Degree", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Degree { get{ return _degree; } set{ _degree=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"NeedValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NeedValue { get{ return _need_value; } set{ _need_value=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareMilitaryRank Create( string in_att, string in_camp_1_name, string in_camp_2_name, string in_color, int in_degree, string in_icon, int in_id, int in_level, int in_need_value )
    {
      DeclareMilitaryRank tmp = new DeclareMilitaryRank();
      tmp._att = in_att;
      tmp._camp_1_name = in_camp_1_name;
      tmp._camp_2_name = in_camp_2_name;
      tmp._color = in_color;
      tmp._degree = in_degree;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._level = in_level;
      tmp._need_value = in_need_value;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareMilitaryRank> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareMilitaryRank> _dataCaches = null;
    public static Dictionary<int, DeclareMilitaryRank> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMilitaryRank");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataMilitaryRank = require 'Lua/Config/DataMilitaryRank'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMilitaryRank");                  }

                 if (dic != null)
                 {
                              _dataCaches = new Dictionary<int, DeclareMilitaryRank>();
                     foreach (var item in dic)
                     {
                         DeclareMilitaryRank tmp = new DeclareMilitaryRank();
                       tmp.Att = CfgStringLua.Get(item.Value[0]);
                       tmp.Camp1Name = CfgStringLua.Get(item.Value[1]);
                       tmp.Camp2Name = CfgStringLua.Get(item.Value[2]);
                       tmp.Color = CfgStringLua.Get(item.Value[3]);
                       tmp.Degree = item.Value[4];
                       tmp.Icon = CfgStringLua.Get(item.Value[5]);
                       tmp.Id = item.Value[6];
                       tmp.Level = item.Value[7];
                       tmp.NeedValue = item.Value[8];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"MilitaryRank");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareMilitaryRank>();
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"MilitaryRank");
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
    public static DeclareMilitaryRank Get(int id)
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
    public static void Transform(Dictionary<int, DeclareMilitaryRank> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
