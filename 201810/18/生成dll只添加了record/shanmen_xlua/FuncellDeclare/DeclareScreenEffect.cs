//文件是自动生成,请勿手动修改.来自数据文件:ScreenEffect
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareScreenEffect")]
  public class DeclareScreenEffect
  {
    #region //私有变量定义
    //ID
    private int _id;
    //播放位置(0上，1中，2下)
    private int _pos;
    //特效ID
    private int _res;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Pos", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Pos { get{ return _pos; } set{ _pos=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Res", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Res { get{ return _res; } set{ _res=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareScreenEffect Create( int in_id, int in_pos, int in_res )
    {
      DeclareScreenEffect tmp = new DeclareScreenEffect();
      tmp._id = in_id;
      tmp._pos = in_pos;
      tmp._res = in_res;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareScreenEffect> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareScreenEffect> _dataCaches = null;
    public static Dictionary<int, DeclareScreenEffect> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataScreenEffect");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataScreenEffect = require 'Lua/Config/DataScreenEffect'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataScreenEffect");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareScreenEffect>(4);
                     foreach (var item in dic)
                     {
                         DeclareScreenEffect tmp = new DeclareScreenEffect();
                       tmp.Id = item.Value[0];
                       tmp.Pos = item.Value[1];
                       tmp.Res = item.Value[2];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"ScreenEffect");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareScreenEffect>(4);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"ScreenEffect");
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
    public static DeclareScreenEffect Get(int id)
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
    public static void Transform(Dictionary<int, DeclareScreenEffect> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
