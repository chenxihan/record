//文件是自动生成,请勿手动修改.来自数据文件:ActivityPrompt
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareActivityPrompt")]
  public class DeclareActivityPrompt
  {
    #region //私有变量定义
    //配置ID
    private int _data_id;
    //提示描述
    private string _desc;
    //ID
    private int _id;
    //打开的界面ID
    private int _open_panel;
    //提示类型(0副本，1工会篝火，2工会boss，3工会战，4怪物入侵，5双倍护送
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"DataId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DataId { get{ return _data_id; } set{ _data_id=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Desc { get{ return _desc; } set{ _desc=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"OpenPanel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OpenPanel { get{ return _open_panel; } set{ _open_panel=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareActivityPrompt Create( int in_data_id, string in_desc, int in_id, int in_open_panel, int in_type )
    {
      DeclareActivityPrompt tmp = new DeclareActivityPrompt();
      tmp._data_id = in_data_id;
      tmp._desc = in_desc;
      tmp._id = in_id;
      tmp._open_panel = in_open_panel;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareActivityPrompt> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareActivityPrompt> _dataCaches = null;
    public static Dictionary<int, DeclareActivityPrompt> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataActivityPrompt");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataActivityPrompt = require 'Lua/Config/DataActivityPrompt'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataActivityPrompt");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareActivityPrompt>(27);
                     foreach (var item in dic)
                     {
                         DeclareActivityPrompt tmp = new DeclareActivityPrompt();
                       tmp.DataId = item.Value[0];
                       tmp.Desc = CfgStringLua.Get(item.Value[1]);
                       tmp.Id = item.Value[2];
                       tmp.OpenPanel = item.Value[3];
                       tmp.Type = item.Value[4];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"ActivityPrompt");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareActivityPrompt>(27);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"ActivityPrompt");
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
    public static DeclareActivityPrompt Get(int id)
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
    public static void Transform(Dictionary<int, DeclareActivityPrompt> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
