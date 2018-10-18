//文件是自动生成,请勿手动修改.来自数据文件:TaskSort
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareTaskSort")]
  public class DeclareTaskSort
  {
    #region //私有变量定义
    //已完成排序值（值越小排序越前）
    private int _finish_value;
    //未完成排序值（值越小排序越前）
    private int _not_finish_value;
    //ID
    private int _task_type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"FinishValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int FinishValue { get{ return _finish_value; } set{ _finish_value=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"NotFinishValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NotFinishValue { get{ return _not_finish_value; } set{ _not_finish_value=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"TaskType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TaskType { get{ return _task_type; } set{ _task_type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareTaskSort Create( int in_finish_value, int in_not_finish_value, int in_task_type )
    {
      DeclareTaskSort tmp = new DeclareTaskSort();
      tmp._finish_value = in_finish_value;
      tmp._not_finish_value = in_not_finish_value;
      tmp._task_type = in_task_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareTaskSort> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareTaskSort> _dataCaches = null;
    public static Dictionary<int, DeclareTaskSort> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTaskSort");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataTaskSort = require 'Lua/Config/DataTaskSort'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTaskSort");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareTaskSort>(12);
                     foreach (var item in dic)
                     {
                         DeclareTaskSort tmp = new DeclareTaskSort();
                       tmp.FinishValue = item.Value[0];
                       tmp.NotFinishValue = item.Value[1];
                       tmp.TaskType = item.Value[2];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"TaskSort");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareTaskSort>(12);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"TaskSort");
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
    public static DeclareTaskSort Get(int id)
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
    public static void Transform(Dictionary<int, DeclareTaskSort> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
