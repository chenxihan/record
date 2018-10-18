//文件是自动生成,请勿手动修改.来自数据文件:sevendayparty
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareSevendayparty")]
  public class DeclareSevendayparty
  {
    #region //私有变量定义
    //可领奖次数
    private int _canGetCount;
    //领取基础条件(@_@)
    private string _conditions;
    //天数
    private int _day;
    //说明hide
    private string _desc;
    //第几天结算
    //凌晨零点
    private int _endDay;
    //装备奖励（ID_数量_是否绑定（0否1是）_职业），没有不填(@;@_@)
    private string _equipAward;
    //奖励ID
    private int _iD;
    //物品奖励ID_数量_是否绑定（0否1是）(@;@_@)
    private string _itemAward;
    //最大
    private int _max;
    //最小
    private int _min;
    //排名条件
    private int _rankConditions;
    //领奖人类型（0.个人；1.公会会长）
    private int _recipientType;
    //第几天开始
    private int _startDay;
    //类型
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"CanGetCount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanGetCount { get{ return _canGetCount; } set{ _canGetCount=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Conditions", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Conditions { get{ return _conditions; } set{ _conditions=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Day", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Day { get{ return _day; } set{ _day=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Desc { get{ return _desc; } set{ _desc=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"EndDay", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int EndDay { get{ return _endDay; } set{ _endDay=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"EquipAward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string EquipAward { get{ return _equipAward; } set{ _equipAward=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID { get{ return _iD; } set{ _iD=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"ItemAward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ItemAward { get{ return _itemAward; } set{ _itemAward=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Max", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Max { get{ return _max; } set{ _max=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Min", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Min { get{ return _min; } set{ _min=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"RankConditions", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int RankConditions { get{ return _rankConditions; } set{ _rankConditions=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"RecipientType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int RecipientType { get{ return _recipientType; } set{ _recipientType=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"StartDay", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int StartDay { get{ return _startDay; } set{ _startDay=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareSevendayparty Create( int in_canGetCount, string in_conditions, int in_day, string in_desc, int in_endDay, string in_equipAward, int in_iD, string in_itemAward, int in_max, int in_min, int in_rankConditions, int in_recipientType, int in_startDay, int in_type )
    {
      DeclareSevendayparty tmp = new DeclareSevendayparty();
      tmp._canGetCount = in_canGetCount;
      tmp._conditions = in_conditions;
      tmp._day = in_day;
      tmp._desc = in_desc;
      tmp._endDay = in_endDay;
      tmp._equipAward = in_equipAward;
      tmp._iD = in_iD;
      tmp._itemAward = in_itemAward;
      tmp._max = in_max;
      tmp._min = in_min;
      tmp._rankConditions = in_rankConditions;
      tmp._recipientType = in_recipientType;
      tmp._startDay = in_startDay;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareSevendayparty> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareSevendayparty> _dataCaches = null;
    public static Dictionary<int, DeclareSevendayparty> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataSevendayparty");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataSevendayparty = require 'Lua/Config/DataSevendayparty'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataSevendayparty");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareSevendayparty>(24);
                     foreach (var item in dic)
                     {
                         DeclareSevendayparty tmp = new DeclareSevendayparty();
                       tmp.CanGetCount = item.Value[0];
                       tmp.Conditions = CfgStringLua.Get(item.Value[1]);
                       tmp.Day = item.Value[2];
                       tmp.Desc = CfgStringLua.Get(item.Value[3]);
                       tmp.EndDay = item.Value[4];
                       tmp.EquipAward = CfgStringLua.Get(item.Value[5]);
                       tmp.ID = item.Value[6];
                       tmp.ItemAward = CfgStringLua.Get(item.Value[7]);
                       tmp.Max = item.Value[8];
                       tmp.Min = item.Value[9];
                       tmp.RankConditions = item.Value[10];
                       tmp.RecipientType = item.Value[11];
                       tmp.StartDay = item.Value[12];
                       tmp.Type = item.Value[13];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Sevendayparty");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareSevendayparty>(24);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Sevendayparty");
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
    public static DeclareSevendayparty Get(int id)
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
    public static void Transform(Dictionary<int, DeclareSevendayparty> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
