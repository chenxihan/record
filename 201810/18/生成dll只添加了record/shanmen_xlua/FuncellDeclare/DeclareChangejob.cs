//文件是自动生成,请勿手动修改.来自数据文件:changejob
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareChangejob")]
  public class DeclareChangejob
  {
    #region //私有变量定义
    //激活分支（职业ID_分支ID_分支索引；职业ID_分支ID_分支索引）(@;@_@)
    private string _active_branch;
    //本级属性(@;@_@)
    private string _attributeValue;
    //职业属性(属性类型_数值;属性类型_数值…… 万分位(@;@_@)
    private string _carrerValue;
    //转职目标 typeID_目标值_icon;typeID_目标值_icon……(@;@_@)
    private string _condition;
    //转职条件(@;@_@)
    private string _conditions;
    //激活描述(hide)
    private string _des;
    //职业限制
    //0-执笔者
    //1-拳师
    //2-大锤
    //3-太刀
    //4-卡牌
    //5-暂无
    //9-通用
    private int _gender;
    //转职阶数
    private int _genderClass;
    //转职次数(hide)
    private string _genderNum;
    //职业头像
    private int _icon;
    //转职ID
    private int _iD;
    //上次转职等级（hide）
    private int _lastLevel;
    //转职等级
    private int _level;
    //等级上限
    private int _levelCap;
    //最大累积经验值
    private Int64 _maxExp;
    //激活徽章ID
    private int _medalid;
    //预览模型星级(hide)
    private int _model;
    //转职特效ID
    private int _modelID;
    //名称
    private string _name;
    //基础技能
    private int _skillID;
    //解锁天赋
    private int _talentID;
    //转职任务ID
    private string _task;
    //进阶操作所需物品及数量(格式: 物品id_数量;物品2id_数量;物品3id_数量……)*此处升级消耗为下一级的(如骑手->骑兵,需求的物品在骑兵哪一列)(@;@_@)
    private string _up_item_info;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ActiveBranch", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ActiveBranch { get{ return _active_branch; } set{ _active_branch=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"AttributeValue", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string AttributeValue { get{ return _attributeValue; } set{ _attributeValue=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"CarrerValue", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string CarrerValue { get{ return _carrerValue; } set{ _carrerValue=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Condition", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Condition { get{ return _condition; } set{ _condition=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Conditions", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Conditions { get{ return _conditions; } set{ _conditions=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Des", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Des { get{ return _des; } set{ _des=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Gender", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Gender { get{ return _gender; } set{ _gender=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"GenderClass", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int GenderClass { get{ return _genderClass; } set{ _genderClass=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"GenderNum", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string GenderNum { get{ return _genderNum; } set{ _genderNum=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID { get{ return _iD; } set{ _iD=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"LastLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int LastLevel { get{ return _lastLevel; } set{ _lastLevel=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"LevelCap", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int LevelCap { get{ return _levelCap; } set{ _levelCap=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"MaxExp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Int64 MaxExp { get{ return _maxExp; } set{ _maxExp=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"Medalid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Medalid { get{ return _medalid; } set{ _medalid=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"Model", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Model { get{ return _model; } set{ _model=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"ModelID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ModelID { get{ return _modelID; } set{ _modelID=value; } }
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(20, IsRequired = true, Name=@"SkillID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SkillID { get{ return _skillID; } set{ _skillID=value; } }
    [global::ProtoBuf.ProtoMember(21, IsRequired = true, Name=@"TalentID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TalentID { get{ return _talentID; } set{ _talentID=value; } }
    [global::ProtoBuf.ProtoMember(22, IsRequired = true, Name=@"Task", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Task { get{ return _task; } set{ _task=value; } }
    [global::ProtoBuf.ProtoMember(23, IsRequired = true, Name=@"UpItemInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string UpItemInfo { get{ return _up_item_info; } set{ _up_item_info=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareChangejob Create( string in_active_branch, string in_attributeValue, string in_carrerValue, string in_condition, string in_conditions, string in_des, int in_gender, int in_genderClass, string in_genderNum, int in_icon, int in_iD, int in_lastLevel, int in_level, int in_levelCap, Int64 in_maxExp, int in_medalid, int in_model, int in_modelID, string in_name, int in_skillID, int in_talentID, string in_task, string in_up_item_info )
    {
      DeclareChangejob tmp = new DeclareChangejob();
      tmp._active_branch = in_active_branch;
      tmp._attributeValue = in_attributeValue;
      tmp._carrerValue = in_carrerValue;
      tmp._condition = in_condition;
      tmp._conditions = in_conditions;
      tmp._des = in_des;
      tmp._gender = in_gender;
      tmp._genderClass = in_genderClass;
      tmp._genderNum = in_genderNum;
      tmp._icon = in_icon;
      tmp._iD = in_iD;
      tmp._lastLevel = in_lastLevel;
      tmp._level = in_level;
      tmp._levelCap = in_levelCap;
      tmp._maxExp = in_maxExp;
      tmp._medalid = in_medalid;
      tmp._model = in_model;
      tmp._modelID = in_modelID;
      tmp._name = in_name;
      tmp._skillID = in_skillID;
      tmp._talentID = in_talentID;
      tmp._task = in_task;
      tmp._up_item_info = in_up_item_info;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareChangejob> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareChangejob> _dataCaches = null;
    public static Dictionary<int, DeclareChangejob> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataChangejob");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataChangejob = require 'Lua/Config/DataChangejob'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataChangejob");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareChangejob>(42);
                     foreach (var item in dic)
                     {
                         DeclareChangejob tmp = new DeclareChangejob();
                       tmp.ActiveBranch = CfgStringLua.Get(item.Value[0]);
                       tmp.AttributeValue = CfgStringLua.Get(item.Value[1]);
                       tmp.CarrerValue = CfgStringLua.Get(item.Value[2]);
                       tmp.Condition = CfgStringLua.Get(item.Value[3]);
                       tmp.Conditions = CfgStringLua.Get(item.Value[4]);
                       tmp.Des = CfgStringLua.Get(item.Value[5]);
                       tmp.Gender = item.Value[6];
                       tmp.GenderClass = item.Value[7];
                       tmp.GenderNum = CfgStringLua.Get(item.Value[8]);
                       tmp.Icon = item.Value[9];
                       tmp.ID = item.Value[10];
                       tmp.LastLevel = item.Value[11];
                       tmp.Level = item.Value[12];
                       tmp.LevelCap = item.Value[13];
                       tmp.MaxExp = item.Value[14];
                       tmp.Medalid = item.Value[15];
                       tmp.Model = item.Value[16];
                       tmp.ModelID = item.Value[17];
                       tmp.Name = CfgStringLua.Get(item.Value[18]);
                       tmp.SkillID = item.Value[19];
                       tmp.TalentID = item.Value[20];
                       tmp.Task = CfgStringLua.Get(item.Value[21]);
                       tmp.UpItemInfo = CfgStringLua.Get(item.Value[22]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Changejob");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareChangejob>(42);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Changejob");
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
    public static DeclareChangejob Get(int id)
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
    public static void Transform(Dictionary<int, DeclareChangejob> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
