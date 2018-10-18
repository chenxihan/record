//文件是自动生成,请勿手动修改.来自数据文件:changejob_equip
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareChangejobEquip")]
  public class DeclareChangejobEquip
  {
    #region //私有变量定义
    //装备id,(id构成：部位，职业，品质，等级）
    private int _id;
    //装备部位_钻石_品阶_装备颜色_品质_职业限制
    private int _key;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Key", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Key { get{ return _key; } set{ _key=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareChangejobEquip Create( int in_id, int in_key )
    {
      DeclareChangejobEquip tmp = new DeclareChangejobEquip();
      tmp._id = in_id;
      tmp._key = in_key;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareChangejobEquip> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareChangejobEquip> _dataCaches = null;
    public static Dictionary<int, DeclareChangejobEquip> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataChangejobEquip");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataChangejobEquip = require 'Lua/Config/DataChangejobEquip'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataChangejobEquip");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareChangejobEquip>(5910);
                     foreach (var item in dic)
                     {
                         DeclareChangejobEquip tmp = new DeclareChangejobEquip();
                       tmp.Id = item.Value[0];
                       tmp.Key = item.Value[1];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"ChangejobEquip");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareChangejobEquip>(5910);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"ChangejobEquip");
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
    public static DeclareChangejobEquip Get(int id)
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
    public static void Transform(Dictionary<int, DeclareChangejobEquip> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
