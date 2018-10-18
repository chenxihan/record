//文件是自动生成,请勿手动修改.来自数据文件:marriage
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareMarriage")]
  public class DeclareMarriage
  {
    #region //私有变量定义
    //增加的属性(@;@_@)
    private string _attr;
    //激活属性类型
    private int _attType;
    //激活BUffId(BUFF配置表中id字段)
    private int _buffId;
    //夫妻关系等级
    private int _level;
    //名称
    private string _name;
    //激活需要亲密度大小
    private int _needValue;
    //是否公告（0不公告；1公告）
    private int _radio;
    //激活技能id(技能配置表中id字段)
    private int _skillId;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Attr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Attr { get{ return _attr; } set{ _attr=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"AttType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int AttType { get{ return _attType; } set{ _attType=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"BuffId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BuffId { get{ return _buffId; } set{ _buffId=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"NeedValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NeedValue { get{ return _needValue; } set{ _needValue=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Radio", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Radio { get{ return _radio; } set{ _radio=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"SkillId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SkillId { get{ return _skillId; } set{ _skillId=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareMarriage Create( string in_attr, int in_attType, int in_buffId, int in_level, string in_name, int in_needValue, int in_radio, int in_skillId )
    {
      DeclareMarriage tmp = new DeclareMarriage();
      tmp._attr = in_attr;
      tmp._attType = in_attType;
      tmp._buffId = in_buffId;
      tmp._level = in_level;
      tmp._name = in_name;
      tmp._needValue = in_needValue;
      tmp._radio = in_radio;
      tmp._skillId = in_skillId;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareMarriage> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareMarriage> _dataCaches = null;
    public static Dictionary<int, DeclareMarriage> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMarriage");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataMarriage = require 'Lua/Config/DataMarriage'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMarriage");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareMarriage>(13);
                     foreach (var item in dic)
                     {
                         DeclareMarriage tmp = new DeclareMarriage();
                       tmp.Attr = CfgStringLua.Get(item.Value[0]);
                       tmp.AttType = item.Value[1];
                       tmp.BuffId = item.Value[2];
                       tmp.Level = item.Value[3];
                       tmp.Name = CfgStringLua.Get(item.Value[4]);
                       tmp.NeedValue = item.Value[5];
                       tmp.Radio = item.Value[6];
                       tmp.SkillId = item.Value[7];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Marriage");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareMarriage>(13);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Marriage");
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
    public static DeclareMarriage Get(int id)
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
    public static void Transform(Dictionary<int, DeclareMarriage> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
