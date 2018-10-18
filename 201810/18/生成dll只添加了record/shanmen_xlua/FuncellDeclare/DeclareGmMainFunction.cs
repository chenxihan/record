//文件是自动生成,请勿手动修改.来自数据文件:GmMainFunction
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareGmMainFunction")]
  public class DeclareGmMainFunction
  {
    #region //私有变量定义
    //子功能ID
    private string _branchFunction;
    //分页图标
    private int _icon;
    //编号
    private int _id;
    //标题
    private string _name;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"BranchFunction", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string BranchFunction { get{ return _branchFunction; } set{ _branchFunction=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareGmMainFunction Create( string in_branchFunction, int in_icon, int in_id, string in_name )
    {
      DeclareGmMainFunction tmp = new DeclareGmMainFunction();
      tmp._branchFunction = in_branchFunction;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._name = in_name;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareGmMainFunction> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareGmMainFunction> _dataCaches = null;
    public static Dictionary<int, DeclareGmMainFunction> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGmMainFunction");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataGmMainFunction = require 'Lua/Config/DataGmMainFunction'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGmMainFunction");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareGmMainFunction>(29);
                     foreach (var item in dic)
                     {
                         DeclareGmMainFunction tmp = new DeclareGmMainFunction();
                       tmp.BranchFunction = CfgStringLua.Get(item.Value[0]);
                       tmp.Icon = item.Value[1];
                       tmp.Id = item.Value[2];
                       tmp.Name = CfgStringLua.Get(item.Value[3]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"GmMainFunction");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareGmMainFunction>(29);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"GmMainFunction");
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
    public static DeclareGmMainFunction Get(int id)
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
    public static void Transform(Dictionary<int, DeclareGmMainFunction> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
