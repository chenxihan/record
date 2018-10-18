//文件是自动生成,请勿手动修改.来自数据文件:pet_sacrifice_item
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclarePetSacrificeItem")]
  public class DeclarePetSacrificeItem
  {
    #region //私有变量定义
    //增加经验
    private int _exp;
    //道具ID
    private int _itemID;
    //需求宠物等级，需要的填宠物ID，不需要的为0
    private int _pet_level;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Exp { get{ return _exp; } set{ _exp=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"ItemID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ItemID { get{ return _itemID; } set{ _itemID=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"PetLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PetLevel { get{ return _pet_level; } set{ _pet_level=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclarePetSacrificeItem Create( int in_exp, int in_itemID, int in_pet_level )
    {
      DeclarePetSacrificeItem tmp = new DeclarePetSacrificeItem();
      tmp._exp = in_exp;
      tmp._itemID = in_itemID;
      tmp._pet_level = in_pet_level;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclarePetSacrificeItem> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclarePetSacrificeItem> _dataCaches = null;
    public static Dictionary<int, DeclarePetSacrificeItem> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPetSacrificeItem");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataPetSacrificeItem = require 'Lua/Config/DataPetSacrificeItem'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPetSacrificeItem");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclarePetSacrificeItem>(22);
                     foreach (var item in dic)
                     {
                         DeclarePetSacrificeItem tmp = new DeclarePetSacrificeItem();
                       tmp.Exp = item.Value[0];
                       tmp.ItemID = item.Value[1];
                       tmp.PetLevel = item.Value[2];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"PetSacrificeItem");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclarePetSacrificeItem>(22);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"PetSacrificeItem");
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
    public static DeclarePetSacrificeItem Get(int id)
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
    public static void Transform(Dictionary<int, DeclarePetSacrificeItem> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
