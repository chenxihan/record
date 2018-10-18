//文件是自动生成,请勿手动修改.来自数据文件:RandTips
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareRandTips")]
  public class DeclareRandTips
  {
    #region //私有变量定义
    //ID
    private int _id;
    //其他完成的条件，类型_取值;类型_取值；0：首冲，取值随意；1：续充，取值表示需要续充的次数（暂时无用）； 2：加入公会，取值随意；3：VIP等级，取值表示需要的vip等级；4：成长基金，取值随意；5：钻石投资，取值0表示没有投资，大于0表示当前投资的等级；6：结婚，取值随意
    private string _other_finish;
    //其他未完成的条件，类型_取值;类型_取值；配置方式同左
    private string _other_not_finish;
    //完成的任务id，0为不限制
    private int _rand_finish_task;
    //最高等级，0为不限制
    private int _rand_level_max;
    //最低等级，0为不限制
    private int _rand_level_min;
    //未完成的任务id，0为不限制
    private int _rand_not_finish_task;
    //随机权重，必须大于0
    private int _rand_weight;
    //显示的时间，单位毫秒
    private int _show_time;
    //显示类型，0随机式（在所有满足需求的配置里边根据权重随机），1：触发式（根据触发类型和参数触发）
    private int _show_type;
    //文字内容
    private string _tips;
    //触发参数，只适用于触发类型，类型_参数；0,完成任务，参数=任务id；1，到达等级，参数=等级；2，开启功能，参数=功能id
    private string _trigger_param;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"OtherFinish", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OtherFinish { get{ return _other_finish; } set{ _other_finish=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"OtherNotFinish", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OtherNotFinish { get{ return _other_not_finish; } set{ _other_not_finish=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"RandFinishTask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int RandFinishTask { get{ return _rand_finish_task; } set{ _rand_finish_task=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"RandLevelMax", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int RandLevelMax { get{ return _rand_level_max; } set{ _rand_level_max=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"RandLevelMin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int RandLevelMin { get{ return _rand_level_min; } set{ _rand_level_min=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"RandNotFinishTask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int RandNotFinishTask { get{ return _rand_not_finish_task; } set{ _rand_not_finish_task=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"RandWeight", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int RandWeight { get{ return _rand_weight; } set{ _rand_weight=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"ShowTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ShowTime { get{ return _show_time; } set{ _show_time=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"ShowType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ShowType { get{ return _show_type; } set{ _show_type=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Tips", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Tips { get{ return _tips; } set{ _tips=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"TriggerParam", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TriggerParam { get{ return _trigger_param; } set{ _trigger_param=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareRandTips Create( int in_id, string in_other_finish, string in_other_not_finish, int in_rand_finish_task, int in_rand_level_max, int in_rand_level_min, int in_rand_not_finish_task, int in_rand_weight, int in_show_time, int in_show_type, string in_tips, string in_trigger_param )
    {
      DeclareRandTips tmp = new DeclareRandTips();
      tmp._id = in_id;
      tmp._other_finish = in_other_finish;
      tmp._other_not_finish = in_other_not_finish;
      tmp._rand_finish_task = in_rand_finish_task;
      tmp._rand_level_max = in_rand_level_max;
      tmp._rand_level_min = in_rand_level_min;
      tmp._rand_not_finish_task = in_rand_not_finish_task;
      tmp._rand_weight = in_rand_weight;
      tmp._show_time = in_show_time;
      tmp._show_type = in_show_type;
      tmp._tips = in_tips;
      tmp._trigger_param = in_trigger_param;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareRandTips> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareRandTips> _dataCaches = null;
    public static Dictionary<int, DeclareRandTips> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataRandTips");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataRandTips = require 'Lua/Config/DataRandTips'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataRandTips");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareRandTips>(22);
                     foreach (var item in dic)
                     {
                         DeclareRandTips tmp = new DeclareRandTips();
                       tmp.Id = item.Value[0];
                       tmp.OtherFinish = CfgStringLua.Get(item.Value[1]);
                       tmp.OtherNotFinish = CfgStringLua.Get(item.Value[2]);
                       tmp.RandFinishTask = item.Value[3];
                       tmp.RandLevelMax = item.Value[4];
                       tmp.RandLevelMin = item.Value[5];
                       tmp.RandNotFinishTask = item.Value[6];
                       tmp.RandWeight = item.Value[7];
                       tmp.ShowTime = item.Value[8];
                       tmp.ShowType = item.Value[9];
                       tmp.Tips = CfgStringLua.Get(item.Value[10]);
                       tmp.TriggerParam = CfgStringLua.Get(item.Value[11]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"RandTips");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareRandTips>(22);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"RandTips");
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
    public static DeclareRandTips Get(int id)
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
    public static void Transform(Dictionary<int, DeclareRandTips> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
