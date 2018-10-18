//文件是自动生成,请勿手动修改.来自数据文件:shop_gift
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareShopGift")]
  public class DeclareShopGift
  {
    #region //私有变量定义
    //购买礼包ID
    private int _buyID;
    //礼包持续时间 秒
    private int _countTime;
    //商品ID
    private int _goodsID;
    //礼包图标hide
    private int _icon;
    //触发道具ID
    private int _itemID;
    //展示商品hide
    private string _itemShow;
    //礼包名字hide
    private string _name;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"BuyID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BuyID { get{ return _buyID; } set{ _buyID=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"CountTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CountTime { get{ return _countTime; } set{ _countTime=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"GoodsID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int GoodsID { get{ return _goodsID; } set{ _goodsID=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"ItemID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ItemID { get{ return _itemID; } set{ _itemID=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"ItemShow", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ItemShow { get{ return _itemShow; } set{ _itemShow=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareShopGift Create( int in_buyID, int in_countTime, int in_goodsID, int in_icon, int in_itemID, string in_itemShow, string in_name )
    {
      DeclareShopGift tmp = new DeclareShopGift();
      tmp._buyID = in_buyID;
      tmp._countTime = in_countTime;
      tmp._goodsID = in_goodsID;
      tmp._icon = in_icon;
      tmp._itemID = in_itemID;
      tmp._itemShow = in_itemShow;
      tmp._name = in_name;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareShopGift> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareShopGift> _dataCaches = null;
    public static Dictionary<int, DeclareShopGift> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataShopGift");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataShopGift = require 'Lua/Config/DataShopGift'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataShopGift");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareShopGift>(8);
                     foreach (var item in dic)
                     {
                         DeclareShopGift tmp = new DeclareShopGift();
                       tmp.BuyID = item.Value[0];
                       tmp.CountTime = item.Value[1];
                       tmp.GoodsID = item.Value[2];
                       tmp.Icon = item.Value[3];
                       tmp.ItemID = item.Value[4];
                       tmp.ItemShow = CfgStringLua.Get(item.Value[5]);
                       tmp.Name = CfgStringLua.Get(item.Value[6]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"ShopGift");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareShopGift>(8);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"ShopGift");
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
    public static DeclareShopGift Get(int id)
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
    public static void Transform(Dictionary<int, DeclareShopGift> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
