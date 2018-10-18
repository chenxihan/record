//文件是自动生成,请勿手动修改.来自数据文件:elves_runelevel
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareElvesRunelevel")]
  public class DeclareElvesRunelevel
  {
    #region //私有变量定义
    //增加属性(@;@_@)
    private string _addAttribute;
    //强化总等级
    private int _iD;
    //强化数量
    private int _num;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"AddAttribute", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string AddAttribute { get{ return _addAttribute; } set{ _addAttribute=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID { get{ return _iD; } set{ _iD=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Num { get{ return _num; } set{ _num=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareElvesRunelevel Create( string in_addAttribute, int in_iD, int in_num )
    {
      DeclareElvesRunelevel tmp = new DeclareElvesRunelevel();
      tmp._addAttribute = in_addAttribute;
      tmp._iD = in_iD;
      tmp._num = in_num;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareElvesRunelevel> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareElvesRunelevel> _dataCaches = null;
    public static Dictionary<int, DeclareElvesRunelevel> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataElvesRunelevel");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataElvesRunelevel = require 'Lua/Config/DataElvesRunelevel'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataElvesRunelevel");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareElvesRunelevel>(9);
                     foreach (var item in dic)
                     {
                         DeclareElvesRunelevel tmp = new DeclareElvesRunelevel();
                       tmp.AddAttribute = CfgStringLua.Get(item.Value[0]);
                       tmp.ID = item.Value[1];
                       tmp.Num = item.Value[2];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"ElvesRunelevel");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareElvesRunelevel>(9);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"ElvesRunelevel");
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
    public static DeclareElvesRunelevel Get(int id)
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
    public static void Transform(Dictionary<int, DeclareElvesRunelevel> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
