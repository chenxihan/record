//文件是自动生成,请勿手动修改.来自数据文件:ScuffleLevel
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareScuffleLevel")]
  public class DeclareScuffleLevel
  {
    #region //私有变量定义
    //段位
    private int _degree;
    //初次进入本段位的奖励(@;@_@)
    private string _first_award;
    //每个名次获得的积分(@_@)
    private string _get_score;
    //三场连胜以后获得称号
    private int _get_title;
    //段位ID
    private int _id;
    //乱斗之王，第三场胜利奖励最终奖励(@;@_@)
    private string _king_ex_third_win;
    //乱斗之王，第一场失败奖励(@;@_@)
    private string _king_first_lose;
    //乱斗之王，第一场胜利奖励(@;@_@)
    private string _king_first_win;
    //乱斗之王，第二场胜利奖励(@;@_@)
    private string _king_second_win;
    //乱斗之王，第二场失败奖励(@;@_@)
    private string _king_seond_lose;
    //乱斗之王，第三场失败奖励(@;@_@)
    private string _king_third_lose;
    //乱斗之王，第三场胜利奖励(@;@_@)
    private string _king_third_win;
    //段位名字
    private string _name;
    //升级到本段需要积分
    private int _need_score;
    //资源图片
    private int _res_icon;
    //段位图片
    private string _res_tex;
    //星星数量
    private int _star_num;
    //本段位周结算奖励(@;@_@)
    private string _week_award;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Degree", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Degree { get{ return _degree; } set{ _degree=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"FirstAward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string FirstAward { get{ return _first_award; } set{ _first_award=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"GetScore", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string GetScore { get{ return _get_score; } set{ _get_score=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"GetTitle", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int GetTitle { get{ return _get_title; } set{ _get_title=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"KingExThirdWin", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string KingExThirdWin { get{ return _king_ex_third_win; } set{ _king_ex_third_win=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"KingFirstLose", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string KingFirstLose { get{ return _king_first_lose; } set{ _king_first_lose=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"KingFirstWin", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string KingFirstWin { get{ return _king_first_win; } set{ _king_first_win=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"KingSecondWin", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string KingSecondWin { get{ return _king_second_win; } set{ _king_second_win=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"KingSeondLose", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string KingSeondLose { get{ return _king_seond_lose; } set{ _king_seond_lose=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"KingThirdLose", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string KingThirdLose { get{ return _king_third_lose; } set{ _king_third_lose=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"KingThirdWin", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string KingThirdWin { get{ return _king_third_win; } set{ _king_third_win=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"NeedScore", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NeedScore { get{ return _need_score; } set{ _need_score=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"ResIcon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ResIcon { get{ return _res_icon; } set{ _res_icon=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"ResTex", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ResTex { get{ return _res_tex; } set{ _res_tex=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"StarNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int StarNum { get{ return _star_num; } set{ _star_num=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"WeekAward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string WeekAward { get{ return _week_award; } set{ _week_award=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareScuffleLevel Create( int in_degree, string in_first_award, string in_get_score, int in_get_title, int in_id, string in_king_ex_third_win, string in_king_first_lose, string in_king_first_win, string in_king_second_win, string in_king_seond_lose, string in_king_third_lose, string in_king_third_win, string in_name, int in_need_score, int in_res_icon, string in_res_tex, int in_star_num, string in_week_award )
    {
      DeclareScuffleLevel tmp = new DeclareScuffleLevel();
      tmp._degree = in_degree;
      tmp._first_award = in_first_award;
      tmp._get_score = in_get_score;
      tmp._get_title = in_get_title;
      tmp._id = in_id;
      tmp._king_ex_third_win = in_king_ex_third_win;
      tmp._king_first_lose = in_king_first_lose;
      tmp._king_first_win = in_king_first_win;
      tmp._king_second_win = in_king_second_win;
      tmp._king_seond_lose = in_king_seond_lose;
      tmp._king_third_lose = in_king_third_lose;
      tmp._king_third_win = in_king_third_win;
      tmp._name = in_name;
      tmp._need_score = in_need_score;
      tmp._res_icon = in_res_icon;
      tmp._res_tex = in_res_tex;
      tmp._star_num = in_star_num;
      tmp._week_award = in_week_award;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareScuffleLevel> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareScuffleLevel> _dataCaches = null;
    public static Dictionary<int, DeclareScuffleLevel> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataScuffleLevel");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataScuffleLevel = require 'Lua/Config/DataScuffleLevel'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataScuffleLevel");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareScuffleLevel>(30);
                     foreach (var item in dic)
                     {
                         DeclareScuffleLevel tmp = new DeclareScuffleLevel();
                       tmp.Degree = item.Value[0];
                       tmp.FirstAward = CfgStringLua.Get(item.Value[1]);
                       tmp.GetScore = CfgStringLua.Get(item.Value[2]);
                       tmp.GetTitle = item.Value[3];
                       tmp.Id = item.Value[4];
                       tmp.KingExThirdWin = CfgStringLua.Get(item.Value[5]);
                       tmp.KingFirstLose = CfgStringLua.Get(item.Value[6]);
                       tmp.KingFirstWin = CfgStringLua.Get(item.Value[7]);
                       tmp.KingSecondWin = CfgStringLua.Get(item.Value[8]);
                       tmp.KingSeondLose = CfgStringLua.Get(item.Value[9]);
                       tmp.KingThirdLose = CfgStringLua.Get(item.Value[10]);
                       tmp.KingThirdWin = CfgStringLua.Get(item.Value[11]);
                       tmp.Name = CfgStringLua.Get(item.Value[12]);
                       tmp.NeedScore = item.Value[13];
                       tmp.ResIcon = item.Value[14];
                       tmp.ResTex = CfgStringLua.Get(item.Value[15]);
                       tmp.StarNum = item.Value[16];
                       tmp.WeekAward = CfgStringLua.Get(item.Value[17]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"ScuffleLevel");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareScuffleLevel>(30);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"ScuffleLevel");
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
    public static DeclareScuffleLevel Get(int id)
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
    public static void Transform(Dictionary<int, DeclareScuffleLevel> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
