//文件是自动生成,请勿手动修改.来自数据文件:UIConfig
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareUIConfig")]
  public class DeclareUIConfig
  {
    #region //私有变量定义
    //关闭音效
    private string _closeSFX;
    //UIComponent
    private string _componentScript;
    //0
    private int _id;
    //UIPrefab名
    private string _name;
    //开启音效
    private string _openSFX;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"CloseSFX", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string CloseSFX { get{ return _closeSFX; } set{ _closeSFX=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"ComponentScript", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ComponentScript { get{ return _componentScript; } set{ _componentScript=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"OpenSFX", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OpenSFX { get{ return _openSFX; } set{ _openSFX=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareUIConfig Create( string in_closeSFX, string in_componentScript, int in_id, string in_name, string in_openSFX )
    {
      DeclareUIConfig tmp = new DeclareUIConfig();
      tmp._closeSFX = in_closeSFX;
      tmp._componentScript = in_componentScript;
      tmp._id = in_id;
      tmp._name = in_name;
      tmp._openSFX = in_openSFX;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<string, DeclareUIConfig> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<string, DeclareUIConfig> _dataCaches = null;
    public static Dictionary<string, DeclareUIConfig> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataUIConfig");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataUIConfig = require 'Lua/Config/DataUIConfig'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataUIConfig");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<string, DeclareUIConfig>(397);
                     foreach (var item in dic)
                     {
                         DeclareUIConfig tmp = new DeclareUIConfig();
                       tmp.CloseSFX = CfgStringLua.Get(item.Value[0]);
                       tmp.ComponentScript = CfgStringLua.Get(item.Value[1]);
                       tmp.Id = item.Value[2];
                       tmp.Name = CfgStringLua.Get(item.Value[3]);
                       tmp.OpenSFX = CfgStringLua.Get(item.Value[4]);

                         _dataCaches.Add(CfgStringLua.Get(item.Key), tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"UIConfig");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<string, DeclareUIConfig>(397);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"UIConfig");
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
    public static DeclareUIConfig Get(string id)
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
    public static void Transform(Dictionary<string, DeclareUIConfig> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
