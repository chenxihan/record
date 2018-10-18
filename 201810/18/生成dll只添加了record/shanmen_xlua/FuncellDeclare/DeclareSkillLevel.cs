//文件是自动生成,请勿手动修改.来自数据文件:skill_level
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareSkillLevel")]
  public class DeclareSkillLevel
  {
    #region //私有变量定义
    //升级消耗基础值
    private int _costBase;
    //升级消耗提升值
    private int _costUp;
    //伤害基础值
    private int _damageBase;
    //伤害提升值
    private int _damageUp;
    //唯一ID
    private int _id;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"CostBase", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CostBase { get{ return _costBase; } set{ _costBase=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"CostUp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CostUp { get{ return _costUp; } set{ _costUp=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"DamageBase", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DamageBase { get{ return _damageBase; } set{ _damageBase=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"DamageUp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DamageUp { get{ return _damageUp; } set{ _damageUp=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareSkillLevel Create( int in_costBase, int in_costUp, int in_damageBase, int in_damageUp, int in_id )
    {
      DeclareSkillLevel tmp = new DeclareSkillLevel();
      tmp._costBase = in_costBase;
      tmp._costUp = in_costUp;
      tmp._damageBase = in_damageBase;
      tmp._damageUp = in_damageUp;
      tmp._id = in_id;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareSkillLevel> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareSkillLevel> _dataCaches = null;
    public static Dictionary<int, DeclareSkillLevel> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataSkillLevel");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataSkillLevel = require 'Lua/Config/DataSkillLevel'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataSkillLevel");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareSkillLevel>(5165);
                     foreach (var item in dic)
                     {
                         DeclareSkillLevel tmp = new DeclareSkillLevel();
                       tmp.CostBase = item.Value[0];
                       tmp.CostUp = item.Value[1];
                       tmp.DamageBase = item.Value[2];
                       tmp.DamageUp = item.Value[3];
                       tmp.Id = item.Value[4];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"SkillLevel");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareSkillLevel>(5165);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"SkillLevel");
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
    public static DeclareSkillLevel Get(int id)
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
    public static void Transform(Dictionary<int, DeclareSkillLevel> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
