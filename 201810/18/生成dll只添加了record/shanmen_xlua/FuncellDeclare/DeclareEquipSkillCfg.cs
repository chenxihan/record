//文件是自动生成,请勿手动修改.来自数据文件:EquipSkillCfg
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareEquipSkillCfg")]
  public class DeclareEquipSkillCfg
  {
    #region //私有变量定义
    //初级技能书1级ID
    private string _book1;
    //初级技能书2级ID
    private string _book2;
    //初级技能书3级ID
    private string _book3;
    //初级技能书4级ID
    private string _book4;
    //初级技能书5级ID
    private string _book5;
    //部位
    private int _num;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Book1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Book1 { get{ return _book1; } set{ _book1=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Book2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Book2 { get{ return _book2; } set{ _book2=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Book3", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Book3 { get{ return _book3; } set{ _book3=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Book4", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Book4 { get{ return _book4; } set{ _book4=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Book5", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Book5 { get{ return _book5; } set{ _book5=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Num { get{ return _num; } set{ _num=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareEquipSkillCfg Create( string in_book1, string in_book2, string in_book3, string in_book4, string in_book5, int in_num )
    {
      DeclareEquipSkillCfg tmp = new DeclareEquipSkillCfg();
      tmp._book1 = in_book1;
      tmp._book2 = in_book2;
      tmp._book3 = in_book3;
      tmp._book4 = in_book4;
      tmp._book5 = in_book5;
      tmp._num = in_num;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareEquipSkillCfg> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareEquipSkillCfg> _dataCaches = null;
    public static Dictionary<int, DeclareEquipSkillCfg> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataEquipSkillCfg");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataEquipSkillCfg = require 'Lua/Config/DataEquipSkillCfg'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataEquipSkillCfg");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareEquipSkillCfg>(8);
                     foreach (var item in dic)
                     {
                         DeclareEquipSkillCfg tmp = new DeclareEquipSkillCfg();
                       tmp.Book1 = CfgStringLua.Get(item.Value[0]);
                       tmp.Book2 = CfgStringLua.Get(item.Value[1]);
                       tmp.Book3 = CfgStringLua.Get(item.Value[2]);
                       tmp.Book4 = CfgStringLua.Get(item.Value[3]);
                       tmp.Book5 = CfgStringLua.Get(item.Value[4]);
                       tmp.Num = item.Value[5];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"EquipSkillCfg");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareEquipSkillCfg>(8);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"EquipSkillCfg");
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
    public static DeclareEquipSkillCfg Get(int id)
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
    public static void Transform(Dictionary<int, DeclareEquipSkillCfg> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
