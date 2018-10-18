//文件是自动生成,请勿手动修改.来自数据文件:PetRuneName
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclarePetRuneName")]
  public class DeclarePetRuneName
  {
    #region //私有变量定义
    //ID
    private int _id;
    //名字
    private string _name;
    //图片资源
    private string _tex_res;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"TexRes", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TexRes { get{ return _tex_res; } set{ _tex_res=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclarePetRuneName Create( int in_id, string in_name, string in_tex_res )
    {
      DeclarePetRuneName tmp = new DeclarePetRuneName();
      tmp._id = in_id;
      tmp._name = in_name;
      tmp._tex_res = in_tex_res;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclarePetRuneName> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclarePetRuneName> _dataCaches = null;
    public static Dictionary<int, DeclarePetRuneName> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPetRuneName");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataPetRuneName = require 'Lua/Config/DataPetRuneName'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPetRuneName");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclarePetRuneName>(6);
                     foreach (var item in dic)
                     {
                         DeclarePetRuneName tmp = new DeclarePetRuneName();
                       tmp.Id = item.Value[0];
                       tmp.Name = CfgStringLua.Get(item.Value[1]);
                       tmp.TexRes = CfgStringLua.Get(item.Value[2]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"PetRuneName");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclarePetRuneName>(6);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"PetRuneName");
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
    public static DeclarePetRuneName Get(int id)
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
    public static void Transform(Dictionary<int, DeclarePetRuneName> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
