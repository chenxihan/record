//文件是自动生成,请勿手动修改.来自数据文件:online_reward
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareOnlineReward")]
  public class DeclareOnlineReward
  {
    #region //私有变量定义
    //默认显示物品
    private int _q_default_item;
    //在线时长(秒)
    private int _q_onlinetime;
    //随机物品1（ID_万分之概率_数量_是否绑定（0否 1是））(@;@_@)
    private string _q_reward_item;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"QDefaultItem", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int QDefaultItem { get{ return _q_default_item; } set{ _q_default_item=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"QOnlinetime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int QOnlinetime { get{ return _q_onlinetime; } set{ _q_onlinetime=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"QRewardItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string QRewardItem { get{ return _q_reward_item; } set{ _q_reward_item=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareOnlineReward Create( int in_q_default_item, int in_q_onlinetime, string in_q_reward_item )
    {
      DeclareOnlineReward tmp = new DeclareOnlineReward();
      tmp._q_default_item = in_q_default_item;
      tmp._q_onlinetime = in_q_onlinetime;
      tmp._q_reward_item = in_q_reward_item;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareOnlineReward> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareOnlineReward> _dataCaches = null;
    public static Dictionary<int, DeclareOnlineReward> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataOnlineReward");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataOnlineReward = require 'Lua/Config/DataOnlineReward'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataOnlineReward");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareOnlineReward>(5);
                     foreach (var item in dic)
                     {
                         DeclareOnlineReward tmp = new DeclareOnlineReward();
                       tmp.QDefaultItem = item.Value[0];
                       tmp.QOnlinetime = item.Value[1];
                       tmp.QRewardItem = CfgStringLua.Get(item.Value[2]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"OnlineReward");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareOnlineReward>(5);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"OnlineReward");
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
    public static DeclareOnlineReward Get(int id)
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
    public static void Transform(Dictionary<int, DeclareOnlineReward> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
