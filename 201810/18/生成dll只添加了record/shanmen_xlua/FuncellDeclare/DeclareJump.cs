//文件是自动生成,请勿手动修改.来自数据文件:Jump
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareJump")]
  public class DeclareJump
  {
    #region //私有变量定义
    //轻功动画(hide)
    private string _aniID;
    //轻功落下加速度（厘米）
    private int _endAddSpeed;
    //轻功后段的最大距离（厘米）
    private int _endMaxDis;
    //轻功落下初始速度（厘米）
    private int _endSpeed;
    //是否有结束段
    private int _haveEnd;
    //轻功飞行的最大高度（厘米）
    private int _maxHeight;
    //跳跃阶段
    private int _stage;
    //轻功前段的曲线(hide)
    private string _startCurve;
    //轻功前段的最大距离（厘米）
    private int _startMaxDis;
    //轻功前段的时间（毫秒）
    private int _startTime;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"AniID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string AniID { get{ return _aniID; } set{ _aniID=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"EndAddSpeed", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int EndAddSpeed { get{ return _endAddSpeed; } set{ _endAddSpeed=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"EndMaxDis", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int EndMaxDis { get{ return _endMaxDis; } set{ _endMaxDis=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"EndSpeed", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int EndSpeed { get{ return _endSpeed; } set{ _endSpeed=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"HaveEnd", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int HaveEnd { get{ return _haveEnd; } set{ _haveEnd=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"MaxHeight", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MaxHeight { get{ return _maxHeight; } set{ _maxHeight=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Stage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Stage { get{ return _stage; } set{ _stage=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"StartCurve", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string StartCurve { get{ return _startCurve; } set{ _startCurve=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"StartMaxDis", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int StartMaxDis { get{ return _startMaxDis; } set{ _startMaxDis=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"StartTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int StartTime { get{ return _startTime; } set{ _startTime=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareJump Create( string in_aniID, int in_endAddSpeed, int in_endMaxDis, int in_endSpeed, int in_haveEnd, int in_maxHeight, int in_stage, string in_startCurve, int in_startMaxDis, int in_startTime )
    {
      DeclareJump tmp = new DeclareJump();
      tmp._aniID = in_aniID;
      tmp._endAddSpeed = in_endAddSpeed;
      tmp._endMaxDis = in_endMaxDis;
      tmp._endSpeed = in_endSpeed;
      tmp._haveEnd = in_haveEnd;
      tmp._maxHeight = in_maxHeight;
      tmp._stage = in_stage;
      tmp._startCurve = in_startCurve;
      tmp._startMaxDis = in_startMaxDis;
      tmp._startTime = in_startTime;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareJump> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareJump> _dataCaches = null;
    public static Dictionary<int, DeclareJump> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataJump");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataJump = require 'Lua/Config/DataJump'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataJump");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareJump>(3);
                     foreach (var item in dic)
                     {
                         DeclareJump tmp = new DeclareJump();
                       tmp.AniID = CfgStringLua.Get(item.Value[0]);
                       tmp.EndAddSpeed = item.Value[1];
                       tmp.EndMaxDis = item.Value[2];
                       tmp.EndSpeed = item.Value[3];
                       tmp.HaveEnd = item.Value[4];
                       tmp.MaxHeight = item.Value[5];
                       tmp.Stage = item.Value[6];
                       tmp.StartCurve = CfgStringLua.Get(item.Value[7]);
                       tmp.StartMaxDis = item.Value[8];
                       tmp.StartTime = item.Value[9];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Jump");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareJump>(3);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Jump");
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
    public static DeclareJump Get(int id)
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
    public static void Transform(Dictionary<int, DeclareJump> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
