//文件是自动生成,请勿手动修改.来自数据文件:guild_trial
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareGuildTrial")]
  public class DeclareGuildTrial
  {
    #region //私有变量定义
    //进入竞拍的掉落ID
    private int _auction;
    //bossID
    private int _bOSS_ID;
    //在伙伴界面中伙伴模型显示缩放（默认为100）(hide)
    private int _camera_size;
    //等级段
    private int _num;
    //出生坐标x_y(@_@)
    private string _pos;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Auction", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Auction { get{ return _auction; } set{ _auction=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"BOSSID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BOSSID { get{ return _bOSS_ID; } set{ _bOSS_ID=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"CameraSize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CameraSize { get{ return _camera_size; } set{ _camera_size=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Num { get{ return _num; } set{ _num=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Pos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Pos { get{ return _pos; } set{ _pos=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareGuildTrial Create( int in_auction, int in_bOSS_ID, int in_camera_size, int in_num, string in_pos )
    {
      DeclareGuildTrial tmp = new DeclareGuildTrial();
      tmp._auction = in_auction;
      tmp._bOSS_ID = in_bOSS_ID;
      tmp._camera_size = in_camera_size;
      tmp._num = in_num;
      tmp._pos = in_pos;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareGuildTrial> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareGuildTrial> _dataCaches = null;
    public static Dictionary<int, DeclareGuildTrial> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGuildTrial");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataGuildTrial = require 'Lua/Config/DataGuildTrial'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGuildTrial");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareGuildTrial>(13);
                     foreach (var item in dic)
                     {
                         DeclareGuildTrial tmp = new DeclareGuildTrial();
                       tmp.Auction = item.Value[0];
                       tmp.BOSSID = item.Value[1];
                       tmp.CameraSize = item.Value[2];
                       tmp.Num = item.Value[3];
                       tmp.Pos = CfgStringLua.Get(item.Value[4]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"GuildTrial");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareGuildTrial>(13);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"GuildTrial");
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
    public static DeclareGuildTrial Get(int id)
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
    public static void Transform(Dictionary<int, DeclareGuildTrial> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
