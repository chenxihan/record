//文件是自动生成,请勿手动修改.来自数据文件:guild_donate
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareGuildDonate")]
  public class DeclareGuildDonate
  {
    #region //私有变量定义
    //捐献货币(@;@_@)
    private string _coinType;
    //帮会获得资金(@_@)
    private string _guild_get;
    //捐献id（1-10）
    private int _id;
    //自己获得贡献值(@_@)
    private string _own_get;
    //自己获得科技点(@_@)
    private string _technology_get;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"CoinType", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string CoinType { get{ return _coinType; } set{ _coinType=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"GuildGet", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string GuildGet { get{ return _guild_get; } set{ _guild_get=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"OwnGet", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OwnGet { get{ return _own_get; } set{ _own_get=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"TechnologyGet", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TechnologyGet { get{ return _technology_get; } set{ _technology_get=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareGuildDonate Create( string in_coinType, string in_guild_get, int in_id, string in_own_get, string in_technology_get )
    {
      DeclareGuildDonate tmp = new DeclareGuildDonate();
      tmp._coinType = in_coinType;
      tmp._guild_get = in_guild_get;
      tmp._id = in_id;
      tmp._own_get = in_own_get;
      tmp._technology_get = in_technology_get;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareGuildDonate> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareGuildDonate> _dataCaches = null;
    public static Dictionary<int, DeclareGuildDonate> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGuildDonate");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataGuildDonate = require 'Lua/Config/DataGuildDonate'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGuildDonate");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareGuildDonate>(4);
                     foreach (var item in dic)
                     {
                         DeclareGuildDonate tmp = new DeclareGuildDonate();
                       tmp.CoinType = CfgStringLua.Get(item.Value[0]);
                       tmp.GuildGet = CfgStringLua.Get(item.Value[1]);
                       tmp.Id = item.Value[2];
                       tmp.OwnGet = CfgStringLua.Get(item.Value[3]);
                       tmp.TechnologyGet = CfgStringLua.Get(item.Value[4]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"GuildDonate");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareGuildDonate>(4);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"GuildDonate");
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
    public static DeclareGuildDonate Get(int id)
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
    public static void Transform(Dictionary<int, DeclareGuildDonate> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
