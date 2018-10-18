//文件是自动生成,请勿手动修改.来自数据文件:GodToolsStar
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareGodToolsStar")]
  public class DeclareGodToolsStar
  {
    #region //私有变量定义
    //id = 神器id*100+星级
    private int _id;
    //当前星最大可强化等级
    private int _max_level;
    //当前星级属性(@;@_@)
    private string _property;
    //星级
    private int _star;
    //升星需要的道具（升到下一级需要的道具）(@;@_@)
    private string _star_up_cost;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"MaxLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MaxLevel { get{ return _max_level; } set{ _max_level=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Property", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Property { get{ return _property; } set{ _property=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Star", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Star { get{ return _star; } set{ _star=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"StarUpCost", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string StarUpCost { get{ return _star_up_cost; } set{ _star_up_cost=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareGodToolsStar Create( int in_id, int in_max_level, string in_property, int in_star, string in_star_up_cost )
    {
      DeclareGodToolsStar tmp = new DeclareGodToolsStar();
      tmp._id = in_id;
      tmp._max_level = in_max_level;
      tmp._property = in_property;
      tmp._star = in_star;
      tmp._star_up_cost = in_star_up_cost;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareGodToolsStar> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareGodToolsStar> _dataCaches = null;
    public static Dictionary<int, DeclareGodToolsStar> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGodToolsStar");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataGodToolsStar = require 'Lua/Config/DataGodToolsStar'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGodToolsStar");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareGodToolsStar>(192);
                     foreach (var item in dic)
                     {
                         DeclareGodToolsStar tmp = new DeclareGodToolsStar();
                       tmp.Id = item.Value[0];
                       tmp.MaxLevel = item.Value[1];
                       tmp.Property = CfgStringLua.Get(item.Value[2]);
                       tmp.Star = item.Value[3];
                       tmp.StarUpCost = CfgStringLua.Get(item.Value[4]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"GodToolsStar");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareGodToolsStar>(192);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"GodToolsStar");
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
    public static DeclareGodToolsStar Get(int id)
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
    public static void Transform(Dictionary<int, DeclareGodToolsStar> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
