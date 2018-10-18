//文件是自动生成,请勿手动修改.来自数据文件:FunctionStart
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareFunctionStart")]
  public class DeclareFunctionStart
  {
    #region //私有变量定义
    //功能id 主功能ID为10000到990000
    private int _function_id;
    //功能是否在跨服中显示
    private int _function_in_cross;
    //功能名称hide
    private string _function_name;
    //功能所在位置类型,0:主功能,1:顶层按钮,2:内部功能,3:顶部活动按钮（hide）
    private int _function_pos_type;
    //功能排序:针对技能按钮类型是用来选择技能按钮的(针对主功能按钮中,1,2,3表示的是左边,4,5,6表示的是右边,其他的值表示的是在中间)hide
    private int _function_sort_num;
    //图片名称hide
    private string _main_icon;
    //打开菜单，只在主菜单和顶部菜单的功能有效
    private int _open_menu;
    //父功能Id
    private int _parent_id;
    //开启需要的变量列表(变量取值参考FunctionVariable配置表)(@;@_@)
    private string _start_variables;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"FunctionId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int FunctionId { get{ return _function_id; } set{ _function_id=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"FunctionInCross", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int FunctionInCross { get{ return _function_in_cross; } set{ _function_in_cross=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"FunctionName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string FunctionName { get{ return _function_name; } set{ _function_name=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"FunctionPosType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int FunctionPosType { get{ return _function_pos_type; } set{ _function_pos_type=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"FunctionSortNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int FunctionSortNum { get{ return _function_sort_num; } set{ _function_sort_num=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"MainIcon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string MainIcon { get{ return _main_icon; } set{ _main_icon=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"OpenMenu", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OpenMenu { get{ return _open_menu; } set{ _open_menu=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"ParentId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ParentId { get{ return _parent_id; } set{ _parent_id=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"StartVariables", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string StartVariables { get{ return _start_variables; } set{ _start_variables=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareFunctionStart Create( int in_function_id, int in_function_in_cross, string in_function_name, int in_function_pos_type, int in_function_sort_num, string in_main_icon, int in_open_menu, int in_parent_id, string in_start_variables )
    {
      DeclareFunctionStart tmp = new DeclareFunctionStart();
      tmp._function_id = in_function_id;
      tmp._function_in_cross = in_function_in_cross;
      tmp._function_name = in_function_name;
      tmp._function_pos_type = in_function_pos_type;
      tmp._function_sort_num = in_function_sort_num;
      tmp._main_icon = in_main_icon;
      tmp._open_menu = in_open_menu;
      tmp._parent_id = in_parent_id;
      tmp._start_variables = in_start_variables;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareFunctionStart> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareFunctionStart> _dataCaches = null;
    public static Dictionary<int, DeclareFunctionStart> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataFunctionStart");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataFunctionStart = require 'Lua/Config/DataFunctionStart'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataFunctionStart");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareFunctionStart>(309);
                     foreach (var item in dic)
                     {
                         DeclareFunctionStart tmp = new DeclareFunctionStart();
                       tmp.FunctionId = item.Value[0];
                       tmp.FunctionInCross = item.Value[1];
                       tmp.FunctionName = CfgStringLua.Get(item.Value[2]);
                       tmp.FunctionPosType = item.Value[3];
                       tmp.FunctionSortNum = item.Value[4];
                       tmp.MainIcon = CfgStringLua.Get(item.Value[5]);
                       tmp.OpenMenu = item.Value[6];
                       tmp.ParentId = item.Value[7];
                       tmp.StartVariables = CfgStringLua.Get(item.Value[8]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"FunctionStart");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareFunctionStart>(309);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"FunctionStart");
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
    public static DeclareFunctionStart Get(int id)
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
    public static void Transform(Dictionary<int, DeclareFunctionStart> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
