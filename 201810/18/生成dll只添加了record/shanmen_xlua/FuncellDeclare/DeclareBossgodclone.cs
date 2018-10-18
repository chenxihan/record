//文件是自动生成,请勿手动修改.来自数据文件:bossgodclone
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareBossgodclone")]
  public class DeclareBossgodclone
  {
    #region //私有变量定义
    //boss等级
    private int _bossLevel;
    //是否在列表中显示(0否1是)
    private int _canShow;
    //副本地图
    private int _cloneID;
    //是否为跨服（0否1是）
    private int _crossSever;
    //显示掉落(@;@)hide
    private string _drop;
    //掉落装备阶数 hide
    private int _dropEquipShow;
    //进入所需等级
    private int _enterLevel;
    //怪物头像 hide
    private int _head_icon;
    //编号ID
    private int _iD;
    //所在层数
    private int _layer;
    //刷新地图
    private int _mapsid;
    //怪物名称
    private string _monster_name;
    //怪物ID或采集物ID
    private int _monsterid;
    //刷新数量
    private int _num;
    //刷新坐标(@;@_@)1.随机坐标点；2固定坐标点；3固定坐标点；4固定坐标点
    private string _pos;
    //击杀累积天谴值
    private int _scourge;
    //显示的模型(hide)
    private int _show_model;
    //模型缩放hide
    private int _size;
    //类型1.宝箱；2.精英；3.隐藏BOSS；4.Boss
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"BossLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BossLevel { get{ return _bossLevel; } set{ _bossLevel=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"CanShow", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanShow { get{ return _canShow; } set{ _canShow=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"CloneID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CloneID { get{ return _cloneID; } set{ _cloneID=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"CrossSever", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CrossSever { get{ return _crossSever; } set{ _crossSever=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Drop", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Drop { get{ return _drop; } set{ _drop=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"DropEquipShow", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DropEquipShow { get{ return _dropEquipShow; } set{ _dropEquipShow=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"EnterLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int EnterLevel { get{ return _enterLevel; } set{ _enterLevel=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"HeadIcon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int HeadIcon { get{ return _head_icon; } set{ _head_icon=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID { get{ return _iD; } set{ _iD=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Layer", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Layer { get{ return _layer; } set{ _layer=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Mapsid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Mapsid { get{ return _mapsid; } set{ _mapsid=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"MonsterName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string MonsterName { get{ return _monster_name; } set{ _monster_name=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"Monsterid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Monsterid { get{ return _monsterid; } set{ _monsterid=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"Num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Num { get{ return _num; } set{ _num=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"Pos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Pos { get{ return _pos; } set{ _pos=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"Scourge", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Scourge { get{ return _scourge; } set{ _scourge=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"ShowModel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ShowModel { get{ return _show_model; } set{ _show_model=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"Size", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Size { get{ return _size; } set{ _size=value; } }
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareBossgodclone Create( int in_bossLevel, int in_canShow, int in_cloneID, int in_crossSever, string in_drop, int in_dropEquipShow, int in_enterLevel, int in_head_icon, int in_iD, int in_layer, int in_mapsid, string in_monster_name, int in_monsterid, int in_num, string in_pos, int in_scourge, int in_show_model, int in_size, int in_type )
    {
      DeclareBossgodclone tmp = new DeclareBossgodclone();
      tmp._bossLevel = in_bossLevel;
      tmp._canShow = in_canShow;
      tmp._cloneID = in_cloneID;
      tmp._crossSever = in_crossSever;
      tmp._drop = in_drop;
      tmp._dropEquipShow = in_dropEquipShow;
      tmp._enterLevel = in_enterLevel;
      tmp._head_icon = in_head_icon;
      tmp._iD = in_iD;
      tmp._layer = in_layer;
      tmp._mapsid = in_mapsid;
      tmp._monster_name = in_monster_name;
      tmp._monsterid = in_monsterid;
      tmp._num = in_num;
      tmp._pos = in_pos;
      tmp._scourge = in_scourge;
      tmp._show_model = in_show_model;
      tmp._size = in_size;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareBossgodclone> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareBossgodclone> _dataCaches = null;
    public static Dictionary<int, DeclareBossgodclone> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataBossgodclone");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataBossgodclone = require 'Lua/Config/DataBossgodclone'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataBossgodclone");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareBossgodclone>(15);
                     foreach (var item in dic)
                     {
                         DeclareBossgodclone tmp = new DeclareBossgodclone();
                       tmp.BossLevel = item.Value[0];
                       tmp.CanShow = item.Value[1];
                       tmp.CloneID = item.Value[2];
                       tmp.CrossSever = item.Value[3];
                       tmp.Drop = CfgStringLua.Get(item.Value[4]);
                       tmp.DropEquipShow = item.Value[5];
                       tmp.EnterLevel = item.Value[6];
                       tmp.HeadIcon = item.Value[7];
                       tmp.ID = item.Value[8];
                       tmp.Layer = item.Value[9];
                       tmp.Mapsid = item.Value[10];
                       tmp.MonsterName = CfgStringLua.Get(item.Value[11]);
                       tmp.Monsterid = item.Value[12];
                       tmp.Num = item.Value[13];
                       tmp.Pos = CfgStringLua.Get(item.Value[14]);
                       tmp.Scourge = item.Value[15];
                       tmp.ShowModel = item.Value[16];
                       tmp.Size = item.Value[17];
                       tmp.Type = item.Value[18];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Bossgodclone");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareBossgodclone>(15);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Bossgodclone");
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
    public static DeclareBossgodclone Get(int id)
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
    public static void Transform(Dictionary<int, DeclareBossgodclone> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
