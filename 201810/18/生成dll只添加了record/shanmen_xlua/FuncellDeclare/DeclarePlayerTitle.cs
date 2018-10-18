//文件是自动生成,请勿手动修改.来自数据文件:PlayerTitle
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclarePlayerTitle")]
  public class DeclarePlayerTitle
  {
    #region //私有变量定义
    //激活分支（职业ID_分支ID_分支索引；职业ID_分支ID_分支索引）(@;@_@)
    private string _active_branch;
    //称号颜色(填写颜色表内ID)hide
    private string _color;
    //称号图标id(hide)
    private int _icon;
    //称号ID
    private int _id;
    //称号名称
    private string _name;
    //称号需求完成条件类型(@_@);
    private string _need;
    //需求战斗力
    private int _need_fight_power;
    //激活称号需求道具(@;@_@)
    private string _need_item;
    //需求特殊条件的描述hide
    private string _need_special_text;
    //是否公告1公告0否
    private int _notice;
    //称号需求前置称号,多个需求用分号隔开(@;@)
    private string _pre_title;
    //称号属性(@;@_@)
    private string _propetry;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ActiveBranch", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ActiveBranch { get{ return _active_branch; } set{ _active_branch=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Color", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Color { get{ return _color; } set{ _color=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Need", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Need { get{ return _need; } set{ _need=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"NeedFightPower", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NeedFightPower { get{ return _need_fight_power; } set{ _need_fight_power=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"NeedItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string NeedItem { get{ return _need_item; } set{ _need_item=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"NeedSpecialText", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string NeedSpecialText { get{ return _need_special_text; } set{ _need_special_text=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Notice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Notice { get{ return _notice; } set{ _notice=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"PreTitle", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string PreTitle { get{ return _pre_title; } set{ _pre_title=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"Propetry", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Propetry { get{ return _propetry; } set{ _propetry=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclarePlayerTitle Create( string in_active_branch, string in_color, int in_icon, int in_id, string in_name, string in_need, int in_need_fight_power, string in_need_item, string in_need_special_text, int in_notice, string in_pre_title, string in_propetry )
    {
      DeclarePlayerTitle tmp = new DeclarePlayerTitle();
      tmp._active_branch = in_active_branch;
      tmp._color = in_color;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._name = in_name;
      tmp._need = in_need;
      tmp._need_fight_power = in_need_fight_power;
      tmp._need_item = in_need_item;
      tmp._need_special_text = in_need_special_text;
      tmp._notice = in_notice;
      tmp._pre_title = in_pre_title;
      tmp._propetry = in_propetry;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclarePlayerTitle> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclarePlayerTitle> _dataCaches = null;
    public static Dictionary<int, DeclarePlayerTitle> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPlayerTitle");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataPlayerTitle = require 'Lua/Config/DataPlayerTitle'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPlayerTitle");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclarePlayerTitle>(20);
                     foreach (var item in dic)
                     {
                         DeclarePlayerTitle tmp = new DeclarePlayerTitle();
                       tmp.ActiveBranch = CfgStringLua.Get(item.Value[0]);
                       tmp.Color = CfgStringLua.Get(item.Value[1]);
                       tmp.Icon = item.Value[2];
                       tmp.Id = item.Value[3];
                       tmp.Name = CfgStringLua.Get(item.Value[4]);
                       tmp.Need = CfgStringLua.Get(item.Value[5]);
                       tmp.NeedFightPower = item.Value[6];
                       tmp.NeedItem = CfgStringLua.Get(item.Value[7]);
                       tmp.NeedSpecialText = CfgStringLua.Get(item.Value[8]);
                       tmp.Notice = item.Value[9];
                       tmp.PreTitle = CfgStringLua.Get(item.Value[10]);
                       tmp.Propetry = CfgStringLua.Get(item.Value[11]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"PlayerTitle");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclarePlayerTitle>(20);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"PlayerTitle");
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
    public static DeclarePlayerTitle Get(int id)
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
    public static void Transform(Dictionary<int, DeclarePlayerTitle> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
