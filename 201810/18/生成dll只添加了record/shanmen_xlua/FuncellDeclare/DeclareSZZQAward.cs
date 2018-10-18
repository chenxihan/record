//文件是自动生成,请勿手动修改.来自数据文件:SZZQAward
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareSZZQAward")]
  public class DeclareSZZQAward
  {
    #region //私有变量定义
    //奖励(@;@_@)
    private string _award;
    //id
    private int _id;
    //名字
    private string _name;
    //最大排名
    private int _rank_max;
    //最低排名
    private int _rank_min;
    //icon图片
    private int _res_icon;
    //经验奖励索引
    private int _ues_exp_index;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Award", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Award { get{ return _award; } set{ _award=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"RankMax", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int RankMax { get{ return _rank_max; } set{ _rank_max=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"RankMin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int RankMin { get{ return _rank_min; } set{ _rank_min=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"ResIcon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ResIcon { get{ return _res_icon; } set{ _res_icon=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"UesExpIndex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UesExpIndex { get{ return _ues_exp_index; } set{ _ues_exp_index=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareSZZQAward Create( string in_award, int in_id, string in_name, int in_rank_max, int in_rank_min, int in_res_icon, int in_ues_exp_index )
    {
      DeclareSZZQAward tmp = new DeclareSZZQAward();
      tmp._award = in_award;
      tmp._id = in_id;
      tmp._name = in_name;
      tmp._rank_max = in_rank_max;
      tmp._rank_min = in_rank_min;
      tmp._res_icon = in_res_icon;
      tmp._ues_exp_index = in_ues_exp_index;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareSZZQAward> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareSZZQAward> _dataCaches = null;
    public static Dictionary<int, DeclareSZZQAward> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataSZZQAward");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataSZZQAward = require 'Lua/Config/DataSZZQAward'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataSZZQAward");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareSZZQAward>(5);
                     foreach (var item in dic)
                     {
                         DeclareSZZQAward tmp = new DeclareSZZQAward();
                       tmp.Award = CfgStringLua.Get(item.Value[0]);
                       tmp.Id = item.Value[1];
                       tmp.Name = CfgStringLua.Get(item.Value[2]);
                       tmp.RankMax = item.Value[3];
                       tmp.RankMin = item.Value[4];
                       tmp.ResIcon = item.Value[5];
                       tmp.UesExpIndex = item.Value[6];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"SZZQAward");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareSZZQAward>(5);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"SZZQAward");
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
    public static DeclareSZZQAward Get(int id)
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
    public static void Transform(Dictionary<int, DeclareSZZQAward> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
