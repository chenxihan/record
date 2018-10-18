//文件是自动生成,请勿手动修改.来自数据文件:GodTools
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareGodTools")]
  public class DeclareGodTools
  {
    #region //私有变量定义
    //攻击类型（0，物攻；1，法攻）
    private int _ack_type;
    //激活消耗的道具(@;@_@)
    private string _active_cost;
    //神器基础属性(@;@_@)
    private string _base_property;
    //附灵第一条属性100%的值(@_@)[1,增加属性；2，特殊属性]
    private string _fuling_1;
    //附灵第二条属性100%的值(@_@)
    private string _fuling_2;
    //附灵第三条条属性100%的值(@_@)
    private string _fuling_3;
    //附灵第二条属性100%的值(@_@)
    private string _fuling_4;
    //附灵消耗的道具(@;@_@)
    private string _fuling_cost;
    //附灵第一条属性第一次激活值
    private int _fuling_first1;
    //附灵第二条属性第一次激活值
    private int _fuling_first2;
    //附灵第三条属性第一次激活值
    private int _fuling_first3;
    //附灵第四条属性第一次激活值
    private int _fuling_first4;
    //每次附灵最大值
    private int _fuling_max1;
    //每次附灵最大值
    private int _fuling_max2;
    //每次附灵最大值
    private int _fuling_max3;
    //每次附灵最大值
    private int _fuling_max4;
    //每次附灵最小值
    private int _fuling_min1;
    //每次附灵最小值
    private int _fuling_min2;
    //每次附灵最小值
    private int _fuling_min3;
    //每次附灵最小值
    private int _fuling_min4;
    //d
    private int _id;
    //升级消耗的道具(@;@_@)
    private string _level_up_cost;
    //神器升级属性，每升一级获得的属性(@;@_@)
    private string _level_up_property;
    //模型
    private int _model;
    //名字
    private string _name;
    //品质（0紫，1金，2红，3粉）
    private int _quality;
    //缩放比
    private int _suofang_size;
    //突破消耗的道具(@;@_@)
    private string _tupo_cost;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"AckType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int AckType { get{ return _ack_type; } set{ _ack_type=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"ActiveCost", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ActiveCost { get{ return _active_cost; } set{ _active_cost=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"BaseProperty", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string BaseProperty { get{ return _base_property; } set{ _base_property=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Fuling1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Fuling1 { get{ return _fuling_1; } set{ _fuling_1=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Fuling2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Fuling2 { get{ return _fuling_2; } set{ _fuling_2=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Fuling3", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Fuling3 { get{ return _fuling_3; } set{ _fuling_3=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Fuling4", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Fuling4 { get{ return _fuling_4; } set{ _fuling_4=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"FulingCost", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string FulingCost { get{ return _fuling_cost; } set{ _fuling_cost=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"FulingFirst1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int FulingFirst1 { get{ return _fuling_first1; } set{ _fuling_first1=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"FulingFirst2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int FulingFirst2 { get{ return _fuling_first2; } set{ _fuling_first2=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"FulingFirst3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int FulingFirst3 { get{ return _fuling_first3; } set{ _fuling_first3=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"FulingFirst4", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int FulingFirst4 { get{ return _fuling_first4; } set{ _fuling_first4=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"FulingMax1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int FulingMax1 { get{ return _fuling_max1; } set{ _fuling_max1=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"FulingMax2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int FulingMax2 { get{ return _fuling_max2; } set{ _fuling_max2=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"FulingMax3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int FulingMax3 { get{ return _fuling_max3; } set{ _fuling_max3=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"FulingMax4", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int FulingMax4 { get{ return _fuling_max4; } set{ _fuling_max4=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"FulingMin1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int FulingMin1 { get{ return _fuling_min1; } set{ _fuling_min1=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"FulingMin2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int FulingMin2 { get{ return _fuling_min2; } set{ _fuling_min2=value; } }
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"FulingMin3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int FulingMin3 { get{ return _fuling_min3; } set{ _fuling_min3=value; } }
    [global::ProtoBuf.ProtoMember(20, IsRequired = true, Name=@"FulingMin4", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int FulingMin4 { get{ return _fuling_min4; } set{ _fuling_min4=value; } }
    [global::ProtoBuf.ProtoMember(21, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(22, IsRequired = true, Name=@"LevelUpCost", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string LevelUpCost { get{ return _level_up_cost; } set{ _level_up_cost=value; } }
    [global::ProtoBuf.ProtoMember(23, IsRequired = true, Name=@"LevelUpProperty", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string LevelUpProperty { get{ return _level_up_property; } set{ _level_up_property=value; } }
    [global::ProtoBuf.ProtoMember(24, IsRequired = true, Name=@"Model", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Model { get{ return _model; } set{ _model=value; } }
    [global::ProtoBuf.ProtoMember(25, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(26, IsRequired = true, Name=@"Quality", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Quality { get{ return _quality; } set{ _quality=value; } }
    [global::ProtoBuf.ProtoMember(27, IsRequired = true, Name=@"SuofangSize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SuofangSize { get{ return _suofang_size; } set{ _suofang_size=value; } }
    [global::ProtoBuf.ProtoMember(28, IsRequired = true, Name=@"TupoCost", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TupoCost { get{ return _tupo_cost; } set{ _tupo_cost=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareGodTools Create( int in_ack_type, string in_active_cost, string in_base_property, string in_fuling_1, string in_fuling_2, string in_fuling_3, string in_fuling_4, string in_fuling_cost, int in_fuling_first1, int in_fuling_first2, int in_fuling_first3, int in_fuling_first4, int in_fuling_max1, int in_fuling_max2, int in_fuling_max3, int in_fuling_max4, int in_fuling_min1, int in_fuling_min2, int in_fuling_min3, int in_fuling_min4, int in_id, string in_level_up_cost, string in_level_up_property, int in_model, string in_name, int in_quality, int in_suofang_size, string in_tupo_cost )
    {
      DeclareGodTools tmp = new DeclareGodTools();
      tmp._ack_type = in_ack_type;
      tmp._active_cost = in_active_cost;
      tmp._base_property = in_base_property;
      tmp._fuling_1 = in_fuling_1;
      tmp._fuling_2 = in_fuling_2;
      tmp._fuling_3 = in_fuling_3;
      tmp._fuling_4 = in_fuling_4;
      tmp._fuling_cost = in_fuling_cost;
      tmp._fuling_first1 = in_fuling_first1;
      tmp._fuling_first2 = in_fuling_first2;
      tmp._fuling_first3 = in_fuling_first3;
      tmp._fuling_first4 = in_fuling_first4;
      tmp._fuling_max1 = in_fuling_max1;
      tmp._fuling_max2 = in_fuling_max2;
      tmp._fuling_max3 = in_fuling_max3;
      tmp._fuling_max4 = in_fuling_max4;
      tmp._fuling_min1 = in_fuling_min1;
      tmp._fuling_min2 = in_fuling_min2;
      tmp._fuling_min3 = in_fuling_min3;
      tmp._fuling_min4 = in_fuling_min4;
      tmp._id = in_id;
      tmp._level_up_cost = in_level_up_cost;
      tmp._level_up_property = in_level_up_property;
      tmp._model = in_model;
      tmp._name = in_name;
      tmp._quality = in_quality;
      tmp._suofang_size = in_suofang_size;
      tmp._tupo_cost = in_tupo_cost;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareGodTools> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareGodTools> _dataCaches = null;
    public static Dictionary<int, DeclareGodTools> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGodTools");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataGodTools = require 'Lua/Config/DataGodTools'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGodTools");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareGodTools>(32);
                     foreach (var item in dic)
                     {
                         DeclareGodTools tmp = new DeclareGodTools();
                       tmp.AckType = item.Value[0];
                       tmp.ActiveCost = CfgStringLua.Get(item.Value[1]);
                       tmp.BaseProperty = CfgStringLua.Get(item.Value[2]);
                       tmp.Fuling1 = CfgStringLua.Get(item.Value[3]);
                       tmp.Fuling2 = CfgStringLua.Get(item.Value[4]);
                       tmp.Fuling3 = CfgStringLua.Get(item.Value[5]);
                       tmp.Fuling4 = CfgStringLua.Get(item.Value[6]);
                       tmp.FulingCost = CfgStringLua.Get(item.Value[7]);
                       tmp.FulingFirst1 = item.Value[8];
                       tmp.FulingFirst2 = item.Value[9];
                       tmp.FulingFirst3 = item.Value[10];
                       tmp.FulingFirst4 = item.Value[11];
                       tmp.FulingMax1 = item.Value[12];
                       tmp.FulingMax2 = item.Value[13];
                       tmp.FulingMax3 = item.Value[14];
                       tmp.FulingMax4 = item.Value[15];
                       tmp.FulingMin1 = item.Value[16];
                       tmp.FulingMin2 = item.Value[17];
                       tmp.FulingMin3 = item.Value[18];
                       tmp.FulingMin4 = item.Value[19];
                       tmp.Id = item.Value[20];
                       tmp.LevelUpCost = CfgStringLua.Get(item.Value[21]);
                       tmp.LevelUpProperty = CfgStringLua.Get(item.Value[22]);
                       tmp.Model = item.Value[23];
                       tmp.Name = CfgStringLua.Get(item.Value[24]);
                       tmp.Quality = item.Value[25];
                       tmp.SuofangSize = item.Value[26];
                       tmp.TupoCost = CfgStringLua.Get(item.Value[27]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"GodTools");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareGodTools>(32);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"GodTools");
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
    public static DeclareGodTools Get(int id)
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
    public static void Transform(Dictionary<int, DeclareGodTools> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
