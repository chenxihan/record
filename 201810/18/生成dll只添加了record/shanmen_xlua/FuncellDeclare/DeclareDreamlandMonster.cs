//文件是自动生成,请勿手动修改.来自数据文件:dreamland_monster
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareDreamlandMonster")]
  public class DeclareDreamlandMonster
  {
    #region //私有变量定义
    //刷新副本地图
    private int _clone_map;
    //显示掉落(职业ID_道具ID)(@;@_@)
    private string _drop;
    //掉落装备阶数
    private int _dropEquipShow;
    //编号ID(怪物ID*1000+刷新地图)
    private int _iD;
    //刷新地图
    private int _mapsid;
    //模型旋转hide
    private int _model_rotat;
    //怪物贴图(hide)
    private int _monster_picture;
    //怪物ID
    private int _monsterid;
    //刷新坐标(@;@_@)
    private string _pos;
    //是否屏蔽（0为不屏蔽，1为屏蔽）
    private int _shielding;
    //模型缩放
    private int _size;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"CloneMap", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CloneMap { get{ return _clone_map; } set{ _clone_map=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Drop", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Drop { get{ return _drop; } set{ _drop=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"DropEquipShow", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DropEquipShow { get{ return _dropEquipShow; } set{ _dropEquipShow=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID { get{ return _iD; } set{ _iD=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Mapsid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Mapsid { get{ return _mapsid; } set{ _mapsid=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"ModelRotat", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ModelRotat { get{ return _model_rotat; } set{ _model_rotat=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"MonsterPicture", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MonsterPicture { get{ return _monster_picture; } set{ _monster_picture=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Monsterid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Monsterid { get{ return _monsterid; } set{ _monsterid=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Pos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Pos { get{ return _pos; } set{ _pos=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Shielding", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Shielding { get{ return _shielding; } set{ _shielding=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Size", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Size { get{ return _size; } set{ _size=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareDreamlandMonster Create( int in_clone_map, string in_drop, int in_dropEquipShow, int in_iD, int in_mapsid, int in_model_rotat, int in_monster_picture, int in_monsterid, string in_pos, int in_shielding, int in_size )
    {
      DeclareDreamlandMonster tmp = new DeclareDreamlandMonster();
      tmp._clone_map = in_clone_map;
      tmp._drop = in_drop;
      tmp._dropEquipShow = in_dropEquipShow;
      tmp._iD = in_iD;
      tmp._mapsid = in_mapsid;
      tmp._model_rotat = in_model_rotat;
      tmp._monster_picture = in_monster_picture;
      tmp._monsterid = in_monsterid;
      tmp._pos = in_pos;
      tmp._shielding = in_shielding;
      tmp._size = in_size;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareDreamlandMonster> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareDreamlandMonster> _dataCaches = null;
    public static Dictionary<int, DeclareDreamlandMonster> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataDreamlandMonster");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataDreamlandMonster = require 'Lua/Config/DataDreamlandMonster'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataDreamlandMonster");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareDreamlandMonster>(41);
                     foreach (var item in dic)
                     {
                         DeclareDreamlandMonster tmp = new DeclareDreamlandMonster();
                       tmp.CloneMap = item.Value[0];
                       tmp.Drop = CfgStringLua.Get(item.Value[1]);
                       tmp.DropEquipShow = item.Value[2];
                       tmp.ID = item.Value[3];
                       tmp.Mapsid = item.Value[4];
                       tmp.ModelRotat = item.Value[5];
                       tmp.MonsterPicture = item.Value[6];
                       tmp.Monsterid = item.Value[7];
                       tmp.Pos = CfgStringLua.Get(item.Value[8]);
                       tmp.Shielding = item.Value[9];
                       tmp.Size = item.Value[10];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"DreamlandMonster");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareDreamlandMonster>(41);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"DreamlandMonster");
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
    public static DeclareDreamlandMonster Get(int id)
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
    public static void Transform(Dictionary<int, DeclareDreamlandMonster> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
