//文件是自动生成,请勿手动修改.来自数据文件:achievement
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareAchievement")]
  public class DeclareAchievement
  {
    #region //私有变量定义
    //完成获得的成就值
    private int _addAchievement;
    //完成获得绑定元宝
    private int _addBindGold;
    //大分类类型hide
    private int _bigType;
    //成就类型(@_@)
    private string _condition;
    //key值
    private int _id;
    //成就内容说明hide
    private string _instructions;
    //奖励的道具(@;@_@)
    private string _item;
    //返回平台ID
    private string _krSDKUse;
    //成就名称hide
    private string _name;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"AddAchievement", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int AddAchievement { get{ return _addAchievement; } set{ _addAchievement=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"AddBindGold", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int AddBindGold { get{ return _addBindGold; } set{ _addBindGold=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"BigType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BigType { get{ return _bigType; } set{ _bigType=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Condition", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Condition { get{ return _condition; } set{ _condition=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Instructions", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Instructions { get{ return _instructions; } set{ _instructions=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Item { get{ return _item; } set{ _item=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"KrSDKUse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string KrSDKUse { get{ return _krSDKUse; } set{ _krSDKUse=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareAchievement Create( int in_addAchievement, int in_addBindGold, int in_bigType, string in_condition, int in_id, string in_instructions, string in_item, string in_krSDKUse, string in_name )
    {
      DeclareAchievement tmp = new DeclareAchievement();
      tmp._addAchievement = in_addAchievement;
      tmp._addBindGold = in_addBindGold;
      tmp._bigType = in_bigType;
      tmp._condition = in_condition;
      tmp._id = in_id;
      tmp._instructions = in_instructions;
      tmp._item = in_item;
      tmp._krSDKUse = in_krSDKUse;
      tmp._name = in_name;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareAchievement> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareAchievement> _dataCaches = null;
    public static Dictionary<int, DeclareAchievement> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataAchievement");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataAchievement = require 'Lua/Config/DataAchievement'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataAchievement");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareAchievement>(198);
                     foreach (var item in dic)
                     {
                         DeclareAchievement tmp = new DeclareAchievement();
                       tmp.AddAchievement = item.Value[0];
                       tmp.AddBindGold = item.Value[1];
                       tmp.BigType = item.Value[2];
                       tmp.Condition = CfgStringLua.Get(item.Value[3]);
                       tmp.Id = item.Value[4];
                       tmp.Instructions = CfgStringLua.Get(item.Value[5]);
                       tmp.Item = CfgStringLua.Get(item.Value[6]);
                       tmp.KrSDKUse = CfgStringLua.Get(item.Value[7]);
                       tmp.Name = CfgStringLua.Get(item.Value[8]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Achievement");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareAchievement>(198);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Achievement");
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
    public static DeclareAchievement Get(int id)
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
    public static void Transform(Dictionary<int, DeclareAchievement> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
