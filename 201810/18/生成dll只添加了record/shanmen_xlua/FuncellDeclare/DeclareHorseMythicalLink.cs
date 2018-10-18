//文件是自动生成,请勿手动修改.来自数据文件:horse_mythical_link
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareHorseMythicalLink")]
  public class DeclareHorseMythicalLink
  {
    #region //私有变量定义
    //羁绊增加属性(@;@_@)
    private string _attribute;
    //编号
    private int _id;
    //对应神兽的编号(@_@)
    private string _link;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Attribute", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Attribute { get{ return _attribute; } set{ _attribute=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Link", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Link { get{ return _link; } set{ _link=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareHorseMythicalLink Create( string in_attribute, int in_id, string in_link )
    {
      DeclareHorseMythicalLink tmp = new DeclareHorseMythicalLink();
      tmp._attribute = in_attribute;
      tmp._id = in_id;
      tmp._link = in_link;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareHorseMythicalLink> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareHorseMythicalLink> _dataCaches = null;
    public static Dictionary<int, DeclareHorseMythicalLink> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataHorseMythicalLink");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataHorseMythicalLink = require 'Lua/Config/DataHorseMythicalLink'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataHorseMythicalLink");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareHorseMythicalLink>(1);
                     foreach (var item in dic)
                     {
                         DeclareHorseMythicalLink tmp = new DeclareHorseMythicalLink();
                       tmp.Attribute = CfgStringLua.Get(item.Value[0]);
                       tmp.Id = item.Value[1];
                       tmp.Link = CfgStringLua.Get(item.Value[2]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"HorseMythicalLink");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareHorseMythicalLink>(1);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"HorseMythicalLink");
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
    public static DeclareHorseMythicalLink Get(int id)
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
    public static void Transform(Dictionary<int, DeclareHorseMythicalLink> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
