//文件是自动生成,请勿手动修改.来自数据文件:melting
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareMelting")]
  public class DeclareMelting
  {
    #region //私有变量定义
    //客户端显示物品（物品id;物品id）
    private string _clientShowItem;
    //熔炼ID
    private int _id;
    //单次奖励(材料ID_数量;)(@;@_@)
    private string _singleAward;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ClientShowItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ClientShowItem { get{ return _clientShowItem; } set{ _clientShowItem=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"SingleAward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SingleAward { get{ return _singleAward; } set{ _singleAward=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareMelting Create( string in_clientShowItem, int in_id, string in_singleAward )
    {
      DeclareMelting tmp = new DeclareMelting();
      tmp._clientShowItem = in_clientShowItem;
      tmp._id = in_id;
      tmp._singleAward = in_singleAward;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareMelting> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareMelting> _dataCaches = null;
    public static Dictionary<int, DeclareMelting> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMelting");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataMelting = require 'Lua/Config/DataMelting'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMelting");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareMelting>(280);
                     foreach (var item in dic)
                     {
                         DeclareMelting tmp = new DeclareMelting();
                       tmp.ClientShowItem = CfgStringLua.Get(item.Value[0]);
                       tmp.Id = item.Value[1];
                       tmp.SingleAward = CfgStringLua.Get(item.Value[2]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Melting");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareMelting>(280);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Melting");
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
    public static DeclareMelting Get(int id)
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
    public static void Transform(Dictionary<int, DeclareMelting> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
