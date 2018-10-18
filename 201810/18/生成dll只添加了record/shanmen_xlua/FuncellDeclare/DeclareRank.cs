//文件是自动生成,请勿手动修改.来自数据文件:Rank
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareRank")]
  public class DeclareRank
  {
    #region //私有变量定义
    //ID
    private int _id;
    //显示模型类型(1.玩家,2.坐骑,3.翅膀,4.宠物,5.器灵,6精灵球)
    private int _modelType;
    //排行榜名称
    private string _name;
    //父节点
    private int _parent;
    //服务器枚举值
    private int _serverEnum;
    //UI上数值的名称
    private string _uiValueDes;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"ModelType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ModelType { get{ return _modelType; } set{ _modelType=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Parent", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Parent { get{ return _parent; } set{ _parent=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"ServerEnum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ServerEnum { get{ return _serverEnum; } set{ _serverEnum=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"UiValueDes", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string UiValueDes { get{ return _uiValueDes; } set{ _uiValueDes=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareRank Create( int in_id, int in_modelType, string in_name, int in_parent, int in_serverEnum, string in_uiValueDes )
    {
      DeclareRank tmp = new DeclareRank();
      tmp._id = in_id;
      tmp._modelType = in_modelType;
      tmp._name = in_name;
      tmp._parent = in_parent;
      tmp._serverEnum = in_serverEnum;
      tmp._uiValueDes = in_uiValueDes;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareRank> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareRank> _dataCaches = null;
    public static Dictionary<int, DeclareRank> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataRank");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataRank = require 'Lua/Config/DataRank'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataRank");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareRank>(24);
                     foreach (var item in dic)
                     {
                         DeclareRank tmp = new DeclareRank();
                       tmp.Id = item.Value[0];
                       tmp.ModelType = item.Value[1];
                       tmp.Name = CfgStringLua.Get(item.Value[2]);
                       tmp.Parent = item.Value[3];
                       tmp.ServerEnum = item.Value[4];
                       tmp.UiValueDes = CfgStringLua.Get(item.Value[5]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Rank");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareRank>(24);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Rank");
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
    public static DeclareRank Get(int id)
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
    public static void Transform(Dictionary<int, DeclareRank> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
