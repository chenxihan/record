//文件是自动生成,请勿手动修改.来自数据文件:guild_up
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareGuildUp")]
  public class DeclareGuildUp
  {
    #region //私有变量定义
    //公会基地对应加入玩家数量上限
    private int _base_num;
    //指挥人数
    private int _command_num;
    //功能描述hide
    private string _functional_describe;
    //key=type*10000+level
    private int _id;
    //建筑等级
    private int _level;
    //升级所需建设度
    private int _needNum;
    //升级所需其他建筑相关(@;@_@)
    private string _other;
    //答题基数（数量）
    private int _question_reward;
    //图片资源（hide）
    private string _resources;
    //建筑类型（1基地，2商店，3学院，4练功房）
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"BaseNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BaseNum { get{ return _base_num; } set{ _base_num=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"CommandNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CommandNum { get{ return _command_num; } set{ _command_num=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"FunctionalDescribe", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string FunctionalDescribe { get{ return _functional_describe; } set{ _functional_describe=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"NeedNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NeedNum { get{ return _needNum; } set{ _needNum=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Other", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Other { get{ return _other; } set{ _other=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"QuestionReward", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int QuestionReward { get{ return _question_reward; } set{ _question_reward=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Resources", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Resources { get{ return _resources; } set{ _resources=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareGuildUp Create( int in_base_num, int in_command_num, string in_functional_describe, int in_id, int in_level, int in_needNum, string in_other, int in_question_reward, string in_resources, int in_type )
    {
      DeclareGuildUp tmp = new DeclareGuildUp();
      tmp._base_num = in_base_num;
      tmp._command_num = in_command_num;
      tmp._functional_describe = in_functional_describe;
      tmp._id = in_id;
      tmp._level = in_level;
      tmp._needNum = in_needNum;
      tmp._other = in_other;
      tmp._question_reward = in_question_reward;
      tmp._resources = in_resources;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareGuildUp> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareGuildUp> _dataCaches = null;
    public static Dictionary<int, DeclareGuildUp> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGuildUp");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataGuildUp = require 'Lua/Config/DataGuildUp'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGuildUp");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareGuildUp>(40);
                     foreach (var item in dic)
                     {
                         DeclareGuildUp tmp = new DeclareGuildUp();
                       tmp.BaseNum = item.Value[0];
                       tmp.CommandNum = item.Value[1];
                       tmp.FunctionalDescribe = CfgStringLua.Get(item.Value[2]);
                       tmp.Id = item.Value[3];
                       tmp.Level = item.Value[4];
                       tmp.NeedNum = item.Value[5];
                       tmp.Other = CfgStringLua.Get(item.Value[6]);
                       tmp.QuestionReward = item.Value[7];
                       tmp.Resources = CfgStringLua.Get(item.Value[8]);
                       tmp.Type = item.Value[9];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"GuildUp");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareGuildUp>(40);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"GuildUp");
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
    public static DeclareGuildUp Get(int id)
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
    public static void Transform(Dictionary<int, DeclareGuildUp> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
