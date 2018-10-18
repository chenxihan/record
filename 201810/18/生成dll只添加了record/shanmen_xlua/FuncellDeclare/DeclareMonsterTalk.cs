//文件是自动生成,请勿手动修改.来自数据文件:MonsterTalk
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareMonsterTalk")]
  public class DeclareMonsterTalk
  {
    #region //私有变量定义
    //ID
    private int _id;
    //是否显示怪物名字
    private int _show_monster_name;
    //是否显示玩家名字
    private int _show_player_name;
    //显示时间（单位毫秒）
    private int _show_time;
    //说话内容
    private string _talk;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"ShowMonsterName", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ShowMonsterName { get{ return _show_monster_name; } set{ _show_monster_name=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"ShowPlayerName", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ShowPlayerName { get{ return _show_player_name; } set{ _show_player_name=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"ShowTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ShowTime { get{ return _show_time; } set{ _show_time=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Talk", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Talk { get{ return _talk; } set{ _talk=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareMonsterTalk Create( int in_id, int in_show_monster_name, int in_show_player_name, int in_show_time, string in_talk )
    {
      DeclareMonsterTalk tmp = new DeclareMonsterTalk();
      tmp._id = in_id;
      tmp._show_monster_name = in_show_monster_name;
      tmp._show_player_name = in_show_player_name;
      tmp._show_time = in_show_time;
      tmp._talk = in_talk;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareMonsterTalk> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareMonsterTalk> _dataCaches = null;
    public static Dictionary<int, DeclareMonsterTalk> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMonsterTalk");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataMonsterTalk = require 'Lua/Config/DataMonsterTalk'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMonsterTalk");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareMonsterTalk>(86);
                     foreach (var item in dic)
                     {
                         DeclareMonsterTalk tmp = new DeclareMonsterTalk();
                       tmp.Id = item.Value[0];
                       tmp.ShowMonsterName = item.Value[1];
                       tmp.ShowPlayerName = item.Value[2];
                       tmp.ShowTime = item.Value[3];
                       tmp.Talk = CfgStringLua.Get(item.Value[4]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"MonsterTalk");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareMonsterTalk>(86);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"MonsterTalk");
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
    public static DeclareMonsterTalk Get(int id)
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
    public static void Transform(Dictionary<int, DeclareMonsterTalk> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
