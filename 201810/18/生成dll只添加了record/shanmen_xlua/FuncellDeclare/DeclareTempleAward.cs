//文件是自动生成,请勿手动修改.来自数据文件:templeAward
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareTempleAward")]
  public class DeclareTempleAward
  {
    #region //私有变量定义
    //奖励(@;@_@)
    private string _award;
    //奖励唯一di
    private int _id;
    //领取奖励所需积分
    private int _point;
    //神殿进度
    private int _process;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Award", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Award { get{ return _award; } set{ _award=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Point", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Point { get{ return _point; } set{ _point=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Process", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Process { get{ return _process; } set{ _process=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareTempleAward Create( string in_award, int in_id, int in_point, int in_process )
    {
      DeclareTempleAward tmp = new DeclareTempleAward();
      tmp._award = in_award;
      tmp._id = in_id;
      tmp._point = in_point;
      tmp._process = in_process;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareTempleAward> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareTempleAward> _dataCaches = null;
    public static Dictionary<int, DeclareTempleAward> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTempleAward");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataTempleAward = require 'Lua/Config/DataTempleAward'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTempleAward");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareTempleAward>(45);
                     foreach (var item in dic)
                     {
                         DeclareTempleAward tmp = new DeclareTempleAward();
                       tmp.Award = CfgStringLua.Get(item.Value[0]);
                       tmp.Id = item.Value[1];
                       tmp.Point = item.Value[2];
                       tmp.Process = item.Value[3];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"TempleAward");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareTempleAward>(45);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"TempleAward");
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
    public static DeclareTempleAward Get(int id)
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
    public static void Transform(Dictionary<int, DeclareTempleAward> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
