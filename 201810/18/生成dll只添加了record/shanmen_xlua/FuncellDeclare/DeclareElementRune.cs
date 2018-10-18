//文件是自动生成,请勿手动修改.来自数据文件:elementRune
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareElementRune")]
  public class DeclareElementRune
  {
    #region //私有变量定义
    //基础属性：属性类型_数值，属性类型1_数值，(@;@_@)
    private string _attribute;
    //绑定类型(0：不绑定;1：获得时绑定;2：使用后绑定)
    private int _bind;
    //分解时是弹出确认提示（0：不弹出;1：弹出）
    private int _confirm;
    //元素属性：属性ID_数值; 属性ID_数值;….(@;@_@)
    private string _elementAtt;
    //职业限制
    //0-执笔者;1-拳师;2-大锤;3-太刀;4-卡牌;5-枪手;9-通用
    private int _gender;
    //品阶：1表示1阶，2表示2阶
    private int _grade;
    //元素符文id=道具表中itemId
    private int _id;
    //穿戴等级
    private int _level;
    //符文品质(：1.白 2.绿 3.蓝 4.紫 5.橙 6.金 7.红 8.粉)
    private int _quality;
    //推荐极品属性显示
    private string _recommended_tips;
    //分解提供经验(-1为无法分)
    private int _seal_exp;
    //附加属性产出：属性ID_数值; 属性ID_数值;….(@;@_@)
    private string _specialAtt;
    //套装ID，不填则没有套装
    private int _suitId;
    //符文种类(1勇气、2专注、3信念、4谦卑、5智慧、6戒律、7灾厄、8恐惧、9贪婪、10愤怒、11毁灭、12符文材料)
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Attribute", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Attribute { get{ return _attribute; } set{ _attribute=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Bind", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Bind { get{ return _bind; } set{ _bind=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Confirm", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Confirm { get{ return _confirm; } set{ _confirm=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"ElementAtt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ElementAtt { get{ return _elementAtt; } set{ _elementAtt=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Gender", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Gender { get{ return _gender; } set{ _gender=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Grade", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Grade { get{ return _grade; } set{ _grade=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Quality", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Quality { get{ return _quality; } set{ _quality=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"RecommendedTips", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string RecommendedTips { get{ return _recommended_tips; } set{ _recommended_tips=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"SealExp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SealExp { get{ return _seal_exp; } set{ _seal_exp=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"SpecialAtt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SpecialAtt { get{ return _specialAtt; } set{ _specialAtt=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"SuitId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SuitId { get{ return _suitId; } set{ _suitId=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareElementRune Create( string in_attribute, int in_bind, int in_confirm, string in_elementAtt, int in_gender, int in_grade, int in_id, int in_level, int in_quality, string in_recommended_tips, int in_seal_exp, string in_specialAtt, int in_suitId, int in_type )
    {
      DeclareElementRune tmp = new DeclareElementRune();
      tmp._attribute = in_attribute;
      tmp._bind = in_bind;
      tmp._confirm = in_confirm;
      tmp._elementAtt = in_elementAtt;
      tmp._gender = in_gender;
      tmp._grade = in_grade;
      tmp._id = in_id;
      tmp._level = in_level;
      tmp._quality = in_quality;
      tmp._recommended_tips = in_recommended_tips;
      tmp._seal_exp = in_seal_exp;
      tmp._specialAtt = in_specialAtt;
      tmp._suitId = in_suitId;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareElementRune> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareElementRune> _dataCaches = null;
    public static Dictionary<int, DeclareElementRune> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataElementRune");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataElementRune = require 'Lua/Config/DataElementRune'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataElementRune");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareElementRune>(182);
                     foreach (var item in dic)
                     {
                         DeclareElementRune tmp = new DeclareElementRune();
                       tmp.Attribute = CfgStringLua.Get(item.Value[0]);
                       tmp.Bind = item.Value[1];
                       tmp.Confirm = item.Value[2];
                       tmp.ElementAtt = CfgStringLua.Get(item.Value[3]);
                       tmp.Gender = item.Value[4];
                       tmp.Grade = item.Value[5];
                       tmp.Id = item.Value[6];
                       tmp.Level = item.Value[7];
                       tmp.Quality = item.Value[8];
                       tmp.RecommendedTips = CfgStringLua.Get(item.Value[9]);
                       tmp.SealExp = item.Value[10];
                       tmp.SpecialAtt = CfgStringLua.Get(item.Value[11]);
                       tmp.SuitId = item.Value[12];
                       tmp.Type = item.Value[13];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"ElementRune");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareElementRune>(182);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"ElementRune");
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
    public static DeclareElementRune Get(int id)
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
    public static void Transform(Dictionary<int, DeclareElementRune> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
