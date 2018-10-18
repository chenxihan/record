//文件是自动生成,请勿手动修改.来自数据文件:marriage_ring
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareMarriageRing")]
  public class DeclareMarriageRing
  {
    #region //私有变量定义
    //增加的亲密度
    private int _addIntimacy;
    //增加的属性(@;@_@)
    private string _attributes;
    //激活属性类型
    private int _attType;
    //激活BUffId(BUFF配置表中id字段)
    private int _buffId;
    //阶数(hide)
    private string _degree;
    //激活说明(hide)
    private string _dis;
    //图标hide
    private int _icon;
    //戒指等级
    private int _level;
    //模型hide
    private int _modelId;
    //名称
    private string _name;
    //是否公告（0不公告；1公告）
    private int _radio;
    //激活技能id(技能配置表中id字段)
    private int _skillId;
    //升级所需元宝数量
    private int _upGold;
    //升级所需物品id(@;@_@)
    private string _upNeedItem;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"AddIntimacy", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int AddIntimacy { get{ return _addIntimacy; } set{ _addIntimacy=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Attributes", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Attributes { get{ return _attributes; } set{ _attributes=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"AttType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int AttType { get{ return _attType; } set{ _attType=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"BuffId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BuffId { get{ return _buffId; } set{ _buffId=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Degree", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Degree { get{ return _degree; } set{ _degree=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Dis", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Dis { get{ return _dis; } set{ _dis=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"ModelId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ModelId { get{ return _modelId; } set{ _modelId=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Radio", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Radio { get{ return _radio; } set{ _radio=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"SkillId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SkillId { get{ return _skillId; } set{ _skillId=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"UpGold", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UpGold { get{ return _upGold; } set{ _upGold=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"UpNeedItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string UpNeedItem { get{ return _upNeedItem; } set{ _upNeedItem=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareMarriageRing Create( int in_addIntimacy, string in_attributes, int in_attType, int in_buffId, string in_degree, string in_dis, int in_icon, int in_level, int in_modelId, string in_name, int in_radio, int in_skillId, int in_upGold, string in_upNeedItem )
    {
      DeclareMarriageRing tmp = new DeclareMarriageRing();
      tmp._addIntimacy = in_addIntimacy;
      tmp._attributes = in_attributes;
      tmp._attType = in_attType;
      tmp._buffId = in_buffId;
      tmp._degree = in_degree;
      tmp._dis = in_dis;
      tmp._icon = in_icon;
      tmp._level = in_level;
      tmp._modelId = in_modelId;
      tmp._name = in_name;
      tmp._radio = in_radio;
      tmp._skillId = in_skillId;
      tmp._upGold = in_upGold;
      tmp._upNeedItem = in_upNeedItem;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareMarriageRing> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareMarriageRing> _dataCaches = null;
    public static Dictionary<int, DeclareMarriageRing> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMarriageRing");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataMarriageRing = require 'Lua/Config/DataMarriageRing'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMarriageRing");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareMarriageRing>(9);
                     foreach (var item in dic)
                     {
                         DeclareMarriageRing tmp = new DeclareMarriageRing();
                       tmp.AddIntimacy = item.Value[0];
                       tmp.Attributes = CfgStringLua.Get(item.Value[1]);
                       tmp.AttType = item.Value[2];
                       tmp.BuffId = item.Value[3];
                       tmp.Degree = CfgStringLua.Get(item.Value[4]);
                       tmp.Dis = CfgStringLua.Get(item.Value[5]);
                       tmp.Icon = item.Value[6];
                       tmp.Level = item.Value[7];
                       tmp.ModelId = item.Value[8];
                       tmp.Name = CfgStringLua.Get(item.Value[9]);
                       tmp.Radio = item.Value[10];
                       tmp.SkillId = item.Value[11];
                       tmp.UpGold = item.Value[12];
                       tmp.UpNeedItem = CfgStringLua.Get(item.Value[13]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"MarriageRing");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareMarriageRing>(9);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"MarriageRing");
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
    public static DeclareMarriageRing Get(int id)
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
    public static void Transform(Dictionary<int, DeclareMarriageRing> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
