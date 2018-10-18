//文件是自动生成,请勿手动修改.来自数据文件:TaskChapter
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareTaskChapter")]
  public class DeclareTaskChapter
  {
    #region //私有变量定义
    //结束增加的属性(@;@_@)
    private string _finish_att;
    //结束的标题（hide）
    private string _finish_title;
    //任务ID
    private int _id;
    //开始的描述（hide）
    private string _start_desc;
    //开始的名字（hide）
    private string _start_name;
    //开始的标题（hide）
    private string _start_title;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"FinishAtt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string FinishAtt { get{ return _finish_att; } set{ _finish_att=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"FinishTitle", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string FinishTitle { get{ return _finish_title; } set{ _finish_title=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"StartDesc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string StartDesc { get{ return _start_desc; } set{ _start_desc=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"StartName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string StartName { get{ return _start_name; } set{ _start_name=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"StartTitle", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string StartTitle { get{ return _start_title; } set{ _start_title=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareTaskChapter Create( string in_finish_att, string in_finish_title, int in_id, string in_start_desc, string in_start_name, string in_start_title )
    {
      DeclareTaskChapter tmp = new DeclareTaskChapter();
      tmp._finish_att = in_finish_att;
      tmp._finish_title = in_finish_title;
      tmp._id = in_id;
      tmp._start_desc = in_start_desc;
      tmp._start_name = in_start_name;
      tmp._start_title = in_start_title;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareTaskChapter> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareTaskChapter> _dataCaches = null;
    public static Dictionary<int, DeclareTaskChapter> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTaskChapter");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataTaskChapter = require 'Lua/Config/DataTaskChapter'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTaskChapter");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareTaskChapter>(9);
                     foreach (var item in dic)
                     {
                         DeclareTaskChapter tmp = new DeclareTaskChapter();
                       tmp.FinishAtt = CfgStringLua.Get(item.Value[0]);
                       tmp.FinishTitle = CfgStringLua.Get(item.Value[1]);
                       tmp.Id = item.Value[2];
                       tmp.StartDesc = CfgStringLua.Get(item.Value[3]);
                       tmp.StartName = CfgStringLua.Get(item.Value[4]);
                       tmp.StartTitle = CfgStringLua.Get(item.Value[5]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"TaskChapter");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareTaskChapter>(9);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"TaskChapter");
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
    public static DeclareTaskChapter Get(int id)
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
    public static void Transform(Dictionary<int, DeclareTaskChapter> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
