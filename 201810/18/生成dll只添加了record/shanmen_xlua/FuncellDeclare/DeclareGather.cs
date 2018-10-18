//文件是自动生成,请勿手动修改.来自数据文件:Gather
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareGather")]
  public class DeclareGather
  {
    #region //私有变量定义
    //采集后Action Type(1:特效，2:动画,3:对话泡泡,10:混合)
    private int _afterType;
    //动作片段名字
    private string _animName;
    //采集进度条文字 hide
    private string _collect_info;
    //采集时间(毫秒)
    private int _collect_time;
    //动作片段名字
    private string _dialog;
    //掉落数量（目前只用于公会战）
    private int _drop_num;
    //特效id
    private int _effectId;
    //敌方占领
    private int _enemy_flag;
    //友方占领
    private int _friends_flag;
    //头像icon
    private int _icon;
    //采集物ID
    private int _id;
    //逻辑半径（单位厘米）(hide)
    private int _logic_body_size;
    //混合Type_执行顺序（0：顺序，1同时执行）
    private string _multType;
    //名称
    private string _name;
    //资源
    private int _res;
    //采集共享(1共享，0不共享）
    private int _share;
    //是否显示名字(1是，0否）hide
    private int _show_name;
    //靠近是否显示按钮（(1是，0否））
    private int _showButton;
    //模型缩放（百分比）
    private int _size_scale;
    //任务隐藏(@;@_@)
    private string _takHinde;
    //类型 0普通采集物（都可以采集） 1任务采集物（只有接受了某些任务才能采集）
    private int _type;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"AfterType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int AfterType { get{ return _afterType; } set{ _afterType=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"AnimName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string AnimName { get{ return _animName; } set{ _animName=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"CollectInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string CollectInfo { get{ return _collect_info; } set{ _collect_info=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"CollectTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CollectTime { get{ return _collect_time; } set{ _collect_time=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Dialog", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Dialog { get{ return _dialog; } set{ _dialog=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"DropNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DropNum { get{ return _drop_num; } set{ _drop_num=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"EffectId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int EffectId { get{ return _effectId; } set{ _effectId=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"EnemyFlag", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int EnemyFlag { get{ return _enemy_flag; } set{ _enemy_flag=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"FriendsFlag", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int FriendsFlag { get{ return _friends_flag; } set{ _friends_flag=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"LogicBodySize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int LogicBodySize { get{ return _logic_body_size; } set{ _logic_body_size=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"MultType", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string MultType { get{ return _multType; } set{ _multType=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"Res", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Res { get{ return _res; } set{ _res=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"Share", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Share { get{ return _share; } set{ _share=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"ShowName", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ShowName { get{ return _show_name; } set{ _show_name=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"ShowButton", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ShowButton { get{ return _showButton; } set{ _showButton=value; } }
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"SizeScale", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SizeScale { get{ return _size_scale; } set{ _size_scale=value; } }
    [global::ProtoBuf.ProtoMember(20, IsRequired = true, Name=@"TakHinde", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TakHinde { get{ return _takHinde; } set{ _takHinde=value; } }
    [global::ProtoBuf.ProtoMember(21, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareGather Create( int in_afterType, string in_animName, string in_collect_info, int in_collect_time, string in_dialog, int in_drop_num, int in_effectId, int in_enemy_flag, int in_friends_flag, int in_icon, int in_id, int in_logic_body_size, string in_multType, string in_name, int in_res, int in_share, int in_show_name, int in_showButton, int in_size_scale, string in_takHinde, int in_type )
    {
      DeclareGather tmp = new DeclareGather();
      tmp._afterType = in_afterType;
      tmp._animName = in_animName;
      tmp._collect_info = in_collect_info;
      tmp._collect_time = in_collect_time;
      tmp._dialog = in_dialog;
      tmp._drop_num = in_drop_num;
      tmp._effectId = in_effectId;
      tmp._enemy_flag = in_enemy_flag;
      tmp._friends_flag = in_friends_flag;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._logic_body_size = in_logic_body_size;
      tmp._multType = in_multType;
      tmp._name = in_name;
      tmp._res = in_res;
      tmp._share = in_share;
      tmp._show_name = in_show_name;
      tmp._showButton = in_showButton;
      tmp._size_scale = in_size_scale;
      tmp._takHinde = in_takHinde;
      tmp._type = in_type;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareGather> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareGather> _dataCaches = null;
    public static Dictionary<int, DeclareGather> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGather");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataGather = require 'Lua/Config/DataGather'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataGather");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareGather>(176);
                     foreach (var item in dic)
                     {
                         DeclareGather tmp = new DeclareGather();
                       tmp.AfterType = item.Value[0];
                       tmp.AnimName = CfgStringLua.Get(item.Value[1]);
                       tmp.CollectInfo = CfgStringLua.Get(item.Value[2]);
                       tmp.CollectTime = item.Value[3];
                       tmp.Dialog = CfgStringLua.Get(item.Value[4]);
                       tmp.DropNum = item.Value[5];
                       tmp.EffectId = item.Value[6];
                       tmp.EnemyFlag = item.Value[7];
                       tmp.FriendsFlag = item.Value[8];
                       tmp.Icon = item.Value[9];
                       tmp.Id = item.Value[10];
                       tmp.LogicBodySize = item.Value[11];
                       tmp.MultType = CfgStringLua.Get(item.Value[12]);
                       tmp.Name = CfgStringLua.Get(item.Value[13]);
                       tmp.Res = item.Value[14];
                       tmp.Share = item.Value[15];
                       tmp.ShowName = item.Value[16];
                       tmp.ShowButton = item.Value[17];
                       tmp.SizeScale = item.Value[18];
                       tmp.TakHinde = CfgStringLua.Get(item.Value[19]);
                       tmp.Type = item.Value[20];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Gather");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareGather>(176);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Gather");
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
    public static DeclareGather Get(int id)
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
    public static void Transform(Dictionary<int, DeclareGather> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
