//文件是自动生成,请勿手动修改.来自数据文件:marriage_dinner
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareMarriageDinner")]
  public class DeclareMarriageDinner
  {
    #region //私有变量定义
    //举办最大可获得魅力值（hide）
    private int _charm;
    //举办消耗(@;@_@)
    private string _cost_value;
    //参与消耗
    private int _gift_money;
    //图标
    private int _icon;
    //可以参与的次数
    private int _join_count;
    //宴席等级
    private int _level;
    //名称
    private string _name;
    //是否公告（0不公告；1公告）
    private int _radio;
    //参与获得奖励(@;@_@)
    private string _reward;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Charm", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Charm { get{ return _charm; } set{ _charm=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"CostValue", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string CostValue { get{ return _cost_value; } set{ _cost_value=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"GiftMoney", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int GiftMoney { get{ return _gift_money; } set{ _gift_money=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"JoinCount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int JoinCount { get{ return _join_count; } set{ _join_count=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Radio", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Radio { get{ return _radio; } set{ _radio=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Reward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Reward { get{ return _reward; } set{ _reward=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareMarriageDinner Create( int in_charm, string in_cost_value, int in_gift_money, int in_icon, int in_join_count, int in_level, string in_name, int in_radio, string in_reward )
    {
      DeclareMarriageDinner tmp = new DeclareMarriageDinner();
      tmp._charm = in_charm;
      tmp._cost_value = in_cost_value;
      tmp._gift_money = in_gift_money;
      tmp._icon = in_icon;
      tmp._join_count = in_join_count;
      tmp._level = in_level;
      tmp._name = in_name;
      tmp._radio = in_radio;
      tmp._reward = in_reward;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareMarriageDinner> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareMarriageDinner> _dataCaches = null;
    public static Dictionary<int, DeclareMarriageDinner> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMarriageDinner");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataMarriageDinner = require 'Lua/Config/DataMarriageDinner'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMarriageDinner");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareMarriageDinner>(3);
                     foreach (var item in dic)
                     {
                         DeclareMarriageDinner tmp = new DeclareMarriageDinner();
                       tmp.Charm = item.Value[0];
                       tmp.CostValue = CfgStringLua.Get(item.Value[1]);
                       tmp.GiftMoney = item.Value[2];
                       tmp.Icon = item.Value[3];
                       tmp.JoinCount = item.Value[4];
                       tmp.Level = item.Value[5];
                       tmp.Name = CfgStringLua.Get(item.Value[6]);
                       tmp.Radio = item.Value[7];
                       tmp.Reward = CfgStringLua.Get(item.Value[8]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"MarriageDinner");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareMarriageDinner>(3);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"MarriageDinner");
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
    public static DeclareMarriageDinner Get(int id)
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
    public static void Transform(Dictionary<int, DeclareMarriageDinner> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
