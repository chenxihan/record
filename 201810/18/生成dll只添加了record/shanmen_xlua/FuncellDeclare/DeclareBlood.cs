//文件是自动生成,请勿手动修改.来自数据文件:blood
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareBlood")]
  public class DeclareBlood
  {
    #region //私有变量定义
    //本级属性(@;@_@)
    private string _attr;
    //龙脉加成（百分比）
    private int _attr_add;
    //进阶属性(@;@_@)
    private string _attr_levelup;
    //血脉ID_等级
    private string _id;
    //进阶后下一等级的Id(@_@)
    private string _next_level;
    //进阶下一级成功是否全服公告（0不公告，1公告）
    private int _notice;
    //x,y,z
    private string _pos;
    //进阶消耗物品及数量(格式;物品ID，数量；物品ID，数量【是或】）(@;@_@)
    private string _up_item_info;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Attr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Attr { get{ return _attr; } set{ _attr=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"AttrAdd", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int AttrAdd { get{ return _attr_add; } set{ _attr_add=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"AttrLevelup", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string AttrLevelup { get{ return _attr_levelup; } set{ _attr_levelup=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"NextLevel", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string NextLevel { get{ return _next_level; } set{ _next_level=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Notice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Notice { get{ return _notice; } set{ _notice=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Pos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Pos { get{ return _pos; } set{ _pos=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"UpItemInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string UpItemInfo { get{ return _up_item_info; } set{ _up_item_info=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareBlood Create( string in_attr, int in_attr_add, string in_attr_levelup, string in_id, string in_next_level, int in_notice, string in_pos, string in_up_item_info )
    {
      DeclareBlood tmp = new DeclareBlood();
      tmp._attr = in_attr;
      tmp._attr_add = in_attr_add;
      tmp._attr_levelup = in_attr_levelup;
      tmp._id = in_id;
      tmp._next_level = in_next_level;
      tmp._notice = in_notice;
      tmp._pos = in_pos;
      tmp._up_item_info = in_up_item_info;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<string, DeclareBlood> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<string, DeclareBlood> _dataCaches = null;
    public static Dictionary<string, DeclareBlood> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataBlood");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataBlood = require 'Lua/Config/DataBlood'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataBlood");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<string, DeclareBlood>(101);
                     foreach (var item in dic)
                     {
                         DeclareBlood tmp = new DeclareBlood();
                       tmp.Attr = CfgStringLua.Get(item.Value[0]);
                       tmp.AttrAdd = item.Value[1];
                       tmp.AttrLevelup = CfgStringLua.Get(item.Value[2]);
                       tmp.Id = CfgStringLua.Get(item.Value[3]);
                       tmp.NextLevel = CfgStringLua.Get(item.Value[4]);
                       tmp.Notice = item.Value[5];
                       tmp.Pos = CfgStringLua.Get(item.Value[6]);
                       tmp.UpItemInfo = CfgStringLua.Get(item.Value[7]);

                         _dataCaches.Add(CfgStringLua.Get(item.Key), tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Blood");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<string, DeclareBlood>(101);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Blood");
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
    public static DeclareBlood Get(string id)
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
    public static void Transform(Dictionary<string, DeclareBlood> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
