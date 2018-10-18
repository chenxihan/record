//文件是自动生成,请勿手动修改.来自数据文件:Cinematic
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareCinematic")]
  public class DeclareCinematic
  {
    #region //私有变量定义
    //剧情播完后角色位置（不做传送则留空）(@_@)
    private string _flyTo;
    //ID
    private int _id;
    //剧情文件名 hide
    private string _path;
    //是否能跳过
    //（0或者不填：能跳过；
    //1 ：不能跳过；）
    private int _skip;
    //剧情开启前播放渐变效果
    //（0或者不填：无效果；
    //1：播放渐变效果）
    private int _toBlack;
    //触发条件（任务1， 场景2， 其他3, 未知0）
    private int _type;
    //任务id/场景id/其他 等
    private int _type_id;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"FlyTo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string FlyTo { get{ return _flyTo; } set{ _flyTo=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Path", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Path { get{ return _path; } set{ _path=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Skip", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Skip { get{ return _skip; } set{ _skip=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"ToBlack", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ToBlack { get{ return _toBlack; } set{ _toBlack=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"TypeId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TypeId { get{ return _type_id; } set{ _type_id=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareCinematic Create( string in_flyTo, int in_id, string in_path, int in_skip, int in_toBlack, int in_type, int in_type_id )
    {
      DeclareCinematic tmp = new DeclareCinematic();
      tmp._flyTo = in_flyTo;
      tmp._id = in_id;
      tmp._path = in_path;
      tmp._skip = in_skip;
      tmp._toBlack = in_toBlack;
      tmp._type = in_type;
      tmp._type_id = in_type_id;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareCinematic> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareCinematic> _dataCaches = null;
    public static Dictionary<int, DeclareCinematic> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataCinematic");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataCinematic = require 'Lua/Config/DataCinematic'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataCinematic");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareCinematic>(25);
                     foreach (var item in dic)
                     {
                         DeclareCinematic tmp = new DeclareCinematic();
                       tmp.FlyTo = CfgStringLua.Get(item.Value[0]);
                       tmp.Id = item.Value[1];
                       tmp.Path = CfgStringLua.Get(item.Value[2]);
                       tmp.Skip = item.Value[3];
                       tmp.ToBlack = item.Value[4];
                       tmp.Type = item.Value[5];
                       tmp.TypeId = item.Value[6];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Cinematic");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareCinematic>(25);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Cinematic");
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
    public static DeclareCinematic Get(int id)
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
    public static void Transform(Dictionary<int, DeclareCinematic> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
