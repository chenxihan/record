//文件是自动生成,请勿手动修改.来自数据文件:Equip_seal
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareEquipSeal")]
  public class DeclareEquipSeal
  {
    #region //私有变量定义
    //角色特效id
    private int _effect_id;
    //UI特效id
    private int _effect_uiid;
    //是否公告
    private int _nocite;
    //本级附加属性(@;@_@)
    private string _sea_attribute;
    //等级
    private int _sea_level;
    //升下级经验
    private int _sea_material;
    //激活技能
    private int _skill;
    //升阶物品id_进度(@;@_@)
    private string _up_item;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"EffectId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int EffectId { get{ return _effect_id; } set{ _effect_id=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"EffectUiid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int EffectUiid { get{ return _effect_uiid; } set{ _effect_uiid=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Nocite", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Nocite { get{ return _nocite; } set{ _nocite=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"SeaAttribute", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SeaAttribute { get{ return _sea_attribute; } set{ _sea_attribute=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"SeaLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SeaLevel { get{ return _sea_level; } set{ _sea_level=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"SeaMaterial", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SeaMaterial { get{ return _sea_material; } set{ _sea_material=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Skill", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Skill { get{ return _skill; } set{ _skill=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"UpItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string UpItem { get{ return _up_item; } set{ _up_item=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareEquipSeal Create( int in_effect_id, int in_effect_uiid, int in_nocite, string in_sea_attribute, int in_sea_level, int in_sea_material, int in_skill, string in_up_item )
    {
      DeclareEquipSeal tmp = new DeclareEquipSeal();
      tmp._effect_id = in_effect_id;
      tmp._effect_uiid = in_effect_uiid;
      tmp._nocite = in_nocite;
      tmp._sea_attribute = in_sea_attribute;
      tmp._sea_level = in_sea_level;
      tmp._sea_material = in_sea_material;
      tmp._skill = in_skill;
      tmp._up_item = in_up_item;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareEquipSeal> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareEquipSeal> _dataCaches = null;
    public static Dictionary<int, DeclareEquipSeal> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataEquipSeal");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataEquipSeal = require 'Lua/Config/DataEquipSeal'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataEquipSeal");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareEquipSeal>(2000);
                     foreach (var item in dic)
                     {
                         DeclareEquipSeal tmp = new DeclareEquipSeal();
                       tmp.EffectId = item.Value[0];
                       tmp.EffectUiid = item.Value[1];
                       tmp.Nocite = item.Value[2];
                       tmp.SeaAttribute = CfgStringLua.Get(item.Value[3]);
                       tmp.SeaLevel = item.Value[4];
                       tmp.SeaMaterial = item.Value[5];
                       tmp.Skill = item.Value[6];
                       tmp.UpItem = CfgStringLua.Get(item.Value[7]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"EquipSeal");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareEquipSeal>(2000);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"EquipSeal");
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
    public static DeclareEquipSeal Get(int id)
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
    public static void Transform(Dictionary<int, DeclareEquipSeal> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
