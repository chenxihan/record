//文件是自动生成,请勿手动修改.来自数据文件:monster
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareMonster")]
  public class DeclareMonster
  {
    #region //私有变量定义
    //护甲量
    private int _armor;
    //护甲是否会掉（0，会掉；1,不会掉）
    private int _armor_if;
    //怪物攻击模式（0不反击，1主动，2被动）
    private int _attack_type;
    //本级属性(@;@_@)
    private string _attributeValue;
    //掉落的血之精魄
    private int _blood;
    //出生特效 other目录下（hide）
    private int _brithVfx;
    //阵营(0玩家 3怪物)
    private int _camp;
    //是否能够被选中
    private int _can_be_select;
    //破坏物信息（破坏类型(1:部位破坏，2:静态物体替换）_部位索引_条件类型(0:默认条件，1:血量条件)_条件值_动画索引_隐藏时间(-1:不隐藏）
    private string _damageInfo;
    //是否进行死亡特写，0不特写，1特写（hide）
    private int _dead_feature;
    //是否能够被死亡击飞（0不能，1能）（hide）
    private int _dead_hit_fly;
    //怪物气泡对白
    private string _dialog;
    //死亡时音效编号
    private int _die_soundid;
    //掉落经验
    private Int64 _exp;
    //被击飞效果的百分比（0-100）（hide）
    private int _hit_fly_percent;
    //boss血条数量hide
    private int _hP_num;
    //头像
    private int _icon;
    //怪物id
    private int _id;
    //等级
    private int _level;
    //血量
    private Int64 _maxHp;
    //怪物类型(1普通小怪,2精英,3BOSS，4特殊，5野外精英，6野外BOSS,7BOSS掉落后给自己通知,8静态破坏物),9创世神殿元素怪,10防御塔,11荣耀战场小兵;12荣耀战场傀儡;13荣耀战场防御塔;14荣耀战场基地水晶;
    private int _monster_type;
    //怪物名
    private string _name;
    //是否使用玩家模型(0不使用，1使用)
    private int _playerModel;
    //身体ID_武器ID_披风ID
    private string _playerModelRes;
    //资源
    private int _res;
    //怪物战斗力（用于判断是否进行战斗力的压制，空或零都不进行战斗力压制）
    private int _score;
    //模型缩放（百分比）
    private int _size_scale;
    //受击半径（厘米）
    private int _strike_distance;
    //任务剧情，在主角有指定的任务并且靠近怪物时播放动画，任务ID_剧情ID(hide)
    private string _task_cinematic;
    //怪物隐藏（用于任务,任务类型_任务ID;任务类型_任务ID）(@;@_@)
    private string _taskShow;
    //怪物称号hide
    private string _title;
    //怪物使用的技能ID(@;@)
    private string _use_skills;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Armor", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Armor { get{ return _armor; } set{ _armor=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"ArmorIf", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ArmorIf { get{ return _armor_if; } set{ _armor_if=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"AttackType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int AttackType { get{ return _attack_type; } set{ _attack_type=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"AttributeValue", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string AttributeValue { get{ return _attributeValue; } set{ _attributeValue=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Blood", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Blood { get{ return _blood; } set{ _blood=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"BrithVfx", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BrithVfx { get{ return _brithVfx; } set{ _brithVfx=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Camp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Camp { get{ return _camp; } set{ _camp=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"CanBeSelect", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanBeSelect { get{ return _can_be_select; } set{ _can_be_select=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"DamageInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DamageInfo { get{ return _damageInfo; } set{ _damageInfo=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"DeadFeature", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DeadFeature { get{ return _dead_feature; } set{ _dead_feature=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"DeadHitFly", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DeadHitFly { get{ return _dead_hit_fly; } set{ _dead_hit_fly=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"Dialog", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Dialog { get{ return _dialog; } set{ _dialog=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"DieSoundid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DieSoundid { get{ return _die_soundid; } set{ _die_soundid=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"Exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Int64 Exp { get{ return _exp; } set{ _exp=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"HitFlyPercent", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int HitFlyPercent { get{ return _hit_fly_percent; } set{ _hit_fly_percent=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"HPNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int HPNum { get{ return _hP_num; } set{ _hP_num=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(20, IsRequired = true, Name=@"MaxHp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Int64 MaxHp { get{ return _maxHp; } set{ _maxHp=value; } }
    [global::ProtoBuf.ProtoMember(21, IsRequired = true, Name=@"MonsterType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MonsterType { get{ return _monster_type; } set{ _monster_type=value; } }
    [global::ProtoBuf.ProtoMember(22, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(23, IsRequired = true, Name=@"PlayerModel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PlayerModel { get{ return _playerModel; } set{ _playerModel=value; } }
    [global::ProtoBuf.ProtoMember(24, IsRequired = true, Name=@"PlayerModelRes", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string PlayerModelRes { get{ return _playerModelRes; } set{ _playerModelRes=value; } }
    [global::ProtoBuf.ProtoMember(25, IsRequired = true, Name=@"Res", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Res { get{ return _res; } set{ _res=value; } }
    [global::ProtoBuf.ProtoMember(26, IsRequired = true, Name=@"Score", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Score { get{ return _score; } set{ _score=value; } }
    [global::ProtoBuf.ProtoMember(27, IsRequired = true, Name=@"SizeScale", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SizeScale { get{ return _size_scale; } set{ _size_scale=value; } }
    [global::ProtoBuf.ProtoMember(28, IsRequired = true, Name=@"StrikeDistance", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int StrikeDistance { get{ return _strike_distance; } set{ _strike_distance=value; } }
    [global::ProtoBuf.ProtoMember(29, IsRequired = true, Name=@"TaskCinematic", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TaskCinematic { get{ return _task_cinematic; } set{ _task_cinematic=value; } }
    [global::ProtoBuf.ProtoMember(30, IsRequired = true, Name=@"TaskShow", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TaskShow { get{ return _taskShow; } set{ _taskShow=value; } }
    [global::ProtoBuf.ProtoMember(31, IsRequired = true, Name=@"Title", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Title { get{ return _title; } set{ _title=value; } }
    [global::ProtoBuf.ProtoMember(32, IsRequired = true, Name=@"UseSkills", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string UseSkills { get{ return _use_skills; } set{ _use_skills=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareMonster Create( int in_armor, int in_armor_if, int in_attack_type, string in_attributeValue, int in_blood, int in_brithVfx, int in_camp, int in_can_be_select, string in_damageInfo, int in_dead_feature, int in_dead_hit_fly, string in_dialog, int in_die_soundid, Int64 in_exp, int in_hit_fly_percent, int in_hP_num, int in_icon, int in_id, int in_level, Int64 in_maxHp, int in_monster_type, string in_name, int in_playerModel, string in_playerModelRes, int in_res, int in_score, int in_size_scale, int in_strike_distance, string in_task_cinematic, string in_taskShow, string in_title, string in_use_skills )
    {
      DeclareMonster tmp = new DeclareMonster();
      tmp._armor = in_armor;
      tmp._armor_if = in_armor_if;
      tmp._attack_type = in_attack_type;
      tmp._attributeValue = in_attributeValue;
      tmp._blood = in_blood;
      tmp._brithVfx = in_brithVfx;
      tmp._camp = in_camp;
      tmp._can_be_select = in_can_be_select;
      tmp._damageInfo = in_damageInfo;
      tmp._dead_feature = in_dead_feature;
      tmp._dead_hit_fly = in_dead_hit_fly;
      tmp._dialog = in_dialog;
      tmp._die_soundid = in_die_soundid;
      tmp._exp = in_exp;
      tmp._hit_fly_percent = in_hit_fly_percent;
      tmp._hP_num = in_hP_num;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._level = in_level;
      tmp._maxHp = in_maxHp;
      tmp._monster_type = in_monster_type;
      tmp._name = in_name;
      tmp._playerModel = in_playerModel;
      tmp._playerModelRes = in_playerModelRes;
      tmp._res = in_res;
      tmp._score = in_score;
      tmp._size_scale = in_size_scale;
      tmp._strike_distance = in_strike_distance;
      tmp._task_cinematic = in_task_cinematic;
      tmp._taskShow = in_taskShow;
      tmp._title = in_title;
      tmp._use_skills = in_use_skills;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareMonster> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareMonster> _dataCaches = null;
    public static Dictionary<int, DeclareMonster> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMonster");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataMonster = require 'Lua/Config/DataMonster'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMonster");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareMonster>(6774);
                     foreach (var item in dic)
                     {
                         DeclareMonster tmp = new DeclareMonster();
                       tmp.Armor = item.Value[0];
                       tmp.ArmorIf = item.Value[1];
                       tmp.AttackType = item.Value[2];
                       tmp.AttributeValue = CfgStringLua.Get(item.Value[3]);
                       tmp.Blood = item.Value[4];
                       tmp.BrithVfx = item.Value[5];
                       tmp.Camp = item.Value[6];
                       tmp.CanBeSelect = item.Value[7];
                       tmp.DamageInfo = CfgStringLua.Get(item.Value[8]);
                       tmp.DeadFeature = item.Value[9];
                       tmp.DeadHitFly = item.Value[10];
                       tmp.Dialog = CfgStringLua.Get(item.Value[11]);
                       tmp.DieSoundid = item.Value[12];
                       tmp.Exp = item.Value[13];
                       tmp.HitFlyPercent = item.Value[14];
                       tmp.HPNum = item.Value[15];
                       tmp.Icon = item.Value[16];
                       tmp.Id = item.Value[17];
                       tmp.Level = item.Value[18];
                       tmp.MaxHp = item.Value[19];
                       tmp.MonsterType = item.Value[20];
                       tmp.Name = CfgStringLua.Get(item.Value[21]);
                       tmp.PlayerModel = item.Value[22];
                       tmp.PlayerModelRes = CfgStringLua.Get(item.Value[23]);
                       tmp.Res = item.Value[24];
                       tmp.Score = item.Value[25];
                       tmp.SizeScale = item.Value[26];
                       tmp.StrikeDistance = item.Value[27];
                       tmp.TaskCinematic = CfgStringLua.Get(item.Value[28]);
                       tmp.TaskShow = CfgStringLua.Get(item.Value[29]);
                       tmp.Title = CfgStringLua.Get(item.Value[30]);
                       tmp.UseSkills = CfgStringLua.Get(item.Value[31]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Monster");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareMonster>(6774);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Monster");
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
    public static DeclareMonster Get(int id)
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
    public static void Transform(Dictionary<int, DeclareMonster> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
