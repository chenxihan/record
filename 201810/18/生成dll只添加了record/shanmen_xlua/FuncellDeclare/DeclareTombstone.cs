//文件是自动生成,请勿手动修改.来自数据文件:tombstone
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareTombstone")]
  public class DeclareTombstone
  {
    #region //私有变量定义
    //刷新地图
    private int _map;
    //墓碑模型
    //（填写ModelConfig中ID）
    private int _model;
    //怪物ID
    private int _monsterID;
    //墓碑名字
    private string _name;
    //刷新坐标(@_@)
    private string _pos;
    //刷新时间(@;@_@)
    private string _resurrectiontime;
    //复活的类型
    //（1.定点刷新；2.死亡后复活）
    private int _resurrectionType;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Map", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Map { get{ return _map; } set{ _map=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Model", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Model { get{ return _model; } set{ _model=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"MonsterID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MonsterID { get{ return _monsterID; } set{ _monsterID=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Pos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Pos { get{ return _pos; } set{ _pos=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Resurrectiontime", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Resurrectiontime { get{ return _resurrectiontime; } set{ _resurrectiontime=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"ResurrectionType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ResurrectionType { get{ return _resurrectionType; } set{ _resurrectionType=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareTombstone Create( int in_map, int in_model, int in_monsterID, string in_name, string in_pos, string in_resurrectiontime, int in_resurrectionType )
    {
      DeclareTombstone tmp = new DeclareTombstone();
      tmp._map = in_map;
      tmp._model = in_model;
      tmp._monsterID = in_monsterID;
      tmp._name = in_name;
      tmp._pos = in_pos;
      tmp._resurrectiontime = in_resurrectiontime;
      tmp._resurrectionType = in_resurrectionType;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareTombstone> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareTombstone> _dataCaches = null;
    public static Dictionary<int, DeclareTombstone> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTombstone");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataTombstone = require 'Lua/Config/DataTombstone'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTombstone");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareTombstone>(128);
                     foreach (var item in dic)
                     {
                         DeclareTombstone tmp = new DeclareTombstone();
                       tmp.Map = item.Value[0];
                       tmp.Model = item.Value[1];
                       tmp.MonsterID = item.Value[2];
                       tmp.Name = CfgStringLua.Get(item.Value[3]);
                       tmp.Pos = CfgStringLua.Get(item.Value[4]);
                       tmp.Resurrectiontime = CfgStringLua.Get(item.Value[5]);
                       tmp.ResurrectionType = item.Value[6];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Tombstone");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareTombstone>(128);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Tombstone");
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
    public static DeclareTombstone Get(int id)
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
    public static void Transform(Dictionary<int, DeclareTombstone> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
