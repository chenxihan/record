//文件是自动生成,请勿手动修改.来自数据文件:PlayerSkillEvolution
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclarePlayerSkillEvolution")]
  public class DeclarePlayerSkillEvolution
  {
    #region //私有变量定义
    //格子id
    private int _cell_id;
    //格子描述（hide）
    private string _desc;
    //天赋产生的效果数据(类型_参数)（类型0：进化技能，参数为进化技能的格子索引(1-5)；1：改变技能cd，参数为改变的格子索引(1-5)_cd值(毫秒)；2：改变技能伤害，参数为“格子id(1-5)_加成伤害值”；3：学习被动技能，参数为技能id）4:增加神物属性（1，翅膀；2，坐骑，5；器灵）5：增加属性(@;@_@)
    private string _effect_param;
    //格子icon(hide)
    private int _icon;
    //id = 职业*10000+cell_id*100+level
    private int _id;
    //等级
    private int _level;
    //副本名字
    private string _name;
    //需求技能点
    private int _need_skill_point;
    //所属职业
    private int _occ;
    //父格子id_等级，必须要父格子激活后才能激活本格子(@_@)
    private string _parent_cell;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"CellId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CellId { get{ return _cell_id; } set{ _cell_id=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Desc { get{ return _desc; } set{ _desc=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"EffectParam", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string EffectParam { get{ return _effect_param; } set{ _effect_param=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"NeedSkillPoint", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NeedSkillPoint { get{ return _need_skill_point; } set{ _need_skill_point=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Occ", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Occ { get{ return _occ; } set{ _occ=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"ParentCell", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ParentCell { get{ return _parent_cell; } set{ _parent_cell=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclarePlayerSkillEvolution Create( int in_cell_id, string in_desc, string in_effect_param, int in_icon, int in_id, int in_level, string in_name, int in_need_skill_point, int in_occ, string in_parent_cell )
    {
      DeclarePlayerSkillEvolution tmp = new DeclarePlayerSkillEvolution();
      tmp._cell_id = in_cell_id;
      tmp._desc = in_desc;
      tmp._effect_param = in_effect_param;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._level = in_level;
      tmp._name = in_name;
      tmp._need_skill_point = in_need_skill_point;
      tmp._occ = in_occ;
      tmp._parent_cell = in_parent_cell;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclarePlayerSkillEvolution> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclarePlayerSkillEvolution> _dataCaches = null;
    public static Dictionary<int, DeclarePlayerSkillEvolution> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPlayerSkillEvolution");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataPlayerSkillEvolution = require 'Lua/Config/DataPlayerSkillEvolution'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPlayerSkillEvolution");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclarePlayerSkillEvolution>(2664);
                     foreach (var item in dic)
                     {
                         DeclarePlayerSkillEvolution tmp = new DeclarePlayerSkillEvolution();
                       tmp.CellId = item.Value[0];
                       tmp.Desc = CfgStringLua.Get(item.Value[1]);
                       tmp.EffectParam = CfgStringLua.Get(item.Value[2]);
                       tmp.Icon = item.Value[3];
                       tmp.Id = item.Value[4];
                       tmp.Level = item.Value[5];
                       tmp.Name = CfgStringLua.Get(item.Value[6]);
                       tmp.NeedSkillPoint = item.Value[7];
                       tmp.Occ = item.Value[8];
                       tmp.ParentCell = CfgStringLua.Get(item.Value[9]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"PlayerSkillEvolution");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclarePlayerSkillEvolution>(2664);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"PlayerSkillEvolution");
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
    public static DeclarePlayerSkillEvolution Get(int id)
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
    public static void Transform(Dictionary<int, DeclarePlayerSkillEvolution> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
