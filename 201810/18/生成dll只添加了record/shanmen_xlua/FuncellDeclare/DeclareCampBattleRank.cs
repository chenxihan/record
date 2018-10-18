//文件是自动生成,请勿手动修改.来自数据文件:CampBattleRank
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareCampBattleRank")]
  public class DeclareCampBattleRank
  {
    #region //私有变量定义
    //段位周奖励(@;@_@)
    private string _awards;
    //段位图片(hide)
    private int _icon;
    //等级
    private int _id;
    //段位等级
    private int _level;
    //段位名称（hide）
    private string _name;
    //段位
    private int _quality;
    //达成积分
    private int _reachScore;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Awards", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Awards { get{ return _awards; } set{ _awards=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Quality", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Quality { get{ return _quality; } set{ _quality=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"ReachScore", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ReachScore { get{ return _reachScore; } set{ _reachScore=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareCampBattleRank Create( string in_awards, int in_icon, int in_id, int in_level, string in_name, int in_quality, int in_reachScore )
    {
      DeclareCampBattleRank tmp = new DeclareCampBattleRank();
      tmp._awards = in_awards;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._level = in_level;
      tmp._name = in_name;
      tmp._quality = in_quality;
      tmp._reachScore = in_reachScore;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareCampBattleRank> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareCampBattleRank> _dataCaches = null;
    public static Dictionary<int, DeclareCampBattleRank> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataCampBattleRank");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataCampBattleRank = require 'Lua/Config/DataCampBattleRank'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataCampBattleRank");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareCampBattleRank>(31);
                     foreach (var item in dic)
                     {
                         DeclareCampBattleRank tmp = new DeclareCampBattleRank();
                       tmp.Awards = CfgStringLua.Get(item.Value[0]);
                       tmp.Icon = item.Value[1];
                       tmp.Id = item.Value[2];
                       tmp.Level = item.Value[3];
                       tmp.Name = CfgStringLua.Get(item.Value[4]);
                       tmp.Quality = item.Value[5];
                       tmp.ReachScore = item.Value[6];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"CampBattleRank");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareCampBattleRank>(31);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"CampBattleRank");
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
    public static DeclareCampBattleRank Get(int id)
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
    public static void Transform(Dictionary<int, DeclareCampBattleRank> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
