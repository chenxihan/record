//文件是自动生成,请勿手动修改.来自数据文件:diamondinvest_up
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareDiamondinvestUp")]
  public class DeclareDiamondinvestUp
  {
    #region //私有变量定义
    //购买价格1
    private int _buy_1;
    //购买价格2
    private int _buy_2;
    //购买价格3
    private int _buy_3;
    //购买条件（VIP等级_玩家角色等级_最大等级）(@_@)
    private string _condition;
    //ID
    private int _iD;
    //领取等级
    private int _level;
    //返还1
    private int _return_1;
    //返还2
    private int _return_2;
    //返还3
    private int _return_3;
    //显示等级
    private string _showLevel;
    //返利百分比
    private int _showPercent;
    //显示文字
    private string _showText;
    //类型（1巅峰投资;2至尊投资）
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Buy1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Buy1 { get{ return _buy_1; } set{ _buy_1=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Buy2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Buy2 { get{ return _buy_2; } set{ _buy_2=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Buy3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Buy3 { get{ return _buy_3; } set{ _buy_3=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Condition", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Condition { get{ return _condition; } set{ _condition=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID { get{ return _iD; } set{ _iD=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Return1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Return1 { get{ return _return_1; } set{ _return_1=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Return2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Return2 { get{ return _return_2; } set{ _return_2=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Return3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Return3 { get{ return _return_3; } set{ _return_3=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"ShowLevel", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ShowLevel { get{ return _showLevel; } set{ _showLevel=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"ShowPercent", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ShowPercent { get{ return _showPercent; } set{ _showPercent=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"ShowText", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ShowText { get{ return _showText; } set{ _showText=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareDiamondinvestUp Create( int in_buy_1, int in_buy_2, int in_buy_3, string in_condition, int in_iD, int in_level, int in_return_1, int in_return_2, int in_return_3, string in_showLevel, int in_showPercent, string in_showText, int in_type )
    {
      DeclareDiamondinvestUp tmp = new DeclareDiamondinvestUp();
      tmp._buy_1 = in_buy_1;
      tmp._buy_2 = in_buy_2;
      tmp._buy_3 = in_buy_3;
      tmp._condition = in_condition;
      tmp._iD = in_iD;
      tmp._level = in_level;
      tmp._return_1 = in_return_1;
      tmp._return_2 = in_return_2;
      tmp._return_3 = in_return_3;
      tmp._showLevel = in_showLevel;
      tmp._showPercent = in_showPercent;
      tmp._showText = in_showText;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareDiamondinvestUp> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareDiamondinvestUp> _dataCaches = null;
    public static Dictionary<int, DeclareDiamondinvestUp> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataDiamondinvestUp");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataDiamondinvestUp = require 'Lua/Config/DataDiamondinvestUp'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataDiamondinvestUp");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareDiamondinvestUp>(55);
                     foreach (var item in dic)
                     {
                         DeclareDiamondinvestUp tmp = new DeclareDiamondinvestUp();
                       tmp.Buy1 = item.Value[0];
                       tmp.Buy2 = item.Value[1];
                       tmp.Buy3 = item.Value[2];
                       tmp.Condition = CfgStringLua.Get(item.Value[3]);
                       tmp.ID = item.Value[4];
                       tmp.Level = item.Value[5];
                       tmp.Return1 = item.Value[6];
                       tmp.Return2 = item.Value[7];
                       tmp.Return3 = item.Value[8];
                       tmp.ShowLevel = CfgStringLua.Get(item.Value[9]);
                       tmp.ShowPercent = item.Value[10];
                       tmp.ShowText = CfgStringLua.Get(item.Value[11]);
                       tmp.Type = item.Value[12];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"DiamondinvestUp");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareDiamondinvestUp>(55);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"DiamondinvestUp");
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
    public static DeclareDiamondinvestUp Get(int id)
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
    public static void Transform(Dictionary<int, DeclareDiamondinvestUp> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
