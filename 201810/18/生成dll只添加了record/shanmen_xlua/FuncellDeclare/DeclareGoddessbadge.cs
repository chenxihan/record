//文件是自动生成,请勿手动修改.来自数据文件:goddessbadge
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareGoddessbadge")]
  public class DeclareGoddessbadge
  {
    #region //私有变量定义
    //达成的成就条件(@;@_@)
    //条件都需要定义在functionVariable中
    private string _accomplishments;
    //本组所属徽章的ID
    private int _badgeId;
    //显示boss（icon_bossID）hide
    private string _boss;
    //领奖说明hide
    private string _des;
    //显示装备（ID_职业）hide
    private string _equip;
    //ID编号
    private int _id;
    //显示道具hide
    private string _item;
    //达到此项获得的奖励值(@;@_@)
    private string _reward;
    //展示内容说明hide
    private string _showDes;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Accomplishments", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Accomplishments { get{ return _accomplishments; } set{ _accomplishments=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"BadgeId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BadgeId { get{ return _badgeId; } set{ _badgeId=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Boss", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Boss { get{ return _boss; } set{ _boss=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Des", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Des { get{ return _des; } set{ _des=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Equip", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Equip { get{ return _equip; } set{ _equip=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Item { get{ return _item; } set{ _item=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Reward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Reward { get{ return _reward; } set{ _reward=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"ShowDes", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ShowDes { get{ return _showDes; } set{ _showDes=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareGoddessbadge Create( string in_accomplishments, int in_badgeId, string in_boss, string in_des, string in_equip, int in_id, string in_item, string in_reward, string in_showDes )
    {
      DeclareGoddessbadge tmp = new DeclareGoddessbadge();
      tmp._accomplishments = in_accomplishments;
      tmp._badgeId = in_badgeId;
      tmp._boss = in_boss;
      tmp._des = in_des;
      tmp._equip = in_equip;
      tmp._id = in_id;
      tmp._item = in_item;
      tmp._reward = in_reward;
      tmp._showDes = in_showDes;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareGoddessbadge> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareGoddessbadge> _dataCaches = null;
    public static Dictionary<int, DeclareGoddessbadge> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGoddessbadge");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataGoddessbadge = require 'Lua/Config/DataGoddessbadge'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGoddessbadge");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareGoddessbadge>(29);
                     foreach (var item in dic)
                     {
                         DeclareGoddessbadge tmp = new DeclareGoddessbadge();
                       tmp.Accomplishments = CfgStringLua.Get(item.Value[0]);
                       tmp.BadgeId = item.Value[1];
                       tmp.Boss = CfgStringLua.Get(item.Value[2]);
                       tmp.Des = CfgStringLua.Get(item.Value[3]);
                       tmp.Equip = CfgStringLua.Get(item.Value[4]);
                       tmp.Id = item.Value[5];
                       tmp.Item = CfgStringLua.Get(item.Value[6]);
                       tmp.Reward = CfgStringLua.Get(item.Value[7]);
                       tmp.ShowDes = CfgStringLua.Get(item.Value[8]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Goddessbadge");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareGoddessbadge>(29);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Goddessbadge");
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
    public static DeclareGoddessbadge Get(int id)
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
    public static void Transform(Dictionary<int, DeclareGoddessbadge> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
