//文件是自动生成,请勿手动修改.来自数据文件:recharge_daygift
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareRechargeDaygift")]
  public class DeclareRechargeDaygift
  {
    #region //私有变量定义
    //礼包描述
    private string _desAward;
    //等值钻石
    private int _gold;
    //礼包ID
    private int _id;
    //物品表礼包ID
    private int _itemAward;
    //等级限制
    private int _level;
    //需要充值金额
    private int _needRecharge;
    //是否公告（0不公告；1公告）
    private int _radio;
    //奖励的物品
    private string _rewards;
    //VIP限制
    private int _vip;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"DesAward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DesAward { get{ return _desAward; } set{ _desAward=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Gold", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Gold { get{ return _gold; } set{ _gold=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"ItemAward", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ItemAward { get{ return _itemAward; } set{ _itemAward=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"NeedRecharge", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NeedRecharge { get{ return _needRecharge; } set{ _needRecharge=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Radio", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Radio { get{ return _radio; } set{ _radio=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Rewards", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Rewards { get{ return _rewards; } set{ _rewards=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Vip", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Vip { get{ return _vip; } set{ _vip=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareRechargeDaygift Create( string in_desAward, int in_gold, int in_id, int in_itemAward, int in_level, int in_needRecharge, int in_radio, string in_rewards, int in_vip )
    {
      DeclareRechargeDaygift tmp = new DeclareRechargeDaygift();
      tmp._desAward = in_desAward;
      tmp._gold = in_gold;
      tmp._id = in_id;
      tmp._itemAward = in_itemAward;
      tmp._level = in_level;
      tmp._needRecharge = in_needRecharge;
      tmp._radio = in_radio;
      tmp._rewards = in_rewards;
      tmp._vip = in_vip;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareRechargeDaygift> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareRechargeDaygift> _dataCaches = null;
    public static Dictionary<int, DeclareRechargeDaygift> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataRechargeDaygift");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataRechargeDaygift = require 'Lua/Config/DataRechargeDaygift'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataRechargeDaygift");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareRechargeDaygift>(3);
                     foreach (var item in dic)
                     {
                         DeclareRechargeDaygift tmp = new DeclareRechargeDaygift();
                       tmp.DesAward = CfgStringLua.Get(item.Value[0]);
                       tmp.Gold = item.Value[1];
                       tmp.Id = item.Value[2];
                       tmp.ItemAward = item.Value[3];
                       tmp.Level = item.Value[4];
                       tmp.NeedRecharge = item.Value[5];
                       tmp.Radio = item.Value[6];
                       tmp.Rewards = CfgStringLua.Get(item.Value[7]);
                       tmp.Vip = item.Value[8];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"RechargeDaygift");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareRechargeDaygift>(3);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"RechargeDaygift");
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
    public static DeclareRechargeDaygift Get(int id)
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
    public static void Transform(Dictionary<int, DeclareRechargeDaygift> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
