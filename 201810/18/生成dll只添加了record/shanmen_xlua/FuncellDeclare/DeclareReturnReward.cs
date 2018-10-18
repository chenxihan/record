//文件是自动生成,请勿手动修改.来自数据文件:returnReward
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareReturnReward")]
  public class DeclareReturnReward
  {
    #region //私有变量定义
    //等级要求离开天数
    private int _day;
    //上面的文字
    private string _des1;
    //下面的文字
    private string _des2;
    //奖励ID
    private int _iD;
    //奖励,ID_数量_是否绑定（0否 1是）(@;@_@)
    private string _q_reward_item;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Day", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Day { get{ return _day; } set{ _day=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Des1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Des1 { get{ return _des1; } set{ _des1=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Des2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Des2 { get{ return _des2; } set{ _des2=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID { get{ return _iD; } set{ _iD=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"QRewardItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string QRewardItem { get{ return _q_reward_item; } set{ _q_reward_item=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareReturnReward Create( int in_day, string in_des1, string in_des2, int in_iD, string in_q_reward_item )
    {
      DeclareReturnReward tmp = new DeclareReturnReward();
      tmp._day = in_day;
      tmp._des1 = in_des1;
      tmp._des2 = in_des2;
      tmp._iD = in_iD;
      tmp._q_reward_item = in_q_reward_item;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareReturnReward> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareReturnReward> _dataCaches = null;
    public static Dictionary<int, DeclareReturnReward> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataReturnReward");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataReturnReward = require 'Lua/Config/DataReturnReward'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataReturnReward");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareReturnReward>(1);
                     foreach (var item in dic)
                     {
                         DeclareReturnReward tmp = new DeclareReturnReward();
                       tmp.Day = item.Value[0];
                       tmp.Des1 = CfgStringLua.Get(item.Value[1]);
                       tmp.Des2 = CfgStringLua.Get(item.Value[2]);
                       tmp.ID = item.Value[3];
                       tmp.QRewardItem = CfgStringLua.Get(item.Value[4]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"ReturnReward");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareReturnReward>(1);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"ReturnReward");
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
    public static DeclareReturnReward Get(int id)
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
    public static void Transform(Dictionary<int, DeclareReturnReward> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
