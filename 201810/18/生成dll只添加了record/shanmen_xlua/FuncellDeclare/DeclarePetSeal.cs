//文件是自动生成,请勿手动修改.来自数据文件:pet_seal
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclarePetSeal")]
  public class DeclarePetSeal
  {
    #region //私有变量定义
    //本级附加属性(@;@_@)
    private string _sea_attribute;
    //等级
    private int _sea_level;
    //升下级经验
    private int _sea_material;
    //激活技能
    private int _skill;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"SeaAttribute", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SeaAttribute { get{ return _sea_attribute; } set{ _sea_attribute=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"SeaLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SeaLevel { get{ return _sea_level; } set{ _sea_level=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"SeaMaterial", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SeaMaterial { get{ return _sea_material; } set{ _sea_material=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Skill", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Skill { get{ return _skill; } set{ _skill=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclarePetSeal Create( string in_sea_attribute, int in_sea_level, int in_sea_material, int in_skill )
    {
      DeclarePetSeal tmp = new DeclarePetSeal();
      tmp._sea_attribute = in_sea_attribute;
      tmp._sea_level = in_sea_level;
      tmp._sea_material = in_sea_material;
      tmp._skill = in_skill;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclarePetSeal> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclarePetSeal> _dataCaches = null;
    public static Dictionary<int, DeclarePetSeal> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPetSeal");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataPetSeal = require 'Lua/Config/DataPetSeal'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPetSeal");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclarePetSeal>(1000);
                     foreach (var item in dic)
                     {
                         DeclarePetSeal tmp = new DeclarePetSeal();
                       tmp.SeaAttribute = CfgStringLua.Get(item.Value[0]);
                       tmp.SeaLevel = item.Value[1];
                       tmp.SeaMaterial = item.Value[2];
                       tmp.Skill = item.Value[3];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"PetSeal");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclarePetSeal>(1000);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"PetSeal");
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
    public static DeclarePetSeal Get(int id)
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
    public static void Transform(Dictionary<int, DeclarePetSeal> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
