//文件是自动生成,请勿手动修改.来自数据文件:horse_mythical
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareHorseMythical")]
  public class DeclareHorseMythical
  {
    #region //私有变量定义
    //激活增加属性(@;@_@)
    private string _active_attr;
    //激活消耗材料编号_数量;材料编号_数量(@_@)
    private string _active_item;
    //相机大小
    private int _camera_size;
    //坐骑是否可以飞行
    private int _can_fly;
    //神兽图标资源编号
    private int _icon;
    //神兽ID
    private int _id;
    //神兽可培养次数
    private int _max_level;
    //神兽名称
    private string _name;
    //激活成功是否公告（0不公告，1公告）
    private int _notice;
    //优先级
    private int _priority;
    //神兽造型资源编号
    private int _res;
    //坐骑最大骑乘人数
    private int _ride_num;
    //培养增加属性(@;@_@)
    private string _train_attr;
    //培养消耗材料编号_数量;材料编号_数量(@;@_@)
    private string _train_item;
    //坐骑类型（1,坐骑；2,飞行坐骑；3,多人坐骑）
    private int _type;
    //界面上的Y坐标偏移（正数向上，负数向下）
    private int _y_num;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ActiveAttr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ActiveAttr { get{ return _active_attr; } set{ _active_attr=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"ActiveItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ActiveItem { get{ return _active_item; } set{ _active_item=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"CameraSize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CameraSize { get{ return _camera_size; } set{ _camera_size=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"CanFly", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanFly { get{ return _can_fly; } set{ _can_fly=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"MaxLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MaxLevel { get{ return _max_level; } set{ _max_level=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Notice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Notice { get{ return _notice; } set{ _notice=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Priority", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Priority { get{ return _priority; } set{ _priority=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Res", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Res { get{ return _res; } set{ _res=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"RideNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int RideNum { get{ return _ride_num; } set{ _ride_num=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"TrainAttr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TrainAttr { get{ return _train_attr; } set{ _train_attr=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"TrainItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TrainItem { get{ return _train_item; } set{ _train_item=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"YNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int YNum { get{ return _y_num; } set{ _y_num=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareHorseMythical Create( string in_active_attr, string in_active_item, int in_camera_size, int in_can_fly, int in_icon, int in_id, int in_max_level, string in_name, int in_notice, int in_priority, int in_res, int in_ride_num, string in_train_attr, string in_train_item, int in_type, int in_y_num )
    {
      DeclareHorseMythical tmp = new DeclareHorseMythical();
      tmp._active_attr = in_active_attr;
      tmp._active_item = in_active_item;
      tmp._camera_size = in_camera_size;
      tmp._can_fly = in_can_fly;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._max_level = in_max_level;
      tmp._name = in_name;
      tmp._notice = in_notice;
      tmp._priority = in_priority;
      tmp._res = in_res;
      tmp._ride_num = in_ride_num;
      tmp._train_attr = in_train_attr;
      tmp._train_item = in_train_item;
      tmp._type = in_type;
      tmp._y_num = in_y_num;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareHorseMythical> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareHorseMythical> _dataCaches = null;
    public static Dictionary<int, DeclareHorseMythical> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataHorseMythical");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataHorseMythical = require 'Lua/Config/DataHorseMythical'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataHorseMythical");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareHorseMythical>(21);
                     foreach (var item in dic)
                     {
                         DeclareHorseMythical tmp = new DeclareHorseMythical();
                       tmp.ActiveAttr = CfgStringLua.Get(item.Value[0]);
                       tmp.ActiveItem = CfgStringLua.Get(item.Value[1]);
                       tmp.CameraSize = item.Value[2];
                       tmp.CanFly = item.Value[3];
                       tmp.Icon = item.Value[4];
                       tmp.Id = item.Value[5];
                       tmp.MaxLevel = item.Value[6];
                       tmp.Name = CfgStringLua.Get(item.Value[7]);
                       tmp.Notice = item.Value[8];
                       tmp.Priority = item.Value[9];
                       tmp.Res = item.Value[10];
                       tmp.RideNum = item.Value[11];
                       tmp.TrainAttr = CfgStringLua.Get(item.Value[12]);
                       tmp.TrainItem = CfgStringLua.Get(item.Value[13]);
                       tmp.Type = item.Value[14];
                       tmp.YNum = item.Value[15];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"HorseMythical");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareHorseMythical>(21);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"HorseMythical");
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
    public static DeclareHorseMythical Get(int id)
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
    public static void Transform(Dictionary<int, DeclareHorseMythical> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
