//文件是自动生成,请勿手动修改.来自数据文件:master_graduate
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareMasterGraduate")]
  public class DeclareMasterGraduate
  {
    #region //私有变量定义
    //是否可出师0否，1是
    private int _graduate;
    //评价图标ID
    private string _icon;
    //所需学分
    private int _num;
    //学分转换比例（百分比）
    private int _proportion;
    //是否公告（0不公告；1公告）
    private int _radio;
    //奖励物品(奖励物品id_物品数量,(@;@_@)
    private string _rewards_app;
    //奖励物品(奖励物品id_物品数量,(@;@_@)
    private string _rewards_master;
    //学分对应的评分
    private int _score;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Graduate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Graduate { get{ return _graduate; } set{ _graduate=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Num { get{ return _num; } set{ _num=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Proportion", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Proportion { get{ return _proportion; } set{ _proportion=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Radio", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Radio { get{ return _radio; } set{ _radio=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"RewardsApp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string RewardsApp { get{ return _rewards_app; } set{ _rewards_app=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"RewardsMaster", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string RewardsMaster { get{ return _rewards_master; } set{ _rewards_master=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Score", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Score { get{ return _score; } set{ _score=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareMasterGraduate Create( int in_graduate, string in_icon, int in_num, int in_proportion, int in_radio, string in_rewards_app, string in_rewards_master, int in_score )
    {
      DeclareMasterGraduate tmp = new DeclareMasterGraduate();
      tmp._graduate = in_graduate;
      tmp._icon = in_icon;
      tmp._num = in_num;
      tmp._proportion = in_proportion;
      tmp._radio = in_radio;
      tmp._rewards_app = in_rewards_app;
      tmp._rewards_master = in_rewards_master;
      tmp._score = in_score;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareMasterGraduate> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareMasterGraduate> _dataCaches = null;
    public static Dictionary<int, DeclareMasterGraduate> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMasterGraduate");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataMasterGraduate = require 'Lua/Config/DataMasterGraduate'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMasterGraduate");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareMasterGraduate>(6);
                     foreach (var item in dic)
                     {
                         DeclareMasterGraduate tmp = new DeclareMasterGraduate();
                       tmp.Graduate = item.Value[0];
                       tmp.Icon = CfgStringLua.Get(item.Value[1]);
                       tmp.Num = item.Value[2];
                       tmp.Proportion = item.Value[3];
                       tmp.Radio = item.Value[4];
                       tmp.RewardsApp = CfgStringLua.Get(item.Value[5]);
                       tmp.RewardsMaster = CfgStringLua.Get(item.Value[6]);
                       tmp.Score = item.Value[7];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"MasterGraduate");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareMasterGraduate>(6);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"MasterGraduate");
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
    public static DeclareMasterGraduate Get(int id)
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
    public static void Transform(Dictionary<int, DeclareMasterGraduate> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
