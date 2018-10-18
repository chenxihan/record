//文件是自动生成,请勿手动修改.来自数据文件:horse_star
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareHorseStar")]
  public class DeclareHorseStar
  {
    #region //私有变量定义
    //本级属性(@;@_@)
    private string _attr;
    //坐骑等阶_升星等级(@_@)
    private string _id;
    //进阶成功是否全服公告（0不公告，1公告）
    private int _notice;
    //进阶消耗物品及数量(格式：物品ID，数量；物品ID，数量【是或】）(@;@_@)
    private string _up_item_info;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Attr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Attr { get{ return _attr; } set{ _attr=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Notice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Notice { get{ return _notice; } set{ _notice=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"UpItemInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string UpItemInfo { get{ return _up_item_info; } set{ _up_item_info=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareHorseStar Create( string in_attr, string in_id, int in_notice, string in_up_item_info )
    {
      DeclareHorseStar tmp = new DeclareHorseStar();
      tmp._attr = in_attr;
      tmp._id = in_id;
      tmp._notice = in_notice;
      tmp._up_item_info = in_up_item_info;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<string, DeclareHorseStar> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<string, DeclareHorseStar> _dataCaches = null;
    public static Dictionary<string, DeclareHorseStar> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataHorseStar");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataHorseStar = require 'Lua/Config/DataHorseStar'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataHorseStar");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<string, DeclareHorseStar>(110);
                     foreach (var item in dic)
                     {
                         DeclareHorseStar tmp = new DeclareHorseStar();
                       tmp.Attr = CfgStringLua.Get(item.Value[0]);
                       tmp.Id = CfgStringLua.Get(item.Value[1]);
                       tmp.Notice = item.Value[2];
                       tmp.UpItemInfo = CfgStringLua.Get(item.Value[3]);

                         _dataCaches.Add(CfgStringLua.Get(item.Key), tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"HorseStar");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<string, DeclareHorseStar>(110);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"HorseStar");
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
    public static DeclareHorseStar Get(string id)
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
    public static void Transform(Dictionary<string, DeclareHorseStar> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
