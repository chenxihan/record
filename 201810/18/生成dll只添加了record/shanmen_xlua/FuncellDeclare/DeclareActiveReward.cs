//文件是自动生成,请勿手动修改.来自数据文件:active_reward
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareActiveReward")]
  public class DeclareActiveReward
  {
    #region //私有变量定义
    //开启需要积分
    private int _q_needintegral;
    //奖励物品1(物品ID_数量_绑定)(@;@_@)
    private string _q_reward_item;
    //开服前七天额外奖励
    private string _q_reward_seven;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"QNeedintegral", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int QNeedintegral { get{ return _q_needintegral; } set{ _q_needintegral=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"QRewardItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string QRewardItem { get{ return _q_reward_item; } set{ _q_reward_item=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"QRewardSeven", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string QRewardSeven { get{ return _q_reward_seven; } set{ _q_reward_seven=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareActiveReward Create( int in_q_needintegral, string in_q_reward_item, string in_q_reward_seven )
    {
      DeclareActiveReward tmp = new DeclareActiveReward();
      tmp._q_needintegral = in_q_needintegral;
      tmp._q_reward_item = in_q_reward_item;
      tmp._q_reward_seven = in_q_reward_seven;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareActiveReward> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareActiveReward> _dataCaches = null;
    public static Dictionary<int, DeclareActiveReward> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataActiveReward");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataActiveReward = require 'Lua/Config/DataActiveReward'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataActiveReward");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareActiveReward>(5);
                     foreach (var item in dic)
                     {
                         DeclareActiveReward tmp = new DeclareActiveReward();
                       tmp.QNeedintegral = item.Value[0];
                       tmp.QRewardItem = CfgStringLua.Get(item.Value[1]);
                       tmp.QRewardSeven = CfgStringLua.Get(item.Value[2]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"ActiveReward");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareActiveReward>(5);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"ActiveReward");
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
    public static DeclareActiveReward Get(int id)
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
    public static void Transform(Dictionary<int, DeclareActiveReward> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
