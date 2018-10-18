//文件是自动生成,请勿手动修改.来自数据文件:npc
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareNpc")]
  public class DeclareNpc
  {
    #region //私有变量定义
    //按钮显示文字 hide
    private string _btnName;
    //主线任务-进入副本NPC对话描述 hide
    private string _cloneNpcDialog;
    //NPC功能面板上的简单对白 hide
    private string _dialog;
    //填写FunctionStart中功能ID
    private int _funcType;
    //头像资源编号
    private int _icon;
    //NPC编号
    private int _id;
    //是否像服务器请求消息（0不请求）
    private int _isReq_NPC;
    //等级(hide)
    private int _level;
    //逻辑半径(单位厘米)(hide)
    private int _logic_body_size;
    //NPC名字
    private string _name;
    //对话中模型旋转值
    private int _notation;
    //是否使用玩家模型（0不使用/1使用）
    private int _playerModel;
    //使用玩家的模型ID（身体ID_武器ID_翅膀ID_坐骑ID）
    private string _playerModelRes;
    //对话中模型X坐标
    private int _pos_X;
    //对话中模型Y坐标
    private int _pos_Y;
    //NPC对话时需要职业（-1为所有职业）
    private int _professional;
    //职业对话 hide
    private string _professional_dialog;
    //造型资源编号（资源使用：单方向6帧）
    private int _res;
    //是否显示配置表名字0否1是
    private int _showCfgName;
    //模型缩放（百分比）
    private int _size_scale;
    //发言ID列表分号隔开
    private string _speakIds;
    //语音资源名 hide
    private string _speech;
    //NPC隐藏（用于任务,任务类型_任务ID;任务类型_任务ID）(@;@_@)主线任务配0_任务ID
    private string _taskShow;
    //称号(hide)
    private string _title;
    //NPC类型，默认为0，查看功能为1 转换阵营为2 师徒为3进入副本4,5为仙丹功能使用
    private int _type;
    //任务模型缩放比(只针对任务对话)
    private int _zoom;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"BtnName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string BtnName { get{ return _btnName; } set{ _btnName=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"CloneNpcDialog", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string CloneNpcDialog { get{ return _cloneNpcDialog; } set{ _cloneNpcDialog=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Dialog", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Dialog { get{ return _dialog; } set{ _dialog=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"FuncType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int FuncType { get{ return _funcType; } set{ _funcType=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"IsReqNPC", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int IsReqNPC { get{ return _isReq_NPC; } set{ _isReq_NPC=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"LogicBodySize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int LogicBodySize { get{ return _logic_body_size; } set{ _logic_body_size=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Notation", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Notation { get{ return _notation; } set{ _notation=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"PlayerModel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PlayerModel { get{ return _playerModel; } set{ _playerModel=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"PlayerModelRes", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string PlayerModelRes { get{ return _playerModelRes; } set{ _playerModelRes=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"PosX", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PosX { get{ return _pos_X; } set{ _pos_X=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"PosY", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PosY { get{ return _pos_Y; } set{ _pos_Y=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"Professional", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Professional { get{ return _professional; } set{ _professional=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"ProfessionalDialog", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ProfessionalDialog { get{ return _professional_dialog; } set{ _professional_dialog=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"Res", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Res { get{ return _res; } set{ _res=value; } }
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"ShowCfgName", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ShowCfgName { get{ return _showCfgName; } set{ _showCfgName=value; } }
    [global::ProtoBuf.ProtoMember(20, IsRequired = true, Name=@"SizeScale", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SizeScale { get{ return _size_scale; } set{ _size_scale=value; } }
    [global::ProtoBuf.ProtoMember(21, IsRequired = true, Name=@"SpeakIds", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SpeakIds { get{ return _speakIds; } set{ _speakIds=value; } }
    [global::ProtoBuf.ProtoMember(22, IsRequired = true, Name=@"Speech", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Speech { get{ return _speech; } set{ _speech=value; } }
    [global::ProtoBuf.ProtoMember(23, IsRequired = true, Name=@"TaskShow", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TaskShow { get{ return _taskShow; } set{ _taskShow=value; } }
    [global::ProtoBuf.ProtoMember(24, IsRequired = true, Name=@"Title", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Title { get{ return _title; } set{ _title=value; } }
    [global::ProtoBuf.ProtoMember(25, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    [global::ProtoBuf.ProtoMember(26, IsRequired = true, Name=@"Zoom", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Zoom { get{ return _zoom; } set{ _zoom=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareNpc Create( string in_btnName, string in_cloneNpcDialog, string in_dialog, int in_funcType, int in_icon, int in_id, int in_isReq_NPC, int in_level, int in_logic_body_size, string in_name, int in_notation, int in_playerModel, string in_playerModelRes, int in_pos_X, int in_pos_Y, int in_professional, string in_professional_dialog, int in_res, int in_showCfgName, int in_size_scale, string in_speakIds, string in_speech, string in_taskShow, string in_title, int in_type, int in_zoom )
    {
      DeclareNpc tmp = new DeclareNpc();
      tmp._btnName = in_btnName;
      tmp._cloneNpcDialog = in_cloneNpcDialog;
      tmp._dialog = in_dialog;
      tmp._funcType = in_funcType;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._isReq_NPC = in_isReq_NPC;
      tmp._level = in_level;
      tmp._logic_body_size = in_logic_body_size;
      tmp._name = in_name;
      tmp._notation = in_notation;
      tmp._playerModel = in_playerModel;
      tmp._playerModelRes = in_playerModelRes;
      tmp._pos_X = in_pos_X;
      tmp._pos_Y = in_pos_Y;
      tmp._professional = in_professional;
      tmp._professional_dialog = in_professional_dialog;
      tmp._res = in_res;
      tmp._showCfgName = in_showCfgName;
      tmp._size_scale = in_size_scale;
      tmp._speakIds = in_speakIds;
      tmp._speech = in_speech;
      tmp._taskShow = in_taskShow;
      tmp._title = in_title;
      tmp._type = in_type;
      tmp._zoom = in_zoom;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareNpc> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareNpc> _dataCaches = null;
    public static Dictionary<int, DeclareNpc> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataNpc");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataNpc = require 'Lua/Config/DataNpc'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataNpc");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareNpc>(434);
                     foreach (var item in dic)
                     {
                         DeclareNpc tmp = new DeclareNpc();
                       tmp.BtnName = CfgStringLua.Get(item.Value[0]);
                       tmp.CloneNpcDialog = CfgStringLua.Get(item.Value[1]);
                       tmp.Dialog = CfgStringLua.Get(item.Value[2]);
                       tmp.FuncType = item.Value[3];
                       tmp.Icon = item.Value[4];
                       tmp.Id = item.Value[5];
                       tmp.IsReqNPC = item.Value[6];
                       tmp.Level = item.Value[7];
                       tmp.LogicBodySize = item.Value[8];
                       tmp.Name = CfgStringLua.Get(item.Value[9]);
                       tmp.Notation = item.Value[10];
                       tmp.PlayerModel = item.Value[11];
                       tmp.PlayerModelRes = CfgStringLua.Get(item.Value[12]);
                       tmp.PosX = item.Value[13];
                       tmp.PosY = item.Value[14];
                       tmp.Professional = item.Value[15];
                       tmp.ProfessionalDialog = CfgStringLua.Get(item.Value[16]);
                       tmp.Res = item.Value[17];
                       tmp.ShowCfgName = item.Value[18];
                       tmp.SizeScale = item.Value[19];
                       tmp.SpeakIds = CfgStringLua.Get(item.Value[20]);
                       tmp.Speech = CfgStringLua.Get(item.Value[21]);
                       tmp.TaskShow = CfgStringLua.Get(item.Value[22]);
                       tmp.Title = CfgStringLua.Get(item.Value[23]);
                       tmp.Type = item.Value[24];
                       tmp.Zoom = item.Value[25];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Npc");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareNpc>(434);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Npc");
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
    public static DeclareNpc Get(int id)
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
    public static void Transform(Dictionary<int, DeclareNpc> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
