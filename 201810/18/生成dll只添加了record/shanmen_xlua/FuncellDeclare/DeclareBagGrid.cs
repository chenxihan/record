//文件是自动生成,请勿手动修改.来自数据文件:bag_grid
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareBagGrid")]
  public class DeclareBagGrid
  {
    #region //私有变量定义
    //所属系统（1 背包 3 仓库）
    private int _bag;
    //格子索引
    private string _bag_grid;
    //元宝费用
    private Int64 _cost;
    //格子编号
    private int _grid;
    //开启时间/秒
    private Int64 _time;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Bag", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Bag { get{ return _bag; } set{ _bag=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"BagGrid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string BagGrid { get{ return _bag_grid; } set{ _bag_grid=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Cost", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Int64 Cost { get{ return _cost; } set{ _cost=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Grid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Grid { get{ return _grid; } set{ _grid=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Int64 Time { get{ return _time; } set{ _time=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareBagGrid Create( int in_bag, string in_bag_grid, Int64 in_cost, int in_grid, Int64 in_time )
    {
      DeclareBagGrid tmp = new DeclareBagGrid();
      tmp._bag = in_bag;
      tmp._bag_grid = in_bag_grid;
      tmp._cost = in_cost;
      tmp._grid = in_grid;
      tmp._time = in_time;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<string, DeclareBagGrid> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<string, DeclareBagGrid> _dataCaches = null;
    public static Dictionary<string, DeclareBagGrid> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataBagGrid");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataBagGrid = require 'Lua/Config/DataBagGrid'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataBagGrid");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<string, DeclareBagGrid>(230);
                     foreach (var item in dic)
                     {
                         DeclareBagGrid tmp = new DeclareBagGrid();
                       tmp.Bag = item.Value[0];
                       tmp.BagGrid = CfgStringLua.Get(item.Value[1]);
                       tmp.Cost = item.Value[2];
                       tmp.Grid = item.Value[3];
                       tmp.Time = item.Value[4];

                         _dataCaches.Add(CfgStringLua.Get(item.Key), tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"BagGrid");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<string, DeclareBagGrid>(230);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"BagGrid");
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
    public static DeclareBagGrid Get(string id)
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
    public static void Transform(Dictionary<string, DeclareBagGrid> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
