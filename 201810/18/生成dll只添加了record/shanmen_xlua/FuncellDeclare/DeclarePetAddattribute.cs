//文件是自动生成,请勿手动修改.来自数据文件:pet_addattribute
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclarePetAddattribute")]
  public class DeclarePetAddattribute
  {
    #region //私有变量定义
    //宠物属性加成，加值而不是加百分比(@;@_@)
    private string _addAttribute;
    //编号
    private int _id;
    //需要的总等级
    private int _level;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"AddAttribute", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string AddAttribute { get{ return _addAttribute; } set{ _addAttribute=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclarePetAddattribute Create( string in_addAttribute, int in_id, int in_level )
    {
      DeclarePetAddattribute tmp = new DeclarePetAddattribute();
      tmp._addAttribute = in_addAttribute;
      tmp._id = in_id;
      tmp._level = in_level;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclarePetAddattribute> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclarePetAddattribute> _dataCaches = null;
    public static Dictionary<int, DeclarePetAddattribute> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPetAddattribute");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataPetAddattribute = require 'Lua/Config/DataPetAddattribute'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPetAddattribute");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclarePetAddattribute>(9);
                     foreach (var item in dic)
                     {
                         DeclarePetAddattribute tmp = new DeclarePetAddattribute();
                       tmp.AddAttribute = CfgStringLua.Get(item.Value[0]);
                       tmp.Id = item.Value[1];
                       tmp.Level = item.Value[2];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"PetAddattribute");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclarePetAddattribute>(9);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"PetAddattribute");
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
    public static DeclarePetAddattribute Get(int id)
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
    public static void Transform(Dictionary<int, DeclarePetAddattribute> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
