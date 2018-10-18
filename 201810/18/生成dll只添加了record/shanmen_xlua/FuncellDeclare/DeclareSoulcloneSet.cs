//文件是自动生成,请勿手动修改.来自数据文件:soulclone_set
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareSoulcloneSet")]
  public class DeclareSoulcloneSet
  {
    #region //私有变量定义
    //描述（hide）
    private string _desc;
    //拆卸返还
    private int _explain;
    //塔的头像
    private int _icon;
    //灵魂唯一ID（塔的类型_等级）
    private string _id;
    //升级消耗
    private int _levelup;
    //塔的名字
    private string _name;
    //类型（1，群攻塔；2，减速塔；3，定身塔；4，单体攻击塔）
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Desc { get{ return _desc; } set{ _desc=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Explain", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Explain { get{ return _explain; } set{ _explain=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Levelup", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Levelup { get{ return _levelup; } set{ _levelup=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareSoulcloneSet Create( string in_desc, int in_explain, int in_icon, string in_id, int in_levelup, string in_name, int in_type )
    {
      DeclareSoulcloneSet tmp = new DeclareSoulcloneSet();
      tmp._desc = in_desc;
      tmp._explain = in_explain;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._levelup = in_levelup;
      tmp._name = in_name;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<string, DeclareSoulcloneSet> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<string, DeclareSoulcloneSet> _dataCaches = null;
    public static Dictionary<string, DeclareSoulcloneSet> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataSoulcloneSet");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataSoulcloneSet = require 'Lua/Config/DataSoulcloneSet'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataSoulcloneSet");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<string, DeclareSoulcloneSet>(20);
                     foreach (var item in dic)
                     {
                         DeclareSoulcloneSet tmp = new DeclareSoulcloneSet();
                       tmp.Desc = CfgStringLua.Get(item.Value[0]);
                       tmp.Explain = item.Value[1];
                       tmp.Icon = item.Value[2];
                       tmp.Id = CfgStringLua.Get(item.Value[3]);
                       tmp.Levelup = item.Value[4];
                       tmp.Name = CfgStringLua.Get(item.Value[5]);
                       tmp.Type = item.Value[6];

                         _dataCaches.Add(CfgStringLua.Get(item.Key), tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"SoulcloneSet");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<string, DeclareSoulcloneSet>(20);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"SoulcloneSet");
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
    public static DeclareSoulcloneSet Get(string id)
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
    public static void Transform(Dictionary<string, DeclareSoulcloneSet> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
