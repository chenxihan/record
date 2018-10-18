//文件是自动生成,请勿手动修改.来自数据文件:shengwu_model
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareShengwuModel")]
  public class DeclareShengwuModel
  {
    #region //私有变量定义
    //激活增加属性(@;@_@)
    private string _active_attr;
    //激活材料id_数量(@;@_@)
    private string _active_item;
    //图标
    private int _icon;
    //圣器模型ID
    private int _id;
    //可培养次数
    private int _max_level;
    //激活成功是否公告（0不公告，1公告）
    private int _notice;
    //特效
    private int _res;
    //培养增加属性(@;@_@)
    private string _train_attr;
    //培养消耗材料编号_数量;材料编号_数量(@;@_@)
    private string _train_item;
    //UI上的特效
    private int _ui_Res;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ActiveAttr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ActiveAttr { get{ return _active_attr; } set{ _active_attr=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"ActiveItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ActiveItem { get{ return _active_item; } set{ _active_item=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"MaxLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MaxLevel { get{ return _max_level; } set{ _max_level=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Notice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Notice { get{ return _notice; } set{ _notice=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Res", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Res { get{ return _res; } set{ _res=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"TrainAttr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TrainAttr { get{ return _train_attr; } set{ _train_attr=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"TrainItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TrainItem { get{ return _train_item; } set{ _train_item=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"UiRes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UiRes { get{ return _ui_Res; } set{ _ui_Res=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareShengwuModel Create( string in_active_attr, string in_active_item, int in_icon, int in_id, int in_max_level, int in_notice, int in_res, string in_train_attr, string in_train_item, int in_ui_Res )
    {
      DeclareShengwuModel tmp = new DeclareShengwuModel();
      tmp._active_attr = in_active_attr;
      tmp._active_item = in_active_item;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._max_level = in_max_level;
      tmp._notice = in_notice;
      tmp._res = in_res;
      tmp._train_attr = in_train_attr;
      tmp._train_item = in_train_item;
      tmp._ui_Res = in_ui_Res;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareShengwuModel> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareShengwuModel> _dataCaches = null;
    public static Dictionary<int, DeclareShengwuModel> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataShengwuModel");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataShengwuModel = require 'Lua/Config/DataShengwuModel'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataShengwuModel");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareShengwuModel>(8);
                     foreach (var item in dic)
                     {
                         DeclareShengwuModel tmp = new DeclareShengwuModel();
                       tmp.ActiveAttr = CfgStringLua.Get(item.Value[0]);
                       tmp.ActiveItem = CfgStringLua.Get(item.Value[1]);
                       tmp.Icon = item.Value[2];
                       tmp.Id = item.Value[3];
                       tmp.MaxLevel = item.Value[4];
                       tmp.Notice = item.Value[5];
                       tmp.Res = item.Value[6];
                       tmp.TrainAttr = CfgStringLua.Get(item.Value[7]);
                       tmp.TrainItem = CfgStringLua.Get(item.Value[8]);
                       tmp.UiRes = item.Value[9];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"ShengwuModel");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareShengwuModel>(8);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"ShengwuModel");
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
    public static DeclareShengwuModel Get(int id)
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
    public static void Transform(Dictionary<int, DeclareShengwuModel> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
