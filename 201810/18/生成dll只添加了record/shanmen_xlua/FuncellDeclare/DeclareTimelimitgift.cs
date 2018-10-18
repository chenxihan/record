//文件是自动生成,请勿手动修改.来自数据文件:timelimitgift
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareTimelimitgift")]
  public class DeclareTimelimitgift
  {
    #region //私有变量定义
    //花费的蓝钻
    private int _gold;
    //礼包ID
    private int _id;
    //描述
    private string _info;
    //礼包名称
    private string _name;
    //标题
    private string _title;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Gold", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Gold { get{ return _gold; } set{ _gold=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Info { get{ return _info; } set{ _info=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Title", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Title { get{ return _title; } set{ _title=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareTimelimitgift Create( int in_gold, int in_id, string in_info, string in_name, string in_title )
    {
      DeclareTimelimitgift tmp = new DeclareTimelimitgift();
      tmp._gold = in_gold;
      tmp._id = in_id;
      tmp._info = in_info;
      tmp._name = in_name;
      tmp._title = in_title;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareTimelimitgift> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareTimelimitgift> _dataCaches = null;
    public static Dictionary<int, DeclareTimelimitgift> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTimelimitgift");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataTimelimitgift = require 'Lua/Config/DataTimelimitgift'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTimelimitgift");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareTimelimitgift>(14);
                     foreach (var item in dic)
                     {
                         DeclareTimelimitgift tmp = new DeclareTimelimitgift();
                       tmp.Gold = item.Value[0];
                       tmp.Id = item.Value[1];
                       tmp.Info = CfgStringLua.Get(item.Value[2]);
                       tmp.Name = CfgStringLua.Get(item.Value[3]);
                       tmp.Title = CfgStringLua.Get(item.Value[4]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Timelimitgift");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareTimelimitgift>(14);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Timelimitgift");
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
    public static DeclareTimelimitgift Get(int id)
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
    public static void Transform(Dictionary<int, DeclareTimelimitgift> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
