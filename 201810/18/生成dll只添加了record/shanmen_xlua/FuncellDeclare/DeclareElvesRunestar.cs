//文件是自动生成,请勿手动修改.来自数据文件:elves_runestar
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareElvesRunestar")]
  public class DeclareElvesRunestar
  {
    #region //私有变量定义
    //属性值(@;@_@)
    private string _addAttribute;
    //自动消耗元宝数量
    private int _gold_num;
    //符文(符文类型*10000+等级*100+星级数量)
    private int _id;
    //道具数量
    private int _item_num;
    //进阶消耗物品
    private int _up_item;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"AddAttribute", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string AddAttribute { get{ return _addAttribute; } set{ _addAttribute=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"GoldNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int GoldNum { get{ return _gold_num; } set{ _gold_num=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"ItemNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ItemNum { get{ return _item_num; } set{ _item_num=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"UpItem", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UpItem { get{ return _up_item; } set{ _up_item=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareElvesRunestar Create( string in_addAttribute, int in_gold_num, int in_id, int in_item_num, int in_up_item )
    {
      DeclareElvesRunestar tmp = new DeclareElvesRunestar();
      tmp._addAttribute = in_addAttribute;
      tmp._gold_num = in_gold_num;
      tmp._id = in_id;
      tmp._item_num = in_item_num;
      tmp._up_item = in_up_item;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareElvesRunestar> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareElvesRunestar> _dataCaches = null;
    public static Dictionary<int, DeclareElvesRunestar> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataElvesRunestar");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataElvesRunestar = require 'Lua/Config/DataElvesRunestar'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataElvesRunestar");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareElvesRunestar>(660);
                     foreach (var item in dic)
                     {
                         DeclareElvesRunestar tmp = new DeclareElvesRunestar();
                       tmp.AddAttribute = CfgStringLua.Get(item.Value[0]);
                       tmp.GoldNum = item.Value[1];
                       tmp.Id = item.Value[2];
                       tmp.ItemNum = item.Value[3];
                       tmp.UpItem = item.Value[4];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"ElvesRunestar");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareElvesRunestar>(660);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"ElvesRunestar");
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
    public static DeclareElvesRunestar Get(int id)
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
    public static void Transform(Dictionary<int, DeclareElvesRunestar> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
