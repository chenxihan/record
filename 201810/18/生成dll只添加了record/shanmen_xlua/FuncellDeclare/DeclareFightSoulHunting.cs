//文件是自动生成,请勿手动修改.来自数据文件:FightSoulHunting
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareFightSoulHunting")]
  public class DeclareFightSoulHunting
  {
    #region //私有变量定义
    //直接召唤掉率(@;@_@)
    private string _call_drop_rate;
    //单次猎魂消耗金币
    private int _consume_gold;
    //掉落战魂概率(品质_概率;品质_概率;品质_概率;)所有概率相加10000,0:白，1：绿，2：蓝，3：紫，4：橙色，5：金，6：特效经验(@;@_@)
    private string _drop_rate;
    //猎魂师图标
    private int _icon;
    //猎魂师ID
    private int _id;
    //猎魂师名称
    private string _name;
    //激活下一级概率（万分之）
    private int _next_probability;
    //头像上播放的特效id
    private int _vfx_id;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"CallDropRate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string CallDropRate { get{ return _call_drop_rate; } set{ _call_drop_rate=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"ConsumeGold", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ConsumeGold { get{ return _consume_gold; } set{ _consume_gold=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"DropRate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DropRate { get{ return _drop_rate; } set{ _drop_rate=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"NextProbability", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NextProbability { get{ return _next_probability; } set{ _next_probability=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"VfxId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int VfxId { get{ return _vfx_id; } set{ _vfx_id=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareFightSoulHunting Create( string in_call_drop_rate, int in_consume_gold, string in_drop_rate, int in_icon, int in_id, string in_name, int in_next_probability, int in_vfx_id )
    {
      DeclareFightSoulHunting tmp = new DeclareFightSoulHunting();
      tmp._call_drop_rate = in_call_drop_rate;
      tmp._consume_gold = in_consume_gold;
      tmp._drop_rate = in_drop_rate;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._name = in_name;
      tmp._next_probability = in_next_probability;
      tmp._vfx_id = in_vfx_id;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareFightSoulHunting> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareFightSoulHunting> _dataCaches = null;
    public static Dictionary<int, DeclareFightSoulHunting> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataFightSoulHunting");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataFightSoulHunting = require 'Lua/Config/DataFightSoulHunting'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataFightSoulHunting");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareFightSoulHunting>(5);
                     foreach (var item in dic)
                     {
                         DeclareFightSoulHunting tmp = new DeclareFightSoulHunting();
                       tmp.CallDropRate = CfgStringLua.Get(item.Value[0]);
                       tmp.ConsumeGold = item.Value[1];
                       tmp.DropRate = CfgStringLua.Get(item.Value[2]);
                       tmp.Icon = item.Value[3];
                       tmp.Id = item.Value[4];
                       tmp.Name = CfgStringLua.Get(item.Value[5]);
                       tmp.NextProbability = item.Value[6];
                       tmp.VfxId = item.Value[7];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"FightSoulHunting");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareFightSoulHunting>(5);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"FightSoulHunting");
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
    public static DeclareFightSoulHunting Get(int id)
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
    public static void Transform(Dictionary<int, DeclareFightSoulHunting> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
