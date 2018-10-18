//文件是自动生成,请勿手动修改.来自数据文件:horse_mythical_gift
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareHorseMythicalGift")]
  public class DeclareHorseMythicalGift
  {
    #region //私有变量定义
    //奖励库id
    private int _id;
    //抽中概率（万分比）
    private int _probability;
    //是否公告（0不公告；1公告）
    private int _radio;
    //奖励内容（ID_数量_是否绑定（0不绑）(@_@)
    private string _reward;
    //所属抽奖（1,必得物品；2,随机开启的物品）
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Probability", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Probability { get{ return _probability; } set{ _probability=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Radio", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Radio { get{ return _radio; } set{ _radio=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Reward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Reward { get{ return _reward; } set{ _reward=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareHorseMythicalGift Create( int in_id, int in_probability, int in_radio, string in_reward, int in_type )
    {
      DeclareHorseMythicalGift tmp = new DeclareHorseMythicalGift();
      tmp._id = in_id;
      tmp._probability = in_probability;
      tmp._radio = in_radio;
      tmp._reward = in_reward;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareHorseMythicalGift> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareHorseMythicalGift> _dataCaches = null;
    public static Dictionary<int, DeclareHorseMythicalGift> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataHorseMythicalGift");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataHorseMythicalGift = require 'Lua/Config/DataHorseMythicalGift'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataHorseMythicalGift");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareHorseMythicalGift>(10);
                     foreach (var item in dic)
                     {
                         DeclareHorseMythicalGift tmp = new DeclareHorseMythicalGift();
                       tmp.Id = item.Value[0];
                       tmp.Probability = item.Value[1];
                       tmp.Radio = item.Value[2];
                       tmp.Reward = CfgStringLua.Get(item.Value[3]);
                       tmp.Type = item.Value[4];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"HorseMythicalGift");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareHorseMythicalGift>(10);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"HorseMythicalGift");
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
    public static DeclareHorseMythicalGift Get(int id)
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
    public static void Transform(Dictionary<int, DeclareHorseMythicalGift> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
