//文件是自动生成,请勿手动修改.来自数据文件:master_target
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareMasterTarget")]
  public class DeclareMasterTarget
  {
    #region //私有变量定义
    //描述 hide
    private string _describe;
    //目标ID（type*100+level）
    private int _id;
    //分级
    private int _level;
    //徒弟奖励学分
    private int _rewards;
    //目标（FunctionVariable表中ID_值）(@_@)
    private string _target;
    //目标归类（同一个大类下的目标在前一个目标完成之后再显示下一个目标）
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Describe", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Describe { get{ return _describe; } set{ _describe=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Rewards", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Rewards { get{ return _rewards; } set{ _rewards=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Target", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Target { get{ return _target; } set{ _target=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareMasterTarget Create( string in_describe, int in_id, int in_level, int in_rewards, string in_target, int in_type )
    {
      DeclareMasterTarget tmp = new DeclareMasterTarget();
      tmp._describe = in_describe;
      tmp._id = in_id;
      tmp._level = in_level;
      tmp._rewards = in_rewards;
      tmp._target = in_target;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareMasterTarget> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareMasterTarget> _dataCaches = null;
    public static Dictionary<int, DeclareMasterTarget> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMasterTarget");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataMasterTarget = require 'Lua/Config/DataMasterTarget'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMasterTarget");                  }

                 if (dic != null)
                 {
                              _dataCaches = new Dictionary<int, DeclareMasterTarget>();
                     foreach (var item in dic)
                     {
                         DeclareMasterTarget tmp = new DeclareMasterTarget();
                       tmp.Describe = CfgStringLua.Get(item.Value[0]);
                       tmp.Id = item.Value[1];
                       tmp.Level = item.Value[2];
                       tmp.Rewards = item.Value[3];
                       tmp.Target = CfgStringLua.Get(item.Value[4]);
                       tmp.Type = item.Value[5];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"MasterTarget");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareMasterTarget>();
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"MasterTarget");
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
    public static DeclareMasterTarget Get(int id)
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
    public static void Transform(Dictionary<int, DeclareMasterTarget> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
