//文件是自动生成,请勿手动修改.来自数据文件:temple
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareTemple")]
  public class DeclareTemple
  {
    #region //私有变量定义
    //背景模型
    private int _back_vfx;
    //bossID(@_@)
    private string _boss;
    //可缩短时间（秒）
    private int _canCutTime;
    //是否继续掉落水晶（0是1否）
    private int _canDrop;
    //副本ID
    private int _cloneID;
    //每次缩短时间（秒）
    private int _cutTime;
    //第一个通关的奖励(@;@_@)
    private string _firstAward;
    //提交可获得积分
    private int _integral;
    //每次提交道具：ID_数量(@_@)
    private string _item;
    //模型
    private int _model_vfx;
    //副本名字
    private string _name;
    //进度
    private int _process;
    //封印解除时间（秒）
    private int _sealTime;
    //二星通关时间 秒
    private int _star2;
    //三星通关时间 秒
    private int _star3;
    //周宝箱(@;@_@)
    private string _weekAreward;
    //通关开放世界等级
    private int _worldLevel;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"BackVfx", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BackVfx { get{ return _back_vfx; } set{ _back_vfx=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Boss", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Boss { get{ return _boss; } set{ _boss=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"CanCutTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanCutTime { get{ return _canCutTime; } set{ _canCutTime=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"CanDrop", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanDrop { get{ return _canDrop; } set{ _canDrop=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"CloneID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CloneID { get{ return _cloneID; } set{ _cloneID=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"CutTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CutTime { get{ return _cutTime; } set{ _cutTime=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"FirstAward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string FirstAward { get{ return _firstAward; } set{ _firstAward=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Integral", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Integral { get{ return _integral; } set{ _integral=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"Item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Item { get{ return _item; } set{ _item=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"ModelVfx", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ModelVfx { get{ return _model_vfx; } set{ _model_vfx=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"Process", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Process { get{ return _process; } set{ _process=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"SealTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SealTime { get{ return _sealTime; } set{ _sealTime=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"Star2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Star2 { get{ return _star2; } set{ _star2=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"Star3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Star3 { get{ return _star3; } set{ _star3=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"WeekAreward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string WeekAreward { get{ return _weekAreward; } set{ _weekAreward=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"WorldLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int WorldLevel { get{ return _worldLevel; } set{ _worldLevel=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareTemple Create( int in_back_vfx, string in_boss, int in_canCutTime, int in_canDrop, int in_cloneID, int in_cutTime, string in_firstAward, int in_integral, string in_item, int in_model_vfx, string in_name, int in_process, int in_sealTime, int in_star2, int in_star3, string in_weekAreward, int in_worldLevel )
    {
      DeclareTemple tmp = new DeclareTemple();
      tmp._back_vfx = in_back_vfx;
      tmp._boss = in_boss;
      tmp._canCutTime = in_canCutTime;
      tmp._canDrop = in_canDrop;
      tmp._cloneID = in_cloneID;
      tmp._cutTime = in_cutTime;
      tmp._firstAward = in_firstAward;
      tmp._integral = in_integral;
      tmp._item = in_item;
      tmp._model_vfx = in_model_vfx;
      tmp._name = in_name;
      tmp._process = in_process;
      tmp._sealTime = in_sealTime;
      tmp._star2 = in_star2;
      tmp._star3 = in_star3;
      tmp._weekAreward = in_weekAreward;
      tmp._worldLevel = in_worldLevel;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareTemple> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareTemple> _dataCaches = null;
    public static Dictionary<int, DeclareTemple> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTemple");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataTemple = require 'Lua/Config/DataTemple'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataTemple");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareTemple>(2);
                     foreach (var item in dic)
                     {
                         DeclareTemple tmp = new DeclareTemple();
                       tmp.BackVfx = item.Value[0];
                       tmp.Boss = CfgStringLua.Get(item.Value[1]);
                       tmp.CanCutTime = item.Value[2];
                       tmp.CanDrop = item.Value[3];
                       tmp.CloneID = item.Value[4];
                       tmp.CutTime = item.Value[5];
                       tmp.FirstAward = CfgStringLua.Get(item.Value[6]);
                       tmp.Integral = item.Value[7];
                       tmp.Item = CfgStringLua.Get(item.Value[8]);
                       tmp.ModelVfx = item.Value[9];
                       tmp.Name = CfgStringLua.Get(item.Value[10]);
                       tmp.Process = item.Value[11];
                       tmp.SealTime = item.Value[12];
                       tmp.Star2 = item.Value[13];
                       tmp.Star3 = item.Value[14];
                       tmp.WeekAreward = CfgStringLua.Get(item.Value[15]);
                       tmp.WorldLevel = item.Value[16];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Temple");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareTemple>(2);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Temple");
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
    public static DeclareTemple Get(int id)
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
    public static void Transform(Dictionary<int, DeclareTemple> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
