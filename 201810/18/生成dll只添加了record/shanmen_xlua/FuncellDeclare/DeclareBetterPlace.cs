//文件是自动生成,请勿手动修改.来自数据文件:betterPlace
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareBetterPlace")]
  public class DeclareBetterPlace
  {
    #region //私有变量定义
    //坐标（X1_Z1）
    private string _coordinate;
    //蓝装掉落数量
    private string _dropNum_1;
    //紫装掉落数量
    private string _dropNum_2;
    //标准经验
    private string _exp;
    //挂机点ID
    private int _id;
    //挂机地图ID
    private int _mapID;
    //推荐最大等级
    private int _maxLevel;
    //推荐最小等级
    private int _minLevel;
    //怪物名字
    private string _name;
    //推荐战力
    private int _power;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Coordinate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Coordinate { get{ return _coordinate; } set{ _coordinate=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"DropNum1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DropNum1 { get{ return _dropNum_1; } set{ _dropNum_1=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"DropNum2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DropNum2 { get{ return _dropNum_2; } set{ _dropNum_2=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Exp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Exp { get{ return _exp; } set{ _exp=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"MapID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MapID { get{ return _mapID; } set{ _mapID=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"MaxLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MaxLevel { get{ return _maxLevel; } set{ _maxLevel=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"MinLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MinLevel { get{ return _minLevel; } set{ _minLevel=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Power", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Power { get{ return _power; } set{ _power=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareBetterPlace Create( string in_coordinate, string in_dropNum_1, string in_dropNum_2, string in_exp, int in_id, int in_mapID, int in_maxLevel, int in_minLevel, string in_name, int in_power )
    {
      DeclareBetterPlace tmp = new DeclareBetterPlace();
      tmp._coordinate = in_coordinate;
      tmp._dropNum_1 = in_dropNum_1;
      tmp._dropNum_2 = in_dropNum_2;
      tmp._exp = in_exp;
      tmp._id = in_id;
      tmp._mapID = in_mapID;
      tmp._maxLevel = in_maxLevel;
      tmp._minLevel = in_minLevel;
      tmp._name = in_name;
      tmp._power = in_power;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareBetterPlace> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareBetterPlace> _dataCaches = null;
    public static Dictionary<int, DeclareBetterPlace> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataBetterPlace");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataBetterPlace = require 'Lua/Config/DataBetterPlace'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataBetterPlace");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareBetterPlace>(63);
                     foreach (var item in dic)
                     {
                         DeclareBetterPlace tmp = new DeclareBetterPlace();
                       tmp.Coordinate = CfgStringLua.Get(item.Value[0]);
                       tmp.DropNum1 = CfgStringLua.Get(item.Value[1]);
                       tmp.DropNum2 = CfgStringLua.Get(item.Value[2]);
                       tmp.Exp = CfgStringLua.Get(item.Value[3]);
                       tmp.Id = item.Value[4];
                       tmp.MapID = item.Value[5];
                       tmp.MaxLevel = item.Value[6];
                       tmp.MinLevel = item.Value[7];
                       tmp.Name = CfgStringLua.Get(item.Value[8]);
                       tmp.Power = item.Value[9];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"BetterPlace");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareBetterPlace>(63);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"BetterPlace");
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
    public static DeclareBetterPlace Get(int id)
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
    public static void Transform(Dictionary<int, DeclareBetterPlace> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
