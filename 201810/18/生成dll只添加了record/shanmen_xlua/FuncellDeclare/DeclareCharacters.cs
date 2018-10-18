//文件是自动生成,请勿手动修改.来自数据文件:characters
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareCharacters")]
  public class DeclareCharacters
  {
    #region //私有变量定义
    //参加初级婚宴奖励[@;@_@]
    private string _dinner_1;
    //参加中级婚宴奖励[@;@_@]
    private string _dinner_2;
    //参加高级婚宴奖励[@;@_@]
    private string _dinner_3;
    //错误答题奖励(@;@_@)correct_reward
    private string _error_reward;
    //升级所需经验(当前级别升下级的经验)
    private Int64 _exp;
    //双倍经验累积上限
    private Int64 _expPool;
    //等级
    private int _level;
    //推荐战斗力
    private int _power;
    //圣战之启经验奖励(9个，按照分数从低到高顺序填写）[@;@_@]
    private string _sZZQ_EXP_award;
    //圣战之启排行经验奖励（5个，按照排名从前到后的排名填写）[@;@_@]
    private string _sZZQ_EXP_rank_award;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Dinner1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Dinner1 { get{ return _dinner_1; } set{ _dinner_1=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Dinner2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Dinner2 { get{ return _dinner_2; } set{ _dinner_2=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Dinner3", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Dinner3 { get{ return _dinner_3; } set{ _dinner_3=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"ErrorReward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ErrorReward { get{ return _error_reward; } set{ _error_reward=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Int64 Exp { get{ return _exp; } set{ _exp=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"ExpPool", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Int64 ExpPool { get{ return _expPool; } set{ _expPool=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Power", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Power { get{ return _power; } set{ _power=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"SZZQEXPAward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SZZQEXPAward { get{ return _sZZQ_EXP_award; } set{ _sZZQ_EXP_award=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"SZZQEXPRankAward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SZZQEXPRankAward { get{ return _sZZQ_EXP_rank_award; } set{ _sZZQ_EXP_rank_award=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareCharacters Create( string in_dinner_1, string in_dinner_2, string in_dinner_3, string in_error_reward, Int64 in_exp, Int64 in_expPool, int in_level, int in_power, string in_sZZQ_EXP_award, string in_sZZQ_EXP_rank_award )
    {
      DeclareCharacters tmp = new DeclareCharacters();
      tmp._dinner_1 = in_dinner_1;
      tmp._dinner_2 = in_dinner_2;
      tmp._dinner_3 = in_dinner_3;
      tmp._error_reward = in_error_reward;
      tmp._exp = in_exp;
      tmp._expPool = in_expPool;
      tmp._level = in_level;
      tmp._power = in_power;
      tmp._sZZQ_EXP_award = in_sZZQ_EXP_award;
      tmp._sZZQ_EXP_rank_award = in_sZZQ_EXP_rank_award;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareCharacters> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareCharacters> _dataCaches = null;
    public static Dictionary<int, DeclareCharacters> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataCharacters");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataCharacters = require 'Lua/Config/DataCharacters'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataCharacters");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareCharacters>(800);
                     foreach (var item in dic)
                     {
                         DeclareCharacters tmp = new DeclareCharacters();
                       tmp.Dinner1 = CfgStringLua.Get(item.Value[0]);
                       tmp.Dinner2 = CfgStringLua.Get(item.Value[1]);
                       tmp.Dinner3 = CfgStringLua.Get(item.Value[2]);
                       tmp.ErrorReward = CfgStringLua.Get(item.Value[3]);
                       tmp.Exp = item.Value[4];
                       tmp.ExpPool = item.Value[5];
                       tmp.Level = item.Value[6];
                       tmp.Power = item.Value[7];
                       tmp.SZZQEXPAward = CfgStringLua.Get(item.Value[8]);
                       tmp.SZZQEXPRankAward = CfgStringLua.Get(item.Value[9]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Characters");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareCharacters>(800);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Characters");
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
    public static DeclareCharacters Get(int id)
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
    public static void Transform(Dictionary<int, DeclareCharacters> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
