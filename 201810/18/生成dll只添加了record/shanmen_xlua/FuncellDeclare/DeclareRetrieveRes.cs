//文件是自动生成,请勿手动修改.来自数据文件:retrieveRes
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareRetrieveRes")]
  public class DeclareRetrieveRes
  {
    #region //私有变量定义
    //蓝钻找回单次物品：id_数量;id_数量(@;@_@)
    private string _arward;
    //免费找回单次物品：id_数量;id_数量(@;@_@)
    private string _arward_free;
    //蓝钻找回单次经验奖励
    private Int64 _exp;
    //免费找回单次经验奖励
    private Int64 _exp_free;
    //单次消耗元宝
    private int _gold;
    //唯一ID
    private int _id;
    //单次消耗道具:id_数量(@_@)
    private string _item;
    //次数(每天系统提供的参与次数)
    private int _max;
    //等级max
    private int _maxLevel;
    //等级min
    private int _minLevel;
    //名称
    private string _name;
    //活动开放时间（1-7表示周一到周日的某一天）(@;@)
    private string _openDay;
    //功能开启条件参数(@_@)
    private string _openVariables;
    //蓝钻找回灵魂:灵魂ID_数量(@;@_@)
    private string _soul;
    //免费找回灵魂:灵魂ID_数量(@;@_@)
    private string _soul_free;
    //类型
    private int _type;
    //每天更新时间（保持和各个系统一致）
    private int _update;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Arward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Arward { get{ return _arward; } set{ _arward=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"ArwardFree", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ArwardFree { get{ return _arward_free; } set{ _arward_free=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Int64 Exp { get{ return _exp; } set{ _exp=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"ExpFree", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Int64 ExpFree { get{ return _exp_free; } set{ _exp_free=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Gold", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Gold { get{ return _gold; } set{ _gold=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Item { get{ return _item; } set{ _item=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Max", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Max { get{ return _max; } set{ _max=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"MaxLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MaxLevel { get{ return _maxLevel; } set{ _maxLevel=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"MinLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MinLevel { get{ return _minLevel; } set{ _minLevel=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"OpenDay", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OpenDay { get{ return _openDay; } set{ _openDay=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"OpenVariables", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OpenVariables { get{ return _openVariables; } set{ _openVariables=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"Soul", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Soul { get{ return _soul; } set{ _soul=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"SoulFree", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SoulFree { get{ return _soul_free; } set{ _soul_free=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"Update", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Update { get{ return _update; } set{ _update=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareRetrieveRes Create( string in_arward, string in_arward_free, Int64 in_exp, Int64 in_exp_free, int in_gold, int in_id, string in_item, int in_max, int in_maxLevel, int in_minLevel, string in_name, string in_openDay, string in_openVariables, string in_soul, string in_soul_free, int in_type, int in_update )
    {
      DeclareRetrieveRes tmp = new DeclareRetrieveRes();
      tmp._arward = in_arward;
      tmp._arward_free = in_arward_free;
      tmp._exp = in_exp;
      tmp._exp_free = in_exp_free;
      tmp._gold = in_gold;
      tmp._id = in_id;
      tmp._item = in_item;
      tmp._max = in_max;
      tmp._maxLevel = in_maxLevel;
      tmp._minLevel = in_minLevel;
      tmp._name = in_name;
      tmp._openDay = in_openDay;
      tmp._openVariables = in_openVariables;
      tmp._soul = in_soul;
      tmp._soul_free = in_soul_free;
      tmp._type = in_type;
      tmp._update = in_update;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareRetrieveRes> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareRetrieveRes> _dataCaches = null;
    public static Dictionary<int, DeclareRetrieveRes> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataRetrieveRes");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataRetrieveRes = require 'Lua/Config/DataRetrieveRes'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataRetrieveRes");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareRetrieveRes>(825);
                     foreach (var item in dic)
                     {
                         DeclareRetrieveRes tmp = new DeclareRetrieveRes();
                       tmp.Arward = CfgStringLua.Get(item.Value[0]);
                       tmp.ArwardFree = CfgStringLua.Get(item.Value[1]);
                       tmp.Exp = item.Value[2];
                       tmp.ExpFree = item.Value[3];
                       tmp.Gold = item.Value[4];
                       tmp.Id = item.Value[5];
                       tmp.Item = CfgStringLua.Get(item.Value[6]);
                       tmp.Max = item.Value[7];
                       tmp.MaxLevel = item.Value[8];
                       tmp.MinLevel = item.Value[9];
                       tmp.Name = CfgStringLua.Get(item.Value[10]);
                       tmp.OpenDay = CfgStringLua.Get(item.Value[11]);
                       tmp.OpenVariables = CfgStringLua.Get(item.Value[12]);
                       tmp.Soul = CfgStringLua.Get(item.Value[13]);
                       tmp.SoulFree = CfgStringLua.Get(item.Value[14]);
                       tmp.Type = item.Value[15];
                       tmp.Update = item.Value[16];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"RetrieveRes");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareRetrieveRes>(825);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"RetrieveRes");
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
    public static DeclareRetrieveRes Get(int id)
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
    public static void Transform(Dictionary<int, DeclareRetrieveRes> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
