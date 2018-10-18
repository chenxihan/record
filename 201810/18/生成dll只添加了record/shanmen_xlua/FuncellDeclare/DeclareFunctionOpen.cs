//文件是自动生成,请勿手动修改.来自数据文件:FunctionOpen
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareFunctionOpen")]
  public class DeclareFunctionOpen
  {
    #region //私有变量定义
    //配置ID根据类型代表不同的配置，0技能id，1功能id，2副本id，3徽章id，4图片称号id，5段位id
    private int _data_id;
    //功能开启描述
    private string _desc;
    //资源路径
    private string _icon_path;
    //索引
    private int _id;
    //功能开启标题
    private string _name;
    //播放的音效
    private string _sound;
    //开启类型 0:技能开放，1：功能开放，2：副本开放，3：徽章开启，4：获得新图片称号，5：王者对决升到段位，6：王者联盟升到段位
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"DataId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DataId { get{ return _data_id; } set{ _data_id=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Desc { get{ return _desc; } set{ _desc=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"IconPath", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string IconPath { get{ return _icon_path; } set{ _icon_path=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Sound", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Sound { get{ return _sound; } set{ _sound=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareFunctionOpen Create( int in_data_id, string in_desc, string in_icon_path, int in_id, string in_name, string in_sound, int in_type )
    {
      DeclareFunctionOpen tmp = new DeclareFunctionOpen();
      tmp._data_id = in_data_id;
      tmp._desc = in_desc;
      tmp._icon_path = in_icon_path;
      tmp._id = in_id;
      tmp._name = in_name;
      tmp._sound = in_sound;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareFunctionOpen> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareFunctionOpen> _dataCaches = null;
    public static Dictionary<int, DeclareFunctionOpen> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataFunctionOpen");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataFunctionOpen = require 'Lua/Config/DataFunctionOpen'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataFunctionOpen");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareFunctionOpen>(220);
                     foreach (var item in dic)
                     {
                         DeclareFunctionOpen tmp = new DeclareFunctionOpen();
                       tmp.DataId = item.Value[0];
                       tmp.Desc = CfgStringLua.Get(item.Value[1]);
                       tmp.IconPath = CfgStringLua.Get(item.Value[2]);
                       tmp.Id = item.Value[3];
                       tmp.Name = CfgStringLua.Get(item.Value[4]);
                       tmp.Sound = CfgStringLua.Get(item.Value[5]);
                       tmp.Type = item.Value[6];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"FunctionOpen");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareFunctionOpen>(220);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"FunctionOpen");
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
    public static DeclareFunctionOpen Get(int id)
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
    public static void Transform(Dictionary<int, DeclareFunctionOpen> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
