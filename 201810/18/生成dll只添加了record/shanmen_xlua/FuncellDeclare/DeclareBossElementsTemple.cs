//文件是自动生成,请勿手动修改.来自数据文件:bossElementsTemple
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareBossElementsTemple")]
  public class DeclareBossElementsTemple
  {
    #region //私有变量定义
    //初始怪物等级
    private int _bossLevel;
    //是否在列表中显示(0否1是)
    private int _canShow;
    //副本地图
    private int _cloneID;
    //显示掉落(@;@)hide
    private string _drop;
    //进入所需等级
    private int _enterLevel;
    //战旗ID_掉率倍数(基础为100,1.5倍则是150)_刷新权重（总值为10000）（@;@_@）
    private string _flag;
    //旗帜刷新坐标(@_@)
    private string _flagPos;
    //怪物头像hide
    private int _head_icon;
    //克制所需元素属性（hide）
    private string _hostileElements;
    //编号ID
    private int _iD;
    //所在层数
    private int _layer;
    //等级系数
    private int _levelParameter;
    //刷新地图
    private int _mapsid;
    //怪物名称clientignore
    private string _monster_name;
    //初始怪物ID
    private int _monsterid;
    //采集战旗后刷怪ID（@_@）
    //刷怪ID=（玩家等级-标准等级）/等级系数，根据计算结果数字刷新此单元格中第X个怪物ID
    //例如：（600-500）/5=20，刷新怪物ID为此单元格中第20个怪物ID,小于1则为初始怪，结果值大约怪物id数量时，则刷最后一个ID
    private string _newMonsterId;
    //刷新数量
    private int _num;
    //刷新坐标区域(@;@_@)
    private string _pos;
    //推荐战力hide
    private int _power;
    //模型缩放hide
    private int _size;
    //标准等级
    private int _standardLevel;
    //刷新时间(秒)clientignore
    private int _time;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"BossLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BossLevel { get{ return _bossLevel; } set{ _bossLevel=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"CanShow", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanShow { get{ return _canShow; } set{ _canShow=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"CloneID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CloneID { get{ return _cloneID; } set{ _cloneID=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Drop", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Drop { get{ return _drop; } set{ _drop=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"EnterLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int EnterLevel { get{ return _enterLevel; } set{ _enterLevel=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Flag", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Flag { get{ return _flag; } set{ _flag=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"FlagPos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string FlagPos { get{ return _flagPos; } set{ _flagPos=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"HeadIcon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int HeadIcon { get{ return _head_icon; } set{ _head_icon=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"HostileElements", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string HostileElements { get{ return _hostileElements; } set{ _hostileElements=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID { get{ return _iD; } set{ _iD=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Layer", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Layer { get{ return _layer; } set{ _layer=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"LevelParameter", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int LevelParameter { get{ return _levelParameter; } set{ _levelParameter=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"Mapsid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Mapsid { get{ return _mapsid; } set{ _mapsid=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"MonsterName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string MonsterName { get{ return _monster_name; } set{ _monster_name=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"Monsterid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Monsterid { get{ return _monsterid; } set{ _monsterid=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"NewMonsterId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string NewMonsterId { get{ return _newMonsterId; } set{ _newMonsterId=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"Num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Num { get{ return _num; } set{ _num=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"Pos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Pos { get{ return _pos; } set{ _pos=value; } }
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"Power", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Power { get{ return _power; } set{ _power=value; } }
    [global::ProtoBuf.ProtoMember(20, IsRequired = true, Name=@"Size", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Size { get{ return _size; } set{ _size=value; } }
    [global::ProtoBuf.ProtoMember(21, IsRequired = true, Name=@"StandardLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int StandardLevel { get{ return _standardLevel; } set{ _standardLevel=value; } }
    [global::ProtoBuf.ProtoMember(22, IsRequired = true, Name=@"Time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Time { get{ return _time; } set{ _time=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareBossElementsTemple Create( int in_bossLevel, int in_canShow, int in_cloneID, string in_drop, int in_enterLevel, string in_flag, string in_flagPos, int in_head_icon, string in_hostileElements, int in_iD, int in_layer, int in_levelParameter, int in_mapsid, string in_monster_name, int in_monsterid, string in_newMonsterId, int in_num, string in_pos, int in_power, int in_size, int in_standardLevel, int in_time )
    {
      DeclareBossElementsTemple tmp = new DeclareBossElementsTemple();
      tmp._bossLevel = in_bossLevel;
      tmp._canShow = in_canShow;
      tmp._cloneID = in_cloneID;
      tmp._drop = in_drop;
      tmp._enterLevel = in_enterLevel;
      tmp._flag = in_flag;
      tmp._flagPos = in_flagPos;
      tmp._head_icon = in_head_icon;
      tmp._hostileElements = in_hostileElements;
      tmp._iD = in_iD;
      tmp._layer = in_layer;
      tmp._levelParameter = in_levelParameter;
      tmp._mapsid = in_mapsid;
      tmp._monster_name = in_monster_name;
      tmp._monsterid = in_monsterid;
      tmp._newMonsterId = in_newMonsterId;
      tmp._num = in_num;
      tmp._pos = in_pos;
      tmp._power = in_power;
      tmp._size = in_size;
      tmp._standardLevel = in_standardLevel;
      tmp._time = in_time;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareBossElementsTemple> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareBossElementsTemple> _dataCaches = null;
    public static Dictionary<int, DeclareBossElementsTemple> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataBossElementsTemple");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataBossElementsTemple = require 'Lua/Config/DataBossElementsTemple'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataBossElementsTemple");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareBossElementsTemple>(44);
                     foreach (var item in dic)
                     {
                         DeclareBossElementsTemple tmp = new DeclareBossElementsTemple();
                       tmp.BossLevel = item.Value[0];
                       tmp.CanShow = item.Value[1];
                       tmp.CloneID = item.Value[2];
                       tmp.Drop = CfgStringLua.Get(item.Value[3]);
                       tmp.EnterLevel = item.Value[4];
                       tmp.Flag = CfgStringLua.Get(item.Value[5]);
                       tmp.FlagPos = CfgStringLua.Get(item.Value[6]);
                       tmp.HeadIcon = item.Value[7];
                       tmp.HostileElements = CfgStringLua.Get(item.Value[8]);
                       tmp.ID = item.Value[9];
                       tmp.Layer = item.Value[10];
                       tmp.LevelParameter = item.Value[11];
                       tmp.Mapsid = item.Value[12];
                       tmp.MonsterName = CfgStringLua.Get(item.Value[13]);
                       tmp.Monsterid = item.Value[14];
                       tmp.NewMonsterId = CfgStringLua.Get(item.Value[15]);
                       tmp.Num = item.Value[16];
                       tmp.Pos = CfgStringLua.Get(item.Value[17]);
                       tmp.Power = item.Value[18];
                       tmp.Size = item.Value[19];
                       tmp.StandardLevel = item.Value[20];
                       tmp.Time = item.Value[21];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"BossElementsTemple");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareBossElementsTemple>(44);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"BossElementsTemple");
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
    public static DeclareBossElementsTemple Get(int id)
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
    public static void Transform(Dictionary<int, DeclareBossElementsTemple> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
