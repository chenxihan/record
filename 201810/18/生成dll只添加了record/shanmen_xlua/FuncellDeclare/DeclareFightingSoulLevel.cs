//文件是自动生成,请勿手动修改.来自数据文件:FightingSoulLevel
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareFightingSoulLevel")]
  public class DeclareFightingSoulLevel
  {
    #region //私有变量定义
    //等级
    private int _id;
    //升级需要经验(白色品质升下一级所需经验_绿色品质_蓝色品质…金色品质升下一级所需经验)(@_@)
    private string _need_exp;
    //需要玩家等级
    private int _need_player_level;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"NeedExp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string NeedExp { get{ return _need_exp; } set{ _need_exp=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"NeedPlayerLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NeedPlayerLevel { get{ return _need_player_level; } set{ _need_player_level=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareFightingSoulLevel Create( int in_id, string in_need_exp, int in_need_player_level )
    {
      DeclareFightingSoulLevel tmp = new DeclareFightingSoulLevel();
      tmp._id = in_id;
      tmp._need_exp = in_need_exp;
      tmp._need_player_level = in_need_player_level;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareFightingSoulLevel> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareFightingSoulLevel> _dataCaches = null;
    public static Dictionary<int, DeclareFightingSoulLevel> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataFightingSoulLevel");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataFightingSoulLevel = require 'Lua/Config/DataFightingSoulLevel'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataFightingSoulLevel");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareFightingSoulLevel>(250);
                     foreach (var item in dic)
                     {
                         DeclareFightingSoulLevel tmp = new DeclareFightingSoulLevel();
                       tmp.Id = item.Value[0];
                       tmp.NeedExp = CfgStringLua.Get(item.Value[1]);
                       tmp.NeedPlayerLevel = item.Value[2];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"FightingSoulLevel");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareFightingSoulLevel>(250);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"FightingSoulLevel");
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
    public static DeclareFightingSoulLevel Get(int id)
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
    public static void Transform(Dictionary<int, DeclareFightingSoulLevel> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
