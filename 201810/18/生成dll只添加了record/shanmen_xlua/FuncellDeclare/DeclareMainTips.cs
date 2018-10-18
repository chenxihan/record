//文件是自动生成,请勿手动修改.来自数据文件:main_tips
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareMainTips")]
  public class DeclareMainTips
  {
    #region //私有变量定义
    //登陆的天数
    private int _day;
    //功能描述
    private string _explain;
    //提示用ICON
    private string _icon;
    //编号
    private int _id;
    //需要的等级
    private int _level;
    //模型配置(职业_模型配置id_缩放_旋转_y轴偏移;职业_模型配置id_缩放_旋转_y轴偏移）
    private string _model_res;
    //功能名字
    private string _name;
    //功能需求
    private string _need;
    //需要完成的任务
    private string _task;
    //需要的在线时间(秒)
    private int _time;
    //功能标题
    private string _title;
    //展示类型（0模型，1功能）
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Day", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Day { get{ return _day; } set{ _day=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Explain", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Explain { get{ return _explain; } set{ _explain=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"ModelRes", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ModelRes { get{ return _model_res; } set{ _model_res=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Need", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Need { get{ return _need; } set{ _need=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Task", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Task { get{ return _task; } set{ _task=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Time { get{ return _time; } set{ _time=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Title", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Title { get{ return _title; } set{ _title=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareMainTips Create( int in_day, string in_explain, string in_icon, int in_id, int in_level, string in_model_res, string in_name, string in_need, string in_task, int in_time, string in_title, int in_type )
    {
      DeclareMainTips tmp = new DeclareMainTips();
      tmp._day = in_day;
      tmp._explain = in_explain;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._level = in_level;
      tmp._model_res = in_model_res;
      tmp._name = in_name;
      tmp._need = in_need;
      tmp._task = in_task;
      tmp._time = in_time;
      tmp._title = in_title;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareMainTips> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareMainTips> _dataCaches = null;
    public static Dictionary<int, DeclareMainTips> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMainTips");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataMainTips = require 'Lua/Config/DataMainTips'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMainTips");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareMainTips>(26);
                     foreach (var item in dic)
                     {
                         DeclareMainTips tmp = new DeclareMainTips();
                       tmp.Day = item.Value[0];
                       tmp.Explain = CfgStringLua.Get(item.Value[1]);
                       tmp.Icon = CfgStringLua.Get(item.Value[2]);
                       tmp.Id = item.Value[3];
                       tmp.Level = item.Value[4];
                       tmp.ModelRes = CfgStringLua.Get(item.Value[5]);
                       tmp.Name = CfgStringLua.Get(item.Value[6]);
                       tmp.Need = CfgStringLua.Get(item.Value[7]);
                       tmp.Task = CfgStringLua.Get(item.Value[8]);
                       tmp.Time = item.Value[9];
                       tmp.Title = CfgStringLua.Get(item.Value[10]);
                       tmp.Type = item.Value[11];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"MainTips");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareMainTips>(26);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"MainTips");
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
    public static DeclareMainTips Get(int id)
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
    public static void Transform(Dictionary<int, DeclareMainTips> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
