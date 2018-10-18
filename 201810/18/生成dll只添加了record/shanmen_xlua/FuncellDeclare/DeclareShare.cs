//文件是自动生成,请勿手动修改.来自数据文件:share
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareShare")]
  public class DeclareShare
  {
    #region //私有变量定义
    //条件
    private int _condition;
    //次数
    private int _count;
    //描述
    private string _description;
    //ID(type*10000+cond)
    private int _id;
    //模型ID
    private int _modelId;
    //奖励物品id_数量(@;@_@)
    private string _rewards;
    //分享文本
    private string _text;
    //类型
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Condition", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Condition { get{ return _condition; } set{ _condition=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Count { get{ return _count; } set{ _count=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Description { get{ return _description; } set{ _description=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"ModelId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ModelId { get{ return _modelId; } set{ _modelId=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Rewards", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Rewards { get{ return _rewards; } set{ _rewards=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Text", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Text { get{ return _text; } set{ _text=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareShare Create( int in_condition, int in_count, string in_description, int in_id, int in_modelId, string in_rewards, string in_text, int in_type )
    {
      DeclareShare tmp = new DeclareShare();
      tmp._condition = in_condition;
      tmp._count = in_count;
      tmp._description = in_description;
      tmp._id = in_id;
      tmp._modelId = in_modelId;
      tmp._rewards = in_rewards;
      tmp._text = in_text;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareShare> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareShare> _dataCaches = null;
    public static Dictionary<int, DeclareShare> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataShare");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataShare = require 'Lua/Config/DataShare'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataShare");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareShare>(16);
                     foreach (var item in dic)
                     {
                         DeclareShare tmp = new DeclareShare();
                       tmp.Condition = item.Value[0];
                       tmp.Count = item.Value[1];
                       tmp.Description = CfgStringLua.Get(item.Value[2]);
                       tmp.Id = item.Value[3];
                       tmp.ModelId = item.Value[4];
                       tmp.Rewards = CfgStringLua.Get(item.Value[5]);
                       tmp.Text = CfgStringLua.Get(item.Value[6]);
                       tmp.Type = item.Value[7];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Share");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareShare>(16);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Share");
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
    public static DeclareShare Get(int id)
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
    public static void Transform(Dictionary<int, DeclareShare> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
