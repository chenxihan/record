//文件是自动生成,请勿手动修改.来自数据文件:vipLevel
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareVipLevel")]
  public class DeclareVipLevel
  {
    #region //私有变量定义
    //增加商城购买次数上限（商品ID）(@;@_@)
    private string _addBuyCount;
    //增加道具使用上限次数（包括每日上限和总使用上限）(@;@_@)
    private string _addItemUseCount;
    //元素神殿进入次数
    private int _bossElementsTemple;
    //洪荒副本进入次数
    private int _bossGodCloneNum;
    //每日可进入众神遗迹次数
    private int _bossGodRuinsNum;
    //是否可进入BOSS之家（0否，1是）
    private int _bossHome;
    //个人BOSS额外可参与次数，免费
    private int _bossPersonalNum;
    //杀怪获取经验值buffID
    private int _buffID;
    //能否免费传送
    private int _canFreeTranspot;
    //是否可以在拍卖行上架道具（0否.1是）
    private int _canSell;
    //是否可以扫荡历险副本（0否.1是）
    private int _canSkipCloneStory;
    //额外狂轰乱炸次数
    private int _cloneBombing;
    //经验副本额外购买次数
    private int _cloneExpNum;
    //额外多人副本购买次数
    private int _cloneManyPeople;
    //历险副本额外购买次数
    private int _cloneStoryNum;
    //额外试炼之地购买次数
    private int _cloneTrial;
    //描述hide
    private string _des;
    //装备奖励（ID_数量_是否绑定（0否1是）_职业）(@;@_@)
    private string _equip;
    //礼包（物品id_物品数量_绑定;）(@;@_@)
    private string _gift;
    //灵车漂移购买次数
    private int _hearseDiftNum;
    //VIP等级
    private int _level;
    //需要消耗的元宝数
    private int _needSpend;
    //每日祈祷经验次数
    private int _prayExpNum;
    //祈祷金币双倍暴击概率（万分比）
    private int _prayMoneyCritChance;
    //每日祈祷金币次数
    private int _prayMoneyNum;
    //图片称号ID
    private int _titleID;
    //生效时间 秒 -1表示永久
    private int _titleIDtime;
    //如果是道具激活的VIP存活时间，时间到了转到下一个VIP等级并且也是有过期时间的
    private int _vipOverTime;
    //英灵殿额外购买次数
    private int _yingLingDianNum;
    //永夜幻境额外Boss收益次数，免费
    private int _yyHuanJingNum;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"AddBuyCount", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string AddBuyCount { get{ return _addBuyCount; } set{ _addBuyCount=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"AddItemUseCount", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string AddItemUseCount { get{ return _addItemUseCount; } set{ _addItemUseCount=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"BossElementsTemple", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BossElementsTemple { get{ return _bossElementsTemple; } set{ _bossElementsTemple=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"BossGodCloneNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BossGodCloneNum { get{ return _bossGodCloneNum; } set{ _bossGodCloneNum=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"BossGodRuinsNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BossGodRuinsNum { get{ return _bossGodRuinsNum; } set{ _bossGodRuinsNum=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"BossHome", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BossHome { get{ return _bossHome; } set{ _bossHome=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"BossPersonalNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BossPersonalNum { get{ return _bossPersonalNum; } set{ _bossPersonalNum=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"BuffID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BuffID { get{ return _buffID; } set{ _buffID=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"CanFreeTranspot", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanFreeTranspot { get{ return _canFreeTranspot; } set{ _canFreeTranspot=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"CanSell", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanSell { get{ return _canSell; } set{ _canSell=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"CanSkipCloneStory", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanSkipCloneStory { get{ return _canSkipCloneStory; } set{ _canSkipCloneStory=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"CloneBombing", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CloneBombing { get{ return _cloneBombing; } set{ _cloneBombing=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"CloneExpNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CloneExpNum { get{ return _cloneExpNum; } set{ _cloneExpNum=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"CloneManyPeople", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CloneManyPeople { get{ return _cloneManyPeople; } set{ _cloneManyPeople=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"CloneStoryNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CloneStoryNum { get{ return _cloneStoryNum; } set{ _cloneStoryNum=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"CloneTrial", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CloneTrial { get{ return _cloneTrial; } set{ _cloneTrial=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"Des", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Des { get{ return _des; } set{ _des=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"Equip", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Equip { get{ return _equip; } set{ _equip=value; } }
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"Gift", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Gift { get{ return _gift; } set{ _gift=value; } }
    [global::ProtoBuf.ProtoMember(20, IsRequired = true, Name=@"HearseDiftNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int HearseDiftNum { get{ return _hearseDiftNum; } set{ _hearseDiftNum=value; } }
    [global::ProtoBuf.ProtoMember(21, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(22, IsRequired = true, Name=@"NeedSpend", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NeedSpend { get{ return _needSpend; } set{ _needSpend=value; } }
    [global::ProtoBuf.ProtoMember(23, IsRequired = true, Name=@"PrayExpNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PrayExpNum { get{ return _prayExpNum; } set{ _prayExpNum=value; } }
    [global::ProtoBuf.ProtoMember(24, IsRequired = true, Name=@"PrayMoneyCritChance", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PrayMoneyCritChance { get{ return _prayMoneyCritChance; } set{ _prayMoneyCritChance=value; } }
    [global::ProtoBuf.ProtoMember(25, IsRequired = true, Name=@"PrayMoneyNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PrayMoneyNum { get{ return _prayMoneyNum; } set{ _prayMoneyNum=value; } }
    [global::ProtoBuf.ProtoMember(26, IsRequired = true, Name=@"TitleID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TitleID { get{ return _titleID; } set{ _titleID=value; } }
    [global::ProtoBuf.ProtoMember(27, IsRequired = true, Name=@"TitleIDtime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TitleIDtime { get{ return _titleIDtime; } set{ _titleIDtime=value; } }
    [global::ProtoBuf.ProtoMember(28, IsRequired = true, Name=@"VipOverTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int VipOverTime { get{ return _vipOverTime; } set{ _vipOverTime=value; } }
    [global::ProtoBuf.ProtoMember(29, IsRequired = true, Name=@"YingLingDianNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int YingLingDianNum { get{ return _yingLingDianNum; } set{ _yingLingDianNum=value; } }
    [global::ProtoBuf.ProtoMember(30, IsRequired = true, Name=@"YyHuanJingNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int YyHuanJingNum { get{ return _yyHuanJingNum; } set{ _yyHuanJingNum=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareVipLevel Create( string in_addBuyCount, string in_addItemUseCount, int in_bossElementsTemple, int in_bossGodCloneNum, int in_bossGodRuinsNum, int in_bossHome, int in_bossPersonalNum, int in_buffID, int in_canFreeTranspot, int in_canSell, int in_canSkipCloneStory, int in_cloneBombing, int in_cloneExpNum, int in_cloneManyPeople, int in_cloneStoryNum, int in_cloneTrial, string in_des, string in_equip, string in_gift, int in_hearseDiftNum, int in_level, int in_needSpend, int in_prayExpNum, int in_prayMoneyCritChance, int in_prayMoneyNum, int in_titleID, int in_titleIDtime, int in_vipOverTime, int in_yingLingDianNum, int in_yyHuanJingNum )
    {
      DeclareVipLevel tmp = new DeclareVipLevel();
      tmp._addBuyCount = in_addBuyCount;
      tmp._addItemUseCount = in_addItemUseCount;
      tmp._bossElementsTemple = in_bossElementsTemple;
      tmp._bossGodCloneNum = in_bossGodCloneNum;
      tmp._bossGodRuinsNum = in_bossGodRuinsNum;
      tmp._bossHome = in_bossHome;
      tmp._bossPersonalNum = in_bossPersonalNum;
      tmp._buffID = in_buffID;
      tmp._canFreeTranspot = in_canFreeTranspot;
      tmp._canSell = in_canSell;
      tmp._canSkipCloneStory = in_canSkipCloneStory;
      tmp._cloneBombing = in_cloneBombing;
      tmp._cloneExpNum = in_cloneExpNum;
      tmp._cloneManyPeople = in_cloneManyPeople;
      tmp._cloneStoryNum = in_cloneStoryNum;
      tmp._cloneTrial = in_cloneTrial;
      tmp._des = in_des;
      tmp._equip = in_equip;
      tmp._gift = in_gift;
      tmp._hearseDiftNum = in_hearseDiftNum;
      tmp._level = in_level;
      tmp._needSpend = in_needSpend;
      tmp._prayExpNum = in_prayExpNum;
      tmp._prayMoneyCritChance = in_prayMoneyCritChance;
      tmp._prayMoneyNum = in_prayMoneyNum;
      tmp._titleID = in_titleID;
      tmp._titleIDtime = in_titleIDtime;
      tmp._vipOverTime = in_vipOverTime;
      tmp._yingLingDianNum = in_yingLingDianNum;
      tmp._yyHuanJingNum = in_yyHuanJingNum;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareVipLevel> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareVipLevel> _dataCaches = null;
    public static Dictionary<int, DeclareVipLevel> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataVipLevel");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataVipLevel = require 'Lua/Config/DataVipLevel'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataVipLevel");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareVipLevel>(10);
                     foreach (var item in dic)
                     {
                         DeclareVipLevel tmp = new DeclareVipLevel();
                       tmp.AddBuyCount = CfgStringLua.Get(item.Value[0]);
                       tmp.AddItemUseCount = CfgStringLua.Get(item.Value[1]);
                       tmp.BossElementsTemple = item.Value[2];
                       tmp.BossGodCloneNum = item.Value[3];
                       tmp.BossGodRuinsNum = item.Value[4];
                       tmp.BossHome = item.Value[5];
                       tmp.BossPersonalNum = item.Value[6];
                       tmp.BuffID = item.Value[7];
                       tmp.CanFreeTranspot = item.Value[8];
                       tmp.CanSell = item.Value[9];
                       tmp.CanSkipCloneStory = item.Value[10];
                       tmp.CloneBombing = item.Value[11];
                       tmp.CloneExpNum = item.Value[12];
                       tmp.CloneManyPeople = item.Value[13];
                       tmp.CloneStoryNum = item.Value[14];
                       tmp.CloneTrial = item.Value[15];
                       tmp.Des = CfgStringLua.Get(item.Value[16]);
                       tmp.Equip = CfgStringLua.Get(item.Value[17]);
                       tmp.Gift = CfgStringLua.Get(item.Value[18]);
                       tmp.HearseDiftNum = item.Value[19];
                       tmp.Level = item.Value[20];
                       tmp.NeedSpend = item.Value[21];
                       tmp.PrayExpNum = item.Value[22];
                       tmp.PrayMoneyCritChance = item.Value[23];
                       tmp.PrayMoneyNum = item.Value[24];
                       tmp.TitleID = item.Value[25];
                       tmp.TitleIDtime = item.Value[26];
                       tmp.VipOverTime = item.Value[27];
                       tmp.YingLingDianNum = item.Value[28];
                       tmp.YyHuanJingNum = item.Value[29];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"VipLevel");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareVipLevel>(10);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"VipLevel");
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
    public static DeclareVipLevel Get(int id)
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
    public static void Transform(Dictionary<int, DeclareVipLevel> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
