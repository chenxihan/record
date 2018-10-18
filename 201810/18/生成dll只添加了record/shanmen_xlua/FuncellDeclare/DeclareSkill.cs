//文件是自动生成,请勿手动修改.来自数据文件:skill
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareSkill")]
  public class DeclareSkill
  {
    #region //私有变量定义
    //是否可以使用时选择范围或者方向（hide）
    private int _can_use_select;
    //冷却时间（单位毫秒）
    private int _cd;
    //技能分支ID
    private int _cell_id;
    //伤害类型：0：没有伤害；1：物理伤害；2魔法攻击 (技能没有伤害表示其不是攻击技能，使用后将不会进入战斗状态和进入仇恨列表，所以对敌技能必须要有伤害)
    private int _damage_type;
    //技能介绍hide
    private string _desc;
    //技能大类型
    private int _element_type;
    //技能图标编号,任务技能图标使用的是skillicon的图集
    private int _icon;
    //技能ID
    private int _id;
    //技能的等级（初中高）
    private int _level;
    //技能名称hide
    private string _name;
    //技能额外参数(0_怪物特杀类型_增伤万分比,1_属性_值;2_技能id_属性) 0是特杀1属性加成，2是技能加成(@;@_@)
    private string _params;
    //技能增加的工艺品质
    private int _params2;
    //技能提示文字延迟多久展示，单位毫秒hide
    private int _prompt_delay;
    //技能提示文字生存时间，单位毫秒hide
    private int _prompt_life_time;
    //技能提示文字，在使用技能时进行提示，只针对怪物有效hide
    private string _prompt_text;
    //公共CD（单位毫秒）
    private int _public_cd;
    //和服务器的同步类型（0客户端先表现；1等服务器返回了再表现）
    private int _server_sync_type;
    //挂机技能优先级（填0则挂机时不处理）除0以外，值越小，施放优先级越高
    private int _skill_preferred;
    //0主动、 1被动、2特杀
    private int _type;
    //是否使用公CD（0不使用，1使用）
    private int _use_public_cd;
    //使用者（0-4，职业1,2,3,4,5技能；10：无限制；11怪物技能；12：宠物技能；13：婚姻技能
    private int _user_type;
    //技能可视化数据
    private string _visualDef;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"CanUseSelect", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanUseSelect { get{ return _can_use_select; } set{ _can_use_select=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Cd", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Cd { get{ return _cd; } set{ _cd=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"CellId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CellId { get{ return _cell_id; } set{ _cell_id=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"DamageType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DamageType { get{ return _damage_type; } set{ _damage_type=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Desc { get{ return _desc; } set{ _desc=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"ElementType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ElementType { get{ return _element_type; } set{ _element_type=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Params", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Params { get{ return _params; } set{ _params=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"Params2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Params2 { get{ return _params2; } set{ _params2=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"PromptDelay", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PromptDelay { get{ return _prompt_delay; } set{ _prompt_delay=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"PromptLifeTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PromptLifeTime { get{ return _prompt_life_time; } set{ _prompt_life_time=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"PromptText", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string PromptText { get{ return _prompt_text; } set{ _prompt_text=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"PublicCd", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PublicCd { get{ return _public_cd; } set{ _public_cd=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"ServerSyncType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ServerSyncType { get{ return _server_sync_type; } set{ _server_sync_type=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"SkillPreferred", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SkillPreferred { get{ return _skill_preferred; } set{ _skill_preferred=value; } }
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    [global::ProtoBuf.ProtoMember(20, IsRequired = true, Name=@"UsePublicCd", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UsePublicCd { get{ return _use_public_cd; } set{ _use_public_cd=value; } }
    [global::ProtoBuf.ProtoMember(21, IsRequired = true, Name=@"UserType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UserType { get{ return _user_type; } set{ _user_type=value; } }
    [global::ProtoBuf.ProtoMember(22, IsRequired = true, Name=@"VisualDef", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string VisualDef { get{ return _visualDef; } set{ _visualDef=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareSkill Create( int in_can_use_select, int in_cd, int in_cell_id, int in_damage_type, string in_desc, int in_element_type, int in_icon, int in_id, int in_level, string in_name, string in_params, int in_params2, int in_prompt_delay, int in_prompt_life_time, string in_prompt_text, int in_public_cd, int in_server_sync_type, int in_skill_preferred, int in_type, int in_use_public_cd, int in_user_type, string in_visualDef )
    {
      DeclareSkill tmp = new DeclareSkill();
      tmp._can_use_select = in_can_use_select;
      tmp._cd = in_cd;
      tmp._cell_id = in_cell_id;
      tmp._damage_type = in_damage_type;
      tmp._desc = in_desc;
      tmp._element_type = in_element_type;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._level = in_level;
      tmp._name = in_name;
      tmp._params = in_params;
      tmp._params2 = in_params2;
      tmp._prompt_delay = in_prompt_delay;
      tmp._prompt_life_time = in_prompt_life_time;
      tmp._prompt_text = in_prompt_text;
      tmp._public_cd = in_public_cd;
      tmp._server_sync_type = in_server_sync_type;
      tmp._skill_preferred = in_skill_preferred;
      tmp._type = in_type;
      tmp._use_public_cd = in_use_public_cd;
      tmp._user_type = in_user_type;
      tmp._visualDef = in_visualDef;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareSkill> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareSkill> _dataCaches = null;
    public static Dictionary<int, DeclareSkill> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataSkill");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataSkill = require 'Lua/Config/DataSkill'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataSkill");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareSkill>(1804);
                     foreach (var item in dic)
                     {
                         DeclareSkill tmp = new DeclareSkill();
                       tmp.CanUseSelect = item.Value[0];
                       tmp.Cd = item.Value[1];
                       tmp.CellId = item.Value[2];
                       tmp.DamageType = item.Value[3];
                       tmp.Desc = CfgStringLua.Get(item.Value[4]);
                       tmp.ElementType = item.Value[5];
                       tmp.Icon = item.Value[6];
                       tmp.Id = item.Value[7];
                       tmp.Level = item.Value[8];
                       tmp.Name = CfgStringLua.Get(item.Value[9]);
                       tmp.Params = CfgStringLua.Get(item.Value[10]);
                       tmp.Params2 = item.Value[11];
                       tmp.PromptDelay = item.Value[12];
                       tmp.PromptLifeTime = item.Value[13];
                       tmp.PromptText = CfgStringLua.Get(item.Value[14]);
                       tmp.PublicCd = item.Value[15];
                       tmp.ServerSyncType = item.Value[16];
                       tmp.SkillPreferred = item.Value[17];
                       tmp.Type = item.Value[18];
                       tmp.UsePublicCd = item.Value[19];
                       tmp.UserType = item.Value[20];
                       tmp.VisualDef = CfgStringLua.Get(item.Value[21]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Skill");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareSkill>(1804);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Skill");
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
    public static DeclareSkill Get(int id)
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
    public static void Transform(Dictionary<int, DeclareSkill> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
