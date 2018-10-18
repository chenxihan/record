//文件是自动生成,请勿手动修改.来自数据文件:kaifu_activity_BOSS
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareKaifuActivityBOSS")]
  public class DeclareKaifuActivityBOSS
  {
    #region //私有变量定义
    //BOSSID
    private int _bOSSID;
    //id(轮数*100+第几只)
    private int _id;
    //所在地图
    private int _maps;
    //开启UI
    private int _openUI;
    //轮数
    private int _position;
    //幻境BOSS才会有收益，BOSS之家填0
    private int _profit_num;
    //完成奖励(@;@_@)
    private string _reward;
    //张昌达调整
    private int _tapy;
    //模型缩放
    private int _zoom;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"BOSSID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BOSSID { get{ return _bOSSID; } set{ _bOSSID=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Maps", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Maps { get{ return _maps; } set{ _maps=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"OpenUI", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OpenUI { get{ return _openUI; } set{ _openUI=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Position", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Position { get{ return _position; } set{ _position=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"ProfitNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ProfitNum { get{ return _profit_num; } set{ _profit_num=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Reward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Reward { get{ return _reward; } set{ _reward=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Tapy", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Tapy { get{ return _tapy; } set{ _tapy=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Zoom", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Zoom { get{ return _zoom; } set{ _zoom=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareKaifuActivityBOSS Create( int in_bOSSID, int in_id, int in_maps, int in_openUI, int in_position, int in_profit_num, string in_reward, int in_tapy, int in_zoom )
    {
      DeclareKaifuActivityBOSS tmp = new DeclareKaifuActivityBOSS();
      tmp._bOSSID = in_bOSSID;
      tmp._id = in_id;
      tmp._maps = in_maps;
      tmp._openUI = in_openUI;
      tmp._position = in_position;
      tmp._profit_num = in_profit_num;
      tmp._reward = in_reward;
      tmp._tapy = in_tapy;
      tmp._zoom = in_zoom;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareKaifuActivityBOSS> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareKaifuActivityBOSS> _dataCaches = null;
    public static Dictionary<int, DeclareKaifuActivityBOSS> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataKaifuActivityBOSS");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataKaifuActivityBOSS = require 'Lua/Config/DataKaifuActivityBOSS'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataKaifuActivityBOSS");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareKaifuActivityBOSS>(28);
                     foreach (var item in dic)
                     {
                         DeclareKaifuActivityBOSS tmp = new DeclareKaifuActivityBOSS();
                       tmp.BOSSID = item.Value[0];
                       tmp.Id = item.Value[1];
                       tmp.Maps = item.Value[2];
                       tmp.OpenUI = item.Value[3];
                       tmp.Position = item.Value[4];
                       tmp.ProfitNum = item.Value[5];
                       tmp.Reward = CfgStringLua.Get(item.Value[6]);
                       tmp.Tapy = item.Value[7];
                       tmp.Zoom = item.Value[8];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"KaifuActivityBOSS");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareKaifuActivityBOSS>(28);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"KaifuActivityBOSS");
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
    public static DeclareKaifuActivityBOSS Get(int id)
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
    public static void Transform(Dictionary<int, DeclareKaifuActivityBOSS> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
