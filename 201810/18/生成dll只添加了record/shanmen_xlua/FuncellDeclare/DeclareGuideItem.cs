//文件是自动生成,请勿手动修改.来自数据文件:GuideItem
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareGuideItem")]
  public class DeclareGuideItem
  {
    #region //私有变量定义
    //箭头指向的方向（0左边；1右边，2上，3下）
    private int _arow_dir;
    //是否可以忽略本次引导0不可以，1可以
    private int _can_ignore;
    //对话内容
    private string _dialog;
    //引导ID
    private int _id;
    //引导参数1；距离屏幕顶部的距离
    private string _param1;
    //引导参数2；距离屏幕低部的距离
    private string _param2;
    //引导参数3；距离屏幕左边的距离
    private string _param3;
    //引导参数4；距离屏幕右边的距离
    private string _param4;
    //引导参数5
    private string _param5;
    //播放的音效
    private string _sound;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ArowDir", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ArowDir { get{ return _arow_dir; } set{ _arow_dir=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"CanIgnore", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanIgnore { get{ return _can_ignore; } set{ _can_ignore=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Dialog", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Dialog { get{ return _dialog; } set{ _dialog=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Param1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Param1 { get{ return _param1; } set{ _param1=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Param2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Param2 { get{ return _param2; } set{ _param2=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Param3", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Param3 { get{ return _param3; } set{ _param3=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Param4", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Param4 { get{ return _param4; } set{ _param4=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Param5", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Param5 { get{ return _param5; } set{ _param5=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Sound", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Sound { get{ return _sound; } set{ _sound=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareGuideItem Create( int in_arow_dir, int in_can_ignore, string in_dialog, int in_id, string in_param1, string in_param2, string in_param3, string in_param4, string in_param5, string in_sound )
    {
      DeclareGuideItem tmp = new DeclareGuideItem();
      tmp._arow_dir = in_arow_dir;
      tmp._can_ignore = in_can_ignore;
      tmp._dialog = in_dialog;
      tmp._id = in_id;
      tmp._param1 = in_param1;
      tmp._param2 = in_param2;
      tmp._param3 = in_param3;
      tmp._param4 = in_param4;
      tmp._param5 = in_param5;
      tmp._sound = in_sound;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareGuideItem> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareGuideItem> _dataCaches = null;
    public static Dictionary<int, DeclareGuideItem> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGuideItem");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataGuideItem = require 'Lua/Config/DataGuideItem'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGuideItem");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareGuideItem>(113);
                     foreach (var item in dic)
                     {
                         DeclareGuideItem tmp = new DeclareGuideItem();
                       tmp.ArowDir = item.Value[0];
                       tmp.CanIgnore = item.Value[1];
                       tmp.Dialog = CfgStringLua.Get(item.Value[2]);
                       tmp.Id = item.Value[3];
                       tmp.Param1 = CfgStringLua.Get(item.Value[4]);
                       tmp.Param2 = CfgStringLua.Get(item.Value[5]);
                       tmp.Param3 = CfgStringLua.Get(item.Value[6]);
                       tmp.Param4 = CfgStringLua.Get(item.Value[7]);
                       tmp.Param5 = CfgStringLua.Get(item.Value[8]);
                       tmp.Sound = CfgStringLua.Get(item.Value[9]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"GuideItem");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareGuideItem>(113);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"GuideItem");
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
    public static DeclareGuideItem Get(int id)
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
    public static void Transform(Dictionary<int, DeclareGuideItem> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
