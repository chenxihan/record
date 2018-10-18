//文件是自动生成,请勿手动修改.来自数据文件:fashion
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareFashion")]
  public class DeclareFashion
  {
    #region //私有变量定义
    //激活时装获得属性(@;@_@)
    private string _active_att;
    //激活消耗材料编号_数量;材料编号_数量(@;@_@)
    private string _active_item;
    //激活需要完成任务(@_@)
    private string _active_task;
    //是否在列表中显示(0否1是)
    private int _canshow;
    //头像资源编号（职业ID_道具ID）0-执笔者
    //1-拳师2-大锤3-太刀4-卡牌5-枪手9-通用
    private string _head;
    //时装ID
    private int _id;
    //时装名称
    private string _name;
    //激活成功是否公告（0不公告，1公告）
    private int _notice;
    //填写试用期时常，以分钟为单位
    private int _probation;
    //时装资源
    private string _res;
    //强化属性(@;@_@)
    private string _strengthening_att;
    //强化消耗(@;@_@)
    private string _strengthening_item;
    //强化等级上限
    private int _strengthening_level;
    //时装类型（0身体，1武器）
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ActiveAtt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ActiveAtt { get{ return _active_att; } set{ _active_att=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"ActiveItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ActiveItem { get{ return _active_item; } set{ _active_item=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"ActiveTask", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ActiveTask { get{ return _active_task; } set{ _active_task=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Canshow", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Canshow { get{ return _canshow; } set{ _canshow=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Head", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Head { get{ return _head; } set{ _head=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Notice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Notice { get{ return _notice; } set{ _notice=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Probation", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Probation { get{ return _probation; } set{ _probation=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Res", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Res { get{ return _res; } set{ _res=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"StrengtheningAtt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string StrengtheningAtt { get{ return _strengthening_att; } set{ _strengthening_att=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"StrengtheningItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string StrengtheningItem { get{ return _strengthening_item; } set{ _strengthening_item=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"StrengtheningLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int StrengtheningLevel { get{ return _strengthening_level; } set{ _strengthening_level=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareFashion Create( string in_active_att, string in_active_item, string in_active_task, int in_canshow, string in_head, int in_id, string in_name, int in_notice, int in_probation, string in_res, string in_strengthening_att, string in_strengthening_item, int in_strengthening_level, int in_type )
    {
      DeclareFashion tmp = new DeclareFashion();
      tmp._active_att = in_active_att;
      tmp._active_item = in_active_item;
      tmp._active_task = in_active_task;
      tmp._canshow = in_canshow;
      tmp._head = in_head;
      tmp._id = in_id;
      tmp._name = in_name;
      tmp._notice = in_notice;
      tmp._probation = in_probation;
      tmp._res = in_res;
      tmp._strengthening_att = in_strengthening_att;
      tmp._strengthening_item = in_strengthening_item;
      tmp._strengthening_level = in_strengthening_level;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareFashion> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareFashion> _dataCaches = null;
    public static Dictionary<int, DeclareFashion> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataFashion");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataFashion = require 'Lua/Config/DataFashion'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataFashion");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareFashion>(34);
                     foreach (var item in dic)
                     {
                         DeclareFashion tmp = new DeclareFashion();
                       tmp.ActiveAtt = CfgStringLua.Get(item.Value[0]);
                       tmp.ActiveItem = CfgStringLua.Get(item.Value[1]);
                       tmp.ActiveTask = CfgStringLua.Get(item.Value[2]);
                       tmp.Canshow = item.Value[3];
                       tmp.Head = CfgStringLua.Get(item.Value[4]);
                       tmp.Id = item.Value[5];
                       tmp.Name = CfgStringLua.Get(item.Value[6]);
                       tmp.Notice = item.Value[7];
                       tmp.Probation = item.Value[8];
                       tmp.Res = CfgStringLua.Get(item.Value[9]);
                       tmp.StrengtheningAtt = CfgStringLua.Get(item.Value[10]);
                       tmp.StrengtheningItem = CfgStringLua.Get(item.Value[11]);
                       tmp.StrengtheningLevel = item.Value[12];
                       tmp.Type = item.Value[13];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Fashion");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareFashion>(34);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Fashion");
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
    public static DeclareFashion Get(int id)
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
    public static void Transform(Dictionary<int, DeclareFashion> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
