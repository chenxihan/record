//文件是自动生成,请勿手动修改.来自数据文件:DeviceMatchConfig
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareDeviceMatchConfig")]
  public class DeclareDeviceMatchConfig
  {
    #region //私有变量定义
    //设备名字,(同型号的条件越多的,越往前放比如:iPhone4s就应该比iPhone4放的更靠前.以便首先匹配)
    private string _deviceName;
    //设备类型(0:机型,1:显卡)
    private int _deviceType;
    //ID
    private int _id;
    //匹配等级
    private int _level;
    //是否做CPU的匹配
    private int _matchCPU;
    //是否使用流光
    private int _useFlow;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"DeviceName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DeviceName { get{ return _deviceName; } set{ _deviceName=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"DeviceType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DeviceType { get{ return _deviceType; } set{ _deviceType=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"MatchCPU", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MatchCPU { get{ return _matchCPU; } set{ _matchCPU=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"UseFlow", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UseFlow { get{ return _useFlow; } set{ _useFlow=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareDeviceMatchConfig Create( string in_deviceName, int in_deviceType, int in_id, int in_level, int in_matchCPU, int in_useFlow )
    {
      DeclareDeviceMatchConfig tmp = new DeclareDeviceMatchConfig();
      tmp._deviceName = in_deviceName;
      tmp._deviceType = in_deviceType;
      tmp._id = in_id;
      tmp._level = in_level;
      tmp._matchCPU = in_matchCPU;
      tmp._useFlow = in_useFlow;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareDeviceMatchConfig> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareDeviceMatchConfig> _dataCaches = null;
    public static Dictionary<int, DeclareDeviceMatchConfig> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataDeviceMatchConfig");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataDeviceMatchConfig = require 'Lua/Config/DataDeviceMatchConfig'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataDeviceMatchConfig");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareDeviceMatchConfig>(66);
                     foreach (var item in dic)
                     {
                         DeclareDeviceMatchConfig tmp = new DeclareDeviceMatchConfig();
                       tmp.DeviceName = CfgStringLua.Get(item.Value[0]);
                       tmp.DeviceType = item.Value[1];
                       tmp.Id = item.Value[2];
                       tmp.Level = item.Value[3];
                       tmp.MatchCPU = item.Value[4];
                       tmp.UseFlow = item.Value[5];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"DeviceMatchConfig");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareDeviceMatchConfig>(66);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"DeviceMatchConfig");
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
    public static DeclareDeviceMatchConfig Get(int id)
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
    public static void Transform(Dictionary<int, DeclareDeviceMatchConfig> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
