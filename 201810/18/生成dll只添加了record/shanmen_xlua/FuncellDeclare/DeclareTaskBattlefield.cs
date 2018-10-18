//文件是自动生成,请勿手动修改.来自数据文件:task_battlefield
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareTaskBattlefield")]
  public class DeclareTaskBattlefield
  {
    #region //私有变量定义
    //0单场1累加
    private int _calculate;
    //阵营
    private int _camp;
    //是否可以寻路（0否.1是）（hide）
    private int _canPathfinding;
    //任务描述 hide
    private string _describe;
    //刷星消耗(@_@)
    private string _fillStarcost;
    //任务目标(@_@)
    private string _goal;
    //目标地图id
    private int _goal_map;
    //组ID
    private int _groupID;
    //任务ID
    private int _id;
    //等级max
    private int _level_max;
    //等级min
    private int _level_min;
    //目标地图id(@_@)
    private string _map;
    //任务名称
    private string _name;
    //数量(@_@)
    private string _num;
    //打开界面UI
    private int _openUI;
    //1星任务奖励(奖励_数量;奖励_数量）[@;@_@]
    private string _rewards_1;
    //2星任务奖励(奖励_数量;奖励_数量）[@;@_@]
    private string _rewards_2;
    //3星任务奖励(奖励_数量;奖励_数量）[@;@_@]
    private string _rewards_3;
    //4星任务奖励(奖励_数量;奖励_数量）[@;@_@]
    private string _rewards_4;
    //5星任务奖励(奖励_数量;奖励_数量）[@;@_@]
    private string _rewards_5;
    //星级概率（1星概率_2星概率_3星概率…..）(@_@)
    private string _star;
    //任务类型（0.对话;1.杀怪;2.收集;3.等级达到X;4.使用道具;5.采集;11.击败玩家;12.战场胜利;13.攻击水晶塔;14.保卫水晶塔;15.助攻;16.分数达到多少;17.获得几次最佳）
    private int _task_type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Calculate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Calculate { get{ return _calculate; } set{ _calculate=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Camp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Camp { get{ return _camp; } set{ _camp=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"CanPathfinding", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanPathfinding { get{ return _canPathfinding; } set{ _canPathfinding=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Describe", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Describe { get{ return _describe; } set{ _describe=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"FillStarcost", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string FillStarcost { get{ return _fillStarcost; } set{ _fillStarcost=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Goal", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Goal { get{ return _goal; } set{ _goal=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"GoalMap", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int GoalMap { get{ return _goal_map; } set{ _goal_map=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"GroupID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int GroupID { get{ return _groupID; } set{ _groupID=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"LevelMax", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int LevelMax { get{ return _level_max; } set{ _level_max=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"LevelMin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int LevelMin { get{ return _level_min; } set{ _level_min=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"Map", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Map { get{ return _map; } set{ _map=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"Num", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Num { get{ return _num; } set{ _num=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"OpenUI", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OpenUI { get{ return _openUI; } set{ _openUI=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"Rewards1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Rewards1 { get{ return _rewards_1; } set{ _rewards_1=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"Rewards2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Rewards2 { get{ return _rewards_2; } set{ _rewards_2=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"Rewards3", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Rewards3 { get{ return _rewards_3; } set{ _rewards_3=value; } }
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"Rewards4", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Rewards4 { get{ return _rewards_4; } set{ _rewards_4=value; } }
    [global::ProtoBuf.ProtoMember(20, IsRequired = true, Name=@"Rewards5", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Rewards5 { get{ return _rewards_5; } set{ _rewards_5=value; } }
    [global::ProtoBuf.ProtoMember(21, IsRequired = true, Name=@"Star", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Star { get{ return _star; } set{ _star=value; } }
    [global::ProtoBuf.ProtoMember(22, IsRequired = true, Name=@"TaskType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TaskType { get{ return _task_type; } set{ _task_type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareTaskBattlefield Create( int in_calculate, int in_camp, int in_canPathfinding, string in_describe, string in_fillStarcost, string in_goal, int in_goal_map, int in_groupID, int in_id, int in_level_max, int in_level_min, string in_map, string in_name, string in_num, int in_openUI, string in_rewards_1, string in_rewards_2, string in_rewards_3, string in_rewards_4, string in_rewards_5, string in_star, int in_task_type )
    {
      DeclareTaskBattlefield tmp = new DeclareTaskBattlefield();
      tmp._calculate = in_calculate;
      tmp._camp = in_camp;
      tmp._canPathfinding = in_canPathfinding;
      tmp._describe = in_describe;
      tmp._fillStarcost = in_fillStarcost;
      tmp._goal = in_goal;
      tmp._goal_map = in_goal_map;
      tmp._groupID = in_groupID;
      tmp._id = in_id;
      tmp._level_max = in_level_max;
      tmp._level_min = in_level_min;
      tmp._map = in_map;
      tmp._name = in_name;
      tmp._num = in_num;
      tmp._openUI = in_openUI;
      tmp._rewards_1 = in_rewards_1;
      tmp._rewards_2 = in_rewards_2;
      tmp._rewards_3 = in_rewards_3;
      tmp._rewards_4 = in_rewards_4;
      tmp._rewards_5 = in_rewards_5;
      tmp._star = in_star;
      tmp._task_type = in_task_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareTaskBattlefield> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareTaskBattlefield> _dataCaches = null;
    public static Dictionary<int, DeclareTaskBattlefield> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTaskBattlefield");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataTaskBattlefield = require 'Lua/Config/DataTaskBattlefield'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTaskBattlefield");                  }

                 if (dic != null)
                 {
                              _dataCaches = new Dictionary<int, DeclareTaskBattlefield>();
                     foreach (var item in dic)
                     {
                         DeclareTaskBattlefield tmp = new DeclareTaskBattlefield();
                       tmp.Calculate = item.Value[0];
                       tmp.Camp = item.Value[1];
                       tmp.CanPathfinding = item.Value[2];
                       tmp.Describe = CfgStringLua.Get(item.Value[3]);
                       tmp.FillStarcost = CfgStringLua.Get(item.Value[4]);
                       tmp.Goal = CfgStringLua.Get(item.Value[5]);
                       tmp.GoalMap = item.Value[6];
                       tmp.GroupID = item.Value[7];
                       tmp.Id = item.Value[8];
                       tmp.LevelMax = item.Value[9];
                       tmp.LevelMin = item.Value[10];
                       tmp.Map = CfgStringLua.Get(item.Value[11]);
                       tmp.Name = CfgStringLua.Get(item.Value[12]);
                       tmp.Num = CfgStringLua.Get(item.Value[13]);
                       tmp.OpenUI = item.Value[14];
                       tmp.Rewards1 = CfgStringLua.Get(item.Value[15]);
                       tmp.Rewards2 = CfgStringLua.Get(item.Value[16]);
                       tmp.Rewards3 = CfgStringLua.Get(item.Value[17]);
                       tmp.Rewards4 = CfgStringLua.Get(item.Value[18]);
                       tmp.Rewards5 = CfgStringLua.Get(item.Value[19]);
                       tmp.Star = CfgStringLua.Get(item.Value[20]);
                       tmp.TaskType = item.Value[21];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"TaskBattlefield");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareTaskBattlefield>();
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"TaskBattlefield");
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
    public static DeclareTaskBattlefield Get(int id)
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
    public static void Transform(Dictionary<int, DeclareTaskBattlefield> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
