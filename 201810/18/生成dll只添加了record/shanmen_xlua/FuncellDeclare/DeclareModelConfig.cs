//文件是自动生成,请勿手动修改.来自数据文件:ModelConfig
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareModelConfig")]
  public class DeclareModelConfig
  {
    #region //私有变量定义
    //当前模型适用的状态(1:出生,2:被击,4:死亡,8:霸体),多个状态同时有效可以叠加
    private int _applyStatus;
    //外观ID
    private int _id;
    //设置当前模型使用展示模型
    private int _isShow;
    //用于替换主纹理
    private string _main_textrue;
    //用于替换mask纹理
    private string _mask_textrue;
    //使用的模型ID(位数不得大于5位数)
    private int _model;
    //勾边参数, 颜色RGB;钩边大小
    private string _out_line_param;
    //使用的shader，0默认shader（不需要参数），1流光shader（参数1位纹理，参数2为颜色，参数3为方向，参数4为流动速度,参数5为贴图的平铺数量），2模型高光效果（参数1为power[50-800]，参数2为RGB）,3.消融效果,4.半透效果(参数1:颜色255_255_255_255)6:仿真效果,7:环境光效果(参数1:Cube纹理名字) 8:新流光效果(参数1:流光纹理,参数2:颜色,参数3:颜色2,参数4:流动速度)
    private int _shader;
    //sharder参数1
    private string _sharder_param1;
    //sharder参数2
    private string _sharder_param2;
    //sharder参数3
    private string _sharder_param3;
    //sharder参数4
    private string _sharder_param4;
    //sharder参数5
    private string _sharder_param5;
    //模型类型：1玩家身体，2玩家武器，3玩家翅膀，4玩家坐骑，5怪物，6采集物，7强化特效，8.掉落模型,99,其他模型
    private int _type;
    //使用的特效：绑定点_特效ID_开始颜色_结束颜色
    private string _vfx_1;
    //使用的特效：绑定点_特效ID_开始颜色_结束颜色
    private string _vfx_2;
    //使用的特效：绑定点_特效ID_开始颜色_结束颜色
    private string _vfx_3;
    //使用的特效：绑定点_特效ID_开始颜色_结束颜色
    private string _vfx_4;
    //使用的特效：绑定点_特效ID_开始颜色_结束颜色
    private string _vfx_5;
    //特效type
    //301为转职特效其他的全部填-1
    private int _vfx_type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ApplyStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ApplyStatus { get{ return _applyStatus; } set{ _applyStatus=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"IsShow", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int IsShow { get{ return _isShow; } set{ _isShow=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"MainTextrue", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string MainTextrue { get{ return _main_textrue; } set{ _main_textrue=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"MaskTextrue", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string MaskTextrue { get{ return _mask_textrue; } set{ _mask_textrue=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Model", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Model { get{ return _model; } set{ _model=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"OutLineParam", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OutLineParam { get{ return _out_line_param; } set{ _out_line_param=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Shader", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Shader { get{ return _shader; } set{ _shader=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"SharderParam1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SharderParam1 { get{ return _sharder_param1; } set{ _sharder_param1=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"SharderParam2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SharderParam2 { get{ return _sharder_param2; } set{ _sharder_param2=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"SharderParam3", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SharderParam3 { get{ return _sharder_param3; } set{ _sharder_param3=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"SharderParam4", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SharderParam4 { get{ return _sharder_param4; } set{ _sharder_param4=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"SharderParam5", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SharderParam5 { get{ return _sharder_param5; } set{ _sharder_param5=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"Vfx1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Vfx1 { get{ return _vfx_1; } set{ _vfx_1=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"Vfx2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Vfx2 { get{ return _vfx_2; } set{ _vfx_2=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"Vfx3", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Vfx3 { get{ return _vfx_3; } set{ _vfx_3=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"Vfx4", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Vfx4 { get{ return _vfx_4; } set{ _vfx_4=value; } }
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"Vfx5", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Vfx5 { get{ return _vfx_5; } set{ _vfx_5=value; } }
    [global::ProtoBuf.ProtoMember(20, IsRequired = true, Name=@"VfxType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int VfxType { get{ return _vfx_type; } set{ _vfx_type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareModelConfig Create( int in_applyStatus, int in_id, int in_isShow, string in_main_textrue, string in_mask_textrue, int in_model, string in_out_line_param, int in_shader, string in_sharder_param1, string in_sharder_param2, string in_sharder_param3, string in_sharder_param4, string in_sharder_param5, int in_type, string in_vfx_1, string in_vfx_2, string in_vfx_3, string in_vfx_4, string in_vfx_5, int in_vfx_type )
    {
      DeclareModelConfig tmp = new DeclareModelConfig();
      tmp._applyStatus = in_applyStatus;
      tmp._id = in_id;
      tmp._isShow = in_isShow;
      tmp._main_textrue = in_main_textrue;
      tmp._mask_textrue = in_mask_textrue;
      tmp._model = in_model;
      tmp._out_line_param = in_out_line_param;
      tmp._shader = in_shader;
      tmp._sharder_param1 = in_sharder_param1;
      tmp._sharder_param2 = in_sharder_param2;
      tmp._sharder_param3 = in_sharder_param3;
      tmp._sharder_param4 = in_sharder_param4;
      tmp._sharder_param5 = in_sharder_param5;
      tmp._type = in_type;
      tmp._vfx_1 = in_vfx_1;
      tmp._vfx_2 = in_vfx_2;
      tmp._vfx_3 = in_vfx_3;
      tmp._vfx_4 = in_vfx_4;
      tmp._vfx_5 = in_vfx_5;
      tmp._vfx_type = in_vfx_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareModelConfig> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareModelConfig> _dataCaches = null;
    public static Dictionary<int, DeclareModelConfig> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataModelConfig");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataModelConfig = require 'Lua/Config/DataModelConfig'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataModelConfig");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareModelConfig>(15057);
                     foreach (var item in dic)
                     {
                         DeclareModelConfig tmp = new DeclareModelConfig();
                       tmp.ApplyStatus = item.Value[0];
                       tmp.Id = item.Value[1];
                       tmp.IsShow = item.Value[2];
                       tmp.MainTextrue = CfgStringLua.Get(item.Value[3]);
                       tmp.MaskTextrue = CfgStringLua.Get(item.Value[4]);
                       tmp.Model = item.Value[5];
                       tmp.OutLineParam = CfgStringLua.Get(item.Value[6]);
                       tmp.Shader = item.Value[7];
                       tmp.SharderParam1 = CfgStringLua.Get(item.Value[8]);
                       tmp.SharderParam2 = CfgStringLua.Get(item.Value[9]);
                       tmp.SharderParam3 = CfgStringLua.Get(item.Value[10]);
                       tmp.SharderParam4 = CfgStringLua.Get(item.Value[11]);
                       tmp.SharderParam5 = CfgStringLua.Get(item.Value[12]);
                       tmp.Type = item.Value[13];
                       tmp.Vfx1 = CfgStringLua.Get(item.Value[14]);
                       tmp.Vfx2 = CfgStringLua.Get(item.Value[15]);
                       tmp.Vfx3 = CfgStringLua.Get(item.Value[16]);
                       tmp.Vfx4 = CfgStringLua.Get(item.Value[17]);
                       tmp.Vfx5 = CfgStringLua.Get(item.Value[18]);
                       tmp.VfxType = item.Value[19];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"ModelConfig");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareModelConfig>(15057);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"ModelConfig");
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
    public static DeclareModelConfig Get(int id)
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
    public static void Transform(Dictionary<int, DeclareModelConfig> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
