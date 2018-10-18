//文件是自动生成,请勿手动修改.来自数据文件:Equipclone_reward
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareEquipcloneReward")]
  public class DeclareEquipcloneReward
  {
    #region //私有变量定义
    //开启的装备铸灵的位置
    private int _equip_position;
    //进入最低等级
    private int _level;
    //刷新的怪物ID
    private int _monster;
    //副本的名字
    private string _name;
    //波次
    private int _num;
    //通关奖励(@;@_@)
    private string _reward;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"EquipPosition", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int EquipPosition { get{ return _equip_position; } set{ _equip_position=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Monster", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Monster { get{ return _monster; } set{ _monster=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Num { get{ return _num; } set{ _num=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Reward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Reward { get{ return _reward; } set{ _reward=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareEquipcloneReward Create( int in_equip_position, int in_level, int in_monster, string in_name, int in_num, string in_reward )
    {
      DeclareEquipcloneReward tmp = new DeclareEquipcloneReward();
      tmp._equip_position = in_equip_position;
      tmp._level = in_level;
      tmp._monster = in_monster;
      tmp._name = in_name;
      tmp._num = in_num;
      tmp._reward = in_reward;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareEquipcloneReward> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareEquipcloneReward> _dataCaches = null;
    public static Dictionary<int, DeclareEquipcloneReward> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataEquipcloneReward");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataEquipcloneReward = require 'Lua/Config/DataEquipcloneReward'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataEquipcloneReward");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareEquipcloneReward>(100);
                     foreach (var item in dic)
                     {
                         DeclareEquipcloneReward tmp = new DeclareEquipcloneReward();
                       tmp.EquipPosition = item.Value[0];
                       tmp.Level = item.Value[1];
                       tmp.Monster = item.Value[2];
                       tmp.Name = CfgStringLua.Get(item.Value[3]);
                       tmp.Num = item.Value[4];
                       tmp.Reward = CfgStringLua.Get(item.Value[5]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"EquipcloneReward");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareEquipcloneReward>(100);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"EquipcloneReward");
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
    public static DeclareEquipcloneReward Get(int id)
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
    public static void Transform(Dictionary<int, DeclareEquipcloneReward> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
