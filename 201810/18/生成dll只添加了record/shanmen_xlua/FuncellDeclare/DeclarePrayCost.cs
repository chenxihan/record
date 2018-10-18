//文件是自动生成,请勿手动修改.来自数据文件:PrayCost
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclarePrayCost")]
  public class DeclarePrayCost
  {
    #region //私有变量定义
    //次数
    private int _num;
    //元宝兑换消耗(@_@)
    private string _prayExpCost;
    //邦金兑换消耗(@_@)
    private string _prayMoneyCost;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Num { get{ return _num; } set{ _num=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"PrayExpCost", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string PrayExpCost { get{ return _prayExpCost; } set{ _prayExpCost=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"PrayMoneyCost", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string PrayMoneyCost { get{ return _prayMoneyCost; } set{ _prayMoneyCost=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclarePrayCost Create( int in_num, string in_prayExpCost, string in_prayMoneyCost )
    {
      DeclarePrayCost tmp = new DeclarePrayCost();
      tmp._num = in_num;
      tmp._prayExpCost = in_prayExpCost;
      tmp._prayMoneyCost = in_prayMoneyCost;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclarePrayCost> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclarePrayCost> _dataCaches = null;
    public static Dictionary<int, DeclarePrayCost> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPrayCost");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataPrayCost = require 'Lua/Config/DataPrayCost'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPrayCost");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclarePrayCost>(30);
                     foreach (var item in dic)
                     {
                         DeclarePrayCost tmp = new DeclarePrayCost();
                       tmp.Num = item.Value[0];
                       tmp.PrayExpCost = CfgStringLua.Get(item.Value[1]);
                       tmp.PrayMoneyCost = CfgStringLua.Get(item.Value[2]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"PrayCost");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclarePrayCost>(30);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"PrayCost");
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
    public static DeclarePrayCost Get(int id)
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
    public static void Transform(Dictionary<int, DeclarePrayCost> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
