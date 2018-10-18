//文件是自动生成,请勿手动修改.来自数据文件:AutoUseMedicine
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareAutoUseMedicine")]
  public class DeclareAutoUseMedicine
  {
    #region //私有变量定义
    //ID
    private int _id;
    //最高等级
    private int _level_map;
    //最低等级
    private int _level_min;
    //商品ID
    private int _shop_id;
    //使用的药品ID
    private int _use_itemid;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"LevelMap", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int LevelMap { get{ return _level_map; } set{ _level_map=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"LevelMin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int LevelMin { get{ return _level_min; } set{ _level_min=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"ShopId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ShopId { get{ return _shop_id; } set{ _shop_id=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"UseItemid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UseItemid { get{ return _use_itemid; } set{ _use_itemid=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareAutoUseMedicine Create( int in_id, int in_level_map, int in_level_min, int in_shop_id, int in_use_itemid )
    {
      DeclareAutoUseMedicine tmp = new DeclareAutoUseMedicine();
      tmp._id = in_id;
      tmp._level_map = in_level_map;
      tmp._level_min = in_level_min;
      tmp._shop_id = in_shop_id;
      tmp._use_itemid = in_use_itemid;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareAutoUseMedicine> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareAutoUseMedicine> _dataCaches = null;
    public static Dictionary<int, DeclareAutoUseMedicine> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataAutoUseMedicine");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataAutoUseMedicine = require 'Lua/Config/DataAutoUseMedicine'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataAutoUseMedicine");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareAutoUseMedicine>(7);
                     foreach (var item in dic)
                     {
                         DeclareAutoUseMedicine tmp = new DeclareAutoUseMedicine();
                       tmp.Id = item.Value[0];
                       tmp.LevelMap = item.Value[1];
                       tmp.LevelMin = item.Value[2];
                       tmp.ShopId = item.Value[3];
                       tmp.UseItemid = item.Value[4];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"AutoUseMedicine");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareAutoUseMedicine>(7);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"AutoUseMedicine");
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
    public static DeclareAutoUseMedicine Get(int id)
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
    public static void Transform(Dictionary<int, DeclareAutoUseMedicine> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
