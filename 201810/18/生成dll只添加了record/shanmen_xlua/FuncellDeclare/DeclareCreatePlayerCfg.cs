//文件是自动生成,请勿手动修改.来自数据文件:CreatePlayerCfg
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareCreatePlayerCfg")]
  public class DeclareCreatePlayerCfg
  {
    #region //私有变量定义
    //相机模糊特效参数
    private string _blurArgs;
    //头像Icon
    private string _headIcon;
    //ID
    private int _id;
    //待机动作
    private string _idleAnimName;
    //职业描述
    private string _jobDes;
    //职业名字
    private string _jobName;
    //模型高度
    private int _modelHeight;
    //模型id
    private int _modelID;
    //表演动作
    private string _playAnimName;
    private int _sex;
    //技能特效id
    private int _skillVfxID;
    //武器id
    private int _weaponID;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"BlurArgs", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string BlurArgs { get{ return _blurArgs; } set{ _blurArgs=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"HeadIcon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string HeadIcon { get{ return _headIcon; } set{ _headIcon=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"IdleAnimName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string IdleAnimName { get{ return _idleAnimName; } set{ _idleAnimName=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"JobDes", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string JobDes { get{ return _jobDes; } set{ _jobDes=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"JobName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string JobName { get{ return _jobName; } set{ _jobName=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"ModelHeight", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ModelHeight { get{ return _modelHeight; } set{ _modelHeight=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"ModelID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ModelID { get{ return _modelID; } set{ _modelID=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"PlayAnimName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string PlayAnimName { get{ return _playAnimName; } set{ _playAnimName=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Sex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Sex { get{ return _sex; } set{ _sex=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"SkillVfxID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SkillVfxID { get{ return _skillVfxID; } set{ _skillVfxID=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"WeaponID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int WeaponID { get{ return _weaponID; } set{ _weaponID=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareCreatePlayerCfg Create( string in_blurArgs, string in_headIcon, int in_id, string in_idleAnimName, string in_jobDes, string in_jobName, int in_modelHeight, int in_modelID, string in_playAnimName, int in_sex, int in_skillVfxID, int in_weaponID )
    {
      DeclareCreatePlayerCfg tmp = new DeclareCreatePlayerCfg();
      tmp._blurArgs = in_blurArgs;
      tmp._headIcon = in_headIcon;
      tmp._id = in_id;
      tmp._idleAnimName = in_idleAnimName;
      tmp._jobDes = in_jobDes;
      tmp._jobName = in_jobName;
      tmp._modelHeight = in_modelHeight;
      tmp._modelID = in_modelID;
      tmp._playAnimName = in_playAnimName;
      tmp._sex = in_sex;
      tmp._skillVfxID = in_skillVfxID;
      tmp._weaponID = in_weaponID;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareCreatePlayerCfg> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareCreatePlayerCfg> _dataCaches = null;
    public static Dictionary<int, DeclareCreatePlayerCfg> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataCreatePlayerCfg");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataCreatePlayerCfg = require 'Lua/Config/DataCreatePlayerCfg'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataCreatePlayerCfg");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareCreatePlayerCfg>(6);
                     foreach (var item in dic)
                     {
                         DeclareCreatePlayerCfg tmp = new DeclareCreatePlayerCfg();
                       tmp.BlurArgs = CfgStringLua.Get(item.Value[0]);
                       tmp.HeadIcon = CfgStringLua.Get(item.Value[1]);
                       tmp.Id = item.Value[2];
                       tmp.IdleAnimName = CfgStringLua.Get(item.Value[3]);
                       tmp.JobDes = CfgStringLua.Get(item.Value[4]);
                       tmp.JobName = CfgStringLua.Get(item.Value[5]);
                       tmp.ModelHeight = item.Value[6];
                       tmp.ModelID = item.Value[7];
                       tmp.PlayAnimName = CfgStringLua.Get(item.Value[8]);
                       tmp.Sex = item.Value[9];
                       tmp.SkillVfxID = item.Value[10];
                       tmp.WeaponID = item.Value[11];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"CreatePlayerCfg");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareCreatePlayerCfg>(6);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"CreatePlayerCfg");
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
    public static DeclareCreatePlayerCfg Get(int id)
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
    public static void Transform(Dictionary<int, DeclareCreatePlayerCfg> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
