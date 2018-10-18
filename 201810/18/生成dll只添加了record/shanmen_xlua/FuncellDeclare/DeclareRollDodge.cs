//文件是自动生成,请勿手动修改.来自数据文件:RollDodge
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareRollDodge")]
  public class DeclareRollDodge
  {
    #region //私有变量定义
    //翻滚CD，单位毫秒
    private int _cd_time;
    //执行时间，单位毫秒
    private int _execute_time;
    //翻滚等级
    private int _level;
    //翻滚最大距离，单位厘米
    private int _max_dis;
    //霸体时间，单位毫秒
    private int _super_armor_time;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"CdTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CdTime { get{ return _cd_time; } set{ _cd_time=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"ExecuteTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ExecuteTime { get{ return _execute_time; } set{ _execute_time=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"MaxDis", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MaxDis { get{ return _max_dis; } set{ _max_dis=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"SuperArmorTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SuperArmorTime { get{ return _super_armor_time; } set{ _super_armor_time=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareRollDodge Create( int in_cd_time, int in_execute_time, int in_level, int in_max_dis, int in_super_armor_time )
    {
      DeclareRollDodge tmp = new DeclareRollDodge();
      tmp._cd_time = in_cd_time;
      tmp._execute_time = in_execute_time;
      tmp._level = in_level;
      tmp._max_dis = in_max_dis;
      tmp._super_armor_time = in_super_armor_time;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareRollDodge> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareRollDodge> _dataCaches = null;
    public static Dictionary<int, DeclareRollDodge> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataRollDodge");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataRollDodge = require 'Lua/Config/DataRollDodge'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataRollDodge");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareRollDodge>(10);
                     foreach (var item in dic)
                     {
                         DeclareRollDodge tmp = new DeclareRollDodge();
                       tmp.CdTime = item.Value[0];
                       tmp.ExecuteTime = item.Value[1];
                       tmp.Level = item.Value[2];
                       tmp.MaxDis = item.Value[3];
                       tmp.SuperArmorTime = item.Value[4];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"RollDodge");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareRollDodge>(10);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"RollDodge");
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
    public static DeclareRollDodge Get(int id)
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
    public static void Transform(Dictionary<int, DeclareRollDodge> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
