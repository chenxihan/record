//文件是自动生成,请勿手动修改.来自数据文件:comboKill
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareComboKill")]
  public class DeclareComboKill
  {
    #region //私有变量定义
    //达到此连杀后击杀额外分数
    private int _comboKillScore;
    //击杀数量
    private int _count;
    //终结此连杀后获得额外分数
    private int _shutDownScore;
    //称号
    private string _title;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ComboKillScore", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ComboKillScore { get{ return _comboKillScore; } set{ _comboKillScore=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Count { get{ return _count; } set{ _count=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"ShutDownScore", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ShutDownScore { get{ return _shutDownScore; } set{ _shutDownScore=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Title", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Title { get{ return _title; } set{ _title=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareComboKill Create( int in_comboKillScore, int in_count, int in_shutDownScore, string in_title )
    {
      DeclareComboKill tmp = new DeclareComboKill();
      tmp._comboKillScore = in_comboKillScore;
      tmp._count = in_count;
      tmp._shutDownScore = in_shutDownScore;
      tmp._title = in_title;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareComboKill> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareComboKill> _dataCaches = null;
    public static Dictionary<int, DeclareComboKill> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataComboKill");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataComboKill = require 'Lua/Config/DataComboKill'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataComboKill");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareComboKill>(7);
                     foreach (var item in dic)
                     {
                         DeclareComboKill tmp = new DeclareComboKill();
                       tmp.ComboKillScore = item.Value[0];
                       tmp.Count = item.Value[1];
                       tmp.ShutDownScore = item.Value[2];
                       tmp.Title = CfgStringLua.Get(item.Value[3]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"ComboKill");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareComboKill>(7);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"ComboKill");
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
    public static DeclareComboKill Get(int id)
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
    public static void Transform(Dictionary<int, DeclareComboKill> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
