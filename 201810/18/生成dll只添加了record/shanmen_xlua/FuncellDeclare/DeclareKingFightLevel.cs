//文件是自动生成,请勿手动修改.来自数据文件:KingFightLevel
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareKingFightLevel")]
  public class DeclareKingFightLevel
  {
    #region //私有变量定义
    //本段位每日结算奖励(@_@)
    private string _day_award;
    //每日参数次数奖励:次数_物品id_物品数量;(@;@_@)
    private string _day_join_award;
    //段位
    private int _degree;
    //段位ID
    private int _id;
    //失败获得的功勋值
    private int _lose_feats_value;
    //失败获得积分，可填负值
    private int _lose_score;
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
    //胜利获得功勋值
    private int _win_feats_value;
    //胜利获得积分
    private int _win_socre;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"DayAward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DayAward { get{ return _day_award; } set{ _day_award=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"DayJoinAward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DayJoinAward { get{ return _day_join_award; } set{ _day_join_award=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Degree", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Degree { get{ return _degree; } set{ _degree=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"LoseFeatsValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int LoseFeatsValue { get{ return _lose_feats_value; } set{ _lose_feats_value=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"LoseScore", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int LoseScore { get{ return _lose_score; } set{ _lose_score=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"NeedScore", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NeedScore { get{ return _need_score; } set{ _need_score=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"ResIcon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ResIcon { get{ return _res_icon; } set{ _res_icon=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"ResTex", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ResTex { get{ return _res_tex; } set{ _res_tex=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"StarNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int StarNum { get{ return _star_num; } set{ _star_num=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"WinFeatsValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int WinFeatsValue { get{ return _win_feats_value; } set{ _win_feats_value=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"WinSocre", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int WinSocre { get{ return _win_socre; } set{ _win_socre=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareKingFightLevel Create( string in_day_award, string in_day_join_award, int in_degree, int in_id, int in_lose_feats_value, int in_lose_score, string in_name, int in_need_score, int in_res_icon, string in_res_tex, int in_star_num, int in_win_feats_value, int in_win_socre )
    {
      DeclareKingFightLevel tmp = new DeclareKingFightLevel();
      tmp._day_award = in_day_award;
      tmp._day_join_award = in_day_join_award;
      tmp._degree = in_degree;
      tmp._id = in_id;
      tmp._lose_feats_value = in_lose_feats_value;
      tmp._lose_score = in_lose_score;
      tmp._name = in_name;
      tmp._need_score = in_need_score;
      tmp._res_icon = in_res_icon;
      tmp._res_tex = in_res_tex;
      tmp._star_num = in_star_num;
      tmp._win_feats_value = in_win_feats_value;
      tmp._win_socre = in_win_socre;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareKingFightLevel> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareKingFightLevel> _dataCaches = null;
    public static Dictionary<int, DeclareKingFightLevel> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataKingFightLevel");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataKingFightLevel = require 'Lua/Config/DataKingFightLevel'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataKingFightLevel");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareKingFightLevel>(30);
                     foreach (var item in dic)
                     {
                         DeclareKingFightLevel tmp = new DeclareKingFightLevel();
                       tmp.DayAward = CfgStringLua.Get(item.Value[0]);
                       tmp.DayJoinAward = CfgStringLua.Get(item.Value[1]);
                       tmp.Degree = item.Value[2];
                       tmp.Id = item.Value[3];
                       tmp.LoseFeatsValue = item.Value[4];
                       tmp.LoseScore = item.Value[5];
                       tmp.Name = CfgStringLua.Get(item.Value[6]);
                       tmp.NeedScore = item.Value[7];
                       tmp.ResIcon = item.Value[8];
                       tmp.ResTex = CfgStringLua.Get(item.Value[9]);
                       tmp.StarNum = item.Value[10];
                       tmp.WinFeatsValue = item.Value[11];
                       tmp.WinSocre = item.Value[12];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"KingFightLevel");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareKingFightLevel>(30);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"KingFightLevel");
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
    public static DeclareKingFightLevel Get(int id)
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
    public static void Transform(Dictionary<int, DeclareKingFightLevel> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
