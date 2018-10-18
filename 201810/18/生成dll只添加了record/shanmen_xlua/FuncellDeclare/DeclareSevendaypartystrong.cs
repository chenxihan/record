//文件是自动生成,请勿手动修改.来自数据文件:sevendaypartystrong
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareSevendaypartystrong")]
  public class DeclareSevendaypartystrong
  {
    #region //私有变量定义
    //副本group_id
    private int _cloneGroupID;
    //说明1
    private string _desc1;
    //图标
    private int _icon;
    //编号
    private int _id;
    //寻路NPC的ID(阵营ID_职业ID_NPCID;阵营ID_职业ID_NPCID)
    private string _npcID;
    //打开界面ID
    private int _openUI;
    //类型：1.打开界面、2找NPC
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"CloneGroupID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CloneGroupID { get{ return _cloneGroupID; } set{ _cloneGroupID=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Desc1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Desc1 { get{ return _desc1; } set{ _desc1=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"NpcID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string NpcID { get{ return _npcID; } set{ _npcID=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"OpenUI", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OpenUI { get{ return _openUI; } set{ _openUI=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareSevendaypartystrong Create( int in_cloneGroupID, string in_desc1, int in_icon, int in_id, string in_npcID, int in_openUI, int in_type )
    {
      DeclareSevendaypartystrong tmp = new DeclareSevendaypartystrong();
      tmp._cloneGroupID = in_cloneGroupID;
      tmp._desc1 = in_desc1;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._npcID = in_npcID;
      tmp._openUI = in_openUI;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareSevendaypartystrong> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareSevendaypartystrong> _dataCaches = null;
    public static Dictionary<int, DeclareSevendaypartystrong> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataSevendaypartystrong");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataSevendaypartystrong = require 'Lua/Config/DataSevendaypartystrong'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataSevendaypartystrong");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareSevendaypartystrong>(16);
                     foreach (var item in dic)
                     {
                         DeclareSevendaypartystrong tmp = new DeclareSevendaypartystrong();
                       tmp.CloneGroupID = item.Value[0];
                       tmp.Desc1 = CfgStringLua.Get(item.Value[1]);
                       tmp.Icon = item.Value[2];
                       tmp.Id = item.Value[3];
                       tmp.NpcID = CfgStringLua.Get(item.Value[4]);
                       tmp.OpenUI = item.Value[5];
                       tmp.Type = item.Value[6];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Sevendaypartystrong");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareSevendaypartystrong>(16);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Sevendaypartystrong");
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
    public static DeclareSevendaypartystrong Get(int id)
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
    public static void Transform(Dictionary<int, DeclareSevendaypartystrong> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
