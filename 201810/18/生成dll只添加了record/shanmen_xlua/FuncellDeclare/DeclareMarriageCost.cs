//文件是自动生成,请勿手动修改.来自数据文件:marriage_cost
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareMarriageCost")]
  public class DeclareMarriageCost
  {
    #region //私有变量定义
    //赠送婚宴ID
    private int _dinner;
    //特效ID
    private int _effectID;
    //给的时装(@;@_@)
    private string _fashion;
    //结婚所需所需好友度
    private int _friends;
    //展示（1.时装(1_ 衣服_武器，没有配0)；2.坐骑）(hide)
    private string _mold;
    //名称hide
    private string _name;
    //消耗的货币(@_@)
    private string _need_type;
    //给的物品列表(@;@_@)
    private string _rewardItemList;
    //婚姻类型
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Dinner", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Dinner { get{ return _dinner; } set{ _dinner=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"EffectID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int EffectID { get{ return _effectID; } set{ _effectID=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Fashion", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Fashion { get{ return _fashion; } set{ _fashion=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Friends", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Friends { get{ return _friends; } set{ _friends=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Mold", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Mold { get{ return _mold; } set{ _mold=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"NeedType", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string NeedType { get{ return _need_type; } set{ _need_type=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"RewardItemList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string RewardItemList { get{ return _rewardItemList; } set{ _rewardItemList=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareMarriageCost Create( int in_dinner, int in_effectID, string in_fashion, int in_friends, string in_mold, string in_name, string in_need_type, string in_rewardItemList, int in_type )
    {
      DeclareMarriageCost tmp = new DeclareMarriageCost();
      tmp._dinner = in_dinner;
      tmp._effectID = in_effectID;
      tmp._fashion = in_fashion;
      tmp._friends = in_friends;
      tmp._mold = in_mold;
      tmp._name = in_name;
      tmp._need_type = in_need_type;
      tmp._rewardItemList = in_rewardItemList;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareMarriageCost> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareMarriageCost> _dataCaches = null;
    public static Dictionary<int, DeclareMarriageCost> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMarriageCost");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataMarriageCost = require 'Lua/Config/DataMarriageCost'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMarriageCost");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareMarriageCost>(3);
                     foreach (var item in dic)
                     {
                         DeclareMarriageCost tmp = new DeclareMarriageCost();
                       tmp.Dinner = item.Value[0];
                       tmp.EffectID = item.Value[1];
                       tmp.Fashion = CfgStringLua.Get(item.Value[2]);
                       tmp.Friends = item.Value[3];
                       tmp.Mold = CfgStringLua.Get(item.Value[4]);
                       tmp.Name = CfgStringLua.Get(item.Value[5]);
                       tmp.NeedType = CfgStringLua.Get(item.Value[6]);
                       tmp.RewardItemList = CfgStringLua.Get(item.Value[7]);
                       tmp.Type = item.Value[8];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"MarriageCost");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareMarriageCost>(3);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"MarriageCost");
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
    public static DeclareMarriageCost Get(int id)
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
    public static void Transform(Dictionary<int, DeclareMarriageCost> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
