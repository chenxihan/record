//文件是自动生成,请勿手动修改.来自数据文件:kuafu_Alchemy_Spirit
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareKuafuAlchemySpirit")]
  public class DeclareKuafuAlchemySpirit
  {
    #region //私有变量定义
    //属性（累积属性）(@;@_@)
    private string _attribute;
    //丹灵品质（1白色，2绿色，3蓝色，4紫色，5橙色，6金色，7红色,8粉色）hide
    private int _colour;
    //升级消耗（道具ID_数量）(@;@_@)
    private string _consume;
    //激活守卫技能（技能ID）
    private int _guard_skill;
    //丹灵名字 hide
    private string _hide_name;
    //丹灵头像hide
    private int _iCON;
    //等级
    private int _level;
    //模型 hide
    private int _model;
    //界面旋转（左右）hide
    private int _model_rotate;
    //界面缩放hide
    private int _model_zoom;
    //名称
    private string _name;
    //场景模型 hide
    private int _scene_Model;
    //场景缩放hide
    private int _scene_zoom;
    //仙丹的开启描述 hide
    private string _skill_description;
    //1：守护，2：进攻 hide
    private int _skill_tipe;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Attribute", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Attribute { get{ return _attribute; } set{ _attribute=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Colour", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Colour { get{ return _colour; } set{ _colour=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Consume", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Consume { get{ return _consume; } set{ _consume=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"GuardSkill", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int GuardSkill { get{ return _guard_skill; } set{ _guard_skill=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"HideName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string HideName { get{ return _hide_name; } set{ _hide_name=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"ICON", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ICON { get{ return _iCON; } set{ _iCON=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Model", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Model { get{ return _model; } set{ _model=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"ModelRotate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ModelRotate { get{ return _model_rotate; } set{ _model_rotate=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"ModelZoom", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ModelZoom { get{ return _model_zoom; } set{ _model_zoom=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"SceneModel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SceneModel { get{ return _scene_Model; } set{ _scene_Model=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"SceneZoom", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SceneZoom { get{ return _scene_zoom; } set{ _scene_zoom=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"SkillDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SkillDescription { get{ return _skill_description; } set{ _skill_description=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"SkillTipe", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SkillTipe { get{ return _skill_tipe; } set{ _skill_tipe=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareKuafuAlchemySpirit Create( string in_attribute, int in_colour, string in_consume, int in_guard_skill, string in_hide_name, int in_iCON, int in_level, int in_model, int in_model_rotate, int in_model_zoom, string in_name, int in_scene_Model, int in_scene_zoom, string in_skill_description, int in_skill_tipe )
    {
      DeclareKuafuAlchemySpirit tmp = new DeclareKuafuAlchemySpirit();
      tmp._attribute = in_attribute;
      tmp._colour = in_colour;
      tmp._consume = in_consume;
      tmp._guard_skill = in_guard_skill;
      tmp._hide_name = in_hide_name;
      tmp._iCON = in_iCON;
      tmp._level = in_level;
      tmp._model = in_model;
      tmp._model_rotate = in_model_rotate;
      tmp._model_zoom = in_model_zoom;
      tmp._name = in_name;
      tmp._scene_Model = in_scene_Model;
      tmp._scene_zoom = in_scene_zoom;
      tmp._skill_description = in_skill_description;
      tmp._skill_tipe = in_skill_tipe;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareKuafuAlchemySpirit> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareKuafuAlchemySpirit> _dataCaches = null;
    public static Dictionary<int, DeclareKuafuAlchemySpirit> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataKuafuAlchemySpirit");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataKuafuAlchemySpirit = require 'Lua/Config/DataKuafuAlchemySpirit'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataKuafuAlchemySpirit");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareKuafuAlchemySpirit>(500);
                     foreach (var item in dic)
                     {
                         DeclareKuafuAlchemySpirit tmp = new DeclareKuafuAlchemySpirit();
                       tmp.Attribute = CfgStringLua.Get(item.Value[0]);
                       tmp.Colour = item.Value[1];
                       tmp.Consume = CfgStringLua.Get(item.Value[2]);
                       tmp.GuardSkill = item.Value[3];
                       tmp.HideName = CfgStringLua.Get(item.Value[4]);
                       tmp.ICON = item.Value[5];
                       tmp.Level = item.Value[6];
                       tmp.Model = item.Value[7];
                       tmp.ModelRotate = item.Value[8];
                       tmp.ModelZoom = item.Value[9];
                       tmp.Name = CfgStringLua.Get(item.Value[10]);
                       tmp.SceneModel = item.Value[11];
                       tmp.SceneZoom = item.Value[12];
                       tmp.SkillDescription = CfgStringLua.Get(item.Value[13]);
                       tmp.SkillTipe = item.Value[14];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"KuafuAlchemySpirit");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareKuafuAlchemySpirit>(500);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"KuafuAlchemySpirit");
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
    public static DeclareKuafuAlchemySpirit Get(int id)
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
    public static void Transform(Dictionary<int, DeclareKuafuAlchemySpirit> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
