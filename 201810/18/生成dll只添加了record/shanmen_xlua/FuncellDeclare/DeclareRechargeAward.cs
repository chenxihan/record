//文件是自动生成,请勿手动修改.来自数据文件:RechargeAward
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareRechargeAward")]
  public class DeclareRechargeAward
  {
    #region //私有变量定义
    //奖励类型(0首充奖励；1续充奖励)
    private int _awardType;
    //装备奖励（ID_数量_是否绑定（0否1是）_职业），没有不填(@;@_@)
    private string _equipAward;
    //战斗力
    private string _fightPower;
    //奖励ID
    private int _id;
    //物品奖励ID_数量_是否绑定（0否1是）(@;@_@)
    private string _itemAward;
    //展示资源ID（模型类型_职业_模型ID_缩放(放大100倍)_旋转）(@;@_@)(第一个值为宠物模型)(0武器1时装2宠物3翅膀4图片称号)
    private string _modleId;
    //需要充值元宝
    private int _needRecharge;
    //是否公告（0不公告；1公告）
    private int _radio;
    //奖励物品名称_描述
    private string _rewardDes;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"AwardType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int AwardType { get{ return _awardType; } set{ _awardType=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"EquipAward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string EquipAward { get{ return _equipAward; } set{ _equipAward=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"FightPower", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string FightPower { get{ return _fightPower; } set{ _fightPower=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"ItemAward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ItemAward { get{ return _itemAward; } set{ _itemAward=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"ModleId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ModleId { get{ return _modleId; } set{ _modleId=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"NeedRecharge", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NeedRecharge { get{ return _needRecharge; } set{ _needRecharge=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Radio", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Radio { get{ return _radio; } set{ _radio=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"RewardDes", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string RewardDes { get{ return _rewardDes; } set{ _rewardDes=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareRechargeAward Create( int in_awardType, string in_equipAward, string in_fightPower, int in_id, string in_itemAward, string in_modleId, int in_needRecharge, int in_radio, string in_rewardDes )
    {
      DeclareRechargeAward tmp = new DeclareRechargeAward();
      tmp._awardType = in_awardType;
      tmp._equipAward = in_equipAward;
      tmp._fightPower = in_fightPower;
      tmp._id = in_id;
      tmp._itemAward = in_itemAward;
      tmp._modleId = in_modleId;
      tmp._needRecharge = in_needRecharge;
      tmp._radio = in_radio;
      tmp._rewardDes = in_rewardDes;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareRechargeAward> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareRechargeAward> _dataCaches = null;
    public static Dictionary<int, DeclareRechargeAward> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataRechargeAward");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataRechargeAward = require 'Lua/Config/DataRechargeAward'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataRechargeAward");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareRechargeAward>(9);
                     foreach (var item in dic)
                     {
                         DeclareRechargeAward tmp = new DeclareRechargeAward();
                       tmp.AwardType = item.Value[0];
                       tmp.EquipAward = CfgStringLua.Get(item.Value[1]);
                       tmp.FightPower = CfgStringLua.Get(item.Value[2]);
                       tmp.Id = item.Value[3];
                       tmp.ItemAward = CfgStringLua.Get(item.Value[4]);
                       tmp.ModleId = CfgStringLua.Get(item.Value[5]);
                       tmp.NeedRecharge = item.Value[6];
                       tmp.Radio = item.Value[7];
                       tmp.RewardDes = CfgStringLua.Get(item.Value[8]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"RechargeAward");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareRechargeAward>(9);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"RechargeAward");
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
    public static DeclareRechargeAward Get(int id)
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
    public static void Transform(Dictionary<int, DeclareRechargeAward> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
