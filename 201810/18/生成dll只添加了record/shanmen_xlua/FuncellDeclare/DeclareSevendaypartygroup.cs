//文件是自动生成,请勿手动修改.来自数据文件:sevendaypartygroup
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareSevendaypartygroup")]
  public class DeclareSevendaypartygroup
  {
    #region //私有变量定义
    //奖励
    private string _award;
    //说明1 hide
    private string _desc1;
    //说明2 hide
    private string _desc2;
    //说明3 hide
    private string _desc3;
    //说明4 hide
    private string _desc4;
    //分页图标
    private int _icon;
    //编号
    private int _id;
    //活动名字
    private string _name;
    //变强(@;@)
    private string _strong;
    //背景图ID hide
    private string _texture;
    //代表所对应的功能，即使每天对应的活动改变，此处的ID不能变
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Award", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Award { get{ return _award; } set{ _award=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Desc1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Desc1 { get{ return _desc1; } set{ _desc1=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Desc2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Desc2 { get{ return _desc2; } set{ _desc2=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Desc3", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Desc3 { get{ return _desc3; } set{ _desc3=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Desc4", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Desc4 { get{ return _desc4; } set{ _desc4=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Strong", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Strong { get{ return _strong; } set{ _strong=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Texture", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Texture { get{ return _texture; } set{ _texture=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareSevendaypartygroup Create( string in_award, string in_desc1, string in_desc2, string in_desc3, string in_desc4, int in_icon, int in_id, string in_name, string in_strong, string in_texture, int in_type )
    {
      DeclareSevendaypartygroup tmp = new DeclareSevendaypartygroup();
      tmp._award = in_award;
      tmp._desc1 = in_desc1;
      tmp._desc2 = in_desc2;
      tmp._desc3 = in_desc3;
      tmp._desc4 = in_desc4;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._name = in_name;
      tmp._strong = in_strong;
      tmp._texture = in_texture;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareSevendaypartygroup> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareSevendaypartygroup> _dataCaches = null;
    public static Dictionary<int, DeclareSevendaypartygroup> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataSevendaypartygroup");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataSevendaypartygroup = require 'Lua/Config/DataSevendaypartygroup'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataSevendaypartygroup");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareSevendaypartygroup>(6);
                     foreach (var item in dic)
                     {
                         DeclareSevendaypartygroup tmp = new DeclareSevendaypartygroup();
                       tmp.Award = CfgStringLua.Get(item.Value[0]);
                       tmp.Desc1 = CfgStringLua.Get(item.Value[1]);
                       tmp.Desc2 = CfgStringLua.Get(item.Value[2]);
                       tmp.Desc3 = CfgStringLua.Get(item.Value[3]);
                       tmp.Desc4 = CfgStringLua.Get(item.Value[4]);
                       tmp.Icon = item.Value[5];
                       tmp.Id = item.Value[6];
                       tmp.Name = CfgStringLua.Get(item.Value[7]);
                       tmp.Strong = CfgStringLua.Get(item.Value[8]);
                       tmp.Texture = CfgStringLua.Get(item.Value[9]);
                       tmp.Type = item.Value[10];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Sevendaypartygroup");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareSevendaypartygroup>(6);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Sevendaypartygroup");
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
    public static DeclareSevendaypartygroup Get(int id)
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
    public static void Transform(Dictionary<int, DeclareSevendaypartygroup> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
