//文件是自动生成,请勿手动修改.来自数据文件:photoFilter
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclarePhotoFilter")]
  public class DeclarePhotoFilter
  {
    #region //私有变量定义
    //模糊迭代1-30
    private int _blurIterations;
    //模糊大小
    private int _blurSize;
    //下样品因素
    private int _downSampleFactor;
    //编号
    private int _id;
    //强度
    private int _intensity;
    //滤镜名字
    private string _name;
    //阈值
    private int _threshhold;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"BlurIterations", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BlurIterations { get{ return _blurIterations; } set{ _blurIterations=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"BlurSize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BlurSize { get{ return _blurSize; } set{ _blurSize=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"DownSampleFactor", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DownSampleFactor { get{ return _downSampleFactor; } set{ _downSampleFactor=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Intensity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Intensity { get{ return _intensity; } set{ _intensity=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Threshhold", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Threshhold { get{ return _threshhold; } set{ _threshhold=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclarePhotoFilter Create( int in_blurIterations, int in_blurSize, int in_downSampleFactor, int in_id, int in_intensity, string in_name, int in_threshhold )
    {
      DeclarePhotoFilter tmp = new DeclarePhotoFilter();
      tmp._blurIterations = in_blurIterations;
      tmp._blurSize = in_blurSize;
      tmp._downSampleFactor = in_downSampleFactor;
      tmp._id = in_id;
      tmp._intensity = in_intensity;
      tmp._name = in_name;
      tmp._threshhold = in_threshhold;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclarePhotoFilter> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclarePhotoFilter> _dataCaches = null;
    public static Dictionary<int, DeclarePhotoFilter> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPhotoFilter");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataPhotoFilter = require 'Lua/Config/DataPhotoFilter'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPhotoFilter");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclarePhotoFilter>(5);
                     foreach (var item in dic)
                     {
                         DeclarePhotoFilter tmp = new DeclarePhotoFilter();
                       tmp.BlurIterations = item.Value[0];
                       tmp.BlurSize = item.Value[1];
                       tmp.DownSampleFactor = item.Value[2];
                       tmp.Id = item.Value[3];
                       tmp.Intensity = item.Value[4];
                       tmp.Name = CfgStringLua.Get(item.Value[5]);
                       tmp.Threshhold = item.Value[6];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"PhotoFilter");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclarePhotoFilter>(5);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"PhotoFilter");
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
    public static DeclarePhotoFilter Get(int id)
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
    public static void Transform(Dictionary<int, DeclarePhotoFilter> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
