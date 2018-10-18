//文件是自动生成,请勿手动修改.来自数据文件:horse_up
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareHorseUp")]
  public class DeclareHorseUp
  {
    #region //私有变量定义
    //本级属性(@;@_@)
    private string _attr;
    //祝福值上限值
    private int _blessnum_limit;
    //每次失败增加祝福值区间max
    private int _blessnum_max;
    //每次失败增加祝福值区间min
    private int _blessnum_min;
    //坐骑需要的摄像机距离(单位厘米)（hide）
    private int _camera_dis;
    //相机镜头 hide
    private int _camera_size;
    //坐骑是否可以飞行
    private int _can_fly;
    //坐骑阶数
    private int _layer;
    //坐骑名称
    private string _name;
    //进阶成功是否全服公告（0不公告，1公告）
    private int _notice;
    //坐骑面板展示用头像资源编号 hide
    private int _panel_head_id;
    //名字颜色，支持html语法 hide
    private string _q_name_color;
    //进阶操作所需人物等级
    private int _up_figure_level;
    //进阶消耗物品及数量(格式：物品ID，数量：多个物品以；隔开）(@;@_@)
    private string _up_item_info;
    //进阶成功所需进阶次数max
    private int _up_num_max;
    //进阶成功所需进阶次数min
    private int _up_num_min;
    //服务器端计算用进阶成功几率（万分比）
    private int _up_probability;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Attr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Attr { get{ return _attr; } set{ _attr=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"BlessnumLimit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BlessnumLimit { get{ return _blessnum_limit; } set{ _blessnum_limit=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"BlessnumMax", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BlessnumMax { get{ return _blessnum_max; } set{ _blessnum_max=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"BlessnumMin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BlessnumMin { get{ return _blessnum_min; } set{ _blessnum_min=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"CameraDis", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CameraDis { get{ return _camera_dis; } set{ _camera_dis=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"CameraSize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CameraSize { get{ return _camera_size; } set{ _camera_size=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"CanFly", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanFly { get{ return _can_fly; } set{ _can_fly=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Layer", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Layer { get{ return _layer; } set{ _layer=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Notice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Notice { get{ return _notice; } set{ _notice=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"PanelHeadId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PanelHeadId { get{ return _panel_head_id; } set{ _panel_head_id=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"QNameColor", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string QNameColor { get{ return _q_name_color; } set{ _q_name_color=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"UpFigureLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UpFigureLevel { get{ return _up_figure_level; } set{ _up_figure_level=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"UpItemInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string UpItemInfo { get{ return _up_item_info; } set{ _up_item_info=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"UpNumMax", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UpNumMax { get{ return _up_num_max; } set{ _up_num_max=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"UpNumMin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UpNumMin { get{ return _up_num_min; } set{ _up_num_min=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"UpProbability", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UpProbability { get{ return _up_probability; } set{ _up_probability=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareHorseUp Create( string in_attr, int in_blessnum_limit, int in_blessnum_max, int in_blessnum_min, int in_camera_dis, int in_camera_size, int in_can_fly, int in_layer, string in_name, int in_notice, int in_panel_head_id, string in_q_name_color, int in_up_figure_level, string in_up_item_info, int in_up_num_max, int in_up_num_min, int in_up_probability )
    {
      DeclareHorseUp tmp = new DeclareHorseUp();
      tmp._attr = in_attr;
      tmp._blessnum_limit = in_blessnum_limit;
      tmp._blessnum_max = in_blessnum_max;
      tmp._blessnum_min = in_blessnum_min;
      tmp._camera_dis = in_camera_dis;
      tmp._camera_size = in_camera_size;
      tmp._can_fly = in_can_fly;
      tmp._layer = in_layer;
      tmp._name = in_name;
      tmp._notice = in_notice;
      tmp._panel_head_id = in_panel_head_id;
      tmp._q_name_color = in_q_name_color;
      tmp._up_figure_level = in_up_figure_level;
      tmp._up_item_info = in_up_item_info;
      tmp._up_num_max = in_up_num_max;
      tmp._up_num_min = in_up_num_min;
      tmp._up_probability = in_up_probability;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareHorseUp> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareHorseUp> _dataCaches = null;
    public static Dictionary<int, DeclareHorseUp> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataHorseUp");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataHorseUp = require 'Lua/Config/DataHorseUp'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataHorseUp");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareHorseUp>(11);
                     foreach (var item in dic)
                     {
                         DeclareHorseUp tmp = new DeclareHorseUp();
                       tmp.Attr = CfgStringLua.Get(item.Value[0]);
                       tmp.BlessnumLimit = item.Value[1];
                       tmp.BlessnumMax = item.Value[2];
                       tmp.BlessnumMin = item.Value[3];
                       tmp.CameraDis = item.Value[4];
                       tmp.CameraSize = item.Value[5];
                       tmp.CanFly = item.Value[6];
                       tmp.Layer = item.Value[7];
                       tmp.Name = CfgStringLua.Get(item.Value[8]);
                       tmp.Notice = item.Value[9];
                       tmp.PanelHeadId = item.Value[10];
                       tmp.QNameColor = CfgStringLua.Get(item.Value[11]);
                       tmp.UpFigureLevel = item.Value[12];
                       tmp.UpItemInfo = CfgStringLua.Get(item.Value[13]);
                       tmp.UpNumMax = item.Value[14];
                       tmp.UpNumMin = item.Value[15];
                       tmp.UpProbability = item.Value[16];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"HorseUp");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareHorseUp>(11);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"HorseUp");
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
    public static DeclareHorseUp Get(int id)
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
    public static void Transform(Dictionary<int, DeclareHorseUp> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
