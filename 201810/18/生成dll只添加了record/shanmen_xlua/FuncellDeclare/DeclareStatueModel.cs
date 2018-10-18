//文件是自动生成,请勿手动修改.来自数据文件:statue_model
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareStatueModel")]
  public class DeclareStatueModel
  {
    #region //私有变量定义
    //方向
    private int _dirX;
    //方向
    private int _dirY;
    //Statue编号
    private int _id;
    //地图ID
    private int _mapid;
    //执笔之灵
    private int _model_1;
    //龙魂圣拳
    private int _model_2;
    //圣临战锤
    private int _model_3;
    //疾风剑客
    private int _model_4;
    //卡牌大师
    private int _model_5;
    //皇家枪手
    private int _model_6;
    //默认显示NPC
    private int _npcid;
    //模型缩放（百分比）
    private int _size_scale;
    //类型（1为首席雕像、2为公会雕像、3为圣天城雕像）
    private int _type;
    //坐标x
    private int _x;
    //坐标y
    private int _y;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"DirX", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DirX { get{ return _dirX; } set{ _dirX=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"DirY", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DirY { get{ return _dirY; } set{ _dirY=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Mapid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Mapid { get{ return _mapid; } set{ _mapid=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Model1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Model1 { get{ return _model_1; } set{ _model_1=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Model2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Model2 { get{ return _model_2; } set{ _model_2=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Model3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Model3 { get{ return _model_3; } set{ _model_3=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Model4", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Model4 { get{ return _model_4; } set{ _model_4=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Model5", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Model5 { get{ return _model_5; } set{ _model_5=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Model6", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Model6 { get{ return _model_6; } set{ _model_6=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Npcid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Npcid { get{ return _npcid; } set{ _npcid=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"SizeScale", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SizeScale { get{ return _size_scale; } set{ _size_scale=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"X", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int X { get{ return _x; } set{ _x=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"Y", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Y { get{ return _y; } set{ _y=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareStatueModel Create( int in_dirX, int in_dirY, int in_id, int in_mapid, int in_model_1, int in_model_2, int in_model_3, int in_model_4, int in_model_5, int in_model_6, int in_npcid, int in_size_scale, int in_type, int in_x, int in_y )
    {
      DeclareStatueModel tmp = new DeclareStatueModel();
      tmp._dirX = in_dirX;
      tmp._dirY = in_dirY;
      tmp._id = in_id;
      tmp._mapid = in_mapid;
      tmp._model_1 = in_model_1;
      tmp._model_2 = in_model_2;
      tmp._model_3 = in_model_3;
      tmp._model_4 = in_model_4;
      tmp._model_5 = in_model_5;
      tmp._model_6 = in_model_6;
      tmp._npcid = in_npcid;
      tmp._size_scale = in_size_scale;
      tmp._type = in_type;
      tmp._x = in_x;
      tmp._y = in_y;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareStatueModel> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareStatueModel> _dataCaches = null;
    public static Dictionary<int, DeclareStatueModel> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataStatueModel");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataStatueModel = require 'Lua/Config/DataStatueModel'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataStatueModel");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareStatueModel>(14);
                     foreach (var item in dic)
                     {
                         DeclareStatueModel tmp = new DeclareStatueModel();
                       tmp.DirX = item.Value[0];
                       tmp.DirY = item.Value[1];
                       tmp.Id = item.Value[2];
                       tmp.Mapid = item.Value[3];
                       tmp.Model1 = item.Value[4];
                       tmp.Model2 = item.Value[5];
                       tmp.Model3 = item.Value[6];
                       tmp.Model4 = item.Value[7];
                       tmp.Model5 = item.Value[8];
                       tmp.Model6 = item.Value[9];
                       tmp.Npcid = item.Value[10];
                       tmp.SizeScale = item.Value[11];
                       tmp.Type = item.Value[12];
                       tmp.X = item.Value[13];
                       tmp.Y = item.Value[14];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"StatueModel");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareStatueModel>(14);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"StatueModel");
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
    public static DeclareStatueModel Get(int id)
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
    public static void Transform(Dictionary<int, DeclareStatueModel> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
