//文件是自动生成,请勿手动修改.来自数据文件:guild_monster_Intrusion
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareGuildMonsterIntrusion")]
  public class DeclareGuildMonsterIntrusion
  {
    #region //私有变量定义
    //第八波小怪(怪物id_数量)(@_@)
    private string _eight_wave;
    //第八波BOSS(怪物id_数量)(@_@)
    private string _eight_wave_boss;
    //第一波小怪(怪物id_数量)(@_@)
    private string _first_wave;
    //第一波BOSS(怪物id_数量)(@_@)
    private string _first_wave_boss;
    //第五波小怪(怪物id_数量)(@_@)
    private string _five_wave;
    //第五波BOSS(怪物id_数量)(@_@)
    private string _five_wave_boss;
    //第四波小怪(怪物id_数量)(@_@)
    private string _four_wave;
    //第四波BOSS(怪物id_数量)(@_@)
    private string _four_wave_boss;
    //守护NPC（阵营1;阵营2）(@_@)
    private string _guard_npc;
    //守护NPC位置(@;@_@)
    private string _guard_pos;
    //ID
    private int _iD;
    //等级段（最小等级_最大等级）(@_@)
    private string _level;
    //怪物刷新位置(@;@_@)
    private string _monster_pos;
    //第七波小怪(怪物id_数量)(@_@)
    private string _seven_wave;
    //第七波BOSS(怪物id_数量)(@_@)
    private string _seven_wave_boss;
    //第六波小怪(怪物id_数量)(@_@)
    private string _six_wave;
    //第六波BOSS(怪物id_数量)(@_@)
    private string _six_wave_boss;
    //第三波小怪(怪物id_数量)(@_@)
    private string _three_wave;
    //第三波BOSS(怪物id_数量)(@_@)
    private string _three_wave_boss;
    //传送门NPCID
    private int _transmission_gate;
    //第二波小怪(怪物id_数量)(@_@)
    private string _two_wave;
    //第二波BOSS(怪物id_数量)(@_@)
    private string _two_wave_boss;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"EightWave", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string EightWave { get{ return _eight_wave; } set{ _eight_wave=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"EightWaveBoss", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string EightWaveBoss { get{ return _eight_wave_boss; } set{ _eight_wave_boss=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"FirstWave", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string FirstWave { get{ return _first_wave; } set{ _first_wave=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"FirstWaveBoss", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string FirstWaveBoss { get{ return _first_wave_boss; } set{ _first_wave_boss=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"FiveWave", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string FiveWave { get{ return _five_wave; } set{ _five_wave=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"FiveWaveBoss", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string FiveWaveBoss { get{ return _five_wave_boss; } set{ _five_wave_boss=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"FourWave", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string FourWave { get{ return _four_wave; } set{ _four_wave=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"FourWaveBoss", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string FourWaveBoss { get{ return _four_wave_boss; } set{ _four_wave_boss=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"GuardNpc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string GuardNpc { get{ return _guard_npc; } set{ _guard_npc=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"GuardPos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string GuardPos { get{ return _guard_pos; } set{ _guard_pos=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID { get{ return _iD; } set{ _iD=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"MonsterPos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string MonsterPos { get{ return _monster_pos; } set{ _monster_pos=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"SevenWave", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SevenWave { get{ return _seven_wave; } set{ _seven_wave=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"SevenWaveBoss", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SevenWaveBoss { get{ return _seven_wave_boss; } set{ _seven_wave_boss=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"SixWave", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SixWave { get{ return _six_wave; } set{ _six_wave=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"SixWaveBoss", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SixWaveBoss { get{ return _six_wave_boss; } set{ _six_wave_boss=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"ThreeWave", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ThreeWave { get{ return _three_wave; } set{ _three_wave=value; } }
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"ThreeWaveBoss", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ThreeWaveBoss { get{ return _three_wave_boss; } set{ _three_wave_boss=value; } }
    [global::ProtoBuf.ProtoMember(20, IsRequired = true, Name=@"TransmissionGate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TransmissionGate { get{ return _transmission_gate; } set{ _transmission_gate=value; } }
    [global::ProtoBuf.ProtoMember(21, IsRequired = true, Name=@"TwoWave", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TwoWave { get{ return _two_wave; } set{ _two_wave=value; } }
    [global::ProtoBuf.ProtoMember(22, IsRequired = true, Name=@"TwoWaveBoss", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TwoWaveBoss { get{ return _two_wave_boss; } set{ _two_wave_boss=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareGuildMonsterIntrusion Create( string in_eight_wave, string in_eight_wave_boss, string in_first_wave, string in_first_wave_boss, string in_five_wave, string in_five_wave_boss, string in_four_wave, string in_four_wave_boss, string in_guard_npc, string in_guard_pos, int in_iD, string in_level, string in_monster_pos, string in_seven_wave, string in_seven_wave_boss, string in_six_wave, string in_six_wave_boss, string in_three_wave, string in_three_wave_boss, int in_transmission_gate, string in_two_wave, string in_two_wave_boss )
    {
      DeclareGuildMonsterIntrusion tmp = new DeclareGuildMonsterIntrusion();
      tmp._eight_wave = in_eight_wave;
      tmp._eight_wave_boss = in_eight_wave_boss;
      tmp._first_wave = in_first_wave;
      tmp._first_wave_boss = in_first_wave_boss;
      tmp._five_wave = in_five_wave;
      tmp._five_wave_boss = in_five_wave_boss;
      tmp._four_wave = in_four_wave;
      tmp._four_wave_boss = in_four_wave_boss;
      tmp._guard_npc = in_guard_npc;
      tmp._guard_pos = in_guard_pos;
      tmp._iD = in_iD;
      tmp._level = in_level;
      tmp._monster_pos = in_monster_pos;
      tmp._seven_wave = in_seven_wave;
      tmp._seven_wave_boss = in_seven_wave_boss;
      tmp._six_wave = in_six_wave;
      tmp._six_wave_boss = in_six_wave_boss;
      tmp._three_wave = in_three_wave;
      tmp._three_wave_boss = in_three_wave_boss;
      tmp._transmission_gate = in_transmission_gate;
      tmp._two_wave = in_two_wave;
      tmp._two_wave_boss = in_two_wave_boss;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareGuildMonsterIntrusion> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareGuildMonsterIntrusion> _dataCaches = null;
    public static Dictionary<int, DeclareGuildMonsterIntrusion> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGuildMonsterIntrusion");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataGuildMonsterIntrusion = require 'Lua/Config/DataGuildMonsterIntrusion'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGuildMonsterIntrusion");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareGuildMonsterIntrusion>(21);
                     foreach (var item in dic)
                     {
                         DeclareGuildMonsterIntrusion tmp = new DeclareGuildMonsterIntrusion();
                       tmp.EightWave = CfgStringLua.Get(item.Value[0]);
                       tmp.EightWaveBoss = CfgStringLua.Get(item.Value[1]);
                       tmp.FirstWave = CfgStringLua.Get(item.Value[2]);
                       tmp.FirstWaveBoss = CfgStringLua.Get(item.Value[3]);
                       tmp.FiveWave = CfgStringLua.Get(item.Value[4]);
                       tmp.FiveWaveBoss = CfgStringLua.Get(item.Value[5]);
                       tmp.FourWave = CfgStringLua.Get(item.Value[6]);
                       tmp.FourWaveBoss = CfgStringLua.Get(item.Value[7]);
                       tmp.GuardNpc = CfgStringLua.Get(item.Value[8]);
                       tmp.GuardPos = CfgStringLua.Get(item.Value[9]);
                       tmp.ID = item.Value[10];
                       tmp.Level = CfgStringLua.Get(item.Value[11]);
                       tmp.MonsterPos = CfgStringLua.Get(item.Value[12]);
                       tmp.SevenWave = CfgStringLua.Get(item.Value[13]);
                       tmp.SevenWaveBoss = CfgStringLua.Get(item.Value[14]);
                       tmp.SixWave = CfgStringLua.Get(item.Value[15]);
                       tmp.SixWaveBoss = CfgStringLua.Get(item.Value[16]);
                       tmp.ThreeWave = CfgStringLua.Get(item.Value[17]);
                       tmp.ThreeWaveBoss = CfgStringLua.Get(item.Value[18]);
                       tmp.TransmissionGate = item.Value[19];
                       tmp.TwoWave = CfgStringLua.Get(item.Value[20]);
                       tmp.TwoWaveBoss = CfgStringLua.Get(item.Value[21]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"GuildMonsterIntrusion");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareGuildMonsterIntrusion>(21);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"GuildMonsterIntrusion");
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
    public static DeclareGuildMonsterIntrusion Get(int id)
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
    public static void Transform(Dictionary<int, DeclareGuildMonsterIntrusion> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
