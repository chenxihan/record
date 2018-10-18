//文件是自动生成,请勿手动修改.来自数据文件:recharge_daily_total
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareRechargeDailyTotal")]
  public class DeclareRechargeDailyTotal
  {
    #region //私有变量定义
    //奖励物品(物品ID_数量_绑定)(@;@_@)
    private string _award;
    //时间（天）
    private int _day;
    //ID
    private int _iD;
    //金额
    private int _money;
    //类型（1每日，2累积）
    private int _position;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Award", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Award { get{ return _award; } set{ _award=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Day", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Day { get{ return _day; } set{ _day=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID { get{ return _iD; } set{ _iD=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Money", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Money { get{ return _money; } set{ _money=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Position", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Position { get{ return _position; } set{ _position=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareRechargeDailyTotal Create( string in_award, int in_day, int in_iD, int in_money, int in_position )
    {
      DeclareRechargeDailyTotal tmp = new DeclareRechargeDailyTotal();
      tmp._award = in_award;
      tmp._day = in_day;
      tmp._iD = in_iD;
      tmp._money = in_money;
      tmp._position = in_position;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareRechargeDailyTotal> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareRechargeDailyTotal> _dataCaches = null;
    public static Dictionary<int, DeclareRechargeDailyTotal> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataRechargeDailyTotal");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataRechargeDailyTotal = require 'Lua/Config/DataRechargeDailyTotal'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataRechargeDailyTotal");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareRechargeDailyTotal>(6);
                     foreach (var item in dic)
                     {
                         DeclareRechargeDailyTotal tmp = new DeclareRechargeDailyTotal();
                       tmp.Award = CfgStringLua.Get(item.Value[0]);
                       tmp.Day = item.Value[1];
                       tmp.ID = item.Value[2];
                       tmp.Money = item.Value[3];
                       tmp.Position = item.Value[4];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"RechargeDailyTotal");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareRechargeDailyTotal>(6);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"RechargeDailyTotal");
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
    public static DeclareRechargeDailyTotal Get(int id)
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
    public static void Transform(Dictionary<int, DeclareRechargeDailyTotal> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
