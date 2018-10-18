//文件是自动生成,请勿手动修改.来自数据文件:task_talk
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareTaskTalk")]
  public class DeclareTaskTalk
  {
    #region //私有变量定义
    //对白
    private string _content;
    //ID
    private int _id;
    //NPC ID（0为[ffd557]{0}[-]）
    private int _model;
    //显示名字（0为0）
    private string _name;
    //下一个id(0结束)
    private int _nextid;
    //是否显示名字0否1是
    private int _showName;
    //切入类型1左0右
    private int _side;
    //语音资源名 hide
    private string _speech;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Content { get{ return _content; } set{ _content=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Model", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Model { get{ return _model; } set{ _model=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Nextid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Nextid { get{ return _nextid; } set{ _nextid=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"ShowName", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ShowName { get{ return _showName; } set{ _showName=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Side", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Side { get{ return _side; } set{ _side=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Speech", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Speech { get{ return _speech; } set{ _speech=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareTaskTalk Create( string in_content, int in_id, int in_model, string in_name, int in_nextid, int in_showName, int in_side, string in_speech )
    {
      DeclareTaskTalk tmp = new DeclareTaskTalk();
      tmp._content = in_content;
      tmp._id = in_id;
      tmp._model = in_model;
      tmp._name = in_name;
      tmp._nextid = in_nextid;
      tmp._showName = in_showName;
      tmp._side = in_side;
      tmp._speech = in_speech;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareTaskTalk> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareTaskTalk> _dataCaches = null;
    public static Dictionary<int, DeclareTaskTalk> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTaskTalk");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataTaskTalk = require 'Lua/Config/DataTaskTalk'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTaskTalk");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareTaskTalk>(516);
                     foreach (var item in dic)
                     {
                         DeclareTaskTalk tmp = new DeclareTaskTalk();
                       tmp.Content = CfgStringLua.Get(item.Value[0]);
                       tmp.Id = item.Value[1];
                       tmp.Model = item.Value[2];
                       tmp.Name = CfgStringLua.Get(item.Value[3]);
                       tmp.Nextid = item.Value[4];
                       tmp.ShowName = item.Value[5];
                       tmp.Side = item.Value[6];
                       tmp.Speech = CfgStringLua.Get(item.Value[7]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"TaskTalk");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareTaskTalk>(516);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"TaskTalk");
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
    public static DeclareTaskTalk Get(int id)
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
    public static void Transform(Dictionary<int, DeclareTaskTalk> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
