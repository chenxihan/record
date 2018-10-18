//文件是自动生成,请勿手动修改.来自数据文件:courage
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareCourage")]
  public class DeclareCourage
  {
    #region //私有变量定义
    //副本的类型
    private int _clone_type;
    //每一次获得的点数
    private int _deal;
    //描述 hide
    private string _desc;
    //图标 hide
    private int _icon;
    //id
    private int _id;
    //每日上限
    private int _max;
    //打开界面 hide
    private int _open_ui;
    //打开界面参数 hide
    private int _open_ui_param;
    //参数1
    private int _param1;
    //参数2
    private int _param2;
    //参数3
    private int _param3;
    //参数4
    private int _param4;
    //标题hide
    private string _title;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"CloneType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CloneType { get{ return _clone_type; } set{ _clone_type=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Deal", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Deal { get{ return _deal; } set{ _deal=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Desc { get{ return _desc; } set{ _desc=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Max", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Max { get{ return _max; } set{ _max=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"OpenUi", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OpenUi { get{ return _open_ui; } set{ _open_ui=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"OpenUiParam", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OpenUiParam { get{ return _open_ui_param; } set{ _open_ui_param=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Param1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Param1 { get{ return _param1; } set{ _param1=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Param2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Param2 { get{ return _param2; } set{ _param2=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Param3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Param3 { get{ return _param3; } set{ _param3=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"Param4", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Param4 { get{ return _param4; } set{ _param4=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"Title", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Title { get{ return _title; } set{ _title=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareCourage Create( int in_clone_type, int in_deal, string in_desc, int in_icon, int in_id, int in_max, int in_open_ui, int in_open_ui_param, int in_param1, int in_param2, int in_param3, int in_param4, string in_title )
    {
      DeclareCourage tmp = new DeclareCourage();
      tmp._clone_type = in_clone_type;
      tmp._deal = in_deal;
      tmp._desc = in_desc;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._max = in_max;
      tmp._open_ui = in_open_ui;
      tmp._open_ui_param = in_open_ui_param;
      tmp._param1 = in_param1;
      tmp._param2 = in_param2;
      tmp._param3 = in_param3;
      tmp._param4 = in_param4;
      tmp._title = in_title;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareCourage> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareCourage> _dataCaches = null;
    public static Dictionary<int, DeclareCourage> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataCourage");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataCourage = require 'Lua/Config/DataCourage'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataCourage");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareCourage>(3);
                     foreach (var item in dic)
                     {
                         DeclareCourage tmp = new DeclareCourage();
                       tmp.CloneType = item.Value[0];
                       tmp.Deal = item.Value[1];
                       tmp.Desc = CfgStringLua.Get(item.Value[2]);
                       tmp.Icon = item.Value[3];
                       tmp.Id = item.Value[4];
                       tmp.Max = item.Value[5];
                       tmp.OpenUi = item.Value[6];
                       tmp.OpenUiParam = item.Value[7];
                       tmp.Param1 = item.Value[8];
                       tmp.Param2 = item.Value[9];
                       tmp.Param3 = item.Value[10];
                       tmp.Param4 = item.Value[11];
                       tmp.Title = CfgStringLua.Get(item.Value[12]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Courage");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareCourage>(3);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Courage");
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
    public static DeclareCourage Get(int id)
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
    public static void Transform(Dictionary<int, DeclareCourage> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
