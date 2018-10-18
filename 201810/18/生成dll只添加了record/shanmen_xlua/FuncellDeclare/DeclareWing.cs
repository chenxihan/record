//文件是自动生成,请勿手动修改.来自数据文件:wing
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareWing")]
  public class DeclareWing
  {
    #region //私有变量定义
    //激活需要的物品(@;@_@)
    private string _active_item;
    //相机镜头万分比
    private int _camera_size;
    //激活需要的条件(@;@_@)
    private string _condition;
    //幻化条件的描述
    private string _condition_info;
    //图标hide(职业_模型ID）
    private string _icon;
    //翅膀编号
    private int _id;
    //可培养次数
    private int _max_level;
    //外形hide(职业_模型ID）
    private string _model;
    //翅膀名称
    private string _name;
    //激活成功是否公告（0不公告，1公告）
    private int _notice;
    //名字颜色，支持html语法hide
    private string _q_name_color;
    //激活属性(@;@_@)
    private string _rent_att;
    //描述
    private string _rent_info;
    //租借需要的蓝钻
    private int _rent_lanzuan;
    //培养增加属性(@;@_@)
    private string _train_attr;
    //培养消耗材料编号_数量;材料编号_数量(@;@_@)
    private string _train_item;
    //在UI上的外形hide(职业_模型ID）
    private string _ui_model;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ActiveItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ActiveItem { get{ return _active_item; } set{ _active_item=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"CameraSize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CameraSize { get{ return _camera_size; } set{ _camera_size=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Condition", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Condition { get{ return _condition; } set{ _condition=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"ConditionInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ConditionInfo { get{ return _condition_info; } set{ _condition_info=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"MaxLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MaxLevel { get{ return _max_level; } set{ _max_level=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Model", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Model { get{ return _model; } set{ _model=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Notice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Notice { get{ return _notice; } set{ _notice=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"QNameColor", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string QNameColor { get{ return _q_name_color; } set{ _q_name_color=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"RentAtt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string RentAtt { get{ return _rent_att; } set{ _rent_att=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"RentInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string RentInfo { get{ return _rent_info; } set{ _rent_info=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"RentLanzuan", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int RentLanzuan { get{ return _rent_lanzuan; } set{ _rent_lanzuan=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"TrainAttr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TrainAttr { get{ return _train_attr; } set{ _train_attr=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"TrainItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TrainItem { get{ return _train_item; } set{ _train_item=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"UiModel", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string UiModel { get{ return _ui_model; } set{ _ui_model=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareWing Create( string in_active_item, int in_camera_size, string in_condition, string in_condition_info, string in_icon, int in_id, int in_max_level, string in_model, string in_name, int in_notice, string in_q_name_color, string in_rent_att, string in_rent_info, int in_rent_lanzuan, string in_train_attr, string in_train_item, string in_ui_model )
    {
      DeclareWing tmp = new DeclareWing();
      tmp._active_item = in_active_item;
      tmp._camera_size = in_camera_size;
      tmp._condition = in_condition;
      tmp._condition_info = in_condition_info;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._max_level = in_max_level;
      tmp._model = in_model;
      tmp._name = in_name;
      tmp._notice = in_notice;
      tmp._q_name_color = in_q_name_color;
      tmp._rent_att = in_rent_att;
      tmp._rent_info = in_rent_info;
      tmp._rent_lanzuan = in_rent_lanzuan;
      tmp._train_attr = in_train_attr;
      tmp._train_item = in_train_item;
      tmp._ui_model = in_ui_model;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareWing> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareWing> _dataCaches = null;
    public static Dictionary<int, DeclareWing> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataWing");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataWing = require 'Lua/Config/DataWing'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataWing");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareWing>(17);
                     foreach (var item in dic)
                     {
                         DeclareWing tmp = new DeclareWing();
                       tmp.ActiveItem = CfgStringLua.Get(item.Value[0]);
                       tmp.CameraSize = item.Value[1];
                       tmp.Condition = CfgStringLua.Get(item.Value[2]);
                       tmp.ConditionInfo = CfgStringLua.Get(item.Value[3]);
                       tmp.Icon = CfgStringLua.Get(item.Value[4]);
                       tmp.Id = item.Value[5];
                       tmp.MaxLevel = item.Value[6];
                       tmp.Model = CfgStringLua.Get(item.Value[7]);
                       tmp.Name = CfgStringLua.Get(item.Value[8]);
                       tmp.Notice = item.Value[9];
                       tmp.QNameColor = CfgStringLua.Get(item.Value[10]);
                       tmp.RentAtt = CfgStringLua.Get(item.Value[11]);
                       tmp.RentInfo = CfgStringLua.Get(item.Value[12]);
                       tmp.RentLanzuan = item.Value[13];
                       tmp.TrainAttr = CfgStringLua.Get(item.Value[14]);
                       tmp.TrainItem = CfgStringLua.Get(item.Value[15]);
                       tmp.UiModel = CfgStringLua.Get(item.Value[16]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Wing");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareWing>(17);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Wing");
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
    public static DeclareWing Get(int id)
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
    public static void Transform(Dictionary<int, DeclareWing> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
