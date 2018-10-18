//文件是自动生成,请勿手动修改.来自数据文件:fashion_link
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareFashionLink")]
  public class DeclareFashionLink
  {
    #region //私有变量定义
    //羁绊增加属性(@;@_@)
    private string _attribute;
    //编号
    private int _iD;
    //对应时装的编号(@_@)
    private string _link;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Attribute", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Attribute { get{ return _attribute; } set{ _attribute=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID { get{ return _iD; } set{ _iD=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Link", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Link { get{ return _link; } set{ _link=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareFashionLink Create( string in_attribute, int in_iD, string in_link )
    {
      DeclareFashionLink tmp = new DeclareFashionLink();
      tmp._attribute = in_attribute;
      tmp._iD = in_iD;
      tmp._link = in_link;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareFashionLink> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareFashionLink> _dataCaches = null;
    public static Dictionary<int, DeclareFashionLink> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataFashionLink");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataFashionLink = require 'Lua/Config/DataFashionLink'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataFashionLink");                  }

                 if (dic != null)
                 {
                              _dataCaches = new Dictionary<int, DeclareFashionLink>();
                     foreach (var item in dic)
                     {
                         DeclareFashionLink tmp = new DeclareFashionLink();
                       tmp.Attribute = CfgStringLua.Get(item.Value[0]);
                       tmp.ID = item.Value[1];
                       tmp.Link = CfgStringLua.Get(item.Value[2]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"FashionLink");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareFashionLink>();
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"FashionLink");
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
    public static DeclareFashionLink Get(int id)
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
    public static void Transform(Dictionary<int, DeclareFashionLink> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
