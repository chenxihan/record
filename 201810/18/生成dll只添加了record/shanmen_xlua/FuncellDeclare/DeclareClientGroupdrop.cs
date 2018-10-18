//文件是自动生成,请勿手动修改.来自数据文件:client_groupdrop
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareClientGroupdrop")]
  public class DeclareClientGroupdrop
  {
    #region //私有变量定义
    //是否公告(0为不公告，1为公告)（废弃）
    private int _announcement_1;
    //是否公告(0为不公告，1为公告)
    private int _announcement_10;
    //是否公告(0为不公告，1为公告)
    private int _announcement_2;
    //是否公告(0为不公告，1为公告)
    private int _announcement_3;
    //是否公告(0为不公告，1为公告)
    private int _announcement_4;
    //是否公告(0为不公告，1为公告)
    private int _announcement_5;
    //是否公告(0为不公告，1为公告)
    private int _announcement_6;
    //是否公告(0为不公告，1为公告)
    private int _announcement_7;
    //是否公告(0为不公告，1为公告)
    private int _announcement_8;
    //是否公告(0为不公告，1为公告)
    private int _announcement_9;
    //是否绑定(不绑定为0，绑定为1)
    private int _binding_1;
    //是否绑定(不绑定为0，绑定为1)
    private int _binding_10;
    //是否绑定(不绑定为0，绑定为1)
    private int _binding_2;
    //是否绑定(不绑定为0，绑定为1)
    private int _binding_3;
    //是否绑定(不绑定为0，绑定为1)
    private int _binding_4;
    //是否绑定(不绑定为0，绑定为1)
    private int _binding_5;
    //是否绑定(不绑定为0，绑定为1)
    private int _binding_6;
    //是否绑定(不绑定为0，绑定为1)
    private int _binding_7;
    //是否绑定(不绑定为0，绑定为1)
    private int _binding_8;
    //是否绑定(不绑定为0，绑定为1)
    private int _binding_9;
    //掉落1道具ID(@;@)
    private string _goods_1;
    //掉落10道具ID(@;@)
    private string _goods_10;
    //掉落2道具ID(@;@)
    private string _goods_2;
    //掉落3道具ID(@;@)
    private string _goods_3;
    //掉落4道具ID(@;@)
    private string _goods_4;
    //掉落5道具ID(@;@)
    private string _goods_5;
    //掉落6道具ID(@;@)
    private string _goods_6;
    //掉落7道具ID(@;@)
    private string _goods_7;
    //掉落8道具ID(@;@)
    private string _goods_8;
    //掉落9道具ID(@;@)
    private string _goods_9;
    //掉落ID
    private int _id;
    //掉落总上线
    private string _num_limit;
    //掉落1权重
    private int _weight_1;
    //掉落10权重
    private int _weight_10;
    //掉落2权重
    private int _weight_2;
    //掉落3权重
    private int _weight_3;
    //掉落4权重
    private int _weight_4;
    //掉落5权重
    private int _weight_5;
    //掉落6权重
    private int _weight_6;
    //掉落7权重
    private int _weight_7;
    //掉落8权重
    private int _weight_8;
    //掉落9权重
    private int _weight_9;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Announcement1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Announcement1 { get{ return _announcement_1; } set{ _announcement_1=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Announcement10", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Announcement10 { get{ return _announcement_10; } set{ _announcement_10=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Announcement2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Announcement2 { get{ return _announcement_2; } set{ _announcement_2=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Announcement3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Announcement3 { get{ return _announcement_3; } set{ _announcement_3=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Announcement4", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Announcement4 { get{ return _announcement_4; } set{ _announcement_4=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Announcement5", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Announcement5 { get{ return _announcement_5; } set{ _announcement_5=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Announcement6", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Announcement6 { get{ return _announcement_6; } set{ _announcement_6=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Announcement7", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Announcement7 { get{ return _announcement_7; } set{ _announcement_7=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Announcement8", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Announcement8 { get{ return _announcement_8; } set{ _announcement_8=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Announcement9", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Announcement9 { get{ return _announcement_9; } set{ _announcement_9=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Binding1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Binding1 { get{ return _binding_1; } set{ _binding_1=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"Binding10", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Binding10 { get{ return _binding_10; } set{ _binding_10=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"Binding2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Binding2 { get{ return _binding_2; } set{ _binding_2=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"Binding3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Binding3 { get{ return _binding_3; } set{ _binding_3=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"Binding4", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Binding4 { get{ return _binding_4; } set{ _binding_4=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"Binding5", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Binding5 { get{ return _binding_5; } set{ _binding_5=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"Binding6", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Binding6 { get{ return _binding_6; } set{ _binding_6=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"Binding7", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Binding7 { get{ return _binding_7; } set{ _binding_7=value; } }
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"Binding8", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Binding8 { get{ return _binding_8; } set{ _binding_8=value; } }
    [global::ProtoBuf.ProtoMember(20, IsRequired = true, Name=@"Binding9", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Binding9 { get{ return _binding_9; } set{ _binding_9=value; } }
    [global::ProtoBuf.ProtoMember(21, IsRequired = true, Name=@"Goods1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Goods1 { get{ return _goods_1; } set{ _goods_1=value; } }
    [global::ProtoBuf.ProtoMember(22, IsRequired = true, Name=@"Goods10", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Goods10 { get{ return _goods_10; } set{ _goods_10=value; } }
    [global::ProtoBuf.ProtoMember(23, IsRequired = true, Name=@"Goods2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Goods2 { get{ return _goods_2; } set{ _goods_2=value; } }
    [global::ProtoBuf.ProtoMember(24, IsRequired = true, Name=@"Goods3", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Goods3 { get{ return _goods_3; } set{ _goods_3=value; } }
    [global::ProtoBuf.ProtoMember(25, IsRequired = true, Name=@"Goods4", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Goods4 { get{ return _goods_4; } set{ _goods_4=value; } }
    [global::ProtoBuf.ProtoMember(26, IsRequired = true, Name=@"Goods5", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Goods5 { get{ return _goods_5; } set{ _goods_5=value; } }
    [global::ProtoBuf.ProtoMember(27, IsRequired = true, Name=@"Goods6", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Goods6 { get{ return _goods_6; } set{ _goods_6=value; } }
    [global::ProtoBuf.ProtoMember(28, IsRequired = true, Name=@"Goods7", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Goods7 { get{ return _goods_7; } set{ _goods_7=value; } }
    [global::ProtoBuf.ProtoMember(29, IsRequired = true, Name=@"Goods8", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Goods8 { get{ return _goods_8; } set{ _goods_8=value; } }
    [global::ProtoBuf.ProtoMember(30, IsRequired = true, Name=@"Goods9", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Goods9 { get{ return _goods_9; } set{ _goods_9=value; } }
    [global::ProtoBuf.ProtoMember(31, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(32, IsRequired = true, Name=@"NumLimit", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string NumLimit { get{ return _num_limit; } set{ _num_limit=value; } }
    [global::ProtoBuf.ProtoMember(33, IsRequired = true, Name=@"Weight1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Weight1 { get{ return _weight_1; } set{ _weight_1=value; } }
    [global::ProtoBuf.ProtoMember(34, IsRequired = true, Name=@"Weight10", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Weight10 { get{ return _weight_10; } set{ _weight_10=value; } }
    [global::ProtoBuf.ProtoMember(35, IsRequired = true, Name=@"Weight2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Weight2 { get{ return _weight_2; } set{ _weight_2=value; } }
    [global::ProtoBuf.ProtoMember(36, IsRequired = true, Name=@"Weight3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Weight3 { get{ return _weight_3; } set{ _weight_3=value; } }
    [global::ProtoBuf.ProtoMember(37, IsRequired = true, Name=@"Weight4", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Weight4 { get{ return _weight_4; } set{ _weight_4=value; } }
    [global::ProtoBuf.ProtoMember(38, IsRequired = true, Name=@"Weight5", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Weight5 { get{ return _weight_5; } set{ _weight_5=value; } }
    [global::ProtoBuf.ProtoMember(39, IsRequired = true, Name=@"Weight6", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Weight6 { get{ return _weight_6; } set{ _weight_6=value; } }
    [global::ProtoBuf.ProtoMember(40, IsRequired = true, Name=@"Weight7", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Weight7 { get{ return _weight_7; } set{ _weight_7=value; } }
    [global::ProtoBuf.ProtoMember(41, IsRequired = true, Name=@"Weight8", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Weight8 { get{ return _weight_8; } set{ _weight_8=value; } }
    [global::ProtoBuf.ProtoMember(42, IsRequired = true, Name=@"Weight9", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Weight9 { get{ return _weight_9; } set{ _weight_9=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareClientGroupdrop Create( int in_announcement_1, int in_announcement_10, int in_announcement_2, int in_announcement_3, int in_announcement_4, int in_announcement_5, int in_announcement_6, int in_announcement_7, int in_announcement_8, int in_announcement_9, int in_binding_1, int in_binding_10, int in_binding_2, int in_binding_3, int in_binding_4, int in_binding_5, int in_binding_6, int in_binding_7, int in_binding_8, int in_binding_9, string in_goods_1, string in_goods_10, string in_goods_2, string in_goods_3, string in_goods_4, string in_goods_5, string in_goods_6, string in_goods_7, string in_goods_8, string in_goods_9, int in_id, string in_num_limit, int in_weight_1, int in_weight_10, int in_weight_2, int in_weight_3, int in_weight_4, int in_weight_5, int in_weight_6, int in_weight_7, int in_weight_8, int in_weight_9 )
    {
      DeclareClientGroupdrop tmp = new DeclareClientGroupdrop();
      tmp._announcement_1 = in_announcement_1;
      tmp._announcement_10 = in_announcement_10;
      tmp._announcement_2 = in_announcement_2;
      tmp._announcement_3 = in_announcement_3;
      tmp._announcement_4 = in_announcement_4;
      tmp._announcement_5 = in_announcement_5;
      tmp._announcement_6 = in_announcement_6;
      tmp._announcement_7 = in_announcement_7;
      tmp._announcement_8 = in_announcement_8;
      tmp._announcement_9 = in_announcement_9;
      tmp._binding_1 = in_binding_1;
      tmp._binding_10 = in_binding_10;
      tmp._binding_2 = in_binding_2;
      tmp._binding_3 = in_binding_3;
      tmp._binding_4 = in_binding_4;
      tmp._binding_5 = in_binding_5;
      tmp._binding_6 = in_binding_6;
      tmp._binding_7 = in_binding_7;
      tmp._binding_8 = in_binding_8;
      tmp._binding_9 = in_binding_9;
      tmp._goods_1 = in_goods_1;
      tmp._goods_10 = in_goods_10;
      tmp._goods_2 = in_goods_2;
      tmp._goods_3 = in_goods_3;
      tmp._goods_4 = in_goods_4;
      tmp._goods_5 = in_goods_5;
      tmp._goods_6 = in_goods_6;
      tmp._goods_7 = in_goods_7;
      tmp._goods_8 = in_goods_8;
      tmp._goods_9 = in_goods_9;
      tmp._id = in_id;
      tmp._num_limit = in_num_limit;
      tmp._weight_1 = in_weight_1;
      tmp._weight_10 = in_weight_10;
      tmp._weight_2 = in_weight_2;
      tmp._weight_3 = in_weight_3;
      tmp._weight_4 = in_weight_4;
      tmp._weight_5 = in_weight_5;
      tmp._weight_6 = in_weight_6;
      tmp._weight_7 = in_weight_7;
      tmp._weight_8 = in_weight_8;
      tmp._weight_9 = in_weight_9;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareClientGroupdrop> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareClientGroupdrop> _dataCaches = null;
    public static Dictionary<int, DeclareClientGroupdrop> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataClientGroupdrop");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataClientGroupdrop = require 'Lua/Config/DataClientGroupdrop'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataClientGroupdrop");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareClientGroupdrop>(1145);
                     foreach (var item in dic)
                     {
                         DeclareClientGroupdrop tmp = new DeclareClientGroupdrop();
                       tmp.Announcement1 = item.Value[0];
                       tmp.Announcement10 = item.Value[1];
                       tmp.Announcement2 = item.Value[2];
                       tmp.Announcement3 = item.Value[3];
                       tmp.Announcement4 = item.Value[4];
                       tmp.Announcement5 = item.Value[5];
                       tmp.Announcement6 = item.Value[6];
                       tmp.Announcement7 = item.Value[7];
                       tmp.Announcement8 = item.Value[8];
                       tmp.Announcement9 = item.Value[9];
                       tmp.Binding1 = item.Value[10];
                       tmp.Binding10 = item.Value[11];
                       tmp.Binding2 = item.Value[12];
                       tmp.Binding3 = item.Value[13];
                       tmp.Binding4 = item.Value[14];
                       tmp.Binding5 = item.Value[15];
                       tmp.Binding6 = item.Value[16];
                       tmp.Binding7 = item.Value[17];
                       tmp.Binding8 = item.Value[18];
                       tmp.Binding9 = item.Value[19];
                       tmp.Goods1 = CfgStringLua.Get(item.Value[20]);
                       tmp.Goods10 = CfgStringLua.Get(item.Value[21]);
                       tmp.Goods2 = CfgStringLua.Get(item.Value[22]);
                       tmp.Goods3 = CfgStringLua.Get(item.Value[23]);
                       tmp.Goods4 = CfgStringLua.Get(item.Value[24]);
                       tmp.Goods5 = CfgStringLua.Get(item.Value[25]);
                       tmp.Goods6 = CfgStringLua.Get(item.Value[26]);
                       tmp.Goods7 = CfgStringLua.Get(item.Value[27]);
                       tmp.Goods8 = CfgStringLua.Get(item.Value[28]);
                       tmp.Goods9 = CfgStringLua.Get(item.Value[29]);
                       tmp.Id = item.Value[30];
                       tmp.NumLimit = CfgStringLua.Get(item.Value[31]);
                       tmp.Weight1 = item.Value[32];
                       tmp.Weight10 = item.Value[33];
                       tmp.Weight2 = item.Value[34];
                       tmp.Weight3 = item.Value[35];
                       tmp.Weight4 = item.Value[36];
                       tmp.Weight5 = item.Value[37];
                       tmp.Weight6 = item.Value[38];
                       tmp.Weight7 = item.Value[39];
                       tmp.Weight8 = item.Value[40];
                       tmp.Weight9 = item.Value[41];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"ClientGroupdrop");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareClientGroupdrop>(1145);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"ClientGroupdrop");
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
    public static DeclareClientGroupdrop Get(int id)
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
    public static void Transform(Dictionary<int, DeclareClientGroupdrop> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
