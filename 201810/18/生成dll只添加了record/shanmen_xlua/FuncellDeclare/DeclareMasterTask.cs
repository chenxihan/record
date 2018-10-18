//文件是自动生成,请勿手动修改.来自数据文件:master_task
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareMasterTask")]
  public class DeclareMasterTask
  {
    #region //私有变量定义
    //副本group_id
    private int _cloneGroupID;
    //描述 hide
    private string _describe;
    //目标ID
    private int _id;
    //打开界面ID
    private int _openUI;
    //完成后奖励(@;@_@)
    private string _rewards;
    //目标（FunctionVariable表中ID_值）(@_@)
    private string _target;
    //1.导师日常；2.学徒日常
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"CloneGroupID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CloneGroupID { get{ return _cloneGroupID; } set{ _cloneGroupID=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Describe", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Describe { get{ return _describe; } set{ _describe=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"OpenUI", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OpenUI { get{ return _openUI; } set{ _openUI=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Rewards", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Rewards { get{ return _rewards; } set{ _rewards=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Target", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Target { get{ return _target; } set{ _target=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareMasterTask Create( int in_cloneGroupID, string in_describe, int in_id, int in_openUI, string in_rewards, string in_target, int in_type )
    {
      DeclareMasterTask tmp = new DeclareMasterTask();
      tmp._cloneGroupID = in_cloneGroupID;
      tmp._describe = in_describe;
      tmp._id = in_id;
      tmp._openUI = in_openUI;
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
    public delegate void OnFillDataHandler(Dictionary<int, DeclareMasterTask> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareMasterTask> _dataCaches = null;
    public static Dictionary<int, DeclareMasterTask> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMasterTask");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataMasterTask = require 'Lua/Config/DataMasterTask'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMasterTask");                  }

                 if (dic != null)
                 {
                              _dataCaches = new Dictionary<int, DeclareMasterTask>();
                     foreach (var item in dic)
                     {
                         DeclareMasterTask tmp = new DeclareMasterTask();
                       tmp.CloneGroupID = item.Value[0];
                       tmp.Describe = CfgStringLua.Get(item.Value[1]);
                       tmp.Id = item.Value[2];
                       tmp.OpenUI = item.Value[3];
                       tmp.Rewards = CfgStringLua.Get(item.Value[4]);
                       tmp.Target = CfgStringLua.Get(item.Value[5]);
                       tmp.Type = item.Value[6];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"MasterTask");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareMasterTask>();
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"MasterTask");
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
    public static DeclareMasterTask Get(int id)
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
    public static void Transform(Dictionary<int, DeclareMasterTask> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
