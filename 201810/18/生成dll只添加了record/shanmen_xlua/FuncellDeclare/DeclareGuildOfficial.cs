//文件是自动生成,请勿手动修改.来自数据文件:guild_official
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareGuildOfficial")]
  public class DeclareGuildOfficial
  {
    #region //私有变量定义
    //同意其他玩家进入公会（0不能1能）
    private int _canAgree;
    //修改设置（0不能1能）
    private int _canAlter;
    //帮会召集(0不能1能)
    private int _canCall;
    //是否能销毁仓库物品
    private int _canDestory;
    //喊话招人
    private int _canHan;
    //邀请其他玩家（0不能1能）
    private int _canInvite;
    //踢人（0不能1能）
    private int _canKick;
    //官职任免(0不能1能)
    private int _canSetOfficial;
    //升级建筑（0不能1能）
    private int _canUp;
    //城市战报名权限
    private int _city_match;
    //是否能分配公会战道具
    private int _distribution_itme;
    //是否能参加帮会战
    private int _guild_fighting;
    //跨服公会联赛报名权限
    private int _kuafu_match;
    //官职（1普通成员，2长老，3副会长，4会长,0学徒）
    private int _level;
    //是否显示更改官职(0为不显示)hide
    private int _modify_office_according;
    //官职人数限制(0无限制）
    private int _num;
    //技能研究
    private int _research_skill;
    //语音权限（任命指挥）
    private int _voice;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"CanAgree", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanAgree { get{ return _canAgree; } set{ _canAgree=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"CanAlter", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanAlter { get{ return _canAlter; } set{ _canAlter=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"CanCall", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanCall { get{ return _canCall; } set{ _canCall=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"CanDestory", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanDestory { get{ return _canDestory; } set{ _canDestory=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"CanHan", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanHan { get{ return _canHan; } set{ _canHan=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"CanInvite", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanInvite { get{ return _canInvite; } set{ _canInvite=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"CanKick", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanKick { get{ return _canKick; } set{ _canKick=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"CanSetOfficial", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanSetOfficial { get{ return _canSetOfficial; } set{ _canSetOfficial=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"CanUp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanUp { get{ return _canUp; } set{ _canUp=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"CityMatch", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CityMatch { get{ return _city_match; } set{ _city_match=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"DistributionItme", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DistributionItme { get{ return _distribution_itme; } set{ _distribution_itme=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"GuildFighting", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int GuildFighting { get{ return _guild_fighting; } set{ _guild_fighting=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"KuafuMatch", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int KuafuMatch { get{ return _kuafu_match; } set{ _kuafu_match=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"ModifyOfficeAccording", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ModifyOfficeAccording { get{ return _modify_office_according; } set{ _modify_office_according=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"Num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Num { get{ return _num; } set{ _num=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"ResearchSkill", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ResearchSkill { get{ return _research_skill; } set{ _research_skill=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"Voice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Voice { get{ return _voice; } set{ _voice=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareGuildOfficial Create( int in_canAgree, int in_canAlter, int in_canCall, int in_canDestory, int in_canHan, int in_canInvite, int in_canKick, int in_canSetOfficial, int in_canUp, int in_city_match, int in_distribution_itme, int in_guild_fighting, int in_kuafu_match, int in_level, int in_modify_office_according, int in_num, int in_research_skill, int in_voice )
    {
      DeclareGuildOfficial tmp = new DeclareGuildOfficial();
      tmp._canAgree = in_canAgree;
      tmp._canAlter = in_canAlter;
      tmp._canCall = in_canCall;
      tmp._canDestory = in_canDestory;
      tmp._canHan = in_canHan;
      tmp._canInvite = in_canInvite;
      tmp._canKick = in_canKick;
      tmp._canSetOfficial = in_canSetOfficial;
      tmp._canUp = in_canUp;
      tmp._city_match = in_city_match;
      tmp._distribution_itme = in_distribution_itme;
      tmp._guild_fighting = in_guild_fighting;
      tmp._kuafu_match = in_kuafu_match;
      tmp._level = in_level;
      tmp._modify_office_according = in_modify_office_according;
      tmp._num = in_num;
      tmp._research_skill = in_research_skill;
      tmp._voice = in_voice;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareGuildOfficial> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareGuildOfficial> _dataCaches = null;
    public static Dictionary<int, DeclareGuildOfficial> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGuildOfficial");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataGuildOfficial = require 'Lua/Config/DataGuildOfficial'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGuildOfficial");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareGuildOfficial>(5);
                     foreach (var item in dic)
                     {
                         DeclareGuildOfficial tmp = new DeclareGuildOfficial();
                       tmp.CanAgree = item.Value[0];
                       tmp.CanAlter = item.Value[1];
                       tmp.CanCall = item.Value[2];
                       tmp.CanDestory = item.Value[3];
                       tmp.CanHan = item.Value[4];
                       tmp.CanInvite = item.Value[5];
                       tmp.CanKick = item.Value[6];
                       tmp.CanSetOfficial = item.Value[7];
                       tmp.CanUp = item.Value[8];
                       tmp.CityMatch = item.Value[9];
                       tmp.DistributionItme = item.Value[10];
                       tmp.GuildFighting = item.Value[11];
                       tmp.KuafuMatch = item.Value[12];
                       tmp.Level = item.Value[13];
                       tmp.ModifyOfficeAccording = item.Value[14];
                       tmp.Num = item.Value[15];
                       tmp.ResearchSkill = item.Value[16];
                       tmp.Voice = item.Value[17];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"GuildOfficial");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareGuildOfficial>(5);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"GuildOfficial");
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
    public static DeclareGuildOfficial Get(int id)
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
    public static void Transform(Dictionary<int, DeclareGuildOfficial> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
