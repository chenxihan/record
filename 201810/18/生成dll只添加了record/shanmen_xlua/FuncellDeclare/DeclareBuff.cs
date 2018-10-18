//文件是自动生成,请勿手动修改.来自数据文件:buff
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareBuff")]
  public class DeclareBuff
  {
    #region //私有变量定义
    //增0/减1益hide
    private int _addsub;
    //特效路径
    private int _buffVfx;
    //特殊的条件 条件类型_条件参数;(@;@_@)
    private string _condi;
    //延迟时间（毫秒）
    private int _d_time;
    //buff描述 hide
    private string _desc;
    //分组(同组高等级顶替低等级)
    private int _group;
    //buff图标
    private int _icon;
    //buffid
    private int _id;
    //改地图是否清除（0，不清；1，清除）
    private int _if_changemap;
    //服务器是否发送给客户端显示（0，显示；1，不显示）
    private int _if_send;
    //等级
    private int _level;
    //buff名称
    private string _name;
    //叠加次数 (额外规则-1同buff顶替)
    private int _overlap;
    //参数1
    private int _param1;
    //参数2
    private int _param2;
    //参数3
    private int _param3;
    //参数4
    private int _param4;
    //影响的属性(@;@_@)
    private string _porperty;
    //作用对象（0所有 1怪物 2玩家）
    private int _targetType;
    //类型：
    //0=无      无：无                        
    //1=属性   porperty：属性枚举_属性值
    //2=血池   param1：总血量：param2：单次血量
    //3=掉血   param1：单次掉血
    //4=掉血总值万分比 param1：单次掉血万分比
    //5=掉血当前值万分比 param1：单次掉血万分比
    //6=治疗   param1：单次加血
    //7=治疗总值万分比 param1：单次加血万分比
    //8=治疗当前值万分比 param1：单次加血万分比
    //9=霸体状态 
    //10=金币倍率 param1：倍率万分比
    //11=经验倍率 param1：倍率万分比
    //12=剑士鬼影buff，用于表现鬼影效果
    //15=定身（脱离战斗的定身）
    //16=免控（会受到伤害）
    //17=掉血
    //18=炸弹
    //19=召唤
    //20=召唤物
    //21=眩晕
    //22=变身
    private int _type;
    //特效缩放
    private int _vfxScal;
    //特效挂载点
    private int _vfxSlot;
    //是否有文字显示（0，不显示；1，显示）
    private int _wenzi;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Addsub", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Addsub { get{ return _addsub; } set{ _addsub=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"BuffVfx", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BuffVfx { get{ return _buffVfx; } set{ _buffVfx=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Condi", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Condi { get{ return _condi; } set{ _condi=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"DTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DTime { get{ return _d_time; } set{ _d_time=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Desc { get{ return _desc; } set{ _desc=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Group", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Group { get{ return _group; } set{ _group=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"IfChangemap", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int IfChangemap { get{ return _if_changemap; } set{ _if_changemap=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"IfSend", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int IfSend { get{ return _if_send; } set{ _if_send=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"Overlap", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Overlap { get{ return _overlap; } set{ _overlap=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"Param1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Param1 { get{ return _param1; } set{ _param1=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"Param2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Param2 { get{ return _param2; } set{ _param2=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"Param3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Param3 { get{ return _param3; } set{ _param3=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"Param4", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Param4 { get{ return _param4; } set{ _param4=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"Porperty", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Porperty { get{ return _porperty; } set{ _porperty=value; } }
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"TargetType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TargetType { get{ return _targetType; } set{ _targetType=value; } }
    [global::ProtoBuf.ProtoMember(20, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    [global::ProtoBuf.ProtoMember(21, IsRequired = true, Name=@"VfxScal", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int VfxScal { get{ return _vfxScal; } set{ _vfxScal=value; } }
    [global::ProtoBuf.ProtoMember(22, IsRequired = true, Name=@"VfxSlot", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int VfxSlot { get{ return _vfxSlot; } set{ _vfxSlot=value; } }
    [global::ProtoBuf.ProtoMember(23, IsRequired = true, Name=@"Wenzi", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Wenzi { get{ return _wenzi; } set{ _wenzi=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareBuff Create( int in_addsub, int in_buffVfx, string in_condi, int in_d_time, string in_desc, int in_group, int in_icon, int in_id, int in_if_changemap, int in_if_send, int in_level, string in_name, int in_overlap, int in_param1, int in_param2, int in_param3, int in_param4, string in_porperty, int in_targetType, int in_type, int in_vfxScal, int in_vfxSlot, int in_wenzi )
    {
      DeclareBuff tmp = new DeclareBuff();
      tmp._addsub = in_addsub;
      tmp._buffVfx = in_buffVfx;
      tmp._condi = in_condi;
      tmp._d_time = in_d_time;
      tmp._desc = in_desc;
      tmp._group = in_group;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._if_changemap = in_if_changemap;
      tmp._if_send = in_if_send;
      tmp._level = in_level;
      tmp._name = in_name;
      tmp._overlap = in_overlap;
      tmp._param1 = in_param1;
      tmp._param2 = in_param2;
      tmp._param3 = in_param3;
      tmp._param4 = in_param4;
      tmp._porperty = in_porperty;
      tmp._targetType = in_targetType;
      tmp._type = in_type;
      tmp._vfxScal = in_vfxScal;
      tmp._vfxSlot = in_vfxSlot;
      tmp._wenzi = in_wenzi;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareBuff> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareBuff> _dataCaches = null;
    public static Dictionary<int, DeclareBuff> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataBuff");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataBuff = require 'Lua/Config/DataBuff'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataBuff");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareBuff>(265);
                     foreach (var item in dic)
                     {
                         DeclareBuff tmp = new DeclareBuff();
                       tmp.Addsub = item.Value[0];
                       tmp.BuffVfx = item.Value[1];
                       tmp.Condi = CfgStringLua.Get(item.Value[2]);
                       tmp.DTime = item.Value[3];
                       tmp.Desc = CfgStringLua.Get(item.Value[4]);
                       tmp.Group = item.Value[5];
                       tmp.Icon = item.Value[6];
                       tmp.Id = item.Value[7];
                       tmp.IfChangemap = item.Value[8];
                       tmp.IfSend = item.Value[9];
                       tmp.Level = item.Value[10];
                       tmp.Name = CfgStringLua.Get(item.Value[11]);
                       tmp.Overlap = item.Value[12];
                       tmp.Param1 = item.Value[13];
                       tmp.Param2 = item.Value[14];
                       tmp.Param3 = item.Value[15];
                       tmp.Param4 = item.Value[16];
                       tmp.Porperty = CfgStringLua.Get(item.Value[17]);
                       tmp.TargetType = item.Value[18];
                       tmp.Type = item.Value[19];
                       tmp.VfxScal = item.Value[20];
                       tmp.VfxSlot = item.Value[21];
                       tmp.Wenzi = item.Value[22];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Buff");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareBuff>(265);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Buff");
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
    public static DeclareBuff Get(int id)
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
    public static void Transform(Dictionary<int, DeclareBuff> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
