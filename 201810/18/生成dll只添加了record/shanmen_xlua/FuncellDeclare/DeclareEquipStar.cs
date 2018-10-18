//文件是自动生成,请勿手动修改.来自数据文件:Equip_star
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareEquipStar")]
  public class DeclareEquipStar
  {
    #region //私有变量定义
    //属性提升比率（直接读取本级数据，万分比）
    private int _attribute;
    //失败降低等级
    private int _declineLevel;
    //星级ID（表示达到下一星级需要花费的材料）
    private int _id;
    //升星所需玩家转职等级
    private int _level;
    //消耗材料（ID_数量;ID_数量;……）(@;@_@)
    private string _material1;
    //花费金币
    private int _money;
    //图片ID，底图（界面上的 星星月亮 太阳图片）hide
    private string _public_n;
    //图片ID，亮起（界面上的 星星月亮 太阳图片）hide
    private string _public_p;
    //消耗保星材料ID_数量(@;@_@)
    private string _specialMaterial;
    //成功率（万分比）
    private int _successRatio;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Attribute", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Attribute { get{ return _attribute; } set{ _attribute=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"DeclineLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DeclineLevel { get{ return _declineLevel; } set{ _declineLevel=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Material1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Material1 { get{ return _material1; } set{ _material1=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Money", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Money { get{ return _money; } set{ _money=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"PublicN", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string PublicN { get{ return _public_n; } set{ _public_n=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"PublicP", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string PublicP { get{ return _public_p; } set{ _public_p=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"SpecialMaterial", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SpecialMaterial { get{ return _specialMaterial; } set{ _specialMaterial=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"SuccessRatio", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SuccessRatio { get{ return _successRatio; } set{ _successRatio=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareEquipStar Create( int in_attribute, int in_declineLevel, int in_id, int in_level, string in_material1, int in_money, string in_public_n, string in_public_p, string in_specialMaterial, int in_successRatio )
    {
      DeclareEquipStar tmp = new DeclareEquipStar();
      tmp._attribute = in_attribute;
      tmp._declineLevel = in_declineLevel;
      tmp._id = in_id;
      tmp._level = in_level;
      tmp._material1 = in_material1;
      tmp._money = in_money;
      tmp._public_n = in_public_n;
      tmp._public_p = in_public_p;
      tmp._specialMaterial = in_specialMaterial;
      tmp._successRatio = in_successRatio;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareEquipStar> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareEquipStar> _dataCaches = null;
    public static Dictionary<int, DeclareEquipStar> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataEquipStar");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataEquipStar = require 'Lua/Config/DataEquipStar'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataEquipStar");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareEquipStar>(15);
                     foreach (var item in dic)
                     {
                         DeclareEquipStar tmp = new DeclareEquipStar();
                       tmp.Attribute = item.Value[0];
                       tmp.DeclineLevel = item.Value[1];
                       tmp.Id = item.Value[2];
                       tmp.Level = item.Value[3];
                       tmp.Material1 = CfgStringLua.Get(item.Value[4]);
                       tmp.Money = item.Value[5];
                       tmp.PublicN = CfgStringLua.Get(item.Value[6]);
                       tmp.PublicP = CfgStringLua.Get(item.Value[7]);
                       tmp.SpecialMaterial = CfgStringLua.Get(item.Value[8]);
                       tmp.SuccessRatio = item.Value[9];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"EquipStar");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareEquipStar>(15);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"EquipStar");
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
    public static DeclareEquipStar Get(int id)
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
    public static void Transform(Dictionary<int, DeclareEquipStar> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
