//文件是自动生成,请勿手动修改.来自数据文件:guild_welfare
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareGuildWelfare")]
  public class DeclareGuildWelfare
  {
    #region //私有变量定义
    //按钮名称
    private string _button_name;
    //文字描述
    private string _describe;
    //按钮点击后效果
    private string _function;
    //活动时间（格式为 时：分_时：分；如果为0，那么就是没有开启时间，不做特殊显示处理）
    private string _item;
    //福利名称
    private string _name;
    //编号
    private int _num;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ButtonName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ButtonName { get{ return _button_name; } set{ _button_name=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Describe", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Describe { get{ return _describe; } set{ _describe=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Function", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Function { get{ return _function; } set{ _function=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Item { get{ return _item; } set{ _item=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Num { get{ return _num; } set{ _num=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareGuildWelfare Create( string in_button_name, string in_describe, string in_function, string in_item, string in_name, int in_num )
    {
      DeclareGuildWelfare tmp = new DeclareGuildWelfare();
      tmp._button_name = in_button_name;
      tmp._describe = in_describe;
      tmp._function = in_function;
      tmp._item = in_item;
      tmp._name = in_name;
      tmp._num = in_num;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareGuildWelfare> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareGuildWelfare> _dataCaches = null;
    public static Dictionary<int, DeclareGuildWelfare> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGuildWelfare");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataGuildWelfare = require 'Lua/Config/DataGuildWelfare'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGuildWelfare");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareGuildWelfare>(5);
                     foreach (var item in dic)
                     {
                         DeclareGuildWelfare tmp = new DeclareGuildWelfare();
                       tmp.ButtonName = CfgStringLua.Get(item.Value[0]);
                       tmp.Describe = CfgStringLua.Get(item.Value[1]);
                       tmp.Function = CfgStringLua.Get(item.Value[2]);
                       tmp.Item = CfgStringLua.Get(item.Value[3]);
                       tmp.Name = CfgStringLua.Get(item.Value[4]);
                       tmp.Num = item.Value[5];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"GuildWelfare");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareGuildWelfare>(5);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"GuildWelfare");
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
    public static DeclareGuildWelfare Get(int id)
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
    public static void Transform(Dictionary<int, DeclareGuildWelfare> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
