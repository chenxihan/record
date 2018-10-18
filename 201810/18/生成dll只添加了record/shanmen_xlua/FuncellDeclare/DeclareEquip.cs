//文件是自动生成,请勿手动修改.来自数据文件:Equip
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareEquip")]
  public class DeclareEquip
  {
    #region //私有变量定义
    //初始属性：属性类型_数值，属性类型1_数值，(@;@_@)
    private string _attribute1;
    //绑定类型(0：不绑定;1：获得时绑定;2：使用后绑定)
    private int _bind;
    //填写转职id
    private int _classlevel;
    //回收时是弹出确认提示（0：不弹出;1：弹出）
    private int _confirm;
    //装备描述hide
    private string _describe;
    //1表示1个钻石，2表示2个钻石，0表示没有钻石，钻石显示为左上角
    private int _diamond_Number;
    //掉落模型ID
    private int _drop_model;
    //装备光效编号hide
    private int _effect;
    //是否可以被拆解（0为不可被拆解，1为可以被拆解）
    private int _equip_Dismantling;
    //职业限制
    //0-执笔者
    //1-拳师
    //2-大锤
    //3-太刀
    //4-卡牌
    //5-枪手
    //9-通用
    private int _gender;
    //品阶：1表示1阶，2表示2阶
    private int _grade;
    //装备icon编号hide
    private int _icon;
    //装备id,(id构成：部位，职业，品质，等级）
    private int _id;
    //是否是普通装备
    private int _if_common;
    //是否显示查看（1是;0否）
    private int _isCheck;
    //装备等级需求
    private int _level;
    //熟练等级上限
    private int _levelmax;
    //军衔id
    private int _militaryRank;
    //显示模型id
    private int _model_id;
    //装备名字
    private string _name;
    //装备部位(0头盔.1武器.2胸甲.3项链.4腰带.5腿甲.6鞋子.7戒指)
    private int _part;
    //回收价格（回收获得的金币数量）货币id_数量(@;@_@)
    private string _price;
    //产出PVP装备(不产出为0)
    private int _pvp_produce_Equip;
    //装备品质(：1.白 2.绿 3.蓝 4.紫 5.橙 6.金 7.红)
    private int _quality;
    //当前资质随机 ： 资质类型1_min_max;资质类型2_min_max;资质类型3_min_max;….(@;@_@)
    private string _quality1;
    //产出时资质上限的概率：概率_资质上限比小_大，概率_资质上限比小_大（概率总和为1万）(@;@_@)
    private string _quality2;
    //附加属性产出概率_占比; 概率_占比;….（概率总和为1万,占比放大100倍）(@;@_@)
    private string _quality3;
    //属性条数_概率; 属性条数_概率（概率总和为1万）(@;@_@)
    private string _quality4;
    //推荐极品属性显示
    private string _recommended_tips;
    //精炼消耗，道具id_数量(@;@_@)
    private string _refiningConsumption;
    //精炼成功概率1~10000（概率总和为1万）
    private int _refiningProbability;
    //洗练道具   道具id_数量(@;@_@)
    private string _resetProps;
    //装备评分
    private int _score;
    //封印吞噬经验
    private int _seal_exp;
    //技能id_万分机率；技能id_万分机率；……（概率总和为1万）(@;@_@)
    private string _skill_Bandom;
    //锁定数量及消耗，每个数字代表可锁定的技能数量，数字代表消耗(@_@)
    private string _skill_lock;
    //技能格子最大数量
    private int _skill_Number;
    //培养消耗    道具或货币id_道具id_数量(@;@_@)1:货币，2：道具
    private string _strengthening;
    //工艺品质：min_max(1000倍）(@_@)
    private string _technicalQuality;
    //装备类型：
    //0：pve装备
    //1：pvp装备
    private int _type;
    //装备品质（0.普通，1.极品，2.完美，
    private int _type1;
    //仓库积分
    private int _warehouse_integral;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Attribute1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Attribute1 { get{ return _attribute1; } set{ _attribute1=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Bind", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Bind { get{ return _bind; } set{ _bind=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Classlevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Classlevel { get{ return _classlevel; } set{ _classlevel=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Confirm", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Confirm { get{ return _confirm; } set{ _confirm=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Describe", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Describe { get{ return _describe; } set{ _describe=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"DiamondNumber", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DiamondNumber { get{ return _diamond_Number; } set{ _diamond_Number=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"DropModel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DropModel { get{ return _drop_model; } set{ _drop_model=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Effect", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Effect { get{ return _effect; } set{ _effect=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"EquipDismantling", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int EquipDismantling { get{ return _equip_Dismantling; } set{ _equip_Dismantling=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Gender", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Gender { get{ return _gender; } set{ _gender=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Grade", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Grade { get{ return _grade; } set{ _grade=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"IfCommon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int IfCommon { get{ return _if_common; } set{ _if_common=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"IsCheck", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int IsCheck { get{ return _isCheck; } set{ _isCheck=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"Levelmax", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Levelmax { get{ return _levelmax; } set{ _levelmax=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"MilitaryRank", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MilitaryRank { get{ return _militaryRank; } set{ _militaryRank=value; } }
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"ModelId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ModelId { get{ return _model_id; } set{ _model_id=value; } }
    [global::ProtoBuf.ProtoMember(20, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(21, IsRequired = true, Name=@"Part", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Part { get{ return _part; } set{ _part=value; } }
    [global::ProtoBuf.ProtoMember(22, IsRequired = true, Name=@"Price", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Price { get{ return _price; } set{ _price=value; } }
    [global::ProtoBuf.ProtoMember(23, IsRequired = true, Name=@"PvpProduceEquip", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PvpProduceEquip { get{ return _pvp_produce_Equip; } set{ _pvp_produce_Equip=value; } }
    [global::ProtoBuf.ProtoMember(24, IsRequired = true, Name=@"Quality", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Quality { get{ return _quality; } set{ _quality=value; } }
    [global::ProtoBuf.ProtoMember(25, IsRequired = true, Name=@"Quality1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Quality1 { get{ return _quality1; } set{ _quality1=value; } }
    [global::ProtoBuf.ProtoMember(26, IsRequired = true, Name=@"Quality2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Quality2 { get{ return _quality2; } set{ _quality2=value; } }
    [global::ProtoBuf.ProtoMember(27, IsRequired = true, Name=@"Quality3", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Quality3 { get{ return _quality3; } set{ _quality3=value; } }
    [global::ProtoBuf.ProtoMember(28, IsRequired = true, Name=@"Quality4", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Quality4 { get{ return _quality4; } set{ _quality4=value; } }
    [global::ProtoBuf.ProtoMember(29, IsRequired = true, Name=@"RecommendedTips", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string RecommendedTips { get{ return _recommended_tips; } set{ _recommended_tips=value; } }
    [global::ProtoBuf.ProtoMember(30, IsRequired = true, Name=@"RefiningConsumption", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string RefiningConsumption { get{ return _refiningConsumption; } set{ _refiningConsumption=value; } }
    [global::ProtoBuf.ProtoMember(31, IsRequired = true, Name=@"RefiningProbability", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int RefiningProbability { get{ return _refiningProbability; } set{ _refiningProbability=value; } }
    [global::ProtoBuf.ProtoMember(32, IsRequired = true, Name=@"ResetProps", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ResetProps { get{ return _resetProps; } set{ _resetProps=value; } }
    [global::ProtoBuf.ProtoMember(33, IsRequired = true, Name=@"Score", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Score { get{ return _score; } set{ _score=value; } }
    [global::ProtoBuf.ProtoMember(34, IsRequired = true, Name=@"SealExp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SealExp { get{ return _seal_exp; } set{ _seal_exp=value; } }
    [global::ProtoBuf.ProtoMember(35, IsRequired = true, Name=@"SkillBandom", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SkillBandom { get{ return _skill_Bandom; } set{ _skill_Bandom=value; } }
    [global::ProtoBuf.ProtoMember(36, IsRequired = true, Name=@"SkillLock", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SkillLock { get{ return _skill_lock; } set{ _skill_lock=value; } }
    [global::ProtoBuf.ProtoMember(37, IsRequired = true, Name=@"SkillNumber", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SkillNumber { get{ return _skill_Number; } set{ _skill_Number=value; } }
    [global::ProtoBuf.ProtoMember(38, IsRequired = true, Name=@"Strengthening", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Strengthening { get{ return _strengthening; } set{ _strengthening=value; } }
    [global::ProtoBuf.ProtoMember(39, IsRequired = true, Name=@"TechnicalQuality", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TechnicalQuality { get{ return _technicalQuality; } set{ _technicalQuality=value; } }
    [global::ProtoBuf.ProtoMember(40, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    [global::ProtoBuf.ProtoMember(41, IsRequired = true, Name=@"Type1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type1 { get{ return _type1; } set{ _type1=value; } }
    [global::ProtoBuf.ProtoMember(42, IsRequired = true, Name=@"WarehouseIntegral", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int WarehouseIntegral { get{ return _warehouse_integral; } set{ _warehouse_integral=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareEquip Create( string in_attribute1, int in_bind, int in_classlevel, int in_confirm, string in_describe, int in_diamond_Number, int in_drop_model, int in_effect, int in_equip_Dismantling, int in_gender, int in_grade, int in_icon, int in_id, int in_if_common, int in_isCheck, int in_level, int in_levelmax, int in_militaryRank, int in_model_id, string in_name, int in_part, string in_price, int in_pvp_produce_Equip, int in_quality, string in_quality1, string in_quality2, string in_quality3, string in_quality4, string in_recommended_tips, string in_refiningConsumption, int in_refiningProbability, string in_resetProps, int in_score, int in_seal_exp, string in_skill_Bandom, string in_skill_lock, int in_skill_Number, string in_strengthening, string in_technicalQuality, int in_type, int in_type1, int in_warehouse_integral )
    {
      DeclareEquip tmp = new DeclareEquip();
      tmp._attribute1 = in_attribute1;
      tmp._bind = in_bind;
      tmp._classlevel = in_classlevel;
      tmp._confirm = in_confirm;
      tmp._describe = in_describe;
      tmp._diamond_Number = in_diamond_Number;
      tmp._drop_model = in_drop_model;
      tmp._effect = in_effect;
      tmp._equip_Dismantling = in_equip_Dismantling;
      tmp._gender = in_gender;
      tmp._grade = in_grade;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._if_common = in_if_common;
      tmp._isCheck = in_isCheck;
      tmp._level = in_level;
      tmp._levelmax = in_levelmax;
      tmp._militaryRank = in_militaryRank;
      tmp._model_id = in_model_id;
      tmp._name = in_name;
      tmp._part = in_part;
      tmp._price = in_price;
      tmp._pvp_produce_Equip = in_pvp_produce_Equip;
      tmp._quality = in_quality;
      tmp._quality1 = in_quality1;
      tmp._quality2 = in_quality2;
      tmp._quality3 = in_quality3;
      tmp._quality4 = in_quality4;
      tmp._recommended_tips = in_recommended_tips;
      tmp._refiningConsumption = in_refiningConsumption;
      tmp._refiningProbability = in_refiningProbability;
      tmp._resetProps = in_resetProps;
      tmp._score = in_score;
      tmp._seal_exp = in_seal_exp;
      tmp._skill_Bandom = in_skill_Bandom;
      tmp._skill_lock = in_skill_lock;
      tmp._skill_Number = in_skill_Number;
      tmp._strengthening = in_strengthening;
      tmp._technicalQuality = in_technicalQuality;
      tmp._type = in_type;
      tmp._type1 = in_type1;
      tmp._warehouse_integral = in_warehouse_integral;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareEquip> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareEquip> _dataCaches = null;
    public static Dictionary<int, DeclareEquip> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataEquip");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataEquip = require 'Lua/Config/DataEquip'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataEquip");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareEquip>(5910);
                     foreach (var item in dic)
                     {
                         DeclareEquip tmp = new DeclareEquip();
                       tmp.Attribute1 = CfgStringLua.Get(item.Value[0]);
                       tmp.Bind = item.Value[1];
                       tmp.Classlevel = item.Value[2];
                       tmp.Confirm = item.Value[3];
                       tmp.Describe = CfgStringLua.Get(item.Value[4]);
                       tmp.DiamondNumber = item.Value[5];
                       tmp.DropModel = item.Value[6];
                       tmp.Effect = item.Value[7];
                       tmp.EquipDismantling = item.Value[8];
                       tmp.Gender = item.Value[9];
                       tmp.Grade = item.Value[10];
                       tmp.Icon = item.Value[11];
                       tmp.Id = item.Value[12];
                       tmp.IfCommon = item.Value[13];
                       tmp.IsCheck = item.Value[14];
                       tmp.Level = item.Value[15];
                       tmp.Levelmax = item.Value[16];
                       tmp.MilitaryRank = item.Value[17];
                       tmp.ModelId = item.Value[18];
                       tmp.Name = CfgStringLua.Get(item.Value[19]);
                       tmp.Part = item.Value[20];
                       tmp.Price = CfgStringLua.Get(item.Value[21]);
                       tmp.PvpProduceEquip = item.Value[22];
                       tmp.Quality = item.Value[23];
                       tmp.Quality1 = CfgStringLua.Get(item.Value[24]);
                       tmp.Quality2 = CfgStringLua.Get(item.Value[25]);
                       tmp.Quality3 = CfgStringLua.Get(item.Value[26]);
                       tmp.Quality4 = CfgStringLua.Get(item.Value[27]);
                       tmp.RecommendedTips = CfgStringLua.Get(item.Value[28]);
                       tmp.RefiningConsumption = CfgStringLua.Get(item.Value[29]);
                       tmp.RefiningProbability = item.Value[30];
                       tmp.ResetProps = CfgStringLua.Get(item.Value[31]);
                       tmp.Score = item.Value[32];
                       tmp.SealExp = item.Value[33];
                       tmp.SkillBandom = CfgStringLua.Get(item.Value[34]);
                       tmp.SkillLock = CfgStringLua.Get(item.Value[35]);
                       tmp.SkillNumber = item.Value[36];
                       tmp.Strengthening = CfgStringLua.Get(item.Value[37]);
                       tmp.TechnicalQuality = CfgStringLua.Get(item.Value[38]);
                       tmp.Type = item.Value[39];
                       tmp.Type1 = item.Value[40];
                       tmp.WarehouseIntegral = item.Value[41];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Equip");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareEquip>(5910);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Equip");
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
    public static DeclareEquip Get(int id)
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
    public static void Transform(Dictionary<int, DeclareEquip> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
