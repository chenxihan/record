//文件是自动生成,请勿手动修改.来自数据文件:medal
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareMedal")]
  public class DeclareMedal
  {
    #region //私有变量定义
    //能力描述 hide
    private string _abilityDes;
    //激活分支（职业ID_分支ID_分支索引；职业ID_分支ID_分支索引）(@;@_@)
    private string _active_branch;
    //物品奖励（职业ID_物品ID_物品数量）(@;@_@)
    private string _active_reward;
    //激活技能（职业ID_技能ID；职业ID_技能ID）(@;@_@)
    private string _active_skill;
    //激活条件（1_等级；2_需要完成的任务ID；2_需要完成的成就ID；3_VIP等级；4_转职后的等级；）(@;@_@)
    private string _condition;
    //徽章描述 hide
    private string _des;
    //徽章图片名字
    private string _icon;
    //徽章唯一ID
    private int _id;
    //徽章挑战副本ID
    private int _medal_clone;
    //徽章名字
    private string _name;
    //条件描述 hide
    private string _oddsDes;
    //女神徽章开启条件(@;@_@)
    private string _open_condition;
    //职业ID_技能图标(@;@_@)
    private string _skill_icon;
    //徽章类型_类型名字（1.主线；2.女神）
    private string _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"AbilityDes", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string AbilityDes { get{ return _abilityDes; } set{ _abilityDes=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"ActiveBranch", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ActiveBranch { get{ return _active_branch; } set{ _active_branch=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"ActiveReward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ActiveReward { get{ return _active_reward; } set{ _active_reward=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"ActiveSkill", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ActiveSkill { get{ return _active_skill; } set{ _active_skill=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Condition", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Condition { get{ return _condition; } set{ _condition=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Des", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Des { get{ return _des; } set{ _des=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"MedalClone", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MedalClone { get{ return _medal_clone; } set{ _medal_clone=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"OddsDes", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OddsDes { get{ return _oddsDes; } set{ _oddsDes=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"OpenCondition", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OpenCondition { get{ return _open_condition; } set{ _open_condition=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"SkillIcon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SkillIcon { get{ return _skill_icon; } set{ _skill_icon=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareMedal Create( string in_abilityDes, string in_active_branch, string in_active_reward, string in_active_skill, string in_condition, string in_des, string in_icon, int in_id, int in_medal_clone, string in_name, string in_oddsDes, string in_open_condition, string in_skill_icon, string in_type )
    {
      DeclareMedal tmp = new DeclareMedal();
      tmp._abilityDes = in_abilityDes;
      tmp._active_branch = in_active_branch;
      tmp._active_reward = in_active_reward;
      tmp._active_skill = in_active_skill;
      tmp._condition = in_condition;
      tmp._des = in_des;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._medal_clone = in_medal_clone;
      tmp._name = in_name;
      tmp._oddsDes = in_oddsDes;
      tmp._open_condition = in_open_condition;
      tmp._skill_icon = in_skill_icon;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareMedal> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareMedal> _dataCaches = null;
    public static Dictionary<int, DeclareMedal> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMedal");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataMedal = require 'Lua/Config/DataMedal'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMedal");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareMedal>(20);
                     foreach (var item in dic)
                     {
                         DeclareMedal tmp = new DeclareMedal();
                       tmp.AbilityDes = CfgStringLua.Get(item.Value[0]);
                       tmp.ActiveBranch = CfgStringLua.Get(item.Value[1]);
                       tmp.ActiveReward = CfgStringLua.Get(item.Value[2]);
                       tmp.ActiveSkill = CfgStringLua.Get(item.Value[3]);
                       tmp.Condition = CfgStringLua.Get(item.Value[4]);
                       tmp.Des = CfgStringLua.Get(item.Value[5]);
                       tmp.Icon = CfgStringLua.Get(item.Value[6]);
                       tmp.Id = item.Value[7];
                       tmp.MedalClone = item.Value[8];
                       tmp.Name = CfgStringLua.Get(item.Value[9]);
                       tmp.OddsDes = CfgStringLua.Get(item.Value[10]);
                       tmp.OpenCondition = CfgStringLua.Get(item.Value[11]);
                       tmp.SkillIcon = CfgStringLua.Get(item.Value[12]);
                       tmp.Type = CfgStringLua.Get(item.Value[13]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Medal");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareMedal>(20);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Medal");
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
    public static DeclareMedal Get(int id)
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
    public static void Transform(Dictionary<int, DeclareMedal> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
