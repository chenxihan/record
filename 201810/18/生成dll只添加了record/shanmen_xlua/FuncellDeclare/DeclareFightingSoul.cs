//文件是自动生成,请勿手动修改.来自数据文件:FightingSoul
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareFightingSoul")]
  public class DeclareFightingSoul
  {
    #region //私有变量定义
    //战魂基础经验，用于被吞噬时
    private int _base_exp;
    //战魂属性:属性类型1_基础值_等级成长系数;属性类型2_基础值_等级成长系数（成长系数是放大了10倍的）(@;@_@)
    private string _base_pro;
    //战魂图标
    private int _icon;
    //战魂ID
    private int _id;
    //等级上限
    private int _max_level;
    //战魂名称
    private string _name;
    //1白色，2绿色，3蓝色，4紫色，5橙色，6金色，7红色
    private int _quality;
    //1生息2七杀3金刚4破军5化血6天煞7巨门8普渡9经验10兽腾11虎愤12斩铁13夜叉14战狂15辉煌
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"BaseExp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BaseExp { get{ return _base_exp; } set{ _base_exp=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"BasePro", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string BasePro { get{ return _base_pro; } set{ _base_pro=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"MaxLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MaxLevel { get{ return _max_level; } set{ _max_level=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Quality", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Quality { get{ return _quality; } set{ _quality=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareFightingSoul Create( int in_base_exp, string in_base_pro, int in_icon, int in_id, int in_max_level, string in_name, int in_quality, int in_type )
    {
      DeclareFightingSoul tmp = new DeclareFightingSoul();
      tmp._base_exp = in_base_exp;
      tmp._base_pro = in_base_pro;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._max_level = in_max_level;
      tmp._name = in_name;
      tmp._quality = in_quality;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareFightingSoul> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareFightingSoul> _dataCaches = null;
    public static Dictionary<int, DeclareFightingSoul> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataFightingSoul");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataFightingSoul = require 'Lua/Config/DataFightingSoul'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataFightingSoul");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareFightingSoul>(86);
                     foreach (var item in dic)
                     {
                         DeclareFightingSoul tmp = new DeclareFightingSoul();
                       tmp.BaseExp = item.Value[0];
                       tmp.BasePro = CfgStringLua.Get(item.Value[1]);
                       tmp.Icon = item.Value[2];
                       tmp.Id = item.Value[3];
                       tmp.MaxLevel = item.Value[4];
                       tmp.Name = CfgStringLua.Get(item.Value[5]);
                       tmp.Quality = item.Value[6];
                       tmp.Type = item.Value[7];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"FightingSoul");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareFightingSoul>(86);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"FightingSoul");
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
    public static DeclareFightingSoul Get(int id)
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
    public static void Transform(Dictionary<int, DeclareFightingSoul> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
