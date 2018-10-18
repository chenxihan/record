//文件是自动生成,请勿手动修改.来自数据文件:PictureTitle
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclarePictureTitle")]
  public class DeclarePictureTitle
  {
    #region //私有变量定义
    //激活描述(hide)
    private string _active_desc;
    //是否在列表中显示(0否1是)
    private int _canShow;
    //称号ID
    private int _id;
    //称号名称
    private string _name;
    //点击前往打开的功能
    private int _open_func;
    //点击前往打开的功能参数
    private int _open_func_param;
    //称号属性(@;@_@)
    private string _property;
    //称号图片资源
    private int _textrue;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ActiveDesc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ActiveDesc { get{ return _active_desc; } set{ _active_desc=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"CanShow", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanShow { get{ return _canShow; } set{ _canShow=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"OpenFunc", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OpenFunc { get{ return _open_func; } set{ _open_func=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"OpenFuncParam", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OpenFuncParam { get{ return _open_func_param; } set{ _open_func_param=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Property", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Property { get{ return _property; } set{ _property=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Textrue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Textrue { get{ return _textrue; } set{ _textrue=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclarePictureTitle Create( string in_active_desc, int in_canShow, int in_id, string in_name, int in_open_func, int in_open_func_param, string in_property, int in_textrue )
    {
      DeclarePictureTitle tmp = new DeclarePictureTitle();
      tmp._active_desc = in_active_desc;
      tmp._canShow = in_canShow;
      tmp._id = in_id;
      tmp._name = in_name;
      tmp._open_func = in_open_func;
      tmp._open_func_param = in_open_func_param;
      tmp._property = in_property;
      tmp._textrue = in_textrue;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclarePictureTitle> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclarePictureTitle> _dataCaches = null;
    public static Dictionary<int, DeclarePictureTitle> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPictureTitle");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataPictureTitle = require 'Lua/Config/DataPictureTitle'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPictureTitle");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclarePictureTitle>(83);
                     foreach (var item in dic)
                     {
                         DeclarePictureTitle tmp = new DeclarePictureTitle();
                       tmp.ActiveDesc = CfgStringLua.Get(item.Value[0]);
                       tmp.CanShow = item.Value[1];
                       tmp.Id = item.Value[2];
                       tmp.Name = CfgStringLua.Get(item.Value[3]);
                       tmp.OpenFunc = item.Value[4];
                       tmp.OpenFuncParam = item.Value[5];
                       tmp.Property = CfgStringLua.Get(item.Value[6]);
                       tmp.Textrue = item.Value[7];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"PictureTitle");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclarePictureTitle>(83);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"PictureTitle");
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
    public static DeclarePictureTitle Get(int id)
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
    public static void Transform(Dictionary<int, DeclarePictureTitle> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
