//文件是自动生成,请勿手动修改.来自数据文件:master_level
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareMasterLevel")]
  public class DeclareMasterLevel
  {
    #region //私有变量定义
    //增加的属性(属性类型_增加的值)(@;@_@)
    private string _att;
    //激活的圣器ID
    private int _holy;
    //等级
    private int _lv;
    //名字
    private string _name;
    //是否公告（0不公告；1公告）
    private int _radio;
    //升级所需良师值
    private int _upNeed;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Att", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Att { get{ return _att; } set{ _att=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Holy", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Holy { get{ return _holy; } set{ _holy=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Lv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Lv { get{ return _lv; } set{ _lv=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Radio", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Radio { get{ return _radio; } set{ _radio=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"UpNeed", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UpNeed { get{ return _upNeed; } set{ _upNeed=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareMasterLevel Create( string in_att, int in_holy, int in_lv, string in_name, int in_radio, int in_upNeed )
    {
      DeclareMasterLevel tmp = new DeclareMasterLevel();
      tmp._att = in_att;
      tmp._holy = in_holy;
      tmp._lv = in_lv;
      tmp._name = in_name;
      tmp._radio = in_radio;
      tmp._upNeed = in_upNeed;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareMasterLevel> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareMasterLevel> _dataCaches = null;
    public static Dictionary<int, DeclareMasterLevel> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMasterLevel");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataMasterLevel = require 'Lua/Config/DataMasterLevel'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMasterLevel");                  }

                 if (dic != null)
                 {
                              _dataCaches = new Dictionary<int, DeclareMasterLevel>();
                     foreach (var item in dic)
                     {
                         DeclareMasterLevel tmp = new DeclareMasterLevel();
                       tmp.Att = CfgStringLua.Get(item.Value[0]);
                       tmp.Holy = item.Value[1];
                       tmp.Lv = item.Value[2];
                       tmp.Name = CfgStringLua.Get(item.Value[3]);
                       tmp.Radio = item.Value[4];
                       tmp.UpNeed = item.Value[5];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"MasterLevel");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareMasterLevel>();
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"MasterLevel");
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
    public static DeclareMasterLevel Get(int id)
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
    public static void Transform(Dictionary<int, DeclareMasterLevel> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
