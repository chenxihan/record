//文件是自动生成,请勿手动修改.来自数据文件:GmCmd
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareGmCmd")]
  public class DeclareGmCmd
  {
    #region //私有变量定义
    //功能命令
    private string _cmd;
    //描述
    private string _cmdDesc;
    //编号
    private int _id;
    //参数
    private string _pramaDesc;
    //参数数量
    private string _pramas;
    //参数说明
    private string _pramaTips;
    //命令类型
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Cmd", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Cmd { get{ return _cmd; } set{ _cmd=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"CmdDesc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string CmdDesc { get{ return _cmdDesc; } set{ _cmdDesc=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"PramaDesc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string PramaDesc { get{ return _pramaDesc; } set{ _pramaDesc=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Pramas", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Pramas { get{ return _pramas; } set{ _pramas=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"PramaTips", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string PramaTips { get{ return _pramaTips; } set{ _pramaTips=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareGmCmd Create( string in_cmd, string in_cmdDesc, int in_id, string in_pramaDesc, string in_pramas, string in_pramaTips, int in_type )
    {
      DeclareGmCmd tmp = new DeclareGmCmd();
      tmp._cmd = in_cmd;
      tmp._cmdDesc = in_cmdDesc;
      tmp._id = in_id;
      tmp._pramaDesc = in_pramaDesc;
      tmp._pramas = in_pramas;
      tmp._pramaTips = in_pramaTips;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareGmCmd> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareGmCmd> _dataCaches = null;
    public static Dictionary<int, DeclareGmCmd> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGmCmd");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataGmCmd = require 'Lua/Config/DataGmCmd'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGmCmd");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareGmCmd>(131);
                     foreach (var item in dic)
                     {
                         DeclareGmCmd tmp = new DeclareGmCmd();
                       tmp.Cmd = CfgStringLua.Get(item.Value[0]);
                       tmp.CmdDesc = CfgStringLua.Get(item.Value[1]);
                       tmp.Id = item.Value[2];
                       tmp.PramaDesc = CfgStringLua.Get(item.Value[3]);
                       tmp.Pramas = CfgStringLua.Get(item.Value[4]);
                       tmp.PramaTips = CfgStringLua.Get(item.Value[5]);
                       tmp.Type = item.Value[6];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"GmCmd");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareGmCmd>(131);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"GmCmd");
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
    public static DeclareGmCmd Get(int id)
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
    public static void Transform(Dictionary<int, DeclareGmCmd> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
