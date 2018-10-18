//文件是自动生成,请勿手动修改.来自数据文件:update_reward
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareUpdateReward")]
  public class DeclareUpdateReward
  {
    #region //私有变量定义
    //0为不需要，1为需要
    private int _need_update;
    //ID
    private int _num;
    //更新说明 hide
    private string _update_info;
    //更新奖励(@;@_@)
    private string _update_reward;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"NeedUpdate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NeedUpdate { get{ return _need_update; } set{ _need_update=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Num { get{ return _num; } set{ _num=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"UpdateInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string UpdateInfo { get{ return _update_info; } set{ _update_info=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"UpdateReward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string UpdateReward { get{ return _update_reward; } set{ _update_reward=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareUpdateReward Create( int in_need_update, int in_num, string in_update_info, string in_update_reward )
    {
      DeclareUpdateReward tmp = new DeclareUpdateReward();
      tmp._need_update = in_need_update;
      tmp._num = in_num;
      tmp._update_info = in_update_info;
      tmp._update_reward = in_update_reward;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareUpdateReward> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareUpdateReward> _dataCaches = null;
    public static Dictionary<int, DeclareUpdateReward> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataUpdateReward");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataUpdateReward = require 'Lua/Config/DataUpdateReward'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataUpdateReward");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareUpdateReward>(1);
                     foreach (var item in dic)
                     {
                         DeclareUpdateReward tmp = new DeclareUpdateReward();
                       tmp.NeedUpdate = item.Value[0];
                       tmp.Num = item.Value[1];
                       tmp.UpdateInfo = CfgStringLua.Get(item.Value[2]);
                       tmp.UpdateReward = CfgStringLua.Get(item.Value[3]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"UpdateReward");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareUpdateReward>(1);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"UpdateReward");
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
    public static DeclareUpdateReward Get(int id)
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
    public static void Transform(Dictionary<int, DeclareUpdateReward> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
