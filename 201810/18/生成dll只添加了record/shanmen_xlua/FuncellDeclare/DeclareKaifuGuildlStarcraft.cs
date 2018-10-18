//文件是自动生成,请勿手动修改.来自数据文件:kaifu_guildl_Starcraft
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareKaifuGuildlStarcraft")]
  public class DeclareKaifuGuildlStarcraft
  {
    #region //私有变量定义
    //ID
    private int _iD;
    //描述(hide)
    private string _name;
    //职位（1王者神殿会长，2王者神殿其他成员，3其他参与公会战成员）
    private int _position;
    //领取奖励（@;@_@）
    private string _reward;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID { get{ return _iD; } set{ _iD=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Position", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Position { get{ return _position; } set{ _position=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Reward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Reward { get{ return _reward; } set{ _reward=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareKaifuGuildlStarcraft Create( int in_iD, string in_name, int in_position, string in_reward )
    {
      DeclareKaifuGuildlStarcraft tmp = new DeclareKaifuGuildlStarcraft();
      tmp._iD = in_iD;
      tmp._name = in_name;
      tmp._position = in_position;
      tmp._reward = in_reward;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareKaifuGuildlStarcraft> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareKaifuGuildlStarcraft> _dataCaches = null;
    public static Dictionary<int, DeclareKaifuGuildlStarcraft> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataKaifuGuildlStarcraft");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataKaifuGuildlStarcraft = require 'Lua/Config/DataKaifuGuildlStarcraft'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataKaifuGuildlStarcraft");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareKaifuGuildlStarcraft>(3);
                     foreach (var item in dic)
                     {
                         DeclareKaifuGuildlStarcraft tmp = new DeclareKaifuGuildlStarcraft();
                       tmp.ID = item.Value[0];
                       tmp.Name = CfgStringLua.Get(item.Value[1]);
                       tmp.Position = item.Value[2];
                       tmp.Reward = CfgStringLua.Get(item.Value[3]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"KaifuGuildlStarcraft");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareKaifuGuildlStarcraft>(3);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"KaifuGuildlStarcraft");
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
    public static DeclareKaifuGuildlStarcraft Get(int id)
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
    public static void Transform(Dictionary<int, DeclareKaifuGuildlStarcraft> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
