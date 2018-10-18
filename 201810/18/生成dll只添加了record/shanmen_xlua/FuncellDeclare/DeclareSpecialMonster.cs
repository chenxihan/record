//文件是自动生成,请勿手动修改.来自数据文件:special_monster
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareSpecialMonster")]
  public class DeclareSpecialMonster
  {
    #region //私有变量定义
    //阵营（0为所有阵营）
    private int _camp;
    //刷新描述
    private string _describe;
    //显示掉落(@;@)
    private string _drop;
    //怪物头像
    private int _head_icon;
    //编号ID
    private int _iD;
    //刷新地图
    private int _mapsid;
    //模型旋转hide
    private int _model_rotat;
    //怪物ID
    private int _monsterid;
    //刷新坐标(@;@_@)
    private string _pos;
    //推介战力
    private int _power;
    //模型缩放
    private int _size;
    //刷新时间(@;@_@)
    private string _time;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Camp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Camp { get{ return _camp; } set{ _camp=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Describe", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Describe { get{ return _describe; } set{ _describe=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Drop", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Drop { get{ return _drop; } set{ _drop=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"HeadIcon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int HeadIcon { get{ return _head_icon; } set{ _head_icon=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID { get{ return _iD; } set{ _iD=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Mapsid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Mapsid { get{ return _mapsid; } set{ _mapsid=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"ModelRotat", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ModelRotat { get{ return _model_rotat; } set{ _model_rotat=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Monsterid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Monsterid { get{ return _monsterid; } set{ _monsterid=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Pos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Pos { get{ return _pos; } set{ _pos=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Power", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Power { get{ return _power; } set{ _power=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Size", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Size { get{ return _size; } set{ _size=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"Time", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Time { get{ return _time; } set{ _time=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareSpecialMonster Create( int in_camp, string in_describe, string in_drop, int in_head_icon, int in_iD, int in_mapsid, int in_model_rotat, int in_monsterid, string in_pos, int in_power, int in_size, string in_time )
    {
      DeclareSpecialMonster tmp = new DeclareSpecialMonster();
      tmp._camp = in_camp;
      tmp._describe = in_describe;
      tmp._drop = in_drop;
      tmp._head_icon = in_head_icon;
      tmp._iD = in_iD;
      tmp._mapsid = in_mapsid;
      tmp._model_rotat = in_model_rotat;
      tmp._monsterid = in_monsterid;
      tmp._pos = in_pos;
      tmp._power = in_power;
      tmp._size = in_size;
      tmp._time = in_time;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareSpecialMonster> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareSpecialMonster> _dataCaches = null;
    public static Dictionary<int, DeclareSpecialMonster> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataSpecialMonster");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataSpecialMonster = require 'Lua/Config/DataSpecialMonster'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataSpecialMonster");                  }

                 if (dic != null)
                 {
                              _dataCaches = new Dictionary<int, DeclareSpecialMonster>();
                     foreach (var item in dic)
                     {
                         DeclareSpecialMonster tmp = new DeclareSpecialMonster();
                       tmp.Camp = item.Value[0];
                       tmp.Describe = CfgStringLua.Get(item.Value[1]);
                       tmp.Drop = CfgStringLua.Get(item.Value[2]);
                       tmp.HeadIcon = item.Value[3];
                       tmp.ID = item.Value[4];
                       tmp.Mapsid = item.Value[5];
                       tmp.ModelRotat = item.Value[6];
                       tmp.Monsterid = item.Value[7];
                       tmp.Pos = CfgStringLua.Get(item.Value[8]);
                       tmp.Power = item.Value[9];
                       tmp.Size = item.Value[10];
                       tmp.Time = CfgStringLua.Get(item.Value[11]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"SpecialMonster");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareSpecialMonster>();
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"SpecialMonster");
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
    public static DeclareSpecialMonster Get(int id)
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
    public static void Transform(Dictionary<int, DeclareSpecialMonster> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
