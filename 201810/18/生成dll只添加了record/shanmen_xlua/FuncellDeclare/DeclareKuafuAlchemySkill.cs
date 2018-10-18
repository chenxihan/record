//文件是自动生成,请勿手动修改.来自数据文件:kuafu_Alchemy_skill
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareKuafuAlchemySkill")]
  public class DeclareKuafuAlchemySkill
  {
    #region //私有变量定义
    //BUFFID
    private int _bUFF;
    //技能ID
    private int _skill_id;
    //1为攻，2为守
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"BUFF", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BUFF { get{ return _bUFF; } set{ _bUFF=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"SkillId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SkillId { get{ return _skill_id; } set{ _skill_id=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareKuafuAlchemySkill Create( int in_bUFF, int in_skill_id, int in_type )
    {
      DeclareKuafuAlchemySkill tmp = new DeclareKuafuAlchemySkill();
      tmp._bUFF = in_bUFF;
      tmp._skill_id = in_skill_id;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareKuafuAlchemySkill> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareKuafuAlchemySkill> _dataCaches = null;
    public static Dictionary<int, DeclareKuafuAlchemySkill> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataKuafuAlchemySkill");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataKuafuAlchemySkill = require 'Lua/Config/DataKuafuAlchemySkill'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataKuafuAlchemySkill");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareKuafuAlchemySkill>(8);
                     foreach (var item in dic)
                     {
                         DeclareKuafuAlchemySkill tmp = new DeclareKuafuAlchemySkill();
                       tmp.BUFF = item.Value[0];
                       tmp.SkillId = item.Value[1];
                       tmp.Type = item.Value[2];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"KuafuAlchemySkill");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareKuafuAlchemySkill>(8);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"KuafuAlchemySkill");
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
    public static DeclareKuafuAlchemySkill Get(int id)
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
    public static void Transform(Dictionary<int, DeclareKuafuAlchemySkill> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
