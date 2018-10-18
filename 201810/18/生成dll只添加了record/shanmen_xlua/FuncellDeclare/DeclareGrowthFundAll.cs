//文件是自动生成,请勿手动修改.来自数据文件:growthFund_all
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareGrowthFundAll")]
  public class DeclareGrowthFundAll
  {
    #region //私有变量定义
    //物品奖励ID_数量_是否绑定（0否1是）(@;@_@)
    private string _award;
    //领取人数
    private int _number;
    //保底增长总数
    private int _numberUp;
    //开服后x时到达保底人数
    private int _renovateBegin;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Award", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Award { get{ return _award; } set{ _award=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Number", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Number { get{ return _number; } set{ _number=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"NumberUp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NumberUp { get{ return _numberUp; } set{ _numberUp=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"RenovateBegin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int RenovateBegin { get{ return _renovateBegin; } set{ _renovateBegin=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareGrowthFundAll Create( string in_award, int in_number, int in_numberUp, int in_renovateBegin )
    {
      DeclareGrowthFundAll tmp = new DeclareGrowthFundAll();
      tmp._award = in_award;
      tmp._number = in_number;
      tmp._numberUp = in_numberUp;
      tmp._renovateBegin = in_renovateBegin;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareGrowthFundAll> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareGrowthFundAll> _dataCaches = null;
    public static Dictionary<int, DeclareGrowthFundAll> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGrowthFundAll");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataGrowthFundAll = require 'Lua/Config/DataGrowthFundAll'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGrowthFundAll");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareGrowthFundAll>(6);
                     foreach (var item in dic)
                     {
                         DeclareGrowthFundAll tmp = new DeclareGrowthFundAll();
                       tmp.Award = CfgStringLua.Get(item.Value[0]);
                       tmp.Number = item.Value[1];
                       tmp.NumberUp = item.Value[2];
                       tmp.RenovateBegin = item.Value[3];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"GrowthFundAll");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareGrowthFundAll>(6);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"GrowthFundAll");
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
    public static DeclareGrowthFundAll Get(int id)
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
    public static void Transform(Dictionary<int, DeclareGrowthFundAll> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
