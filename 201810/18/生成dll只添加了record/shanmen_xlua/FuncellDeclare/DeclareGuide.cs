//文件是自动生成,请勿手动修改.来自数据文件:Guide
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareGuide")]
  public class DeclareGuide
  {
    #region //私有变量定义
    //本引导结束后继续执行的引导id
    private int _continueGuide;
    //是否继续任务（0否，1是）
    private int _continueTask;
    //引导ID
    private int _id;
    //可以触发引导的最高等级，没有就配0
    private int _limit_level_max;
    //可以触发引导的最低等级，没有就配0
    private int _limit_level_min;
    //直接打开的功能ID，值参考FunctionStart表
    private int _open_function;
    //打开功能ID参数(副本group_id)
    private int _open_function_param;
    //引导步骤
    private string _steps;
    //触发参数,根据类型决定取值，1功能ID，2等级，3任务ID，4进入地图ID，5打开主界面引导ID,6获得物品ID，7宠物ID，8装备ID
    private int _trigger_param;
    //触发类型,1功能开启，2等级达到多少级，3任务完成，4进入地图，5打开主界面快速提示引导，6获得新物品,7发现宠物,8引导查看新获取的装备属性，9打开离线经验不足界面,10点击打开UI任务的引导，11接受任务引导
    private int _trigger_type;
    //引导类型，0非强制引导，1强制引导
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ContinueGuide", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ContinueGuide { get{ return _continueGuide; } set{ _continueGuide=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"ContinueTask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ContinueTask { get{ return _continueTask; } set{ _continueTask=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"LimitLevelMax", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int LimitLevelMax { get{ return _limit_level_max; } set{ _limit_level_max=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"LimitLevelMin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int LimitLevelMin { get{ return _limit_level_min; } set{ _limit_level_min=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"OpenFunction", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OpenFunction { get{ return _open_function; } set{ _open_function=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"OpenFunctionParam", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OpenFunctionParam { get{ return _open_function_param; } set{ _open_function_param=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Steps", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Steps { get{ return _steps; } set{ _steps=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"TriggerParam", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TriggerParam { get{ return _trigger_param; } set{ _trigger_param=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"TriggerType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TriggerType { get{ return _trigger_type; } set{ _trigger_type=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareGuide Create( int in_continueGuide, int in_continueTask, int in_id, int in_limit_level_max, int in_limit_level_min, int in_open_function, int in_open_function_param, string in_steps, int in_trigger_param, int in_trigger_type, int in_type )
    {
      DeclareGuide tmp = new DeclareGuide();
      tmp._continueGuide = in_continueGuide;
      tmp._continueTask = in_continueTask;
      tmp._id = in_id;
      tmp._limit_level_max = in_limit_level_max;
      tmp._limit_level_min = in_limit_level_min;
      tmp._open_function = in_open_function;
      tmp._open_function_param = in_open_function_param;
      tmp._steps = in_steps;
      tmp._trigger_param = in_trigger_param;
      tmp._trigger_type = in_trigger_type;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareGuide> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareGuide> _dataCaches = null;
    public static Dictionary<int, DeclareGuide> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGuide");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataGuide = require 'Lua/Config/DataGuide'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGuide");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareGuide>(51);
                     foreach (var item in dic)
                     {
                         DeclareGuide tmp = new DeclareGuide();
                       tmp.ContinueGuide = item.Value[0];
                       tmp.ContinueTask = item.Value[1];
                       tmp.Id = item.Value[2];
                       tmp.LimitLevelMax = item.Value[3];
                       tmp.LimitLevelMin = item.Value[4];
                       tmp.OpenFunction = item.Value[5];
                       tmp.OpenFunctionParam = item.Value[6];
                       tmp.Steps = CfgStringLua.Get(item.Value[7]);
                       tmp.TriggerParam = item.Value[8];
                       tmp.TriggerType = item.Value[9];
                       tmp.Type = item.Value[10];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Guide");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareGuide>(51);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Guide");
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
    public static DeclareGuide Get(int id)
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
    public static void Transform(Dictionary<int, DeclareGuide> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
