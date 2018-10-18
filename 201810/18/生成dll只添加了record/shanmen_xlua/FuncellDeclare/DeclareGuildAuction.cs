//文件是自动生成,请勿手动修改.来自数据文件:guild_auction
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareGuildAuction")]
  public class DeclareGuildAuction
  {
    #region //私有变量定义
    //公会时间(小时)
    private int _guild_time;
    //物品ID
    private int _itemID;
    //每次加价（蓝钻）
    private int _price_every_time;
    //最高价（蓝钻）
    private int _price_max;
    //最低价（蓝钻）
    private int _price_min;
    //返还比例（百分比）
    private int _proportion;
    //世界时间(小时)
    private int _world_time;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"GuildTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int GuildTime { get{ return _guild_time; } set{ _guild_time=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"ItemID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ItemID { get{ return _itemID; } set{ _itemID=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"PriceEveryTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PriceEveryTime { get{ return _price_every_time; } set{ _price_every_time=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"PriceMax", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PriceMax { get{ return _price_max; } set{ _price_max=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"PriceMin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PriceMin { get{ return _price_min; } set{ _price_min=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Proportion", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Proportion { get{ return _proportion; } set{ _proportion=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"WorldTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int WorldTime { get{ return _world_time; } set{ _world_time=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareGuildAuction Create( int in_guild_time, int in_itemID, int in_price_every_time, int in_price_max, int in_price_min, int in_proportion, int in_world_time )
    {
      DeclareGuildAuction tmp = new DeclareGuildAuction();
      tmp._guild_time = in_guild_time;
      tmp._itemID = in_itemID;
      tmp._price_every_time = in_price_every_time;
      tmp._price_max = in_price_max;
      tmp._price_min = in_price_min;
      tmp._proportion = in_proportion;
      tmp._world_time = in_world_time;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareGuildAuction> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareGuildAuction> _dataCaches = null;
    public static Dictionary<int, DeclareGuildAuction> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGuildAuction");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataGuildAuction = require 'Lua/Config/DataGuildAuction'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGuildAuction");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareGuildAuction>(389);
                     foreach (var item in dic)
                     {
                         DeclareGuildAuction tmp = new DeclareGuildAuction();
                       tmp.GuildTime = item.Value[0];
                       tmp.ItemID = item.Value[1];
                       tmp.PriceEveryTime = item.Value[2];
                       tmp.PriceMax = item.Value[3];
                       tmp.PriceMin = item.Value[4];
                       tmp.Proportion = item.Value[5];
                       tmp.WorldTime = item.Value[6];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"GuildAuction");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareGuildAuction>(389);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"GuildAuction");
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
    public static DeclareGuildAuction Get(int id)
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
    public static void Transform(Dictionary<int, DeclareGuildAuction> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
