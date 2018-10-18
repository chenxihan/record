//文件是自动生成,请勿手动修改.来自数据文件:master_holy
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareMasterHoly")]
  public class DeclareMasterHoly
  {
    #region //私有变量定义
    //激活时获得属性(@;@_@)
    private string _activeAttribute;
    //激活所需导师积分
    private int _activeNeedValue;
    //可激活圣痕（须要等级_激活圣痕ID）(@;@_@)
    private string _activePoint;
    //是否首次激活免费0否 1是
    private int _canFree;
    //可升级次数
    private int _canUpNum;
    //属性描述 hide
    private string _describe;
    //边框ID（hide）
    private int _frame;
    //所属圣器
    private int _group;
    //图标ID（hide）
    private int _icon;
    //key值
    private int _id;
    //圣痕名字
    private string _name;
    //核心圣痕属性（1.经验BUFFid；2.属性继承提升百分比）(@;@_@)
    private string _specialAtt;
    //圣痕类型（1、核心圣痕,2、特殊圣痕,3、基础圣痕）
    private int _type;
    //基础成长属性(属性类型_增加的值)(@;@_@)
    private string _upAttribute;
    //升级所需导师积分
    private int _upNeendValue;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ActiveAttribute", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ActiveAttribute { get{ return _activeAttribute; } set{ _activeAttribute=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"ActiveNeedValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ActiveNeedValue { get{ return _activeNeedValue; } set{ _activeNeedValue=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"ActivePoint", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ActivePoint { get{ return _activePoint; } set{ _activePoint=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"CanFree", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanFree { get{ return _canFree; } set{ _canFree=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"CanUpNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanUpNum { get{ return _canUpNum; } set{ _canUpNum=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Describe", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Describe { get{ return _describe; } set{ _describe=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Frame", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Frame { get{ return _frame; } set{ _frame=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Group", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Group { get{ return _group; } set{ _group=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"SpecialAtt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SpecialAtt { get{ return _specialAtt; } set{ _specialAtt=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"UpAttribute", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string UpAttribute { get{ return _upAttribute; } set{ _upAttribute=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"UpNeendValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UpNeendValue { get{ return _upNeendValue; } set{ _upNeendValue=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareMasterHoly Create( string in_activeAttribute, int in_activeNeedValue, string in_activePoint, int in_canFree, int in_canUpNum, string in_describe, int in_frame, int in_group, int in_icon, int in_id, string in_name, string in_specialAtt, int in_type, string in_upAttribute, int in_upNeendValue )
    {
      DeclareMasterHoly tmp = new DeclareMasterHoly();
      tmp._activeAttribute = in_activeAttribute;
      tmp._activeNeedValue = in_activeNeedValue;
      tmp._activePoint = in_activePoint;
      tmp._canFree = in_canFree;
      tmp._canUpNum = in_canUpNum;
      tmp._describe = in_describe;
      tmp._frame = in_frame;
      tmp._group = in_group;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._name = in_name;
      tmp._specialAtt = in_specialAtt;
      tmp._type = in_type;
      tmp._upAttribute = in_upAttribute;
      tmp._upNeendValue = in_upNeendValue;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareMasterHoly> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareMasterHoly> _dataCaches = null;
    public static Dictionary<int, DeclareMasterHoly> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMasterHoly");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataMasterHoly = require 'Lua/Config/DataMasterHoly'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMasterHoly");                  }

                 if (dic != null)
                 {
                              _dataCaches = new Dictionary<int, DeclareMasterHoly>();
                     foreach (var item in dic)
                     {
                         DeclareMasterHoly tmp = new DeclareMasterHoly();
                       tmp.ActiveAttribute = CfgStringLua.Get(item.Value[0]);
                       tmp.ActiveNeedValue = item.Value[1];
                       tmp.ActivePoint = CfgStringLua.Get(item.Value[2]);
                       tmp.CanFree = item.Value[3];
                       tmp.CanUpNum = item.Value[4];
                       tmp.Describe = CfgStringLua.Get(item.Value[5]);
                       tmp.Frame = item.Value[6];
                       tmp.Group = item.Value[7];
                       tmp.Icon = item.Value[8];
                       tmp.Id = item.Value[9];
                       tmp.Name = CfgStringLua.Get(item.Value[10]);
                       tmp.SpecialAtt = CfgStringLua.Get(item.Value[11]);
                       tmp.Type = item.Value[12];
                       tmp.UpAttribute = CfgStringLua.Get(item.Value[13]);
                       tmp.UpNeendValue = item.Value[14];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"MasterHoly");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareMasterHoly>();
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"MasterHoly");
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
    public static DeclareMasterHoly Get(int id)
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
    public static void Transform(Dictionary<int, DeclareMasterHoly> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
