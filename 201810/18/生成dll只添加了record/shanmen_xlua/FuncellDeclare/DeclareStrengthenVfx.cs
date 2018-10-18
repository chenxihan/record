//文件是自动生成,请勿手动修改.来自数据文件:StrengthenVfx
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareStrengthenVfx")]
  public class DeclareStrengthenVfx
  {
    #region //私有变量定义
    //强化等级
    private int _level;
    //齐王府特效ID，在modelconfig中配置的id
    private int _vfx;
    //六扇门特效ID，在modelconfig中配置的id
    private int _vfx1;
    //万花楼特效ID，在modelconfig中配置的id
    private int _vfx2;
    //蓟辽营特效ID，在modelconfig中配置的id
    private int _vfx3;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Vfx", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Vfx { get{ return _vfx; } set{ _vfx=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Vfx1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Vfx1 { get{ return _vfx1; } set{ _vfx1=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Vfx2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Vfx2 { get{ return _vfx2; } set{ _vfx2=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Vfx3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Vfx3 { get{ return _vfx3; } set{ _vfx3=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareStrengthenVfx Create( int in_level, int in_vfx, int in_vfx1, int in_vfx2, int in_vfx3 )
    {
      DeclareStrengthenVfx tmp = new DeclareStrengthenVfx();
      tmp._level = in_level;
      tmp._vfx = in_vfx;
      tmp._vfx1 = in_vfx1;
      tmp._vfx2 = in_vfx2;
      tmp._vfx3 = in_vfx3;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareStrengthenVfx> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareStrengthenVfx> _dataCaches = null;
    public static Dictionary<int, DeclareStrengthenVfx> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataStrengthenVfx");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataStrengthenVfx = require 'Lua/Config/DataStrengthenVfx'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataStrengthenVfx");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareStrengthenVfx>(11);
                     foreach (var item in dic)
                     {
                         DeclareStrengthenVfx tmp = new DeclareStrengthenVfx();
                       tmp.Level = item.Value[0];
                       tmp.Vfx = item.Value[1];
                       tmp.Vfx1 = item.Value[2];
                       tmp.Vfx2 = item.Value[3];
                       tmp.Vfx3 = item.Value[4];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"StrengthenVfx");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareStrengthenVfx>(11);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"StrengthenVfx");
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
    public static DeclareStrengthenVfx Get(int id)
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
    public static void Transform(Dictionary<int, DeclareStrengthenVfx> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
