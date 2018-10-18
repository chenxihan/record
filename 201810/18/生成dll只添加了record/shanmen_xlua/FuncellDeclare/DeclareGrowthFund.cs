//文件是自动生成,请勿手动修改.来自数据文件:growthFund
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareGrowthFund")]
  public class DeclareGrowthFund
  {
    #region //私有变量定义
    //奖励物品(物品ID_数量_绑定)(@;@_@)
    private string _award;
    //领取等级
    private int _level;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Award", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Award { get{ return _award; } set{ _award=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareGrowthFund Create( string in_award, int in_level )
    {
      DeclareGrowthFund tmp = new DeclareGrowthFund();
      tmp._award = in_award;
      tmp._level = in_level;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareGrowthFund> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareGrowthFund> _dataCaches = null;
    public static Dictionary<int, DeclareGrowthFund> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGrowthFund");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataGrowthFund = require 'Lua/Config/DataGrowthFund'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGrowthFund");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareGrowthFund>(7);
                     foreach (var item in dic)
                     {
                         DeclareGrowthFund tmp = new DeclareGrowthFund();
                       tmp.Award = CfgStringLua.Get(item.Value[0]);
                       tmp.Level = item.Value[1];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"GrowthFund");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareGrowthFund>(7);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"GrowthFund");
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
    public static DeclareGrowthFund Get(int id)
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
    public static void Transform(Dictionary<int, DeclareGrowthFund> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
