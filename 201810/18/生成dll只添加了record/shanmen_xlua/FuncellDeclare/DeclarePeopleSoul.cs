//文件是自动生成,请勿手动修改.来自数据文件:PeopleSoul
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclarePeopleSoul")]
  public class DeclarePeopleSoul
  {
    #region //私有变量定义
    //基础属性(@;@_@)
    private string _attribute;
    //属性类型（1.单属性；2.双属性）
    private int _attribute_type;
    //暴击万分比(@_@)
    private string _bj;
    //灵魂颜色（1：白色；2：绿色；3：蓝色；4：紫色；5：橙色；6：金色；7：红色）
    private int _color;
    //条件FunctionVariable+数量 (@;@_@)
    private string _conditions;
    //法防万分比(@_@)
    private string _ff;
    //法攻万分比(@_@)
    private string _fg;
    //相同数字的只能穿戴一个(@;@)
    private string _group;
    //灵魂的ICON
    private int _icon;
    //灵魂唯一ID
    private int _id;
    //是否能合成（0,不能；1.能）
    private int _if_synthesis;
    //物品id_数量;物品id_数量;……(@;@_@)
    private string _item;
    //杀怪经验(@_@)
    private string _jy;
    //灵魂的名字
    private string _name;
    //成功的机率（1~10000）
    private int _probability;
    //分解时的基础物品(@;@_@)
    private string _seal_item;
    //生命万分比(@_@)
    private string _sm;
    //灵魂id_数量;灵魂id_数量;……(@;@_@)
    private string _soul;
    //升星总属性(@_@)
    private string _sx;
    //在合成里面的标题（0.不在合成。1.橙色单属性。2.红色单属性。3.紫色双属性。4.橙色双属性。5.红色双属性。6.核心双属性。7.紫色灵魂晋升。8.橙色灵魂晋升。9.红色灵魂晋升。10.核心灵魂晋升。）
    private int _synthesis_title;
    //穿戴类型（0.普通；1.核心;2,材料）
    private int _type;
    //物防万分比(@_@)
    private string _wf;
    //物攻万分比(@_@)
    private string _wg;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Attribute", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Attribute { get{ return _attribute; } set{ _attribute=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"AttributeType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int AttributeType { get{ return _attribute_type; } set{ _attribute_type=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Bj", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Bj { get{ return _bj; } set{ _bj=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Color", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Color { get{ return _color; } set{ _color=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Conditions", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Conditions { get{ return _conditions; } set{ _conditions=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Ff", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Ff { get{ return _ff; } set{ _ff=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Fg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Fg { get{ return _fg; } set{ _fg=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Group", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Group { get{ return _group; } set{ _group=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"IfSynthesis", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int IfSynthesis { get{ return _if_synthesis; } set{ _if_synthesis=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"Item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Item { get{ return _item; } set{ _item=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"Jy", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Jy { get{ return _jy; } set{ _jy=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"Probability", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Probability { get{ return _probability; } set{ _probability=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"SealItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SealItem { get{ return _seal_item; } set{ _seal_item=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"Sm", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Sm { get{ return _sm; } set{ _sm=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"Soul", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Soul { get{ return _soul; } set{ _soul=value; } }
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"Sx", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Sx { get{ return _sx; } set{ _sx=value; } }
    [global::ProtoBuf.ProtoMember(20, IsRequired = true, Name=@"SynthesisTitle", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SynthesisTitle { get{ return _synthesis_title; } set{ _synthesis_title=value; } }
    [global::ProtoBuf.ProtoMember(21, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    [global::ProtoBuf.ProtoMember(22, IsRequired = true, Name=@"Wf", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Wf { get{ return _wf; } set{ _wf=value; } }
    [global::ProtoBuf.ProtoMember(23, IsRequired = true, Name=@"Wg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Wg { get{ return _wg; } set{ _wg=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclarePeopleSoul Create( string in_attribute, int in_attribute_type, string in_bj, int in_color, string in_conditions, string in_ff, string in_fg, string in_group, int in_icon, int in_id, int in_if_synthesis, string in_item, string in_jy, string in_name, int in_probability, string in_seal_item, string in_sm, string in_soul, string in_sx, int in_synthesis_title, int in_type, string in_wf, string in_wg )
    {
      DeclarePeopleSoul tmp = new DeclarePeopleSoul();
      tmp._attribute = in_attribute;
      tmp._attribute_type = in_attribute_type;
      tmp._bj = in_bj;
      tmp._color = in_color;
      tmp._conditions = in_conditions;
      tmp._ff = in_ff;
      tmp._fg = in_fg;
      tmp._group = in_group;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._if_synthesis = in_if_synthesis;
      tmp._item = in_item;
      tmp._jy = in_jy;
      tmp._name = in_name;
      tmp._probability = in_probability;
      tmp._seal_item = in_seal_item;
      tmp._sm = in_sm;
      tmp._soul = in_soul;
      tmp._sx = in_sx;
      tmp._synthesis_title = in_synthesis_title;
      tmp._type = in_type;
      tmp._wf = in_wf;
      tmp._wg = in_wg;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclarePeopleSoul> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclarePeopleSoul> _dataCaches = null;
    public static Dictionary<int, DeclarePeopleSoul> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPeopleSoul");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataPeopleSoul = require 'Lua/Config/DataPeopleSoul'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPeopleSoul");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclarePeopleSoul>(174);
                     foreach (var item in dic)
                     {
                         DeclarePeopleSoul tmp = new DeclarePeopleSoul();
                       tmp.Attribute = CfgStringLua.Get(item.Value[0]);
                       tmp.AttributeType = item.Value[1];
                       tmp.Bj = CfgStringLua.Get(item.Value[2]);
                       tmp.Color = item.Value[3];
                       tmp.Conditions = CfgStringLua.Get(item.Value[4]);
                       tmp.Ff = CfgStringLua.Get(item.Value[5]);
                       tmp.Fg = CfgStringLua.Get(item.Value[6]);
                       tmp.Group = CfgStringLua.Get(item.Value[7]);
                       tmp.Icon = item.Value[8];
                       tmp.Id = item.Value[9];
                       tmp.IfSynthesis = item.Value[10];
                       tmp.Item = CfgStringLua.Get(item.Value[11]);
                       tmp.Jy = CfgStringLua.Get(item.Value[12]);
                       tmp.Name = CfgStringLua.Get(item.Value[13]);
                       tmp.Probability = item.Value[14];
                       tmp.SealItem = CfgStringLua.Get(item.Value[15]);
                       tmp.Sm = CfgStringLua.Get(item.Value[16]);
                       tmp.Soul = CfgStringLua.Get(item.Value[17]);
                       tmp.Sx = CfgStringLua.Get(item.Value[18]);
                       tmp.SynthesisTitle = item.Value[19];
                       tmp.Type = item.Value[20];
                       tmp.Wf = CfgStringLua.Get(item.Value[21]);
                       tmp.Wg = CfgStringLua.Get(item.Value[22]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"PeopleSoul");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclarePeopleSoul>(174);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"PeopleSoul");
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
    public static DeclarePeopleSoul Get(int id)
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
    public static void Transform(Dictionary<int, DeclarePeopleSoul> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
