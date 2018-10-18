//文件是自动生成,请勿手动修改.来自数据文件:shenwu_addatt
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareShenwuAddatt")]
  public class DeclareShenwuAddatt
  {
    #region //私有变量定义
    //增加属性(@;@_@)
    private string _attribute;
    //增加战力
    private int _fightnum;
    //符石ID
    private int _id;
    //物品ID
    private int _item_id;
    //使用等级上限对应各个功能(@;@_@)
    private string _leve_limit;
    //神物类型(1.翅膀，2.坐骑，3.器灵，4.封印,5献祭,6仙丹，7圣物）
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Attribute", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Attribute { get{ return _attribute; } set{ _attribute=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Fightnum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Fightnum { get{ return _fightnum; } set{ _fightnum=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"ItemId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ItemId { get{ return _item_id; } set{ _item_id=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"LeveLimit", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string LeveLimit { get{ return _leve_limit; } set{ _leve_limit=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareShenwuAddatt Create( string in_attribute, int in_fightnum, int in_id, int in_item_id, string in_leve_limit, int in_type )
    {
      DeclareShenwuAddatt tmp = new DeclareShenwuAddatt();
      tmp._attribute = in_attribute;
      tmp._fightnum = in_fightnum;
      tmp._id = in_id;
      tmp._item_id = in_item_id;
      tmp._leve_limit = in_leve_limit;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareShenwuAddatt> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareShenwuAddatt> _dataCaches = null;
    public static Dictionary<int, DeclareShenwuAddatt> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataShenwuAddatt");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataShenwuAddatt = require 'Lua/Config/DataShenwuAddatt'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataShenwuAddatt");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareShenwuAddatt>(18);
                     foreach (var item in dic)
                     {
                         DeclareShenwuAddatt tmp = new DeclareShenwuAddatt();
                       tmp.Attribute = CfgStringLua.Get(item.Value[0]);
                       tmp.Fightnum = item.Value[1];
                       tmp.Id = item.Value[2];
                       tmp.ItemId = item.Value[3];
                       tmp.LeveLimit = CfgStringLua.Get(item.Value[4]);
                       tmp.Type = item.Value[5];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"ShenwuAddatt");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareShenwuAddatt>(18);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"ShenwuAddatt");
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
    public static DeclareShenwuAddatt Get(int id)
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
    public static void Transform(Dictionary<int, DeclareShenwuAddatt> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
