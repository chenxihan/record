//文件是自动生成,请勿手动修改.来自数据文件:PowerAnalysis
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclarePowerAnalysis")]
  public class DeclarePowerAnalysis
  {
    #region //私有变量定义
    //副本group_id
    private int _cloneGroupID;
    //所属分组（1.我要变强；2.我要经验；3.我要金币4.我要代币；5.我要装备；6.我要材料）
    private int _group;
    //图标
    private int _icon;
    //功能id
    private int _iD;
    //玩家等级
    private string _level;
    //寻路NPC的ID(阵营ID_职业ID_NPCID;阵营ID_职业ID_NPCID)
    private string _npcID;
    //打开商店标签页ID
    private int _openShop;
    //打开界面ID
    private int _openUI;
    //参数1
    private int _parameter1;
    //参数2
    private string _parameter2;
    //说明
    private string _product;
    //推荐星级
    private int _star;
    //条件分类
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"CloneGroupID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CloneGroupID { get{ return _cloneGroupID; } set{ _cloneGroupID=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Group", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Group { get{ return _group; } set{ _group=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID { get{ return _iD; } set{ _iD=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"NpcID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string NpcID { get{ return _npcID; } set{ _npcID=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"OpenShop", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OpenShop { get{ return _openShop; } set{ _openShop=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"OpenUI", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OpenUI { get{ return _openUI; } set{ _openUI=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Parameter1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Parameter1 { get{ return _parameter1; } set{ _parameter1=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Parameter2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Parameter2 { get{ return _parameter2; } set{ _parameter2=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Product", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Product { get{ return _product; } set{ _product=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"Star", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Star { get{ return _star; } set{ _star=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclarePowerAnalysis Create( int in_cloneGroupID, int in_group, int in_icon, int in_iD, string in_level, string in_npcID, int in_openShop, int in_openUI, int in_parameter1, string in_parameter2, string in_product, int in_star, int in_type )
    {
      DeclarePowerAnalysis tmp = new DeclarePowerAnalysis();
      tmp._cloneGroupID = in_cloneGroupID;
      tmp._group = in_group;
      tmp._icon = in_icon;
      tmp._iD = in_iD;
      tmp._level = in_level;
      tmp._npcID = in_npcID;
      tmp._openShop = in_openShop;
      tmp._openUI = in_openUI;
      tmp._parameter1 = in_parameter1;
      tmp._parameter2 = in_parameter2;
      tmp._product = in_product;
      tmp._star = in_star;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclarePowerAnalysis> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclarePowerAnalysis> _dataCaches = null;
    public static Dictionary<int, DeclarePowerAnalysis> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPowerAnalysis");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataPowerAnalysis = require 'Lua/Config/DataPowerAnalysis'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPowerAnalysis");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclarePowerAnalysis>(172);
                     foreach (var item in dic)
                     {
                         DeclarePowerAnalysis tmp = new DeclarePowerAnalysis();
                       tmp.CloneGroupID = item.Value[0];
                       tmp.Group = item.Value[1];
                       tmp.Icon = item.Value[2];
                       tmp.ID = item.Value[3];
                       tmp.Level = CfgStringLua.Get(item.Value[4]);
                       tmp.NpcID = CfgStringLua.Get(item.Value[5]);
                       tmp.OpenShop = item.Value[6];
                       tmp.OpenUI = item.Value[7];
                       tmp.Parameter1 = item.Value[8];
                       tmp.Parameter2 = CfgStringLua.Get(item.Value[9]);
                       tmp.Product = CfgStringLua.Get(item.Value[10]);
                       tmp.Star = item.Value[11];
                       tmp.Type = item.Value[12];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"PowerAnalysis");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclarePowerAnalysis>(172);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"PowerAnalysis");
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
    public static DeclarePowerAnalysis Get(int id)
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
    public static void Transform(Dictionary<int, DeclarePowerAnalysis> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
