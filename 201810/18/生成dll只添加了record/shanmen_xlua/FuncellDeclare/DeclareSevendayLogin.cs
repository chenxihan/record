//文件是自动生成,请勿手动修改.来自数据文件:sevenday_login
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareSevendayLogin")]
  public class DeclareSevendayLogin
  {
    #region //私有变量定义
    //签到奖励(@;@_@)ID_数量_是否绑定（0否1是）
    private string _award;
    //累积登录天数
    private int _day;
    //签到装备奖励（ID_数量_职业_是否绑定（0否1是），没有就填0）(@;@_@)
    private string _equip;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Award", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Award { get{ return _award; } set{ _award=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Day", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Day { get{ return _day; } set{ _day=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Equip", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Equip { get{ return _equip; } set{ _equip=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareSevendayLogin Create( string in_award, int in_day, string in_equip )
    {
      DeclareSevendayLogin tmp = new DeclareSevendayLogin();
      tmp._award = in_award;
      tmp._day = in_day;
      tmp._equip = in_equip;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareSevendayLogin> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareSevendayLogin> _dataCaches = null;
    public static Dictionary<int, DeclareSevendayLogin> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataSevendayLogin");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataSevendayLogin = require 'Lua/Config/DataSevendayLogin'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataSevendayLogin");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareSevendayLogin>(7);
                     foreach (var item in dic)
                     {
                         DeclareSevendayLogin tmp = new DeclareSevendayLogin();
                       tmp.Award = CfgStringLua.Get(item.Value[0]);
                       tmp.Day = item.Value[1];
                       tmp.Equip = CfgStringLua.Get(item.Value[2]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"SevendayLogin");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareSevendayLogin>(7);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"SevendayLogin");
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
    public static DeclareSevendayLogin Get(int id)
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
    public static void Transform(Dictionary<int, DeclareSevendayLogin> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
