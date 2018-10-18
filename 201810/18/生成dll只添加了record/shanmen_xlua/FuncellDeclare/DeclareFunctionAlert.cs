//文件是自动生成,请勿手动修改.来自数据文件:FunctionAlert
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareFunctionAlert")]
  public class DeclareFunctionAlert
  {
    #region //私有变量定义
    //执行的功能ID
    private int _do_function_id;
    //icon
    private string _icon;
    //ID
    private int _id;
    //显示的最大等级（0表示不限制）
    private int _level_max;
    //显示的最小等级（0表示不限制）
    private int _level_min;
    //优先级（值越小越靠前）
    private int _priority_level;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"DoFunctionId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DoFunctionId { get{ return _do_function_id; } set{ _do_function_id=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"LevelMax", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int LevelMax { get{ return _level_max; } set{ _level_max=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"LevelMin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int LevelMin { get{ return _level_min; } set{ _level_min=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"PriorityLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PriorityLevel { get{ return _priority_level; } set{ _priority_level=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareFunctionAlert Create( int in_do_function_id, string in_icon, int in_id, int in_level_max, int in_level_min, int in_priority_level )
    {
      DeclareFunctionAlert tmp = new DeclareFunctionAlert();
      tmp._do_function_id = in_do_function_id;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._level_max = in_level_max;
      tmp._level_min = in_level_min;
      tmp._priority_level = in_priority_level;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareFunctionAlert> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareFunctionAlert> _dataCaches = null;
    public static Dictionary<int, DeclareFunctionAlert> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataFunctionAlert");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataFunctionAlert = require 'Lua/Config/DataFunctionAlert'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataFunctionAlert");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareFunctionAlert>(41);
                     foreach (var item in dic)
                     {
                         DeclareFunctionAlert tmp = new DeclareFunctionAlert();
                       tmp.DoFunctionId = item.Value[0];
                       tmp.Icon = CfgStringLua.Get(item.Value[1]);
                       tmp.Id = item.Value[2];
                       tmp.LevelMax = item.Value[3];
                       tmp.LevelMin = item.Value[4];
                       tmp.PriorityLevel = item.Value[5];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"FunctionAlert");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareFunctionAlert>(41);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"FunctionAlert");
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
    public static DeclareFunctionAlert Get(int id)
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
    public static void Transform(Dictionary<int, DeclareFunctionAlert> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
