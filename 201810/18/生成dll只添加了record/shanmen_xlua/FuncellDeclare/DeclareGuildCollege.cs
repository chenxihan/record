//文件是自动生成,请勿手动修改.来自数据文件:guild_college
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareGuildCollege")]
  public class DeclareGuildCollege
  {
    #region //私有变量定义
    //技能ICON
    private int _iCON;
    //技能ID
    private int _id;
    //学习消耗（货币类型_数量；货币类型_数量）(@;@_@)
    private string _learning_consumption;
    //等级
    private int _level;
    //研究需要的建筑等级(@;@_@)
    private string _needLevel;
    //下一级技能ID
    private int _next_level_ID;
    //研究消耗（货币类型_数量；货币类型_数量）
    private int _research_consumption;
    //研究时间（分钟）
    private int _research_time;
    //位置
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ICON", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ICON { get{ return _iCON; } set{ _iCON=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"LearningConsumption", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string LearningConsumption { get{ return _learning_consumption; } set{ _learning_consumption=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"NeedLevel", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string NeedLevel { get{ return _needLevel; } set{ _needLevel=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"NextLevelID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NextLevelID { get{ return _next_level_ID; } set{ _next_level_ID=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"ResearchConsumption", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ResearchConsumption { get{ return _research_consumption; } set{ _research_consumption=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"ResearchTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ResearchTime { get{ return _research_time; } set{ _research_time=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareGuildCollege Create( int in_iCON, int in_id, string in_learning_consumption, int in_level, string in_needLevel, int in_next_level_ID, int in_research_consumption, int in_research_time, int in_type )
    {
      DeclareGuildCollege tmp = new DeclareGuildCollege();
      tmp._iCON = in_iCON;
      tmp._id = in_id;
      tmp._learning_consumption = in_learning_consumption;
      tmp._level = in_level;
      tmp._needLevel = in_needLevel;
      tmp._next_level_ID = in_next_level_ID;
      tmp._research_consumption = in_research_consumption;
      tmp._research_time = in_research_time;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareGuildCollege> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareGuildCollege> _dataCaches = null;
    public static Dictionary<int, DeclareGuildCollege> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGuildCollege");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataGuildCollege = require 'Lua/Config/DataGuildCollege'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGuildCollege");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareGuildCollege>(505);
                     foreach (var item in dic)
                     {
                         DeclareGuildCollege tmp = new DeclareGuildCollege();
                       tmp.ICON = item.Value[0];
                       tmp.Id = item.Value[1];
                       tmp.LearningConsumption = CfgStringLua.Get(item.Value[2]);
                       tmp.Level = item.Value[3];
                       tmp.NeedLevel = CfgStringLua.Get(item.Value[4]);
                       tmp.NextLevelID = item.Value[5];
                       tmp.ResearchConsumption = item.Value[6];
                       tmp.ResearchTime = item.Value[7];
                       tmp.Type = item.Value[8];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"GuildCollege");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareGuildCollege>(505);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"GuildCollege");
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
    public static DeclareGuildCollege Get(int id)
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
    public static void Transform(Dictionary<int, DeclareGuildCollege> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
