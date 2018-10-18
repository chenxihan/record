//文件是自动生成,请勿手动修改.来自数据文件:pet
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclarePet")]
  public class DeclarePet
  {
    #region //私有变量定义
    //宠物攻击技能ID
    private int _attack_skill;
    //头像资源编号
    private int _head;
    //宠物ID
    private int _id;
    //侍宠名称
    private string _name;
    //激活需要人物等级
    private int _need_level;
    //激活需要已获得宠物(@;@)
    private string _need_pet;
    //激活成功是否公告（0不公告，1公告）
    private int _notice;
    //侍宠天赋技能(@;@_@)
    private string _passive_skill;
    //宠物的类型
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"AttackSkill", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int AttackSkill { get{ return _attack_skill; } set{ _attack_skill=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Head", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Head { get{ return _head; } set{ _head=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"NeedLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NeedLevel { get{ return _need_level; } set{ _need_level=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"NeedPet", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string NeedPet { get{ return _need_pet; } set{ _need_pet=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Notice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Notice { get{ return _notice; } set{ _notice=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"PassiveSkill", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string PassiveSkill { get{ return _passive_skill; } set{ _passive_skill=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclarePet Create( int in_attack_skill, int in_head, int in_id, string in_name, int in_need_level, string in_need_pet, int in_notice, string in_passive_skill, int in_type )
    {
      DeclarePet tmp = new DeclarePet();
      tmp._attack_skill = in_attack_skill;
      tmp._head = in_head;
      tmp._id = in_id;
      tmp._name = in_name;
      tmp._need_level = in_need_level;
      tmp._need_pet = in_need_pet;
      tmp._notice = in_notice;
      tmp._passive_skill = in_passive_skill;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclarePet> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclarePet> _dataCaches = null;
    public static Dictionary<int, DeclarePet> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPet");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataPet = require 'Lua/Config/DataPet'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataPet");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclarePet>(23);
                     foreach (var item in dic)
                     {
                         DeclarePet tmp = new DeclarePet();
                       tmp.AttackSkill = item.Value[0];
                       tmp.Head = item.Value[1];
                       tmp.Id = item.Value[2];
                       tmp.Name = CfgStringLua.Get(item.Value[3]);
                       tmp.NeedLevel = item.Value[4];
                       tmp.NeedPet = CfgStringLua.Get(item.Value[5]);
                       tmp.Notice = item.Value[6];
                       tmp.PassiveSkill = CfgStringLua.Get(item.Value[7]);
                       tmp.Type = item.Value[8];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Pet");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclarePet>(23);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Pet");
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
    public static DeclarePet Get(int id)
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
    public static void Transform(Dictionary<int, DeclarePet> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
