//文件是自动生成,请勿手动修改.来自数据文件:GroundBuff
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareGroundBuff")]
  public class DeclareGroundBuff
  {
    #region //私有变量定义
    //激活的时间间隔
    private int _activeStep;
    //激活的次数，如果是临时则写1次就好
    private int _activeTimes;
    //增加的buff id
    private int _buff_id;
    //生效的坐标距离差
    private int _disValue;
    //设置阵营，0为所有阵营都加 其它值与玩家的阵营相同就可以加，-1为怪物阵营
    private int _groupNo;
    //id
    private int _id;
    //碰撞半径（单位厘米）
    private int _logic_body_size;
    //使用的特效，other目录下的特效id
    private int _res;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ActiveStep", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ActiveStep { get{ return _activeStep; } set{ _activeStep=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"ActiveTimes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ActiveTimes { get{ return _activeTimes; } set{ _activeTimes=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"BuffId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BuffId { get{ return _buff_id; } set{ _buff_id=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"DisValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DisValue { get{ return _disValue; } set{ _disValue=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"GroupNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int GroupNo { get{ return _groupNo; } set{ _groupNo=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"LogicBodySize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int LogicBodySize { get{ return _logic_body_size; } set{ _logic_body_size=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Res", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Res { get{ return _res; } set{ _res=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareGroundBuff Create( int in_activeStep, int in_activeTimes, int in_buff_id, int in_disValue, int in_groupNo, int in_id, int in_logic_body_size, int in_res )
    {
      DeclareGroundBuff tmp = new DeclareGroundBuff();
      tmp._activeStep = in_activeStep;
      tmp._activeTimes = in_activeTimes;
      tmp._buff_id = in_buff_id;
      tmp._disValue = in_disValue;
      tmp._groupNo = in_groupNo;
      tmp._id = in_id;
      tmp._logic_body_size = in_logic_body_size;
      tmp._res = in_res;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareGroundBuff> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareGroundBuff> _dataCaches = null;
    public static Dictionary<int, DeclareGroundBuff> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGroundBuff");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataGroundBuff = require 'Lua/Config/DataGroundBuff'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGroundBuff");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareGroundBuff>(8);
                     foreach (var item in dic)
                     {
                         DeclareGroundBuff tmp = new DeclareGroundBuff();
                       tmp.ActiveStep = item.Value[0];
                       tmp.ActiveTimes = item.Value[1];
                       tmp.BuffId = item.Value[2];
                       tmp.DisValue = item.Value[3];
                       tmp.GroupNo = item.Value[4];
                       tmp.Id = item.Value[5];
                       tmp.LogicBodySize = item.Value[6];
                       tmp.Res = item.Value[7];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"GroundBuff");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareGroundBuff>(8);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"GroundBuff");
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
    public static DeclareGroundBuff Get(int id)
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
    public static void Transform(Dictionary<int, DeclareGroundBuff> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
