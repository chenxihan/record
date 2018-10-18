//文件是自动生成,请勿手动修改.来自数据文件:attributeAdd
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareAttributeAdd")]
  public class DeclareAttributeAdd
  {
    #region //私有变量定义
    //变量ID
    private int _id;
    //属性名字(hide)
    private string _name;
    //是否显示为百分比
    private int _show_percent;
    //变量
    private int _variable;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"ShowPercent", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ShowPercent { get{ return _show_percent; } set{ _show_percent=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Variable", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Variable { get{ return _variable; } set{ _variable=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareAttributeAdd Create( int in_id, string in_name, int in_show_percent, int in_variable )
    {
      DeclareAttributeAdd tmp = new DeclareAttributeAdd();
      tmp._id = in_id;
      tmp._name = in_name;
      tmp._show_percent = in_show_percent;
      tmp._variable = in_variable;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareAttributeAdd> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareAttributeAdd> _dataCaches = null;
    public static Dictionary<int, DeclareAttributeAdd> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataAttributeAdd");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataAttributeAdd = require 'Lua/Config/DataAttributeAdd'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataAttributeAdd");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareAttributeAdd>(80);
                     foreach (var item in dic)
                     {
                         DeclareAttributeAdd tmp = new DeclareAttributeAdd();
                       tmp.Id = item.Value[0];
                       tmp.Name = CfgStringLua.Get(item.Value[1]);
                       tmp.ShowPercent = item.Value[2];
                       tmp.Variable = item.Value[3];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"AttributeAdd");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareAttributeAdd>(80);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"AttributeAdd");
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
    public static DeclareAttributeAdd Get(int id)
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
    public static void Transform(Dictionary<int, DeclareAttributeAdd> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
