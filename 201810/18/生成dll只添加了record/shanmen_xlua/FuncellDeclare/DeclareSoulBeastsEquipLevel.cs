//文件是自动生成,请勿手动修改.来自数据文件:SoulBeastsEquipLevel
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareSoulBeastsEquipLevel")]
  public class DeclareSoulBeastsEquipLevel
  {
    #region //私有变量定义
    //强化本级属性(@;@_@)此处为装备本级属性，而不是成长属性，界面显示成长需要下一级减去当前级
    private string _att;
    //ID
    private int _id;
    //等级
    private int _level;
    //本级升级所需经验
    private int _needExp;
    //装备部位(1头盔、2项圈、3铠甲、4利爪、5羽翼)
    private int _part;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Att", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Att { get{ return _att; } set{ _att=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"NeedExp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NeedExp { get{ return _needExp; } set{ _needExp=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Part", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Part { get{ return _part; } set{ _part=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareSoulBeastsEquipLevel Create( string in_att, int in_id, int in_level, int in_needExp, int in_part )
    {
      DeclareSoulBeastsEquipLevel tmp = new DeclareSoulBeastsEquipLevel();
      tmp._att = in_att;
      tmp._id = in_id;
      tmp._level = in_level;
      tmp._needExp = in_needExp;
      tmp._part = in_part;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareSoulBeastsEquipLevel> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareSoulBeastsEquipLevel> _dataCaches = null;
    public static Dictionary<int, DeclareSoulBeastsEquipLevel> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataSoulBeastsEquipLevel");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataSoulBeastsEquipLevel = require 'Lua/Config/DataSoulBeastsEquipLevel'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataSoulBeastsEquipLevel");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareSoulBeastsEquipLevel>(505);
                     foreach (var item in dic)
                     {
                         DeclareSoulBeastsEquipLevel tmp = new DeclareSoulBeastsEquipLevel();
                       tmp.Att = CfgStringLua.Get(item.Value[0]);
                       tmp.Id = item.Value[1];
                       tmp.Level = item.Value[2];
                       tmp.NeedExp = item.Value[3];
                       tmp.Part = item.Value[4];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"SoulBeastsEquipLevel");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareSoulBeastsEquipLevel>(505);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"SoulBeastsEquipLevel");
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
    public static DeclareSoulBeastsEquipLevel Get(int id)
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
    public static void Transform(Dictionary<int, DeclareSoulBeastsEquipLevel> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
