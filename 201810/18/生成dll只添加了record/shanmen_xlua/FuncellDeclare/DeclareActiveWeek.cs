//文件是自动生成,请勿手动修改.来自数据文件:active_week
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareActiveWeek")]
  public class DeclareActiveWeek
  {
    #region //私有变量定义
    //活跃行为ID
    private int _activeId;
    //活跃行为ID
    private int _id;
    //活动名字
    private string _name;
    //活动时间
    private string _time;
    //星期
    private int _week;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ActiveId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ActiveId { get{ return _activeId; } set{ _activeId=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Time", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Time { get{ return _time; } set{ _time=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Week", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Week { get{ return _week; } set{ _week=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareActiveWeek Create( int in_activeId, int in_id, string in_name, string in_time, int in_week )
    {
      DeclareActiveWeek tmp = new DeclareActiveWeek();
      tmp._activeId = in_activeId;
      tmp._id = in_id;
      tmp._name = in_name;
      tmp._time = in_time;
      tmp._week = in_week;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareActiveWeek> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareActiveWeek> _dataCaches = null;
    public static Dictionary<int, DeclareActiveWeek> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataActiveWeek");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataActiveWeek = require 'Lua/Config/DataActiveWeek'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataActiveWeek");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareActiveWeek>(42);
                     foreach (var item in dic)
                     {
                         DeclareActiveWeek tmp = new DeclareActiveWeek();
                       tmp.ActiveId = item.Value[0];
                       tmp.Id = item.Value[1];
                       tmp.Name = CfgStringLua.Get(item.Value[2]);
                       tmp.Time = CfgStringLua.Get(item.Value[3]);
                       tmp.Week = item.Value[4];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"ActiveWeek");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareActiveWeek>(42);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"ActiveWeek");
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
    public static DeclareActiveWeek Get(int id)
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
    public static void Transform(Dictionary<int, DeclareActiveWeek> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
