//文件是自动生成,请勿手动修改.来自数据文件:JJCAeward
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareJJCAeward")]
  public class DeclareJJCAeward
  {
    #region //私有变量定义
    //奖励的唯一ID
    private int _id;
    //排名区间(@_@)
    private string _rank;
    //奖励(@;@_@)
    private string _reward;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Rank", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Rank { get{ return _rank; } set{ _rank=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Reward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Reward { get{ return _reward; } set{ _reward=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareJJCAeward Create( int in_id, string in_rank, string in_reward )
    {
      DeclareJJCAeward tmp = new DeclareJJCAeward();
      tmp._id = in_id;
      tmp._rank = in_rank;
      tmp._reward = in_reward;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareJJCAeward> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareJJCAeward> _dataCaches = null;
    public static Dictionary<int, DeclareJJCAeward> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataJJCAeward");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataJJCAeward = require 'Lua/Config/DataJJCAeward'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataJJCAeward");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareJJCAeward>(10);
                     foreach (var item in dic)
                     {
                         DeclareJJCAeward tmp = new DeclareJJCAeward();
                       tmp.Id = item.Value[0];
                       tmp.Rank = CfgStringLua.Get(item.Value[1]);
                       tmp.Reward = CfgStringLua.Get(item.Value[2]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"JJCAeward");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareJJCAeward>(10);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"JJCAeward");
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
    public static DeclareJJCAeward Get(int id)
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
    public static void Transform(Dictionary<int, DeclareJJCAeward> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
