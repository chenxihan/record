//文件是自动生成,请勿手动修改.来自数据文件:client_drop
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareClientDrop")]
  public class DeclareClientDrop
  {
    #region //私有变量定义
    //组1分配规则
    private int _distribution_1;
    //组10分配规则
    private int _distribution_10;
    //创世水晶分配规则
    private int _distribution_11;
    //组2分配规则
    private int _distribution_2;
    //组3分配规则
    private int _distribution_3;
    //组4分配规则
    private int _distribution_4;
    //组5分配规则
    private int _distribution_5;
    //组6分配规则
    private int _distribution_6;
    //组7分配规则
    private int _distribution_7;
    //组8分配规则
    private int _distribution_8;
    //组9分配规则
    private int _distribution_9;
    //组1掉落ID(职业_掉落ID;职业_掉落ID)(@;@_@)
    private string _drop_id_1;
    //组10掉落ID(职业_掉落ID;职业_掉落ID)(@;@_@)
    private string _drop_id_10;
    //创世水晶掉落ID(职业_掉落ID;职业_掉落ID)(@;@_@)
    private string _drop_id_11;
    //组2掉落ID(职业_掉落ID;职业_掉落ID)(@;@_@)
    private string _drop_id_2;
    //组3掉落ID(职业_掉落ID;职业_掉落ID)(@;@_@)
    private string _drop_id_3;
    //组4掉落ID(职业_掉落ID;职业_掉落ID)(@;@_@)
    private string _drop_id_4;
    //组5掉落ID(职业_掉落ID;职业_掉落ID)(@;@_@)
    private string _drop_id_5;
    //组6掉落ID(职业_掉落ID;职业_掉落ID)(@;@_@)
    private string _drop_id_6;
    //组7掉落ID(职业_掉落ID;职业_掉落ID)(@;@_@)
    private string _drop_id_7;
    //组8掉落ID(职业_掉落ID;职业_掉落ID)(@;@_@)
    private string _drop_id_8;
    //组9掉落ID(职业_掉落ID;职业_掉落ID)(@;@_@)
    private string _drop_id_9;
    //组1掉落概率
    private int _drop_probability_1;
    //组10掉落概率
    private int _drop_probability_10;
    //创世水晶掉落概率
    private int _drop_probability_11;
    //组2掉落概率
    private int _drop_probability_2;
    //组3掉落概率
    private int _drop_probability_3;
    //组4掉落概率
    private int _drop_probability_4;
    //组5掉落概率
    private int _drop_probability_5;
    //组6掉落概率
    private int _drop_probability_6;
    //组7掉落概率
    private int _drop_probability_7;
    //组8掉落概率
    private int _drop_probability_8;
    //组9掉落概率
    private int _drop_probability_9;
    //组1掉落类型
    private int _drop_type_1;
    //组10掉落类型
    private int _drop_type_10;
    //创世水晶掉落类型
    private int _drop_type_11;
    //组2掉落类型
    private int _drop_type_2;
    //组3掉落类型
    private int _drop_type_3;
    //组4掉落类型
    private int _drop_type_4;
    //组5掉落类型
    private int _drop_type_5;
    //组6掉落类型
    private int _drop_type_6;
    //组7掉落类型
    private int _drop_type_7;
    //组8掉落类型
    private int _drop_type_8;
    //组9掉落类型
    private int _drop_type_9;
    //掉落组ID
    private int _id;
    //掉落货币填写规则：货币类型_数量;货币类型_数量(@;@_@)
    private string _money;
    //低于玩家多少级后不再有掉落（如果为0则忽略此数据）
    private int _reduce_act_level;
    //是否需要每个玩家随机一次是否掉了（0为不需要，1为需要）
    private int _shared_drop;
    //任务掉落填写规则:任务ID_万分概率_物品ID;任务ID_万分概率_物品ID(@;@_@)
    private string _task;
    //掉落限制的分组ID
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Distribution1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Distribution1 { get{ return _distribution_1; } set{ _distribution_1=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Distribution10", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Distribution10 { get{ return _distribution_10; } set{ _distribution_10=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Distribution11", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Distribution11 { get{ return _distribution_11; } set{ _distribution_11=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Distribution2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Distribution2 { get{ return _distribution_2; } set{ _distribution_2=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Distribution3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Distribution3 { get{ return _distribution_3; } set{ _distribution_3=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Distribution4", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Distribution4 { get{ return _distribution_4; } set{ _distribution_4=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Distribution5", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Distribution5 { get{ return _distribution_5; } set{ _distribution_5=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Distribution6", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Distribution6 { get{ return _distribution_6; } set{ _distribution_6=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Distribution7", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Distribution7 { get{ return _distribution_7; } set{ _distribution_7=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Distribution8", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Distribution8 { get{ return _distribution_8; } set{ _distribution_8=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Distribution9", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Distribution9 { get{ return _distribution_9; } set{ _distribution_9=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"DropId1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DropId1 { get{ return _drop_id_1; } set{ _drop_id_1=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"DropId10", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DropId10 { get{ return _drop_id_10; } set{ _drop_id_10=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"DropId11", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DropId11 { get{ return _drop_id_11; } set{ _drop_id_11=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"DropId2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DropId2 { get{ return _drop_id_2; } set{ _drop_id_2=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"DropId3", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DropId3 { get{ return _drop_id_3; } set{ _drop_id_3=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"DropId4", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DropId4 { get{ return _drop_id_4; } set{ _drop_id_4=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"DropId5", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DropId5 { get{ return _drop_id_5; } set{ _drop_id_5=value; } }
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"DropId6", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DropId6 { get{ return _drop_id_6; } set{ _drop_id_6=value; } }
    [global::ProtoBuf.ProtoMember(20, IsRequired = true, Name=@"DropId7", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DropId7 { get{ return _drop_id_7; } set{ _drop_id_7=value; } }
    [global::ProtoBuf.ProtoMember(21, IsRequired = true, Name=@"DropId8", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DropId8 { get{ return _drop_id_8; } set{ _drop_id_8=value; } }
    [global::ProtoBuf.ProtoMember(22, IsRequired = true, Name=@"DropId9", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DropId9 { get{ return _drop_id_9; } set{ _drop_id_9=value; } }
    [global::ProtoBuf.ProtoMember(23, IsRequired = true, Name=@"DropProbability1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DropProbability1 { get{ return _drop_probability_1; } set{ _drop_probability_1=value; } }
    [global::ProtoBuf.ProtoMember(24, IsRequired = true, Name=@"DropProbability10", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DropProbability10 { get{ return _drop_probability_10; } set{ _drop_probability_10=value; } }
    [global::ProtoBuf.ProtoMember(25, IsRequired = true, Name=@"DropProbability11", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DropProbability11 { get{ return _drop_probability_11; } set{ _drop_probability_11=value; } }
    [global::ProtoBuf.ProtoMember(26, IsRequired = true, Name=@"DropProbability2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DropProbability2 { get{ return _drop_probability_2; } set{ _drop_probability_2=value; } }
    [global::ProtoBuf.ProtoMember(27, IsRequired = true, Name=@"DropProbability3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DropProbability3 { get{ return _drop_probability_3; } set{ _drop_probability_3=value; } }
    [global::ProtoBuf.ProtoMember(28, IsRequired = true, Name=@"DropProbability4", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DropProbability4 { get{ return _drop_probability_4; } set{ _drop_probability_4=value; } }
    [global::ProtoBuf.ProtoMember(29, IsRequired = true, Name=@"DropProbability5", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DropProbability5 { get{ return _drop_probability_5; } set{ _drop_probability_5=value; } }
    [global::ProtoBuf.ProtoMember(30, IsRequired = true, Name=@"DropProbability6", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DropProbability6 { get{ return _drop_probability_6; } set{ _drop_probability_6=value; } }
    [global::ProtoBuf.ProtoMember(31, IsRequired = true, Name=@"DropProbability7", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DropProbability7 { get{ return _drop_probability_7; } set{ _drop_probability_7=value; } }
    [global::ProtoBuf.ProtoMember(32, IsRequired = true, Name=@"DropProbability8", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DropProbability8 { get{ return _drop_probability_8; } set{ _drop_probability_8=value; } }
    [global::ProtoBuf.ProtoMember(33, IsRequired = true, Name=@"DropProbability9", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DropProbability9 { get{ return _drop_probability_9; } set{ _drop_probability_9=value; } }
    [global::ProtoBuf.ProtoMember(34, IsRequired = true, Name=@"DropType1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DropType1 { get{ return _drop_type_1; } set{ _drop_type_1=value; } }
    [global::ProtoBuf.ProtoMember(35, IsRequired = true, Name=@"DropType10", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DropType10 { get{ return _drop_type_10; } set{ _drop_type_10=value; } }
    [global::ProtoBuf.ProtoMember(36, IsRequired = true, Name=@"DropType11", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DropType11 { get{ return _drop_type_11; } set{ _drop_type_11=value; } }
    [global::ProtoBuf.ProtoMember(37, IsRequired = true, Name=@"DropType2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DropType2 { get{ return _drop_type_2; } set{ _drop_type_2=value; } }
    [global::ProtoBuf.ProtoMember(38, IsRequired = true, Name=@"DropType3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DropType3 { get{ return _drop_type_3; } set{ _drop_type_3=value; } }
    [global::ProtoBuf.ProtoMember(39, IsRequired = true, Name=@"DropType4", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DropType4 { get{ return _drop_type_4; } set{ _drop_type_4=value; } }
    [global::ProtoBuf.ProtoMember(40, IsRequired = true, Name=@"DropType5", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DropType5 { get{ return _drop_type_5; } set{ _drop_type_5=value; } }
    [global::ProtoBuf.ProtoMember(41, IsRequired = true, Name=@"DropType6", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DropType6 { get{ return _drop_type_6; } set{ _drop_type_6=value; } }
    [global::ProtoBuf.ProtoMember(42, IsRequired = true, Name=@"DropType7", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DropType7 { get{ return _drop_type_7; } set{ _drop_type_7=value; } }
    [global::ProtoBuf.ProtoMember(43, IsRequired = true, Name=@"DropType8", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DropType8 { get{ return _drop_type_8; } set{ _drop_type_8=value; } }
    [global::ProtoBuf.ProtoMember(44, IsRequired = true, Name=@"DropType9", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DropType9 { get{ return _drop_type_9; } set{ _drop_type_9=value; } }
    [global::ProtoBuf.ProtoMember(45, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(46, IsRequired = true, Name=@"Money", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Money { get{ return _money; } set{ _money=value; } }
    [global::ProtoBuf.ProtoMember(47, IsRequired = true, Name=@"ReduceActLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ReduceActLevel { get{ return _reduce_act_level; } set{ _reduce_act_level=value; } }
    [global::ProtoBuf.ProtoMember(48, IsRequired = true, Name=@"SharedDrop", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SharedDrop { get{ return _shared_drop; } set{ _shared_drop=value; } }
    [global::ProtoBuf.ProtoMember(49, IsRequired = true, Name=@"Task", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Task { get{ return _task; } set{ _task=value; } }
    [global::ProtoBuf.ProtoMember(50, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareClientDrop Create( int in_distribution_1, int in_distribution_10, int in_distribution_11, int in_distribution_2, int in_distribution_3, int in_distribution_4, int in_distribution_5, int in_distribution_6, int in_distribution_7, int in_distribution_8, int in_distribution_9, string in_drop_id_1, string in_drop_id_10, string in_drop_id_11, string in_drop_id_2, string in_drop_id_3, string in_drop_id_4, string in_drop_id_5, string in_drop_id_6, string in_drop_id_7, string in_drop_id_8, string in_drop_id_9, int in_drop_probability_1, int in_drop_probability_10, int in_drop_probability_11, int in_drop_probability_2, int in_drop_probability_3, int in_drop_probability_4, int in_drop_probability_5, int in_drop_probability_6, int in_drop_probability_7, int in_drop_probability_8, int in_drop_probability_9, int in_drop_type_1, int in_drop_type_10, int in_drop_type_11, int in_drop_type_2, int in_drop_type_3, int in_drop_type_4, int in_drop_type_5, int in_drop_type_6, int in_drop_type_7, int in_drop_type_8, int in_drop_type_9, int in_id, string in_money, int in_reduce_act_level, int in_shared_drop, string in_task, int in_type )
    {
      DeclareClientDrop tmp = new DeclareClientDrop();
      tmp._distribution_1 = in_distribution_1;
      tmp._distribution_10 = in_distribution_10;
      tmp._distribution_11 = in_distribution_11;
      tmp._distribution_2 = in_distribution_2;
      tmp._distribution_3 = in_distribution_3;
      tmp._distribution_4 = in_distribution_4;
      tmp._distribution_5 = in_distribution_5;
      tmp._distribution_6 = in_distribution_6;
      tmp._distribution_7 = in_distribution_7;
      tmp._distribution_8 = in_distribution_8;
      tmp._distribution_9 = in_distribution_9;
      tmp._drop_id_1 = in_drop_id_1;
      tmp._drop_id_10 = in_drop_id_10;
      tmp._drop_id_11 = in_drop_id_11;
      tmp._drop_id_2 = in_drop_id_2;
      tmp._drop_id_3 = in_drop_id_3;
      tmp._drop_id_4 = in_drop_id_4;
      tmp._drop_id_5 = in_drop_id_5;
      tmp._drop_id_6 = in_drop_id_6;
      tmp._drop_id_7 = in_drop_id_7;
      tmp._drop_id_8 = in_drop_id_8;
      tmp._drop_id_9 = in_drop_id_9;
      tmp._drop_probability_1 = in_drop_probability_1;
      tmp._drop_probability_10 = in_drop_probability_10;
      tmp._drop_probability_11 = in_drop_probability_11;
      tmp._drop_probability_2 = in_drop_probability_2;
      tmp._drop_probability_3 = in_drop_probability_3;
      tmp._drop_probability_4 = in_drop_probability_4;
      tmp._drop_probability_5 = in_drop_probability_5;
      tmp._drop_probability_6 = in_drop_probability_6;
      tmp._drop_probability_7 = in_drop_probability_7;
      tmp._drop_probability_8 = in_drop_probability_8;
      tmp._drop_probability_9 = in_drop_probability_9;
      tmp._drop_type_1 = in_drop_type_1;
      tmp._drop_type_10 = in_drop_type_10;
      tmp._drop_type_11 = in_drop_type_11;
      tmp._drop_type_2 = in_drop_type_2;
      tmp._drop_type_3 = in_drop_type_3;
      tmp._drop_type_4 = in_drop_type_4;
      tmp._drop_type_5 = in_drop_type_5;
      tmp._drop_type_6 = in_drop_type_6;
      tmp._drop_type_7 = in_drop_type_7;
      tmp._drop_type_8 = in_drop_type_8;
      tmp._drop_type_9 = in_drop_type_9;
      tmp._id = in_id;
      tmp._money = in_money;
      tmp._reduce_act_level = in_reduce_act_level;
      tmp._shared_drop = in_shared_drop;
      tmp._task = in_task;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareClientDrop> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareClientDrop> _dataCaches = null;
    public static Dictionary<int, DeclareClientDrop> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataClientDrop");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataClientDrop = require 'Lua/Config/DataClientDrop'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataClientDrop");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareClientDrop>(143);
                     foreach (var item in dic)
                     {
                         DeclareClientDrop tmp = new DeclareClientDrop();
                       tmp.Distribution1 = item.Value[0];
                       tmp.Distribution10 = item.Value[1];
                       tmp.Distribution11 = item.Value[2];
                       tmp.Distribution2 = item.Value[3];
                       tmp.Distribution3 = item.Value[4];
                       tmp.Distribution4 = item.Value[5];
                       tmp.Distribution5 = item.Value[6];
                       tmp.Distribution6 = item.Value[7];
                       tmp.Distribution7 = item.Value[8];
                       tmp.Distribution8 = item.Value[9];
                       tmp.Distribution9 = item.Value[10];
                       tmp.DropId1 = CfgStringLua.Get(item.Value[11]);
                       tmp.DropId10 = CfgStringLua.Get(item.Value[12]);
                       tmp.DropId11 = CfgStringLua.Get(item.Value[13]);
                       tmp.DropId2 = CfgStringLua.Get(item.Value[14]);
                       tmp.DropId3 = CfgStringLua.Get(item.Value[15]);
                       tmp.DropId4 = CfgStringLua.Get(item.Value[16]);
                       tmp.DropId5 = CfgStringLua.Get(item.Value[17]);
                       tmp.DropId6 = CfgStringLua.Get(item.Value[18]);
                       tmp.DropId7 = CfgStringLua.Get(item.Value[19]);
                       tmp.DropId8 = CfgStringLua.Get(item.Value[20]);
                       tmp.DropId9 = CfgStringLua.Get(item.Value[21]);
                       tmp.DropProbability1 = item.Value[22];
                       tmp.DropProbability10 = item.Value[23];
                       tmp.DropProbability11 = item.Value[24];
                       tmp.DropProbability2 = item.Value[25];
                       tmp.DropProbability3 = item.Value[26];
                       tmp.DropProbability4 = item.Value[27];
                       tmp.DropProbability5 = item.Value[28];
                       tmp.DropProbability6 = item.Value[29];
                       tmp.DropProbability7 = item.Value[30];
                       tmp.DropProbability8 = item.Value[31];
                       tmp.DropProbability9 = item.Value[32];
                       tmp.DropType1 = item.Value[33];
                       tmp.DropType10 = item.Value[34];
                       tmp.DropType11 = item.Value[35];
                       tmp.DropType2 = item.Value[36];
                       tmp.DropType3 = item.Value[37];
                       tmp.DropType4 = item.Value[38];
                       tmp.DropType5 = item.Value[39];
                       tmp.DropType6 = item.Value[40];
                       tmp.DropType7 = item.Value[41];
                       tmp.DropType8 = item.Value[42];
                       tmp.DropType9 = item.Value[43];
                       tmp.Id = item.Value[44];
                       tmp.Money = CfgStringLua.Get(item.Value[45]);
                       tmp.ReduceActLevel = item.Value[46];
                       tmp.SharedDrop = item.Value[47];
                       tmp.Task = CfgStringLua.Get(item.Value[48]);
                       tmp.Type = item.Value[49];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"ClientDrop");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareClientDrop>(143);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"ClientDrop");
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
    public static DeclareClientDrop Get(int id)
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
    public static void Transform(Dictionary<int, DeclareClientDrop> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
