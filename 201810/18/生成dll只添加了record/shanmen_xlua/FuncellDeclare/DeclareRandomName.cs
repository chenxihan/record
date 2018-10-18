//文件是自动生成,请勿手动修改.来自数据文件:RandomName
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareRandomName")]
  public class DeclareRandomName
  {
    #region //私有变量定义
    //表编号
    private int _q_id;
    //类型（1姓，2男名，3女名）
    private int _q_type;
    //内容
    private string _q_value;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"QId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int QId { get{ return _q_id; } set{ _q_id=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"QType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int QType { get{ return _q_type; } set{ _q_type=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"QValue", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string QValue { get{ return _q_value; } set{ _q_value=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareRandomName Create( int in_q_id, int in_q_type, string in_q_value )
    {
      DeclareRandomName tmp = new DeclareRandomName();
      tmp._q_id = in_q_id;
      tmp._q_type = in_q_type;
      tmp._q_value = in_q_value;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareRandomName> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareRandomName> _dataCaches = null;
    public static Dictionary<int, DeclareRandomName> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataRandomName");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataRandomName = require 'Lua/Config/DataRandomName'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataRandomName");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareRandomName>(386);
                     foreach (var item in dic)
                     {
                         DeclareRandomName tmp = new DeclareRandomName();
                       tmp.QId = item.Value[0];
                       tmp.QType = item.Value[1];
                       tmp.QValue = CfgStringLua.Get(item.Value[2]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"RandomName");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareRandomName>(386);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"RandomName");
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
    public static DeclareRandomName Get(int id)
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
    public static void Transform(Dictionary<int, DeclareRandomName> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
