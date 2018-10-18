//文件是自动生成,请勿手动修改.来自数据文件:hallows_attr
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareHallowsAttr")]
  public class DeclareHallowsAttr
  {
    #region //私有变量定义
    //本级属性(@;@_@)
    private string _attribute;
    //器灵等级
    private int _id;
    //圣器名称
    private string _name;
    //是否公告
    private int _nocite;
    //强化进度
    private int _progress;
    //激活技能
    private int _skill;
    //升阶物品id_进度(@;@_@)
    private string _up_item;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Attribute", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Attribute { get{ return _attribute; } set{ _attribute=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Nocite", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Nocite { get{ return _nocite; } set{ _nocite=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Progress", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Progress { get{ return _progress; } set{ _progress=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Skill", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Skill { get{ return _skill; } set{ _skill=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"UpItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string UpItem { get{ return _up_item; } set{ _up_item=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareHallowsAttr Create( string in_attribute, int in_id, string in_name, int in_nocite, int in_progress, int in_skill, string in_up_item )
    {
      DeclareHallowsAttr tmp = new DeclareHallowsAttr();
      tmp._attribute = in_attribute;
      tmp._id = in_id;
      tmp._name = in_name;
      tmp._nocite = in_nocite;
      tmp._progress = in_progress;
      tmp._skill = in_skill;
      tmp._up_item = in_up_item;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareHallowsAttr> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareHallowsAttr> _dataCaches = null;
    public static Dictionary<int, DeclareHallowsAttr> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataHallowsAttr");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataHallowsAttr = require 'Lua/Config/DataHallowsAttr'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataHallowsAttr");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareHallowsAttr>(800);
                     foreach (var item in dic)
                     {
                         DeclareHallowsAttr tmp = new DeclareHallowsAttr();
                       tmp.Attribute = CfgStringLua.Get(item.Value[0]);
                       tmp.Id = item.Value[1];
                       tmp.Name = CfgStringLua.Get(item.Value[2]);
                       tmp.Nocite = item.Value[3];
                       tmp.Progress = item.Value[4];
                       tmp.Skill = item.Value[5];
                       tmp.UpItem = CfgStringLua.Get(item.Value[6]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"HallowsAttr");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareHallowsAttr>(800);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"HallowsAttr");
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
    public static DeclareHallowsAttr Get(int id)
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
    public static void Transform(Dictionary<int, DeclareHallowsAttr> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
