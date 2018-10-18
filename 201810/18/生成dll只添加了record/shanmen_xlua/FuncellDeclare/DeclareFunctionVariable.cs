//文件是自动生成,请勿手动修改.来自数据文件:FunctionVariable
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareFunctionVariable")]
  public class DeclareFunctionVariable
  {
    #region //私有变量定义
    //是否需要服务器同步数据
    private int _server_sync;
    //变量ID，此ID只能增加不能修改和删除
    private int _variable;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"ServerSync", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ServerSync { get{ return _server_sync; } set{ _server_sync=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Variable", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Variable { get{ return _variable; } set{ _variable=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareFunctionVariable Create( int in_server_sync, int in_variable )
    {
      DeclareFunctionVariable tmp = new DeclareFunctionVariable();
      tmp._server_sync = in_server_sync;
      tmp._variable = in_variable;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareFunctionVariable> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareFunctionVariable> _dataCaches = null;
    public static Dictionary<int, DeclareFunctionVariable> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataFunctionVariable");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataFunctionVariable = require 'Lua/Config/DataFunctionVariable'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataFunctionVariable");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareFunctionVariable>(202);
                     foreach (var item in dic)
                     {
                         DeclareFunctionVariable tmp = new DeclareFunctionVariable();
                       tmp.ServerSync = item.Value[0];
                       tmp.Variable = item.Value[1];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"FunctionVariable");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareFunctionVariable>(202);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"FunctionVariable");
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
    public static DeclareFunctionVariable Get(int id)
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
    public static void Transform(Dictionary<int, DeclareFunctionVariable> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
