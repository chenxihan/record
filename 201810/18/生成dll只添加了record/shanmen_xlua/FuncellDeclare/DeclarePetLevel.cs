//文件是自动生成,请勿手动修改.来自数据文件:pet_level
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclarePetLevel")]
  public class DeclarePetLevel
  {
    #region //私有变量定义
    //本级的属性(宠物在本级的基础属性)(@;@_@)
    private string _attribute;
    //在伙伴界面中伙伴模型显示缩放（默认为100）(hide)
    private int _camera_size;
    //消耗的道具(道具ID_数量；道具ID_数量)(第0级表示激活需求的道具，其他都为升级需要的道具)(@;@_@)
    private string _const_item;
    //等级 = 宠物ID*1000 + 等级
    private int _id;
    //继承比例（百分比）
    private int _inherit_proportion;
    //等级
    private int _level;
    //模型ID(hide)
    private int _model_res;
    //1白色，2绿色，3蓝色，4紫色，5橙色，6金色，7红色
    private int _quality;
    //场景中伙伴的模型大小缩放（默认为100）(hide)
    private int _scene_scale;
    //伙伴激活时模型缩放(hide)
    private int _showmodel_camera_size;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Attribute", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Attribute { get{ return _attribute; } set{ _attribute=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"CameraSize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CameraSize { get{ return _camera_size; } set{ _camera_size=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"ConstItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ConstItem { get{ return _const_item; } set{ _const_item=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"InheritProportion", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int InheritProportion { get{ return _inherit_proportion; } set{ _inherit_proportion=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"ModelRes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ModelRes { get{ return _model_res; } set{ _model_res=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Quality", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Quality { get{ return _quality; } set{ _quality=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"SceneScale", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SceneScale { get{ return _scene_scale; } set{ _scene_scale=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"ShowmodelCameraSize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ShowmodelCameraSize { get{ return _showmodel_camera_size; } set{ _showmodel_camera_size=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclarePetLevel Create( string in_attribute, int in_camera_size, string in_const_item, int in_id, int in_inherit_proportion, int in_level, int in_model_res, int in_quality, int in_scene_scale, int in_showmodel_camera_size )
    {
      DeclarePetLevel tmp = new DeclarePetLevel();
      tmp._attribute = in_attribute;
      tmp._camera_size = in_camera_size;
      tmp._const_item = in_const_item;
      tmp._id = in_id;
      tmp._inherit_proportion = in_inherit_proportion;
      tmp._level = in_level;
      tmp._model_res = in_model_res;
      tmp._quality = in_quality;
      tmp._scene_scale = in_scene_scale;
      tmp._showmodel_camera_size = in_showmodel_camera_size;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclarePetLevel> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclarePetLevel> _dataCaches = null;
    public static Dictionary<int, DeclarePetLevel> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPetLevel");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataPetLevel = require 'Lua/Config/DataPetLevel'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPetLevel");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclarePetLevel>(253);
                     foreach (var item in dic)
                     {
                         DeclarePetLevel tmp = new DeclarePetLevel();
                       tmp.Attribute = CfgStringLua.Get(item.Value[0]);
                       tmp.CameraSize = item.Value[1];
                       tmp.ConstItem = CfgStringLua.Get(item.Value[2]);
                       tmp.Id = item.Value[3];
                       tmp.InheritProportion = item.Value[4];
                       tmp.Level = item.Value[5];
                       tmp.ModelRes = item.Value[6];
                       tmp.Quality = item.Value[7];
                       tmp.SceneScale = item.Value[8];
                       tmp.ShowmodelCameraSize = item.Value[9];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"PetLevel");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclarePetLevel>(253);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"PetLevel");
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
    public static DeclarePetLevel Get(int id)
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
    public static void Transform(Dictionary<int, DeclarePetLevel> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
