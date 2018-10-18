//文件是自动生成,请勿手动修改.来自数据文件:changeJobFateStar
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareChangeJobFateStar")]
  public class DeclareChangeJobFateStar
  {
    #region //私有变量定义
    //基础成长属性(属性类型_增加的值)(@;@_@)
    private string _att;
    //命星icon（hide）
    private int _icon;
    //ID
    private int _id;
    //命星名字
    private string _name;
    //激活所需道具数量(@;@_@)
    private string _need;
    //父类ID，填写需要激活的前一个命星
    private int _parentId;
    //key值激活顺序
    private int _rune;
    //激活所需经验
    private Int64 _upNeedExp;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Att", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Att { get{ return _att; } set{ _att=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Need", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Need { get{ return _need; } set{ _need=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"ParentId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ParentId { get{ return _parentId; } set{ _parentId=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Rune", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Rune { get{ return _rune; } set{ _rune=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"UpNeedExp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Int64 UpNeedExp { get{ return _upNeedExp; } set{ _upNeedExp=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareChangeJobFateStar Create( string in_att, int in_icon, int in_id, string in_name, string in_need, int in_parentId, int in_rune, Int64 in_upNeedExp )
    {
      DeclareChangeJobFateStar tmp = new DeclareChangeJobFateStar();
      tmp._att = in_att;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._name = in_name;
      tmp._need = in_need;
      tmp._parentId = in_parentId;
      tmp._rune = in_rune;
      tmp._upNeedExp = in_upNeedExp;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareChangeJobFateStar> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareChangeJobFateStar> _dataCaches = null;
    public static Dictionary<int, DeclareChangeJobFateStar> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataChangeJobFateStar");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataChangeJobFateStar = require 'Lua/Config/DataChangeJobFateStar'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataChangeJobFateStar");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareChangeJobFateStar>(12);
                     foreach (var item in dic)
                     {
                         DeclareChangeJobFateStar tmp = new DeclareChangeJobFateStar();
                       tmp.Att = CfgStringLua.Get(item.Value[0]);
                       tmp.Icon = item.Value[1];
                       tmp.Id = item.Value[2];
                       tmp.Name = CfgStringLua.Get(item.Value[3]);
                       tmp.Need = CfgStringLua.Get(item.Value[4]);
                       tmp.ParentId = item.Value[5];
                       tmp.Rune = item.Value[6];
                       tmp.UpNeedExp = item.Value[7];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"ChangeJobFateStar");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareChangeJobFateStar>(12);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"ChangeJobFateStar");
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
    public static DeclareChangeJobFateStar Get(int id)
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
    public static void Transform(Dictionary<int, DeclareChangeJobFateStar> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
