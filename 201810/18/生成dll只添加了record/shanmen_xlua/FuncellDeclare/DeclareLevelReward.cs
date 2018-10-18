//文件是自动生成,请勿手动修改.来自数据文件:level_reward
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareLevelReward")]
  public class DeclareLevelReward
  {
    #region //私有变量定义
    //限制数据，-1为不限，0 为不可领，大于0为可领数量
    private int _limitValue;
    //是否显示气泡0否1是
    private int _paoPao;
    //等级要求
    private int _q_level;
    //装备,ID_数量_是否绑定（0否 1是）_职业(@;@_@)
    private string _q_reward_equip;
    //奖励,ID_数量_是否绑定（0否 1是）(@;@_@)
    private string _q_reward_item;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"LimitValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int LimitValue { get{ return _limitValue; } set{ _limitValue=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"PaoPao", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PaoPao { get{ return _paoPao; } set{ _paoPao=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"QLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int QLevel { get{ return _q_level; } set{ _q_level=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"QRewardEquip", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string QRewardEquip { get{ return _q_reward_equip; } set{ _q_reward_equip=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"QRewardItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string QRewardItem { get{ return _q_reward_item; } set{ _q_reward_item=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareLevelReward Create( int in_limitValue, int in_paoPao, int in_q_level, string in_q_reward_equip, string in_q_reward_item )
    {
      DeclareLevelReward tmp = new DeclareLevelReward();
      tmp._limitValue = in_limitValue;
      tmp._paoPao = in_paoPao;
      tmp._q_level = in_q_level;
      tmp._q_reward_equip = in_q_reward_equip;
      tmp._q_reward_item = in_q_reward_item;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareLevelReward> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareLevelReward> _dataCaches = null;
    public static Dictionary<int, DeclareLevelReward> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataLevelReward");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataLevelReward = require 'Lua/Config/DataLevelReward'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataLevelReward");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareLevelReward>(12);
                     foreach (var item in dic)
                     {
                         DeclareLevelReward tmp = new DeclareLevelReward();
                       tmp.LimitValue = item.Value[0];
                       tmp.PaoPao = item.Value[1];
                       tmp.QLevel = item.Value[2];
                       tmp.QRewardEquip = CfgStringLua.Get(item.Value[3]);
                       tmp.QRewardItem = CfgStringLua.Get(item.Value[4]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"LevelReward");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareLevelReward>(12);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"LevelReward");
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
    public static DeclareLevelReward Get(int id)
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
    public static void Transform(Dictionary<int, DeclareLevelReward> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
