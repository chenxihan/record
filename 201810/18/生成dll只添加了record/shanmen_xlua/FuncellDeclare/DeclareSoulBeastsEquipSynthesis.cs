//文件是自动生成,请勿手动修改.来自数据文件:SoulBeastsEquipSynthesis
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareSoulBeastsEquipSynthesis")]
  public class DeclareSoulBeastsEquipSynthesis
  {
    #region //私有变量定义
    //需求道具（道具ID_数量）(@_@)
    private string _demand_item;
    //1表示1个钻石，2表示2个钻石，0表示没有钻石，钻石显示为左上角
    private int _diamond_Number;
    //装备是否带钻
    //1表示1个钻石，2表示2个钻石，0表示没有钻石，钻石显示为左上角(hide)
    private int _equip_diamond_Number;
    //装备ID
    private int _equip_ID;
    //装备部位(1头盔、2项圈、3铠甲、4利爪、5羽翼)
    private int _equip_position;
    //目标装备品质(hide)
    private int _equip_quality;
    //编号
    private int _id;
    //放入数量(最小_最大)(@_@)
    private string _join_num;
    //放入格子数量增加概率（格子数量_概率(万分比);格子数量_概率(万分比)）(@;@_@)
    private string _join_num_probability;
    //放入品质(：1.白 2.绿 3.蓝 4.紫 5.橙 6.金 7.红 8.粉)
    private int _quality;
    //是否屏蔽（0为不屏蔽，1为屏蔽）
    private int _shielding;
    //参与合成等级
    private int _synthesis_level;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"DemandItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DemandItem { get{ return _demand_item; } set{ _demand_item=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"DiamondNumber", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DiamondNumber { get{ return _diamond_Number; } set{ _diamond_Number=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"EquipDiamondNumber", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int EquipDiamondNumber { get{ return _equip_diamond_Number; } set{ _equip_diamond_Number=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"EquipID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int EquipID { get{ return _equip_ID; } set{ _equip_ID=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"EquipPosition", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int EquipPosition { get{ return _equip_position; } set{ _equip_position=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"EquipQuality", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int EquipQuality { get{ return _equip_quality; } set{ _equip_quality=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"JoinNum", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string JoinNum { get{ return _join_num; } set{ _join_num=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"JoinNumProbability", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string JoinNumProbability { get{ return _join_num_probability; } set{ _join_num_probability=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Quality", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Quality { get{ return _quality; } set{ _quality=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Shielding", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Shielding { get{ return _shielding; } set{ _shielding=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"SynthesisLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SynthesisLevel { get{ return _synthesis_level; } set{ _synthesis_level=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareSoulBeastsEquipSynthesis Create( string in_demand_item, int in_diamond_Number, int in_equip_diamond_Number, int in_equip_ID, int in_equip_position, int in_equip_quality, int in_id, string in_join_num, string in_join_num_probability, int in_quality, int in_shielding, int in_synthesis_level )
    {
      DeclareSoulBeastsEquipSynthesis tmp = new DeclareSoulBeastsEquipSynthesis();
      tmp._demand_item = in_demand_item;
      tmp._diamond_Number = in_diamond_Number;
      tmp._equip_diamond_Number = in_equip_diamond_Number;
      tmp._equip_ID = in_equip_ID;
      tmp._equip_position = in_equip_position;
      tmp._equip_quality = in_equip_quality;
      tmp._id = in_id;
      tmp._join_num = in_join_num;
      tmp._join_num_probability = in_join_num_probability;
      tmp._quality = in_quality;
      tmp._shielding = in_shielding;
      tmp._synthesis_level = in_synthesis_level;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareSoulBeastsEquipSynthesis> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareSoulBeastsEquipSynthesis> _dataCaches = null;
    public static Dictionary<int, DeclareSoulBeastsEquipSynthesis> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataSoulBeastsEquipSynthesis");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataSoulBeastsEquipSynthesis = require 'Lua/Config/DataSoulBeastsEquipSynthesis'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataSoulBeastsEquipSynthesis");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareSoulBeastsEquipSynthesis>(10);
                     foreach (var item in dic)
                     {
                         DeclareSoulBeastsEquipSynthesis tmp = new DeclareSoulBeastsEquipSynthesis();
                       tmp.DemandItem = CfgStringLua.Get(item.Value[0]);
                       tmp.DiamondNumber = item.Value[1];
                       tmp.EquipDiamondNumber = item.Value[2];
                       tmp.EquipID = item.Value[3];
                       tmp.EquipPosition = item.Value[4];
                       tmp.EquipQuality = item.Value[5];
                       tmp.Id = item.Value[6];
                       tmp.JoinNum = CfgStringLua.Get(item.Value[7]);
                       tmp.JoinNumProbability = CfgStringLua.Get(item.Value[8]);
                       tmp.Quality = item.Value[9];
                       tmp.Shielding = item.Value[10];
                       tmp.SynthesisLevel = item.Value[11];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"SoulBeastsEquipSynthesis");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareSoulBeastsEquipSynthesis>(10);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"SoulBeastsEquipSynthesis");
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
    public static DeclareSoulBeastsEquipSynthesis Get(int id)
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
    public static void Transform(Dictionary<int, DeclareSoulBeastsEquipSynthesis> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
