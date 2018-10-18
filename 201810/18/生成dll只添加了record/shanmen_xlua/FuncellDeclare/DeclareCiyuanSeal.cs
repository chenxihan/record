//文件是自动生成,请勿手动修改.来自数据文件:ciyuan_seal
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareCiyuanSeal")]
  public class DeclareCiyuanSeal
  {
    #region //私有变量定义
    //本级附加属性(@;@_@)
    private string _sea_attribute;
    //等级
    private int _sea_level;
    //升下级经验
    private int _sea_material;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"SeaAttribute", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SeaAttribute { get{ return _sea_attribute; } set{ _sea_attribute=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"SeaLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SeaLevel { get{ return _sea_level; } set{ _sea_level=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"SeaMaterial", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SeaMaterial { get{ return _sea_material; } set{ _sea_material=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareCiyuanSeal Create( string in_sea_attribute, int in_sea_level, int in_sea_material )
    {
      DeclareCiyuanSeal tmp = new DeclareCiyuanSeal();
      tmp._sea_attribute = in_sea_attribute;
      tmp._sea_level = in_sea_level;
      tmp._sea_material = in_sea_material;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareCiyuanSeal> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareCiyuanSeal> _dataCaches = null;
    public static Dictionary<int, DeclareCiyuanSeal> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataCiyuanSeal");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataCiyuanSeal = require 'Lua/Config/DataCiyuanSeal'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataCiyuanSeal");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareCiyuanSeal>(1000);
                     foreach (var item in dic)
                     {
                         DeclareCiyuanSeal tmp = new DeclareCiyuanSeal();
                       tmp.SeaAttribute = CfgStringLua.Get(item.Value[0]);
                       tmp.SeaLevel = item.Value[1];
                       tmp.SeaMaterial = item.Value[2];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"CiyuanSeal");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareCiyuanSeal>(1000);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"CiyuanSeal");
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
    public static DeclareCiyuanSeal Get(int id)
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
    public static void Transform(Dictionary<int, DeclareCiyuanSeal> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
