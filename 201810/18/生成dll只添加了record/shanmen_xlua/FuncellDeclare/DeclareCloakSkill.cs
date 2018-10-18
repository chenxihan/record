//文件是自动生成,请勿手动修改.来自数据文件:Cloak_skill
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareCloakSkill")]
  public class DeclareCloakSkill
  {
    #region //私有变量定义
    //激活所需披风阶数
    private int _activate_need_layer;
    //披风技能效果（策划查阅用字段）
    private string _for_xiaobiaozha;
    //技能最大等级
    private int _max_level;
    //显示顺序
    private int _show_oder;
    //单次增加经验值
    private int _single_addExp;
    //披风技能名称
    private string _skill_name;
    //技能品质(1:白;2:绿;3:蓝;4:紫;5:橙)
    private int _skill_quality;
    //披风技能编号（需与技能表保持一致）
    private int _skillid;
    //升级所需要的经验
    private string _up_addExp;
    //技能升级消耗物品
    private int _up_item_id;
    //技能升级消耗数量
    private int _up_item_num;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ActivateNeedLayer", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ActivateNeedLayer { get{ return _activate_need_layer; } set{ _activate_need_layer=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"ForXiaobiaozha", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ForXiaobiaozha { get{ return _for_xiaobiaozha; } set{ _for_xiaobiaozha=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"MaxLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MaxLevel { get{ return _max_level; } set{ _max_level=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"ShowOder", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ShowOder { get{ return _show_oder; } set{ _show_oder=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"SingleAddExp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SingleAddExp { get{ return _single_addExp; } set{ _single_addExp=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"SkillName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SkillName { get{ return _skill_name; } set{ _skill_name=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"SkillQuality", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SkillQuality { get{ return _skill_quality; } set{ _skill_quality=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Skillid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Skillid { get{ return _skillid; } set{ _skillid=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"UpAddExp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string UpAddExp { get{ return _up_addExp; } set{ _up_addExp=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"UpItemId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UpItemId { get{ return _up_item_id; } set{ _up_item_id=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"UpItemNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UpItemNum { get{ return _up_item_num; } set{ _up_item_num=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareCloakSkill Create( int in_activate_need_layer, string in_for_xiaobiaozha, int in_max_level, int in_show_oder, int in_single_addExp, string in_skill_name, int in_skill_quality, int in_skillid, string in_up_addExp, int in_up_item_id, int in_up_item_num )
    {
      DeclareCloakSkill tmp = new DeclareCloakSkill();
      tmp._activate_need_layer = in_activate_need_layer;
      tmp._for_xiaobiaozha = in_for_xiaobiaozha;
      tmp._max_level = in_max_level;
      tmp._show_oder = in_show_oder;
      tmp._single_addExp = in_single_addExp;
      tmp._skill_name = in_skill_name;
      tmp._skill_quality = in_skill_quality;
      tmp._skillid = in_skillid;
      tmp._up_addExp = in_up_addExp;
      tmp._up_item_id = in_up_item_id;
      tmp._up_item_num = in_up_item_num;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareCloakSkill> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareCloakSkill> _dataCaches = null;
    public static Dictionary<int, DeclareCloakSkill> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataCloakSkill");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataCloakSkill = require 'Lua/Config/DataCloakSkill'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataCloakSkill");                  }

                 if (dic != null)
                 {
                              _dataCaches = new Dictionary<int, DeclareCloakSkill>();
                     foreach (var item in dic)
                     {
                         DeclareCloakSkill tmp = new DeclareCloakSkill();
                       tmp.ActivateNeedLayer = item.Value[0];
                       tmp.ForXiaobiaozha = CfgStringLua.Get(item.Value[1]);
                       tmp.MaxLevel = item.Value[2];
                       tmp.ShowOder = item.Value[3];
                       tmp.SingleAddExp = item.Value[4];
                       tmp.SkillName = CfgStringLua.Get(item.Value[5]);
                       tmp.SkillQuality = item.Value[6];
                       tmp.Skillid = item.Value[7];
                       tmp.UpAddExp = CfgStringLua.Get(item.Value[8]);
                       tmp.UpItemId = item.Value[9];
                       tmp.UpItemNum = item.Value[10];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"CloakSkill");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareCloakSkill>();
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"CloakSkill");
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
    public static DeclareCloakSkill Get(int id)
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
    public static void Transform(Dictionary<int, DeclareCloakSkill> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
