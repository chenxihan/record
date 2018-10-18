//文件是自动生成,请勿手动修改.来自数据文件:CityWarAward
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareCityWarAward")]
  public class DeclareCityWarAward
  {
    #region //私有变量定义
    //每天领取的奖励(@;@_@)
    private string _day_award;
    //失败奖励(@;@_@)
    private string _lose_award;
    //每月奖励(@;@_@)
    private string _month_award;
    //城市类型0主城；1卫城
    private int _type;
    //每周奖励(@;@_@)
    private string _week_award;
    //胜利成员奖励(@;@_@)
    private string _win_member_award;
    //胜利成员称号
    private int _win_member_title;
    //胜利城主奖励(@;@_@)
    private string _win_owner_award;
    //城主时装（1为武器，2为衣服，格式为：枚举_ID）(@;@_@)
    private string _win_owner_fashion;
    //胜利城主称号
    private int _win_owner_title;
    //预约每次增加资金（主城不能预约）
    private int _yuyue_add_value;
    //预约基础资金（主城不能预约）
    private int _yuyue_base_value;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"DayAward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DayAward { get{ return _day_award; } set{ _day_award=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"LoseAward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string LoseAward { get{ return _lose_award; } set{ _lose_award=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"MonthAward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string MonthAward { get{ return _month_award; } set{ _month_award=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"WeekAward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string WeekAward { get{ return _week_award; } set{ _week_award=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"WinMemberAward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string WinMemberAward { get{ return _win_member_award; } set{ _win_member_award=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"WinMemberTitle", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int WinMemberTitle { get{ return _win_member_title; } set{ _win_member_title=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"WinOwnerAward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string WinOwnerAward { get{ return _win_owner_award; } set{ _win_owner_award=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"WinOwnerFashion", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string WinOwnerFashion { get{ return _win_owner_fashion; } set{ _win_owner_fashion=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"WinOwnerTitle", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int WinOwnerTitle { get{ return _win_owner_title; } set{ _win_owner_title=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"YuyueAddValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int YuyueAddValue { get{ return _yuyue_add_value; } set{ _yuyue_add_value=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"YuyueBaseValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int YuyueBaseValue { get{ return _yuyue_base_value; } set{ _yuyue_base_value=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareCityWarAward Create( string in_day_award, string in_lose_award, string in_month_award, int in_type, string in_week_award, string in_win_member_award, int in_win_member_title, string in_win_owner_award, string in_win_owner_fashion, int in_win_owner_title, int in_yuyue_add_value, int in_yuyue_base_value )
    {
      DeclareCityWarAward tmp = new DeclareCityWarAward();
      tmp._day_award = in_day_award;
      tmp._lose_award = in_lose_award;
      tmp._month_award = in_month_award;
      tmp._type = in_type;
      tmp._week_award = in_week_award;
      tmp._win_member_award = in_win_member_award;
      tmp._win_member_title = in_win_member_title;
      tmp._win_owner_award = in_win_owner_award;
      tmp._win_owner_fashion = in_win_owner_fashion;
      tmp._win_owner_title = in_win_owner_title;
      tmp._yuyue_add_value = in_yuyue_add_value;
      tmp._yuyue_base_value = in_yuyue_base_value;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareCityWarAward> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareCityWarAward> _dataCaches = null;
    public static Dictionary<int, DeclareCityWarAward> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataCityWarAward");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataCityWarAward = require 'Lua/Config/DataCityWarAward'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataCityWarAward");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareCityWarAward>(2);
                     foreach (var item in dic)
                     {
                         DeclareCityWarAward tmp = new DeclareCityWarAward();
                       tmp.DayAward = CfgStringLua.Get(item.Value[0]);
                       tmp.LoseAward = CfgStringLua.Get(item.Value[1]);
                       tmp.MonthAward = CfgStringLua.Get(item.Value[2]);
                       tmp.Type = item.Value[3];
                       tmp.WeekAward = CfgStringLua.Get(item.Value[4]);
                       tmp.WinMemberAward = CfgStringLua.Get(item.Value[5]);
                       tmp.WinMemberTitle = item.Value[6];
                       tmp.WinOwnerAward = CfgStringLua.Get(item.Value[7]);
                       tmp.WinOwnerFashion = CfgStringLua.Get(item.Value[8]);
                       tmp.WinOwnerTitle = item.Value[9];
                       tmp.YuyueAddValue = item.Value[10];
                       tmp.YuyueBaseValue = item.Value[11];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"CityWarAward");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareCityWarAward>(2);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"CityWarAward");
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
    public static DeclareCityWarAward Get(int id)
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
    public static void Transform(Dictionary<int, DeclareCityWarAward> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
