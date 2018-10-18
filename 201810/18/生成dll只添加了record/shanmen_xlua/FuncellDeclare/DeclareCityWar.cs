//文件是自动生成,请勿手动修改.来自数据文件:CityWar
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareCityWar")]
  public class DeclareCityWar
  {
    #region //私有变量定义
    //副本ID
    private int _cloneID;
    //城市ID
    private int _id;
    //名字
    private string _name;
    //城市背景图
    private string _res_tex;
    //城市类型，0主城，1卫城
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"CloneID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CloneID { get{ return _cloneID; } set{ _cloneID=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"ResTex", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ResTex { get{ return _res_tex; } set{ _res_tex=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareCityWar Create( int in_cloneID, int in_id, string in_name, string in_res_tex, int in_type )
    {
      DeclareCityWar tmp = new DeclareCityWar();
      tmp._cloneID = in_cloneID;
      tmp._id = in_id;
      tmp._name = in_name;
      tmp._res_tex = in_res_tex;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareCityWar> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareCityWar> _dataCaches = null;
    public static Dictionary<int, DeclareCityWar> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataCityWar");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataCityWar = require 'Lua/Config/DataCityWar'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataCityWar");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareCityWar>(4);
                     foreach (var item in dic)
                     {
                         DeclareCityWar tmp = new DeclareCityWar();
                       tmp.CloneID = item.Value[0];
                       tmp.Id = item.Value[1];
                       tmp.Name = CfgStringLua.Get(item.Value[2]);
                       tmp.ResTex = CfgStringLua.Get(item.Value[3]);
                       tmp.Type = item.Value[4];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"CityWar");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareCityWar>(4);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"CityWar");
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
    public static DeclareCityWar Get(int id)
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
    public static void Transform(Dictionary<int, DeclareCityWar> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
