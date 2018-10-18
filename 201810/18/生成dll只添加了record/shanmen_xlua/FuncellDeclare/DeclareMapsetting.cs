//文件是自动生成,请勿手动修改.来自数据文件:Mapsetting
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareMapsetting")]
  public class DeclareMapsetting
  {
    #region //私有变量定义
    //区域的高
    private int _area_high;
    //区域的宽
    private int _area_width;
    //地图默认挂机方式（0.全地图；1.当前屏）
    private int _auto_fight_set;
    //泛光参数(hide)  泛光阀值_泛光强度_模糊大小
    private string _bloom_param;
    //地图篝火上限
    private int _bonfire_num;
    //出生位置，可区分阵营（0_x_y 表示不区分阵营，所有人都使用此出生点，并且忽略其他配置）(阵营ID_x_y表示某个阵营出生在此位置)(@;@_@)
    private string _bornPosition;
    //摄像机控制参数（hide）0：摄像机默认值参数为默认pitch值，默认yaw值，默认跟随距离；1:限制pitch参数为最小值和最大值；2：限制yaw参数为最小是和最大值;3：限制跟随距离最小值和最大值（各个参数取值范围:pitch值取值范围为-89到89，yaw为-180到180，跟随距离为0到40）；4：2d模式的摄像机参数：固定pitch值，固定yaw值，默认跟随距离
    private string _cam_control_param;
    //摄像机默认视线的距离
    private int _cam_layer_cull_distance;
    //镜头上播放的特效（hide）othervfx中的id
    private int _camera_vfx;
    //地图里边是否可以挂机
    private int _can_mandate;
    //地图内是否允许组队（0为不允许，1为允许）
    private int _can_team;
    //是否能飞（0否 1是）
    private int _canFly;
    //是否能跳（0否 1是）
    private int _canJump;
    //能否上坐骑（0否 1是）
    private int _canRiding;
    //首次进入地图后播放的动画Id（hide）
    private int _cinematic;
    //地图掉落[几率_掉落ID；几率_掉落ID]
    private string _dropMap;
    //聊天框点击坐标的超链接是否弹出提示（0否，1是）
    private int _enterPrompt;
    //是否显示挂机经验收益（0否，1是）
    private int _exp_efficiency;
    //消息分级类型0=普通，1=？
    private int _filter;
    //消息分级的可见人数
    private int _filter_num;
    //飞行最高高度
    private int _fly_max_height;
    //飞行最低高度
    private int _fly_min_height;
    //公会死亡是否发送消息
    private int _guild_kill;
    //世界地图标志资源（hide）
    private int _icon_model;
    //进入最大等级 -1表示无限制
    private int _level_max;
    //进入最小等级 -1表示无限制
    private int _level_min;
    //场景资源名字
    private string _level_name;
    //最大分线数量（此地图的最大分线数量，当线路中人数满了之后，不会新开线路，只会增加线路可容纳人数上限）
    private int _lines;
    //阵营ID
    private int _map_camp;
    //地图阻挡数据
    private string _map_grid;
    //地图id
    private int _map_id;
    //地图怪物NPC采集物寻路点等等
    private string _map_info;
    //地图逻辑类型（客户端专用）（hide）
    private int _map_logic_type;
    //地图服务器类型 -1登录场景，0为本地野图，1为本地副本， 2为跨服野图，3是宠物地图 跨服副本请以10开始
    private int _mapServerType;
    //音乐(hide)
    private string _music;
    //地图名
    private string _name;
    //进入所需VIP等级（0-9）
    private int _needVip;
    //每条线路每批次最大增加人数（例：分线20条，最大人数50。当20条线路都50人后，会再往20条线路中分别投入50人，如果又满了，再加50，依此循环……）
    private int _online;
    //是否安全(0不能pk, 1常规pk， 2无惩罚pk)
    private int _pkState;
    //阵营1复活目标地图ID
    private int _relive_mapId;
    //阵营2复活目标地图ID
    private int _relive_mapId2;
    //复活倒计时（毫秒
    private int _relive_time;
    //复活模式 0回城和原地 、1只回城(跨服只支持本地图)、2自动复活、3.不显示复活界面，4回城和原地，服务器决定是否可以点击按钮
    private int _relive_type;
    //复活位置，可区分阵营（0_x_y 表示不区分阵营）(阵营ID_x_y表示某个阵营专用复活在此位置，回城复活就近原则)(@;@_@)
    private string _relivePosition;
    //阴影参数(hide) 是否开启_灯光方向_阴影强度，例如1;55_0_0;0.5
    private string _shadow_param;
    //是否显示怪物头顶(hide)
    private int _show_monster_hud;
    //是否显示NPC头顶(hide)
    private int _show_npc_hud;
    //是否显示宠物头顶(hide)
    private int _show_pet_hud;
    //是否显示PK值影响的名字颜色(hide)
    private int _show_pk_color;
    //是否默认展示玩家血条（hide)
    private int _show_player_hp;
    //是否显示其他玩家头顶(hide)
    private int _show_player_hud;
    //特殊的外形，在此地图使用特殊的身体外形，例如0_100;1_100，职业_衣服ID；（hide）
    private string _special_body;
    //特殊的名字，在此地图其他玩家都显示为特殊的名字0_齐王府;1_六扇门（hide）
    private string _special_name;
    //特殊的外形，在此地图使用特殊的武器外形，例如0_100;1_100，职业_武器ID；（hide）
    private string _special_weapon;
    //特殊的外形，在此地图使用特殊的翅膀外形，例如0_100;1_100，职业_翅膀ID；（hide）
    private string _special_wing;
    //是否允许组队（0为不允许，1为允许）
    private int _team;
    //是否允许组队传送（0为不允许，1为允许）
    private int _team_sent;
    //加队自动召唤（0不召唤，1召唤）
    private int _teamAuto;
    //地图类型-1登录场景，0世界地图，1副本地图，2竞技场，3帮会，4跨服副本
    private int _type;
    //是否可以使用药品。0为可以使用，1为不可使用
    private int _use_drug;
    //自动寻路的坐标（世界BOSS用，别的不用；阵营ID_x_z）
    private string _xunlu;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"AreaHigh", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int AreaHigh { get{ return _area_high; } set{ _area_high=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"AreaWidth", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int AreaWidth { get{ return _area_width; } set{ _area_width=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"AutoFightSet", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int AutoFightSet { get{ return _auto_fight_set; } set{ _auto_fight_set=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"BloomParam", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string BloomParam { get{ return _bloom_param; } set{ _bloom_param=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"BonfireNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int BonfireNum { get{ return _bonfire_num; } set{ _bonfire_num=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"BornPosition", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string BornPosition { get{ return _bornPosition; } set{ _bornPosition=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"CamControlParam", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string CamControlParam { get{ return _cam_control_param; } set{ _cam_control_param=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"CamLayerCullDistance", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CamLayerCullDistance { get{ return _cam_layer_cull_distance; } set{ _cam_layer_cull_distance=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"CameraVfx", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CameraVfx { get{ return _camera_vfx; } set{ _camera_vfx=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"CanMandate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanMandate { get{ return _can_mandate; } set{ _can_mandate=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"CanTeam", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanTeam { get{ return _can_team; } set{ _can_team=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"CanFly", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanFly { get{ return _canFly; } set{ _canFly=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"CanJump", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanJump { get{ return _canJump; } set{ _canJump=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"CanRiding", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CanRiding { get{ return _canRiding; } set{ _canRiding=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"Cinematic", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Cinematic { get{ return _cinematic; } set{ _cinematic=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"DropMap", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DropMap { get{ return _dropMap; } set{ _dropMap=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"EnterPrompt", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int EnterPrompt { get{ return _enterPrompt; } set{ _enterPrompt=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"ExpEfficiency", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ExpEfficiency { get{ return _exp_efficiency; } set{ _exp_efficiency=value; } }
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"Filter", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Filter { get{ return _filter; } set{ _filter=value; } }
    [global::ProtoBuf.ProtoMember(20, IsRequired = true, Name=@"FilterNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int FilterNum { get{ return _filter_num; } set{ _filter_num=value; } }
    [global::ProtoBuf.ProtoMember(21, IsRequired = true, Name=@"FlyMaxHeight", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int FlyMaxHeight { get{ return _fly_max_height; } set{ _fly_max_height=value; } }
    [global::ProtoBuf.ProtoMember(22, IsRequired = true, Name=@"FlyMinHeight", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int FlyMinHeight { get{ return _fly_min_height; } set{ _fly_min_height=value; } }
    [global::ProtoBuf.ProtoMember(23, IsRequired = true, Name=@"GuildKill", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int GuildKill { get{ return _guild_kill; } set{ _guild_kill=value; } }
    [global::ProtoBuf.ProtoMember(24, IsRequired = true, Name=@"IconModel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int IconModel { get{ return _icon_model; } set{ _icon_model=value; } }
    [global::ProtoBuf.ProtoMember(25, IsRequired = true, Name=@"LevelMax", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int LevelMax { get{ return _level_max; } set{ _level_max=value; } }
    [global::ProtoBuf.ProtoMember(26, IsRequired = true, Name=@"LevelMin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int LevelMin { get{ return _level_min; } set{ _level_min=value; } }
    [global::ProtoBuf.ProtoMember(27, IsRequired = true, Name=@"LevelName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string LevelName { get{ return _level_name; } set{ _level_name=value; } }
    [global::ProtoBuf.ProtoMember(28, IsRequired = true, Name=@"Lines", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Lines { get{ return _lines; } set{ _lines=value; } }
    [global::ProtoBuf.ProtoMember(29, IsRequired = true, Name=@"MapCamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MapCamp { get{ return _map_camp; } set{ _map_camp=value; } }
    [global::ProtoBuf.ProtoMember(30, IsRequired = true, Name=@"MapGrid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string MapGrid { get{ return _map_grid; } set{ _map_grid=value; } }
    [global::ProtoBuf.ProtoMember(31, IsRequired = true, Name=@"MapId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MapId { get{ return _map_id; } set{ _map_id=value; } }
    [global::ProtoBuf.ProtoMember(32, IsRequired = true, Name=@"MapInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string MapInfo { get{ return _map_info; } set{ _map_info=value; } }
    [global::ProtoBuf.ProtoMember(33, IsRequired = true, Name=@"MapLogicType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MapLogicType { get{ return _map_logic_type; } set{ _map_logic_type=value; } }
    [global::ProtoBuf.ProtoMember(34, IsRequired = true, Name=@"MapServerType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MapServerType { get{ return _mapServerType; } set{ _mapServerType=value; } }
    [global::ProtoBuf.ProtoMember(35, IsRequired = true, Name=@"Music", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Music { get{ return _music; } set{ _music=value; } }
    [global::ProtoBuf.ProtoMember(36, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(37, IsRequired = true, Name=@"NeedVip", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NeedVip { get{ return _needVip; } set{ _needVip=value; } }
    [global::ProtoBuf.ProtoMember(38, IsRequired = true, Name=@"Online", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Online { get{ return _online; } set{ _online=value; } }
    [global::ProtoBuf.ProtoMember(39, IsRequired = true, Name=@"PkState", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int PkState { get{ return _pkState; } set{ _pkState=value; } }
    [global::ProtoBuf.ProtoMember(40, IsRequired = true, Name=@"ReliveMapId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ReliveMapId { get{ return _relive_mapId; } set{ _relive_mapId=value; } }
    [global::ProtoBuf.ProtoMember(41, IsRequired = true, Name=@"ReliveMapId2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ReliveMapId2 { get{ return _relive_mapId2; } set{ _relive_mapId2=value; } }
    [global::ProtoBuf.ProtoMember(42, IsRequired = true, Name=@"ReliveTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ReliveTime { get{ return _relive_time; } set{ _relive_time=value; } }
    [global::ProtoBuf.ProtoMember(43, IsRequired = true, Name=@"ReliveType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ReliveType { get{ return _relive_type; } set{ _relive_type=value; } }
    [global::ProtoBuf.ProtoMember(44, IsRequired = true, Name=@"RelivePosition", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string RelivePosition { get{ return _relivePosition; } set{ _relivePosition=value; } }
    [global::ProtoBuf.ProtoMember(45, IsRequired = true, Name=@"ShadowParam", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ShadowParam { get{ return _shadow_param; } set{ _shadow_param=value; } }
    [global::ProtoBuf.ProtoMember(46, IsRequired = true, Name=@"ShowMonsterHud", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ShowMonsterHud { get{ return _show_monster_hud; } set{ _show_monster_hud=value; } }
    [global::ProtoBuf.ProtoMember(47, IsRequired = true, Name=@"ShowNpcHud", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ShowNpcHud { get{ return _show_npc_hud; } set{ _show_npc_hud=value; } }
    [global::ProtoBuf.ProtoMember(48, IsRequired = true, Name=@"ShowPetHud", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ShowPetHud { get{ return _show_pet_hud; } set{ _show_pet_hud=value; } }
    [global::ProtoBuf.ProtoMember(49, IsRequired = true, Name=@"ShowPkColor", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ShowPkColor { get{ return _show_pk_color; } set{ _show_pk_color=value; } }
    [global::ProtoBuf.ProtoMember(50, IsRequired = true, Name=@"ShowPlayerHp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ShowPlayerHp { get{ return _show_player_hp; } set{ _show_player_hp=value; } }
    [global::ProtoBuf.ProtoMember(51, IsRequired = true, Name=@"ShowPlayerHud", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ShowPlayerHud { get{ return _show_player_hud; } set{ _show_player_hud=value; } }
    [global::ProtoBuf.ProtoMember(52, IsRequired = true, Name=@"SpecialBody", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SpecialBody { get{ return _special_body; } set{ _special_body=value; } }
    [global::ProtoBuf.ProtoMember(53, IsRequired = true, Name=@"SpecialName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SpecialName { get{ return _special_name; } set{ _special_name=value; } }
    [global::ProtoBuf.ProtoMember(54, IsRequired = true, Name=@"SpecialWeapon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SpecialWeapon { get{ return _special_weapon; } set{ _special_weapon=value; } }
    [global::ProtoBuf.ProtoMember(55, IsRequired = true, Name=@"SpecialWing", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SpecialWing { get{ return _special_wing; } set{ _special_wing=value; } }
    [global::ProtoBuf.ProtoMember(56, IsRequired = true, Name=@"Team", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Team { get{ return _team; } set{ _team=value; } }
    [global::ProtoBuf.ProtoMember(57, IsRequired = true, Name=@"TeamSent", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TeamSent { get{ return _team_sent; } set{ _team_sent=value; } }
    [global::ProtoBuf.ProtoMember(58, IsRequired = true, Name=@"TeamAuto", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int TeamAuto { get{ return _teamAuto; } set{ _teamAuto=value; } }
    [global::ProtoBuf.ProtoMember(59, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    [global::ProtoBuf.ProtoMember(60, IsRequired = true, Name=@"UseDrug", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UseDrug { get{ return _use_drug; } set{ _use_drug=value; } }
    [global::ProtoBuf.ProtoMember(61, IsRequired = true, Name=@"Xunlu", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Xunlu { get{ return _xunlu; } set{ _xunlu=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareMapsetting Create( int in_area_high, int in_area_width, int in_auto_fight_set, string in_bloom_param, int in_bonfire_num, string in_bornPosition, string in_cam_control_param, int in_cam_layer_cull_distance, int in_camera_vfx, int in_can_mandate, int in_can_team, int in_canFly, int in_canJump, int in_canRiding, int in_cinematic, string in_dropMap, int in_enterPrompt, int in_exp_efficiency, int in_filter, int in_filter_num, int in_fly_max_height, int in_fly_min_height, int in_guild_kill, int in_icon_model, int in_level_max, int in_level_min, string in_level_name, int in_lines, int in_map_camp, string in_map_grid, int in_map_id, string in_map_info, int in_map_logic_type, int in_mapServerType, string in_music, string in_name, int in_needVip, int in_online, int in_pkState, int in_relive_mapId, int in_relive_mapId2, int in_relive_time, int in_relive_type, string in_relivePosition, string in_shadow_param, int in_show_monster_hud, int in_show_npc_hud, int in_show_pet_hud, int in_show_pk_color, int in_show_player_hp, int in_show_player_hud, string in_special_body, string in_special_name, string in_special_weapon, string in_special_wing, int in_team, int in_team_sent, int in_teamAuto, int in_type, int in_use_drug, string in_xunlu )
    {
      DeclareMapsetting tmp = new DeclareMapsetting();
      tmp._area_high = in_area_high;
      tmp._area_width = in_area_width;
      tmp._auto_fight_set = in_auto_fight_set;
      tmp._bloom_param = in_bloom_param;
      tmp._bonfire_num = in_bonfire_num;
      tmp._bornPosition = in_bornPosition;
      tmp._cam_control_param = in_cam_control_param;
      tmp._cam_layer_cull_distance = in_cam_layer_cull_distance;
      tmp._camera_vfx = in_camera_vfx;
      tmp._can_mandate = in_can_mandate;
      tmp._can_team = in_can_team;
      tmp._canFly = in_canFly;
      tmp._canJump = in_canJump;
      tmp._canRiding = in_canRiding;
      tmp._cinematic = in_cinematic;
      tmp._dropMap = in_dropMap;
      tmp._enterPrompt = in_enterPrompt;
      tmp._exp_efficiency = in_exp_efficiency;
      tmp._filter = in_filter;
      tmp._filter_num = in_filter_num;
      tmp._fly_max_height = in_fly_max_height;
      tmp._fly_min_height = in_fly_min_height;
      tmp._guild_kill = in_guild_kill;
      tmp._icon_model = in_icon_model;
      tmp._level_max = in_level_max;
      tmp._level_min = in_level_min;
      tmp._level_name = in_level_name;
      tmp._lines = in_lines;
      tmp._map_camp = in_map_camp;
      tmp._map_grid = in_map_grid;
      tmp._map_id = in_map_id;
      tmp._map_info = in_map_info;
      tmp._map_logic_type = in_map_logic_type;
      tmp._mapServerType = in_mapServerType;
      tmp._music = in_music;
      tmp._name = in_name;
      tmp._needVip = in_needVip;
      tmp._online = in_online;
      tmp._pkState = in_pkState;
      tmp._relive_mapId = in_relive_mapId;
      tmp._relive_mapId2 = in_relive_mapId2;
      tmp._relive_time = in_relive_time;
      tmp._relive_type = in_relive_type;
      tmp._relivePosition = in_relivePosition;
      tmp._shadow_param = in_shadow_param;
      tmp._show_monster_hud = in_show_monster_hud;
      tmp._show_npc_hud = in_show_npc_hud;
      tmp._show_pet_hud = in_show_pet_hud;
      tmp._show_pk_color = in_show_pk_color;
      tmp._show_player_hp = in_show_player_hp;
      tmp._show_player_hud = in_show_player_hud;
      tmp._special_body = in_special_body;
      tmp._special_name = in_special_name;
      tmp._special_weapon = in_special_weapon;
      tmp._special_wing = in_special_wing;
      tmp._team = in_team;
      tmp._team_sent = in_team_sent;
      tmp._teamAuto = in_teamAuto;
      tmp._type = in_type;
      tmp._use_drug = in_use_drug;
      tmp._xunlu = in_xunlu;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareMapsetting> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareMapsetting> _dataCaches = null;
    public static Dictionary<int, DeclareMapsetting> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMapsetting");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataMapsetting = require 'Lua/Config/DataMapsetting'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataMapsetting");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareMapsetting>(232);
                     foreach (var item in dic)
                     {
                         DeclareMapsetting tmp = new DeclareMapsetting();
                       tmp.AreaHigh = item.Value[0];
                       tmp.AreaWidth = item.Value[1];
                       tmp.AutoFightSet = item.Value[2];
                       tmp.BloomParam = CfgStringLua.Get(item.Value[3]);
                       tmp.BonfireNum = item.Value[4];
                       tmp.BornPosition = CfgStringLua.Get(item.Value[5]);
                       tmp.CamControlParam = CfgStringLua.Get(item.Value[6]);
                       tmp.CamLayerCullDistance = item.Value[7];
                       tmp.CameraVfx = item.Value[8];
                       tmp.CanMandate = item.Value[9];
                       tmp.CanTeam = item.Value[10];
                       tmp.CanFly = item.Value[11];
                       tmp.CanJump = item.Value[12];
                       tmp.CanRiding = item.Value[13];
                       tmp.Cinematic = item.Value[14];
                       tmp.DropMap = CfgStringLua.Get(item.Value[15]);
                       tmp.EnterPrompt = item.Value[16];
                       tmp.ExpEfficiency = item.Value[17];
                       tmp.Filter = item.Value[18];
                       tmp.FilterNum = item.Value[19];
                       tmp.FlyMaxHeight = item.Value[20];
                       tmp.FlyMinHeight = item.Value[21];
                       tmp.GuildKill = item.Value[22];
                       tmp.IconModel = item.Value[23];
                       tmp.LevelMax = item.Value[24];
                       tmp.LevelMin = item.Value[25];
                       tmp.LevelName = CfgStringLua.Get(item.Value[26]);
                       tmp.Lines = item.Value[27];
                       tmp.MapCamp = item.Value[28];
                       tmp.MapGrid = CfgStringLua.Get(item.Value[29]);
                       tmp.MapId = item.Value[30];
                       tmp.MapInfo = CfgStringLua.Get(item.Value[31]);
                       tmp.MapLogicType = item.Value[32];
                       tmp.MapServerType = item.Value[33];
                       tmp.Music = CfgStringLua.Get(item.Value[34]);
                       tmp.Name = CfgStringLua.Get(item.Value[35]);
                       tmp.NeedVip = item.Value[36];
                       tmp.Online = item.Value[37];
                       tmp.PkState = item.Value[38];
                       tmp.ReliveMapId = item.Value[39];
                       tmp.ReliveMapId2 = item.Value[40];
                       tmp.ReliveTime = item.Value[41];
                       tmp.ReliveType = item.Value[42];
                       tmp.RelivePosition = CfgStringLua.Get(item.Value[43]);
                       tmp.ShadowParam = CfgStringLua.Get(item.Value[44]);
                       tmp.ShowMonsterHud = item.Value[45];
                       tmp.ShowNpcHud = item.Value[46];
                       tmp.ShowPetHud = item.Value[47];
                       tmp.ShowPkColor = item.Value[48];
                       tmp.ShowPlayerHp = item.Value[49];
                       tmp.ShowPlayerHud = item.Value[50];
                       tmp.SpecialBody = CfgStringLua.Get(item.Value[51]);
                       tmp.SpecialName = CfgStringLua.Get(item.Value[52]);
                       tmp.SpecialWeapon = CfgStringLua.Get(item.Value[53]);
                       tmp.SpecialWing = CfgStringLua.Get(item.Value[54]);
                       tmp.Team = item.Value[55];
                       tmp.TeamSent = item.Value[56];
                       tmp.TeamAuto = item.Value[57];
                       tmp.Type = item.Value[58];
                       tmp.UseDrug = item.Value[59];
                       tmp.Xunlu = CfgStringLua.Get(item.Value[60]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Mapsetting");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareMapsetting>(232);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Mapsetting");
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
    public static DeclareMapsetting Get(int id)
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
    public static void Transform(Dictionary<int, DeclareMapsetting> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
