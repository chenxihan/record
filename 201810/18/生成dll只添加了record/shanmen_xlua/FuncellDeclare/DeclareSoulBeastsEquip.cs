//文件是自动生成,请勿手动修改.来自数据文件:SoulBeastsEquip
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareSoulBeastsEquip")]
  public class DeclareSoulBeastsEquip
  {
    #region //私有变量定义
    //初始属性：属性类型_数值，属性类型1_数值，(@;@_@)
    private string _attribute1;
    //绑定类型(0：不绑定;1：获得时绑定;2：使用后绑定)
    private int _bind;
    //蓝色附加属性产出：属性ID_数值; 属性ID_数值;….(@;@_@)
    private string _blueSpecialAtt;
    //回收时是弹出确认提示（0：不弹出;1：弹出）
    private int _confirm;
    //1表示1个钻石，2表示2个钻石，0表示没有钻石，钻石显示为左上角
    private int _diamond_Number;
    //装备id,(id构成：部位，职业，品质，等级）
    private int _id;
    //装备部位(1头盔、2项圈、3铠甲、4利爪、5羽翼)
    private int _part;
    //紫色附加属性产出：属性ID_数值; 属性ID_数值;….(@;@_@)
    private string _purpleSpecialAtt;
    //装备品质(：1.白 2.绿 3.蓝 4.紫 5.橙 6.金 7.红 8.粉)
    private int _quality;
    //推荐极品属性显示
    private string _recommended_tips;
    //强化提供经验
    private int _seal_exp;
    //附加属性条数分配（蓝色数量_紫色数量）(@_@)总数不超过3
    private string _specialAttNum;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Attribute1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Attribute1 { get{ return _attribute1; } set{ _attribute1=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Bind", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Bind { get{ return _bind; } set{ _bind=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"BlueSpecialAtt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string BlueSpecialAtt { get{ return _blueSpecialAtt; } set{ _blueSpecialAtt=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Confirm", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Confirm { get{ return _confirm; } set{ _confirm=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"DiamondNumber", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DiamondNumber { get{ return _diamond_Number; } set{ _diamond_Number=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Part", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Part { get{ return _part; } set{ _part=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"PurpleSpecialAtt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string PurpleSpecialAtt { get{ return _purpleSpecialAtt; } set{ _purpleSpecialAtt=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Quality", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Quality { get{ return _quality; } set{ _quality=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"RecommendedTips", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string RecommendedTips { get{ return _recommended_tips; } set{ _recommended_tips=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"SealExp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SealExp { get{ return _seal_exp; } set{ _seal_exp=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"SpecialAttNum", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SpecialAttNum { get{ return _specialAttNum; } set{ _specialAttNum=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareSoulBeastsEquip Create( string in_attribute1, int in_bind, string in_blueSpecialAtt, int in_confirm, int in_diamond_Number, int in_id, int in_part, string in_purpleSpecialAtt, int in_quality, string in_recommended_tips, int in_seal_exp, string in_specialAttNum )
    {
      DeclareSoulBeastsEquip tmp = new DeclareSoulBeastsEquip();
      tmp._attribute1 = in_attribute1;
      tmp._bind = in_bind;
      tmp._blueSpecialAtt = in_blueSpecialAtt;
      tmp._confirm = in_confirm;
      tmp._diamond_Number = in_diamond_Number;
      tmp._id = in_id;
      tmp._part = in_part;
      tmp._purpleSpecialAtt = in_purpleSpecialAtt;
      tmp._quality = in_quality;
      tmp._recommended_tips = in_recommended_tips;
      tmp._seal_exp = in_seal_exp;
      tmp._specialAttNum = in_specialAttNum;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareSoulBeastsEquip> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareSoulBeastsEquip> _dataCaches = null;
    public static Dictionary<int, DeclareSoulBeastsEquip> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataSoulBeastsEquip");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataSoulBeastsEquip = require 'Lua/Config/DataSoulBeastsEquip'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataSoulBeastsEquip");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareSoulBeastsEquip>(60);
                     foreach (var item in dic)
                     {
                         DeclareSoulBeastsEquip tmp = new DeclareSoulBeastsEquip();
                       tmp.Attribute1 = CfgStringLua.Get(item.Value[0]);
                       tmp.Bind = item.Value[1];
                       tmp.BlueSpecialAtt = CfgStringLua.Get(item.Value[2]);
                       tmp.Confirm = item.Value[3];
                       tmp.DiamondNumber = item.Value[4];
                       tmp.Id = item.Value[5];
                       tmp.Part = item.Value[6];
                       tmp.PurpleSpecialAtt = CfgStringLua.Get(item.Value[7]);
                       tmp.Quality = item.Value[8];
                       tmp.RecommendedTips = CfgStringLua.Get(item.Value[9]);
                       tmp.SealExp = item.Value[10];
                       tmp.SpecialAttNum = CfgStringLua.Get(item.Value[11]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"SoulBeastsEquip");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareSoulBeastsEquip>(60);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"SoulBeastsEquip");
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
    public static DeclareSoulBeastsEquip Get(int id)
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
    public static void Transform(Dictionary<int, DeclareSoulBeastsEquip> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
