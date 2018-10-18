//文件是自动生成,请勿手动修改.来自数据文件:clone_map
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareCloneMap")]
  public class DeclareCloneMap
  {
    #region //私有变量定义
    //采集物ID_x,y(@;@_@)
    private string _big_chest_id;
    //模型的摄像机大小(hide)(放大100倍）
    private int _camera_size;
    //是否可以跨服进入（0不能，1可以）
    private int _canCrossSerever;
    //是否可以组队进入（0不能，1可以）
    private int _canManyPeople;
    //是否可以单人进入（0不能，1可以）
    private int _canOnePeople;
    //能否鼓舞
    private int _canUpMorale;
    //是否检查阵营0是 1否
    private int _checkCamp;
    //剧情副本进入时的剧情动画ID
    private int _cinematic;
    //副本难度(0：不需要填写;1：简单;2：困难;3：地狱）
    private int _clone_story;
    //推荐战斗力
    private int _combat_power;
    //副本名称（支持HTML）
    private string _duplicate_name;
    //进入时消耗的道具(@;@_@)
    private string _enter_item;
    //进入副本后准备阶段时间（毫秒）
    private int _enter_time;
    //副本进入类型：1.本服;2.本服+跨服;3纯跨服
    private int _enter_type;
    //排序（小的再前，大的灾后）
    private int _equipLevel;
    //副本时间（毫秒）
    private int _exist_time;
    //副本说明（支持HTML）hide
    private string _explain;
    //副本特殊奖励【积分】：物品ID_数量;物品ID_数量|物品ID_数量;物品ID_数量[@\\|@;@_@]
    private string _extra_reward;
    //副本失败奖励：物品ID_数量;物品ID_数量[@;@_@]
    private string _fail_reward;
    //A掉落ID(@;@)
    private string _good_reward_ID;
    //副本组，每一组代表同一个副本
    private int _group_id;
    //副本编号
    private int _id;
    //是否能双倍掉落
    private int _if_double;
    //是否可以使用消耗品（0，不行;1可以）
    private int _if_use_up;
    //脚本ID
    private int _isscript;
    //每日手动挑战次数(-1表示未开放,0表示不限制)
    private int _manual_num;
    //副本关联地图编号[xxxx,xxxx]
    private string _mapid;
    //给予经验的索引
    private int _materialLevel;
    //最高等级进入限制
    private int _max_lv;
    //进入最多人数限制
    private int _max_num;
    //进入所需最小等级
    private int _min_lv;
    //进入最少人数限制
    private int _min_num;
    //模型旋转hide
    private int _model_rotat;
    //需要完成的主线任务id(@_@)
    private string _needTaskId;
    //副本界面(如果没有，则为0)
    private int _open_interface;
    //开放时间
    private string _open_time;
    //副本开启类型（0，不做副本开启限制;1，每天指定时间【显示下次副本开启剩余时间】;2,每周指定时间【显示下次副本开启时间】;3，指定日期【具体日期，不计算下次副本开启时间】
    private int _open_type;
    //额外参数
    private string _params;
    //活动参与奖励hide，只用于界面展示
    private string _participation_Award;
    //活动参与文字奖励hide，只用于界面展示
    private string _participation_Award1;
    //前端展示图片hide
    private string _pictureRes;
    //进入地图的坐标（X轴_Z轴_阵营标示【0，默认无区分;1，阵营1;2，阵营2）(@;@_@)
    private string _point;
    //BOSS胜利额外奖励:物品ID_数量;物品ID_数量[@;@_@]
    private string _prefect_reward_ID;
    //BOSS击杀大奖描述（物品ID_数量;物品ID_数量）(@;@_@)
    private string _random_Description;
    //副本重置时间（类型_具体时间）【类型：1，每日;2，不重置;3，每周】
    private string _reset_time;
    //复活位置【填x,y为在副本地图中的（x,y)坐标复活，其他不处理】
    private string _resurrection_type;
    //副本开场跑的ai
    private string _runningyedai;
    //前端展示头像hide
    private int _show_head;
    //前端展示模型hide
    private int _show_model;
    //副本报名时间（毫秒）
    private int _sign_up_time;
    //副本成功奖励：物品ID_数量;物品ID_数量[@;@_@]
    private string _success_reward;
    //剧情副本扫荡要求介绍
    private string _sweep;
    //是否在组队中显示（0为不显示，1为显示）
    private int _teamshow;
    //副本类型：0：活动副本;1：剧情副本;2：多人副本;3：个人挑战副本;4：挂机副本;5：日常副本;6：pvp副本;7：GVG副本;8：BOSS副本;9宠物副本;10主线副本;11首席擂台;12公会试炼;13工会战14首席副本;15婚姻副本;16Boss之家;17永夜幻境;18个人BOSS;19幻境BOSS;20上古战场;21勇者之巅;22王者对决;23众神遗迹;24灵魂列车；25魂兽森林；26王者联盟；27洪荒神迹;28神之灵脉;29元素神殿;30英灵殿;31荣耀战场
    private int _type;
    //副本组队中的名称
    private string _type_name;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"BigChestId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string BigChestId { get{ return _big_chest_id; } set{ _big_chest_id=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"CameraSize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CameraSize { get{ return _camera_size; } set{ _camera_size=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"CanCrossSerever", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanCrossSerever { get{ return _canCrossSerever; } set{ _canCrossSerever=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"CanManyPeople", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanManyPeople { get{ return _canManyPeople; } set{ _canManyPeople=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"CanOnePeople", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanOnePeople { get{ return _canOnePeople; } set{ _canOnePeople=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"CanUpMorale", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanUpMorale { get{ return _canUpMorale; } set{ _canUpMorale=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"CheckCamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CheckCamp { get{ return _checkCamp; } set{ _checkCamp=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Cinematic", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Cinematic { get{ return _cinematic; } set{ _cinematic=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"CloneStory", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CloneStory { get{ return _clone_story; } set{ _clone_story=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"CombatPower", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CombatPower { get{ return _combat_power; } set{ _combat_power=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"DuplicateName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DuplicateName { get{ return _duplicate_name; } set{ _duplicate_name=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"EnterItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string EnterItem { get{ return _enter_item; } set{ _enter_item=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"EnterTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int EnterTime { get{ return _enter_time; } set{ _enter_time=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"EnterType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int EnterType { get{ return _enter_type; } set{ _enter_type=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"EquipLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int EquipLevel { get{ return _equipLevel; } set{ _equipLevel=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"ExistTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ExistTime { get{ return _exist_time; } set{ _exist_time=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"Explain", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Explain { get{ return _explain; } set{ _explain=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"ExtraReward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ExtraReward { get{ return _extra_reward; } set{ _extra_reward=value; } }
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"FailReward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string FailReward { get{ return _fail_reward; } set{ _fail_reward=value; } }
    [global::ProtoBuf.ProtoMember(20, IsRequired = true, Name=@"GoodRewardID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string GoodRewardID { get{ return _good_reward_ID; } set{ _good_reward_ID=value; } }
    [global::ProtoBuf.ProtoMember(21, IsRequired = true, Name=@"GroupId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int GroupId { get{ return _group_id; } set{ _group_id=value; } }
    [global::ProtoBuf.ProtoMember(22, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(23, IsRequired = true, Name=@"IfDouble", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int IfDouble { get{ return _if_double; } set{ _if_double=value; } }
    [global::ProtoBuf.ProtoMember(24, IsRequired = true, Name=@"IfUseUp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int IfUseUp { get{ return _if_use_up; } set{ _if_use_up=value; } }
    [global::ProtoBuf.ProtoMember(25, IsRequired = true, Name=@"Isscript", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Isscript { get{ return _isscript; } set{ _isscript=value; } }
    [global::ProtoBuf.ProtoMember(26, IsRequired = true, Name=@"ManualNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ManualNum { get{ return _manual_num; } set{ _manual_num=value; } }
    [global::ProtoBuf.ProtoMember(27, IsRequired = true, Name=@"Mapid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Mapid { get{ return _mapid; } set{ _mapid=value; } }
    [global::ProtoBuf.ProtoMember(28, IsRequired = true, Name=@"MaterialLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MaterialLevel { get{ return _materialLevel; } set{ _materialLevel=value; } }
    [global::ProtoBuf.ProtoMember(29, IsRequired = true, Name=@"MaxLv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MaxLv { get{ return _max_lv; } set{ _max_lv=value; } }
    [global::ProtoBuf.ProtoMember(30, IsRequired = true, Name=@"MaxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MaxNum { get{ return _max_num; } set{ _max_num=value; } }
    [global::ProtoBuf.ProtoMember(31, IsRequired = true, Name=@"MinLv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MinLv { get{ return _min_lv; } set{ _min_lv=value; } }
    [global::ProtoBuf.ProtoMember(32, IsRequired = true, Name=@"MinNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MinNum { get{ return _min_num; } set{ _min_num=value; } }
    [global::ProtoBuf.ProtoMember(33, IsRequired = true, Name=@"ModelRotat", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ModelRotat { get{ return _model_rotat; } set{ _model_rotat=value; } }
    [global::ProtoBuf.ProtoMember(34, IsRequired = true, Name=@"NeedTaskId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string NeedTaskId { get{ return _needTaskId; } set{ _needTaskId=value; } }
    [global::ProtoBuf.ProtoMember(35, IsRequired = true, Name=@"OpenInterface", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OpenInterface { get{ return _open_interface; } set{ _open_interface=value; } }
    [global::ProtoBuf.ProtoMember(36, IsRequired = true, Name=@"OpenTime", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OpenTime { get{ return _open_time; } set{ _open_time=value; } }
    [global::ProtoBuf.ProtoMember(37, IsRequired = true, Name=@"OpenType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int OpenType { get{ return _open_type; } set{ _open_type=value; } }
    [global::ProtoBuf.ProtoMember(38, IsRequired = true, Name=@"Params", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Params { get{ return _params; } set{ _params=value; } }
    [global::ProtoBuf.ProtoMember(39, IsRequired = true, Name=@"ParticipationAward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ParticipationAward { get{ return _participation_Award; } set{ _participation_Award=value; } }
    [global::ProtoBuf.ProtoMember(40, IsRequired = true, Name=@"ParticipationAward1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ParticipationAward1 { get{ return _participation_Award1; } set{ _participation_Award1=value; } }
    [global::ProtoBuf.ProtoMember(41, IsRequired = true, Name=@"PictureRes", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string PictureRes { get{ return _pictureRes; } set{ _pictureRes=value; } }
    [global::ProtoBuf.ProtoMember(42, IsRequired = true, Name=@"Point", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Point { get{ return _point; } set{ _point=value; } }
    [global::ProtoBuf.ProtoMember(43, IsRequired = true, Name=@"PrefectRewardID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string PrefectRewardID { get{ return _prefect_reward_ID; } set{ _prefect_reward_ID=value; } }
    [global::ProtoBuf.ProtoMember(44, IsRequired = true, Name=@"RandomDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string RandomDescription { get{ return _random_Description; } set{ _random_Description=value; } }
    [global::ProtoBuf.ProtoMember(45, IsRequired = true, Name=@"ResetTime", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ResetTime { get{ return _reset_time; } set{ _reset_time=value; } }
    [global::ProtoBuf.ProtoMember(46, IsRequired = true, Name=@"ResurrectionType", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ResurrectionType { get{ return _resurrection_type; } set{ _resurrection_type=value; } }
    [global::ProtoBuf.ProtoMember(47, IsRequired = true, Name=@"Runningyedai", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Runningyedai { get{ return _runningyedai; } set{ _runningyedai=value; } }
    [global::ProtoBuf.ProtoMember(48, IsRequired = true, Name=@"ShowHead", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ShowHead { get{ return _show_head; } set{ _show_head=value; } }
    [global::ProtoBuf.ProtoMember(49, IsRequired = true, Name=@"ShowModel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ShowModel { get{ return _show_model; } set{ _show_model=value; } }
    [global::ProtoBuf.ProtoMember(50, IsRequired = true, Name=@"SignUpTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SignUpTime { get{ return _sign_up_time; } set{ _sign_up_time=value; } }
    [global::ProtoBuf.ProtoMember(51, IsRequired = true, Name=@"SuccessReward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SuccessReward { get{ return _success_reward; } set{ _success_reward=value; } }
    [global::ProtoBuf.ProtoMember(52, IsRequired = true, Name=@"Sweep", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Sweep { get{ return _sweep; } set{ _sweep=value; } }
    [global::ProtoBuf.ProtoMember(53, IsRequired = true, Name=@"Teamshow", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Teamshow { get{ return _teamshow; } set{ _teamshow=value; } }
    [global::ProtoBuf.ProtoMember(54, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    [global::ProtoBuf.ProtoMember(55, IsRequired = true, Name=@"TypeName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TypeName { get{ return _type_name; } set{ _type_name=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareCloneMap Create( string in_big_chest_id, int in_camera_size, int in_canCrossSerever, int in_canManyPeople, int in_canOnePeople, int in_canUpMorale, int in_checkCamp, int in_cinematic, int in_clone_story, int in_combat_power, string in_duplicate_name, string in_enter_item, int in_enter_time, int in_enter_type, int in_equipLevel, int in_exist_time, string in_explain, string in_extra_reward, string in_fail_reward, string in_good_reward_ID, int in_group_id, int in_id, int in_if_double, int in_if_use_up, int in_isscript, int in_manual_num, string in_mapid, int in_materialLevel, int in_max_lv, int in_max_num, int in_min_lv, int in_min_num, int in_model_rotat, string in_needTaskId, int in_open_interface, string in_open_time, int in_open_type, string in_params, string in_participation_Award, string in_participation_Award1, string in_pictureRes, string in_point, string in_prefect_reward_ID, string in_random_Description, string in_reset_time, string in_resurrection_type, string in_runningyedai, int in_show_head, int in_show_model, int in_sign_up_time, string in_success_reward, string in_sweep, int in_teamshow, int in_type, string in_type_name )
    {
      DeclareCloneMap tmp = new DeclareCloneMap();
      tmp._big_chest_id = in_big_chest_id;
      tmp._camera_size = in_camera_size;
      tmp._canCrossSerever = in_canCrossSerever;
      tmp._canManyPeople = in_canManyPeople;
      tmp._canOnePeople = in_canOnePeople;
      tmp._canUpMorale = in_canUpMorale;
      tmp._checkCamp = in_checkCamp;
      tmp._cinematic = in_cinematic;
      tmp._clone_story = in_clone_story;
      tmp._combat_power = in_combat_power;
      tmp._duplicate_name = in_duplicate_name;
      tmp._enter_item = in_enter_item;
      tmp._enter_time = in_enter_time;
      tmp._enter_type = in_enter_type;
      tmp._equipLevel = in_equipLevel;
      tmp._exist_time = in_exist_time;
      tmp._explain = in_explain;
      tmp._extra_reward = in_extra_reward;
      tmp._fail_reward = in_fail_reward;
      tmp._good_reward_ID = in_good_reward_ID;
      tmp._group_id = in_group_id;
      tmp._id = in_id;
      tmp._if_double = in_if_double;
      tmp._if_use_up = in_if_use_up;
      tmp._isscript = in_isscript;
      tmp._manual_num = in_manual_num;
      tmp._mapid = in_mapid;
      tmp._materialLevel = in_materialLevel;
      tmp._max_lv = in_max_lv;
      tmp._max_num = in_max_num;
      tmp._min_lv = in_min_lv;
      tmp._min_num = in_min_num;
      tmp._model_rotat = in_model_rotat;
      tmp._needTaskId = in_needTaskId;
      tmp._open_interface = in_open_interface;
      tmp._open_time = in_open_time;
      tmp._open_type = in_open_type;
      tmp._params = in_params;
      tmp._participation_Award = in_participation_Award;
      tmp._participation_Award1 = in_participation_Award1;
      tmp._pictureRes = in_pictureRes;
      tmp._point = in_point;
      tmp._prefect_reward_ID = in_prefect_reward_ID;
      tmp._random_Description = in_random_Description;
      tmp._reset_time = in_reset_time;
      tmp._resurrection_type = in_resurrection_type;
      tmp._runningyedai = in_runningyedai;
      tmp._show_head = in_show_head;
      tmp._show_model = in_show_model;
      tmp._sign_up_time = in_sign_up_time;
      tmp._success_reward = in_success_reward;
      tmp._sweep = in_sweep;
      tmp._teamshow = in_teamshow;
      tmp._type = in_type;
      tmp._type_name = in_type_name;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareCloneMap> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareCloneMap> _dataCaches = null;
    public static Dictionary<int, DeclareCloneMap> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataCloneMap");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataCloneMap = require 'Lua/Config/DataCloneMap'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataCloneMap");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareCloneMap>(233);
                     foreach (var item in dic)
                     {
                         DeclareCloneMap tmp = new DeclareCloneMap();
                       tmp.BigChestId = CfgStringLua.Get(item.Value[0]);
                       tmp.CameraSize = item.Value[1];
                       tmp.CanCrossSerever = item.Value[2];
                       tmp.CanManyPeople = item.Value[3];
                       tmp.CanOnePeople = item.Value[4];
                       tmp.CanUpMorale = item.Value[5];
                       tmp.CheckCamp = item.Value[6];
                       tmp.Cinematic = item.Value[7];
                       tmp.CloneStory = item.Value[8];
                       tmp.CombatPower = item.Value[9];
                       tmp.DuplicateName = CfgStringLua.Get(item.Value[10]);
                       tmp.EnterItem = CfgStringLua.Get(item.Value[11]);
                       tmp.EnterTime = item.Value[12];
                       tmp.EnterType = item.Value[13];
                       tmp.EquipLevel = item.Value[14];
                       tmp.ExistTime = item.Value[15];
                       tmp.Explain = CfgStringLua.Get(item.Value[16]);
                       tmp.ExtraReward = CfgStringLua.Get(item.Value[17]);
                       tmp.FailReward = CfgStringLua.Get(item.Value[18]);
                       tmp.GoodRewardID = CfgStringLua.Get(item.Value[19]);
                       tmp.GroupId = item.Value[20];
                       tmp.Id = item.Value[21];
                       tmp.IfDouble = item.Value[22];
                       tmp.IfUseUp = item.Value[23];
                       tmp.Isscript = item.Value[24];
                       tmp.ManualNum = item.Value[25];
                       tmp.Mapid = CfgStringLua.Get(item.Value[26]);
                       tmp.MaterialLevel = item.Value[27];
                       tmp.MaxLv = item.Value[28];
                       tmp.MaxNum = item.Value[29];
                       tmp.MinLv = item.Value[30];
                       tmp.MinNum = item.Value[31];
                       tmp.ModelRotat = item.Value[32];
                       tmp.NeedTaskId = CfgStringLua.Get(item.Value[33]);
                       tmp.OpenInterface = item.Value[34];
                       tmp.OpenTime = CfgStringLua.Get(item.Value[35]);
                       tmp.OpenType = item.Value[36];
                       tmp.Params = CfgStringLua.Get(item.Value[37]);
                       tmp.ParticipationAward = CfgStringLua.Get(item.Value[38]);
                       tmp.ParticipationAward1 = CfgStringLua.Get(item.Value[39]);
                       tmp.PictureRes = CfgStringLua.Get(item.Value[40]);
                       tmp.Point = CfgStringLua.Get(item.Value[41]);
                       tmp.PrefectRewardID = CfgStringLua.Get(item.Value[42]);
                       tmp.RandomDescription = CfgStringLua.Get(item.Value[43]);
                       tmp.ResetTime = CfgStringLua.Get(item.Value[44]);
                       tmp.ResurrectionType = CfgStringLua.Get(item.Value[45]);
                       tmp.Runningyedai = CfgStringLua.Get(item.Value[46]);
                       tmp.ShowHead = item.Value[47];
                       tmp.ShowModel = item.Value[48];
                       tmp.SignUpTime = item.Value[49];
                       tmp.SuccessReward = CfgStringLua.Get(item.Value[50]);
                       tmp.Sweep = CfgStringLua.Get(item.Value[51]);
                       tmp.Teamshow = item.Value[52];
                       tmp.Type = item.Value[53];
                       tmp.TypeName = CfgStringLua.Get(item.Value[54]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"CloneMap");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareCloneMap>(233);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"CloneMap");
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
    public static DeclareCloneMap Get(int id)
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
    public static void Transform(Dictionary<int, DeclareCloneMap> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
