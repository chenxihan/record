//文件是自动生成,请勿手动修改.来自数据文件:challenge_reward
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareChallengeReward")]
  public class DeclareChallengeReward
  {
    #region //私有变量定义
    //摄像机大小(hide)（放大100倍）
    private int _camera_size;
    //进入最低等级
    private int _level;
    //默认旋转值
    private int _model_rot;
    //对应怪物id
    private int _monster_id;
    //波次
    private int _num;
    //扫荡奖励(@;@_@)
    private string _saodang_reward;
    //显示的Icon（hide）
    private int _show_icon;
    //显示的模型(hide)
    private int _show_model;
    //通关奖励(@;@_@)
    private string _success_reward;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"CameraSize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CameraSize { get{ return _camera_size; } set{ _camera_size=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"ModelRot", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ModelRot { get{ return _model_rot; } set{ _model_rot=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"MonsterId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MonsterId { get{ return _monster_id; } set{ _monster_id=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Num { get{ return _num; } set{ _num=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"SaodangReward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SaodangReward { get{ return _saodang_reward; } set{ _saodang_reward=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"ShowIcon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ShowIcon { get{ return _show_icon; } set{ _show_icon=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"ShowModel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ShowModel { get{ return _show_model; } set{ _show_model=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"SuccessReward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SuccessReward { get{ return _success_reward; } set{ _success_reward=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareChallengeReward Create( int in_camera_size, int in_level, int in_model_rot, int in_monster_id, int in_num, string in_saodang_reward, int in_show_icon, int in_show_model, string in_success_reward )
    {
      DeclareChallengeReward tmp = new DeclareChallengeReward();
      tmp._camera_size = in_camera_size;
      tmp._level = in_level;
      tmp._model_rot = in_model_rot;
      tmp._monster_id = in_monster_id;
      tmp._num = in_num;
      tmp._saodang_reward = in_saodang_reward;
      tmp._show_icon = in_show_icon;
      tmp._show_model = in_show_model;
      tmp._success_reward = in_success_reward;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareChallengeReward> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareChallengeReward> _dataCaches = null;
    public static Dictionary<int, DeclareChallengeReward> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataChallengeReward");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataChallengeReward = require 'Lua/Config/DataChallengeReward'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataChallengeReward");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareChallengeReward>(101);
                     foreach (var item in dic)
                     {
                         DeclareChallengeReward tmp = new DeclareChallengeReward();
                       tmp.CameraSize = item.Value[0];
                       tmp.Level = item.Value[1];
                       tmp.ModelRot = item.Value[2];
                       tmp.MonsterId = item.Value[3];
                       tmp.Num = item.Value[4];
                       tmp.SaodangReward = CfgStringLua.Get(item.Value[5]);
                       tmp.ShowIcon = item.Value[6];
                       tmp.ShowModel = item.Value[7];
                       tmp.SuccessReward = CfgStringLua.Get(item.Value[8]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"ChallengeReward");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareChallengeReward>(101);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"ChallengeReward");
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
    public static DeclareChallengeReward Get(int id)
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
    public static void Transform(Dictionary<int, DeclareChallengeReward> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
