//文件是自动生成,请勿手动修改.来自数据文件:KingFightFeatsAward
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareKingFightFeatsAward")]
  public class DeclareKingFightFeatsAward
  {
    #region //私有变量定义
    //奖励(@;@_@)
    private string _award;
    //分数
    private int _feats;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Award", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Award { get{ return _award; } set{ _award=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Feats", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Feats { get{ return _feats; } set{ _feats=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareKingFightFeatsAward Create( string in_award, int in_feats )
    {
      DeclareKingFightFeatsAward tmp = new DeclareKingFightFeatsAward();
      tmp._award = in_award;
      tmp._feats = in_feats;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareKingFightFeatsAward> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareKingFightFeatsAward> _dataCaches = null;
    public static Dictionary<int, DeclareKingFightFeatsAward> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataKingFightFeatsAward");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataKingFightFeatsAward = require 'Lua/Config/DataKingFightFeatsAward'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataKingFightFeatsAward");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareKingFightFeatsAward>(13);
                     foreach (var item in dic)
                     {
                         DeclareKingFightFeatsAward tmp = new DeclareKingFightFeatsAward();
                       tmp.Award = CfgStringLua.Get(item.Value[0]);
                       tmp.Feats = item.Value[1];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"KingFightFeatsAward");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareKingFightFeatsAward>(13);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"KingFightFeatsAward");
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
    public static DeclareKingFightFeatsAward Get(int id)
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
    public static void Transform(Dictionary<int, DeclareKingFightFeatsAward> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
