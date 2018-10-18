//文件是自动生成,请勿手动修改.来自数据文件:elves_rune
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareElvesRune")]
  public class DeclareElvesRune
  {
    #region //私有变量定义
    //addAttribute(@;@_@)
    private string _addAttribute;
    //祝福值上限值
    private int _blessnum_limit;
    //每次失败增加祝福值区间max
    private int _blessnum_max;
    //每次失败增加祝福值区间min
    private int _blessnum_min;
    //自动消耗元宝数量
    private int _gold_num;
    //符文阶数
    private int _iD;
    //道具数量
    private int _item_num;
    //符文名称
    private string _name;
    //进阶成功是否全服公告（0不公告，1公告）
    private int _notice;
    //符文类型
    private int _type;
    //进阶消耗物品
    private int _up_item;
    //进阶成功所需进阶次数max
    private int _up_num_max;
    //进阶成功所需进阶次数min
    private int _up_num_min;
    //服务器端计算用进阶成功几率（万分比）
    private int _up_probability;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"AddAttribute", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string AddAttribute { get{ return _addAttribute; } set{ _addAttribute=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"BlessnumLimit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BlessnumLimit { get{ return _blessnum_limit; } set{ _blessnum_limit=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"BlessnumMax", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BlessnumMax { get{ return _blessnum_max; } set{ _blessnum_max=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"BlessnumMin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BlessnumMin { get{ return _blessnum_min; } set{ _blessnum_min=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"GoldNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int GoldNum { get{ return _gold_num; } set{ _gold_num=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID { get{ return _iD; } set{ _iD=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"ItemNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ItemNum { get{ return _item_num; } set{ _item_num=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Notice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Notice { get{ return _notice; } set{ _notice=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"UpItem", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UpItem { get{ return _up_item; } set{ _up_item=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"UpNumMax", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UpNumMax { get{ return _up_num_max; } set{ _up_num_max=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"UpNumMin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UpNumMin { get{ return _up_num_min; } set{ _up_num_min=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"UpProbability", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UpProbability { get{ return _up_probability; } set{ _up_probability=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareElvesRune Create( string in_addAttribute, int in_blessnum_limit, int in_blessnum_max, int in_blessnum_min, int in_gold_num, int in_iD, int in_item_num, string in_name, int in_notice, int in_type, int in_up_item, int in_up_num_max, int in_up_num_min, int in_up_probability )
    {
      DeclareElvesRune tmp = new DeclareElvesRune();
      tmp._addAttribute = in_addAttribute;
      tmp._blessnum_limit = in_blessnum_limit;
      tmp._blessnum_max = in_blessnum_max;
      tmp._blessnum_min = in_blessnum_min;
      tmp._gold_num = in_gold_num;
      tmp._iD = in_iD;
      tmp._item_num = in_item_num;
      tmp._name = in_name;
      tmp._notice = in_notice;
      tmp._type = in_type;
      tmp._up_item = in_up_item;
      tmp._up_num_max = in_up_num_max;
      tmp._up_num_min = in_up_num_min;
      tmp._up_probability = in_up_probability;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareElvesRune> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareElvesRune> _dataCaches = null;
    public static Dictionary<int, DeclareElvesRune> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataElvesRune");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataElvesRune = require 'Lua/Config/DataElvesRune'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataElvesRune");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareElvesRune>(66);
                     foreach (var item in dic)
                     {
                         DeclareElvesRune tmp = new DeclareElvesRune();
                       tmp.AddAttribute = CfgStringLua.Get(item.Value[0]);
                       tmp.BlessnumLimit = item.Value[1];
                       tmp.BlessnumMax = item.Value[2];
                       tmp.BlessnumMin = item.Value[3];
                       tmp.GoldNum = item.Value[4];
                       tmp.ID = item.Value[5];
                       tmp.ItemNum = item.Value[6];
                       tmp.Name = CfgStringLua.Get(item.Value[7]);
                       tmp.Notice = item.Value[8];
                       tmp.Type = item.Value[9];
                       tmp.UpItem = item.Value[10];
                       tmp.UpNumMax = item.Value[11];
                       tmp.UpNumMin = item.Value[12];
                       tmp.UpProbability = item.Value[13];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"ElvesRune");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareElvesRune>(66);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"ElvesRune");
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
    public static DeclareElvesRune Get(int id)
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
    public static void Transform(Dictionary<int, DeclareElvesRune> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
