//文件是自动生成,请勿手动修改.来自数据文件:kaifu_thousand_people_up
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareKaifuThousandPeopleUp")]
  public class DeclareKaifuThousandPeopleUp
  {
    #region //私有变量定义
    //条件值,枚举_值(@;@_@)
    private string _conditions_value;
    //ID
    private int _iD;
    //描述(hide)
    private string _name;
    //可领取数量
    private int _num;
    //领取奖励(职业ID_道具ID_数量_是否绑定)(@;@_@)
    private string _reward;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ConditionsValue", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ConditionsValue { get{ return _conditions_value; } set{ _conditions_value=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID { get{ return _iD; } set{ _iD=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Num { get{ return _num; } set{ _num=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Reward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Reward { get{ return _reward; } set{ _reward=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareKaifuThousandPeopleUp Create( string in_conditions_value, int in_iD, string in_name, int in_num, string in_reward )
    {
      DeclareKaifuThousandPeopleUp tmp = new DeclareKaifuThousandPeopleUp();
      tmp._conditions_value = in_conditions_value;
      tmp._iD = in_iD;
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
    public delegate void OnFillDataHandler(Dictionary<int, DeclareKaifuThousandPeopleUp> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareKaifuThousandPeopleUp> _dataCaches = null;
    public static Dictionary<int, DeclareKaifuThousandPeopleUp> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataKaifuThousandPeopleUp");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataKaifuThousandPeopleUp = require 'Lua/Config/DataKaifuThousandPeopleUp'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataKaifuThousandPeopleUp");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareKaifuThousandPeopleUp>(6);
                     foreach (var item in dic)
                     {
                         DeclareKaifuThousandPeopleUp tmp = new DeclareKaifuThousandPeopleUp();
                       tmp.ConditionsValue = CfgStringLua.Get(item.Value[0]);
                       tmp.ID = item.Value[1];
                       tmp.Name = CfgStringLua.Get(item.Value[2]);
                       tmp.Num = item.Value[3];
                       tmp.Reward = CfgStringLua.Get(item.Value[4]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"KaifuThousandPeopleUp");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareKaifuThousandPeopleUp>(6);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"KaifuThousandPeopleUp");
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
    public static DeclareKaifuThousandPeopleUp Get(int id)
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
    public static void Transform(Dictionary<int, DeclareKaifuThousandPeopleUp> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
