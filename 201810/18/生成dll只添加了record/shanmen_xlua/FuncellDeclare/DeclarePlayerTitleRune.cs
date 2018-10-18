//文件是自动生成,请勿手动修改.来自数据文件:PlayerTitle_Rune
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclarePlayerTitleRune")]
  public class DeclarePlayerTitleRune
  {
    #region //私有变量定义
    //激活一次所需龙灵
    private int _activeNeedValue;
    //基础成长属性(属性类型_增加的值)(@;@_@)
    private string _att;
    //暴击获得
    private int _critGet;
    //暴击概率万分比
    private int _critPer;
    //没有免费次数扣除所需元宝数
    private int _decGold;
    //每次增加数量
    private int _eachAdd;
    //每隔多少次增加元宝数量
    private int _eachCount;
    //激活满了增加的属性（属性类型_增加的值)(@;@_@)
    private string _full_att;
    //等级
    private int _id;
    //扣除上线
    private int _limitDecGold;
    //名字
    private string _name;
    //普通激活获得
    private int _normalGet;
    //是否公告（0不公告；1公告）
    private int _radio;
    //模型ID（hide）
    private int _res;
    //超级暴击获得
    private int _superGet;
    //超级暴击概率万分比
    private int _superPer;
    //升级所需经验
    private int _upNeedExp;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ActiveNeedValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ActiveNeedValue { get{ return _activeNeedValue; } set{ _activeNeedValue=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Att", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Att { get{ return _att; } set{ _att=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"CritGet", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CritGet { get{ return _critGet; } set{ _critGet=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"CritPer", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CritPer { get{ return _critPer; } set{ _critPer=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"DecGold", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DecGold { get{ return _decGold; } set{ _decGold=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"EachAdd", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int EachAdd { get{ return _eachAdd; } set{ _eachAdd=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"EachCount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int EachCount { get{ return _eachCount; } set{ _eachCount=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"FullAtt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string FullAtt { get{ return _full_att; } set{ _full_att=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"LimitDecGold", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int LimitDecGold { get{ return _limitDecGold; } set{ _limitDecGold=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"NormalGet", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NormalGet { get{ return _normalGet; } set{ _normalGet=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"Radio", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Radio { get{ return _radio; } set{ _radio=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"Res", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Res { get{ return _res; } set{ _res=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"SuperGet", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SuperGet { get{ return _superGet; } set{ _superGet=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"SuperPer", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SuperPer { get{ return _superPer; } set{ _superPer=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"UpNeedExp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UpNeedExp { get{ return _upNeedExp; } set{ _upNeedExp=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclarePlayerTitleRune Create( int in_activeNeedValue, string in_att, int in_critGet, int in_critPer, int in_decGold, int in_eachAdd, int in_eachCount, string in_full_att, int in_id, int in_limitDecGold, string in_name, int in_normalGet, int in_radio, int in_res, int in_superGet, int in_superPer, int in_upNeedExp )
    {
      DeclarePlayerTitleRune tmp = new DeclarePlayerTitleRune();
      tmp._activeNeedValue = in_activeNeedValue;
      tmp._att = in_att;
      tmp._critGet = in_critGet;
      tmp._critPer = in_critPer;
      tmp._decGold = in_decGold;
      tmp._eachAdd = in_eachAdd;
      tmp._eachCount = in_eachCount;
      tmp._full_att = in_full_att;
      tmp._id = in_id;
      tmp._limitDecGold = in_limitDecGold;
      tmp._name = in_name;
      tmp._normalGet = in_normalGet;
      tmp._radio = in_radio;
      tmp._res = in_res;
      tmp._superGet = in_superGet;
      tmp._superPer = in_superPer;
      tmp._upNeedExp = in_upNeedExp;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclarePlayerTitleRune> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclarePlayerTitleRune> _dataCaches = null;
    public static Dictionary<int, DeclarePlayerTitleRune> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPlayerTitleRune");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataPlayerTitleRune = require 'Lua/Config/DataPlayerTitleRune'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPlayerTitleRune");                  }

                 if (dic != null)
                 {
                              _dataCaches = new Dictionary<int, DeclarePlayerTitleRune>();
                     foreach (var item in dic)
                     {
                         DeclarePlayerTitleRune tmp = new DeclarePlayerTitleRune();
                       tmp.ActiveNeedValue = item.Value[0];
                       tmp.Att = CfgStringLua.Get(item.Value[1]);
                       tmp.CritGet = item.Value[2];
                       tmp.CritPer = item.Value[3];
                       tmp.DecGold = item.Value[4];
                       tmp.EachAdd = item.Value[5];
                       tmp.EachCount = item.Value[6];
                       tmp.FullAtt = CfgStringLua.Get(item.Value[7]);
                       tmp.Id = item.Value[8];
                       tmp.LimitDecGold = item.Value[9];
                       tmp.Name = CfgStringLua.Get(item.Value[10]);
                       tmp.NormalGet = item.Value[11];
                       tmp.Radio = item.Value[12];
                       tmp.Res = item.Value[13];
                       tmp.SuperGet = item.Value[14];
                       tmp.SuperPer = item.Value[15];
                       tmp.UpNeedExp = item.Value[16];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"PlayerTitleRune");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclarePlayerTitleRune>();
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"PlayerTitleRune");
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
    public static DeclarePlayerTitleRune Get(int id)
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
    public static void Transform(Dictionary<int, DeclarePlayerTitleRune> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
