//文件是自动生成,请勿手动修改.来自数据文件:PlayerSkill
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclarePlayerSkill")]
  public class DeclarePlayerSkill
  {
    #region //私有变量定义
    //基础分支连击数据，连击类型_类型参数（连击方式，0手动限时连击，1手动不限时连击，2触发连击）（hide）
    private string _base_branch_combo;
    //基础分支，配置技能列表，如果只有一个技能表示没有连击，多个技能必须要配置连击数据(@_@)
    private string _base_branch_skills;
    //技能基础描述（hide）显示第一个分支的第一个技能的伤害数据
    private string _base_desc;
    //基础分支开启条件（hide）
    private string _base_open_desc;
    //分支连击数据，连击类型_类型参数（连击方式，0手动限时连击，1手动不限时连击，2触发连击）（hide）
    private string _branch_1_combo;
    //分支描述(hide)
    private string _branch_1_desc;
    //分支1开启条件（hide）
    private string _branch_1_open_desc;
    //其他分支，配置技能列表，如果只有一个技能表示没有连击，多个技能必须要配置连击数据(@_@)
    private string _branch_1_skills;
    //分支连击数据，连击类型_类型参数（连击方式，0手动限时连击，1手动不限时连击，2触发连击）（hide）
    private string _branch_2_combo;
    //分支描述(hide)
    private string _branch_2_desc;
    //分支2开启条件（hide）
    private string _branch_2_open_desc;
    //其他分支，配置技能列表，如果只有一个技能表示没有连击，多个技能必须要配置连击数据(@_@)
    private string _branch_2_skills;
    //分支连击数据，连击类型_类型参数（连击方式，0手动限时连击，1手动不限时连击，2触发连击）（hide）
    private string _branch_3_combo;
    //分支描述(hide)
    private string _branch_3_desc;
    //分支3开启条件（hide）
    private string _branch_3_open_desc;
    //其他分支，配置技能列表，如果只有一个技能表示没有连击，多个技能必须要配置连击数据(@_@)
    private string _branch_3_skills;
    //是否进化0，没有。1有
    private int _evolution;
    //ID=职业id*100+技能位置ID（职业0学生，1拳师，2大锤，3剑客，4卡牌，5枪手）（技能位置1-5，1为普通攻击）
    private int _id;
    //职业
    private int _occ;
    //技能位置
    private int _pos;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"BaseBranchCombo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string BaseBranchCombo { get{ return _base_branch_combo; } set{ _base_branch_combo=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"BaseBranchSkills", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string BaseBranchSkills { get{ return _base_branch_skills; } set{ _base_branch_skills=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"BaseDesc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string BaseDesc { get{ return _base_desc; } set{ _base_desc=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"BaseOpenDesc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string BaseOpenDesc { get{ return _base_open_desc; } set{ _base_open_desc=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Branch1Combo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Branch1Combo { get{ return _branch_1_combo; } set{ _branch_1_combo=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Branch1Desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Branch1Desc { get{ return _branch_1_desc; } set{ _branch_1_desc=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Branch1OpenDesc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Branch1OpenDesc { get{ return _branch_1_open_desc; } set{ _branch_1_open_desc=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Branch1Skills", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Branch1Skills { get{ return _branch_1_skills; } set{ _branch_1_skills=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Branch2Combo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Branch2Combo { get{ return _branch_2_combo; } set{ _branch_2_combo=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Branch2Desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Branch2Desc { get{ return _branch_2_desc; } set{ _branch_2_desc=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Branch2OpenDesc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Branch2OpenDesc { get{ return _branch_2_open_desc; } set{ _branch_2_open_desc=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"Branch2Skills", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Branch2Skills { get{ return _branch_2_skills; } set{ _branch_2_skills=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"Branch3Combo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Branch3Combo { get{ return _branch_3_combo; } set{ _branch_3_combo=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"Branch3Desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Branch3Desc { get{ return _branch_3_desc; } set{ _branch_3_desc=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"Branch3OpenDesc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Branch3OpenDesc { get{ return _branch_3_open_desc; } set{ _branch_3_open_desc=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"Branch3Skills", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Branch3Skills { get{ return _branch_3_skills; } set{ _branch_3_skills=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"Evolution", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Evolution { get{ return _evolution; } set{ _evolution=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"Occ", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Occ { get{ return _occ; } set{ _occ=value; } }
    [global::ProtoBuf.ProtoMember(20, IsRequired = true, Name=@"Pos", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Pos { get{ return _pos; } set{ _pos=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclarePlayerSkill Create( string in_base_branch_combo, string in_base_branch_skills, string in_base_desc, string in_base_open_desc, string in_branch_1_combo, string in_branch_1_desc, string in_branch_1_open_desc, string in_branch_1_skills, string in_branch_2_combo, string in_branch_2_desc, string in_branch_2_open_desc, string in_branch_2_skills, string in_branch_3_combo, string in_branch_3_desc, string in_branch_3_open_desc, string in_branch_3_skills, int in_evolution, int in_id, int in_occ, int in_pos )
    {
      DeclarePlayerSkill tmp = new DeclarePlayerSkill();
      tmp._base_branch_combo = in_base_branch_combo;
      tmp._base_branch_skills = in_base_branch_skills;
      tmp._base_desc = in_base_desc;
      tmp._base_open_desc = in_base_open_desc;
      tmp._branch_1_combo = in_branch_1_combo;
      tmp._branch_1_desc = in_branch_1_desc;
      tmp._branch_1_open_desc = in_branch_1_open_desc;
      tmp._branch_1_skills = in_branch_1_skills;
      tmp._branch_2_combo = in_branch_2_combo;
      tmp._branch_2_desc = in_branch_2_desc;
      tmp._branch_2_open_desc = in_branch_2_open_desc;
      tmp._branch_2_skills = in_branch_2_skills;
      tmp._branch_3_combo = in_branch_3_combo;
      tmp._branch_3_desc = in_branch_3_desc;
      tmp._branch_3_open_desc = in_branch_3_open_desc;
      tmp._branch_3_skills = in_branch_3_skills;
      tmp._evolution = in_evolution;
      tmp._id = in_id;
      tmp._occ = in_occ;
      tmp._pos = in_pos;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclarePlayerSkill> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclarePlayerSkill> _dataCaches = null;
    public static Dictionary<int, DeclarePlayerSkill> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPlayerSkill");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataPlayerSkill = require 'Lua/Config/DataPlayerSkill'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPlayerSkill");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclarePlayerSkill>(72);
                     foreach (var item in dic)
                     {
                         DeclarePlayerSkill tmp = new DeclarePlayerSkill();
                       tmp.BaseBranchCombo = CfgStringLua.Get(item.Value[0]);
                       tmp.BaseBranchSkills = CfgStringLua.Get(item.Value[1]);
                       tmp.BaseDesc = CfgStringLua.Get(item.Value[2]);
                       tmp.BaseOpenDesc = CfgStringLua.Get(item.Value[3]);
                       tmp.Branch1Combo = CfgStringLua.Get(item.Value[4]);
                       tmp.Branch1Desc = CfgStringLua.Get(item.Value[5]);
                       tmp.Branch1OpenDesc = CfgStringLua.Get(item.Value[6]);
                       tmp.Branch1Skills = CfgStringLua.Get(item.Value[7]);
                       tmp.Branch2Combo = CfgStringLua.Get(item.Value[8]);
                       tmp.Branch2Desc = CfgStringLua.Get(item.Value[9]);
                       tmp.Branch2OpenDesc = CfgStringLua.Get(item.Value[10]);
                       tmp.Branch2Skills = CfgStringLua.Get(item.Value[11]);
                       tmp.Branch3Combo = CfgStringLua.Get(item.Value[12]);
                       tmp.Branch3Desc = CfgStringLua.Get(item.Value[13]);
                       tmp.Branch3OpenDesc = CfgStringLua.Get(item.Value[14]);
                       tmp.Branch3Skills = CfgStringLua.Get(item.Value[15]);
                       tmp.Evolution = item.Value[16];
                       tmp.Id = item.Value[17];
                       tmp.Occ = item.Value[18];
                       tmp.Pos = item.Value[19];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"PlayerSkill");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclarePlayerSkill>(72);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"PlayerSkill");
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
    public static DeclarePlayerSkill Get(int id)
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
    public static void Transform(Dictionary<int, DeclarePlayerSkill> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
