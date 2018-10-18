//文件是自动生成,请勿手动修改.来自数据文件:item
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareItem")]
  public class DeclareItem
  {
    #region //私有变量定义
    //拍卖价格
    private string _auction_price;
    //绑定类型（0：不绑定；1：获得时绑定；2：使用后绑定）
    private int _bind;
    //物品天生颜色（1：白色；2：绿色；3：蓝色；4：紫色；5：橙色；6：金色；7：红色）
    private int _color;
    //药品冷却时间(毫秒)
    private int _cooling_time;
    //CD_ID
    private int _cooling_time_id;
    //物品常规描述hide
    private string _description;
    //1表示1个钻石，2表示2个钻石，0表示没有钻石，钻石显示为左上角
    private int _diamond_Number;
    //掉落出来的堆叠的物品数量（hide）
    private int _drop_item_num;
    //掉落模型ID
    private int _drop_model;
    //装备光效编号hide
    private int _effect;
    //效果配置[@;@_@]
    private string _effect_num;
    //获取途径 功能ID_功能参数_功能名字_功能Icon;功能ID_功能参数_功能名字_功能Icon（hide）
    private string _get_text;
    //物品icon编号hide
    private int _icon;
    //物品ID
    private int _id;
    //是否可以拍卖
    private int _if_auction;
    //二次确定提示(0：不弹出；1：弹出)
    private int _if_confirm;
    //是否可以出售（填0为可以，填1为不可以）
    private int _if_sell;
    //是否能被拆分(0：不能拆分；1：可以拆分)
    private int _if_Split;
    //物品是否可使用(填0为可使用，填1为不可使用)
    private int _if_use;
    //获得时是否有获得提示（0，没有；1，有）
    private int _if_use_info;
    //物品的蓝钻价值
    private int _item_Price;
    //物品使用等级
    private int _level;
    //物品光效编号hide
    private int _light_effect;
    //最大叠加数（1：不可叠加，其他自然数：该物品最大叠加数量；除货币之外的最大值为9999）
    private Int64 _max;
    //物品最高使用等级
    private int _max_level;
    //物品名字
    private string _name;
    //是否任务检查（0否1是）
    private int _needTaskCheck;
    //是否翅膀检查（0否1是）
    private int _needwingCheck;
    //玩家使用职业限制（0：齐王府；1：六扇门；2：待定职业1；3：待定职业2；9：通用）
    private int _occupation;
    //使用部位(针对技能书)(0头盔.1武器.2胸甲.3项链.4腰带.5腿甲.6鞋子.7戒指)(@_@)
    private string _part;
    //卖出单价
    private int _sell_num;
    //卖出货币类型（不可以填元宝和绑定元宝）
    private int _sell_type;
    //玩家使用性别限制（0：女；1：男；2：通用）
    private int _sex;
    //展示的内容（时装，坐骑，宠物用模型ID，称号用名字）
    private string _show_id;
    //物品预览类型（0，没有预览；1，宠物；2，坐骑；3，时装身体，4,时装武器,5,称号,6器灵）
    private int _show_type;
    //模型缩放（百分比）
    private int _size_scale;
    //物品类型(1：货币；2：药水；3：经验类道具； 4：自动寻路类；5：任务类；6：技能书；7：脚本道具；8：材料；9：普通道具；10：礼包；11：任务类；12：宝石类；13：特殊类；14：怪物灵魄;15：属性果实；16:碎片类;17:魔法纹章；18:魂兽装备；19:魂兽水晶；20:符文；21符文材料)
    private int _type;
    //物品使用时打开的UI_idhide
    private int _ues_UI_id;
    //物品自动使用优先级，为0表示不能使用，优先级越大越先使用hide
    private int _use_PRI;
    //使用后学会技能编号或技能等级加一
    private int _use_skill;
    //是否能批量使用(0：不能批量使用；1：可以批量使用)
    private int _whether_batch;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"AuctionPrice", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string AuctionPrice { get{ return _auction_price; } set{ _auction_price=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Bind", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Bind { get{ return _bind; } set{ _bind=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Color", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Color { get{ return _color; } set{ _color=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"CoolingTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CoolingTime { get{ return _cooling_time; } set{ _cooling_time=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"CoolingTimeId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CoolingTimeId { get{ return _cooling_time_id; } set{ _cooling_time_id=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Description { get{ return _description; } set{ _description=value; } }
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"DiamondNumber", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DiamondNumber { get{ return _diamond_Number; } set{ _diamond_Number=value; } }
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"DropItemNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DropItemNum { get{ return _drop_item_num; } set{ _drop_item_num=value; } }
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"DropModel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int DropModel { get{ return _drop_model; } set{ _drop_model=value; } }
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Effect", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Effect { get{ return _effect; } set{ _effect=value; } }
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"EffectNum", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string EffectNum { get{ return _effect_num; } set{ _effect_num=value; } }
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"GetText", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string GetText { get{ return _get_text; } set{ _get_text=value; } }
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Icon { get{ return _icon; } set{ _icon=value; } }
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"IfAuction", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int IfAuction { get{ return _if_auction; } set{ _if_auction=value; } }
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"IfConfirm", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int IfConfirm { get{ return _if_confirm; } set{ _if_confirm=value; } }
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"IfSell", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int IfSell { get{ return _if_sell; } set{ _if_sell=value; } }
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"IfSplit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int IfSplit { get{ return _if_Split; } set{ _if_Split=value; } }
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"IfUse", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int IfUse { get{ return _if_use; } set{ _if_use=value; } }
    [global::ProtoBuf.ProtoMember(20, IsRequired = true, Name=@"IfUseInfo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int IfUseInfo { get{ return _if_use_info; } set{ _if_use_info=value; } }
    [global::ProtoBuf.ProtoMember(21, IsRequired = true, Name=@"ItemPrice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ItemPrice { get{ return _item_Price; } set{ _item_Price=value; } }
    [global::ProtoBuf.ProtoMember(22, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Level { get{ return _level; } set{ _level=value; } }
    [global::ProtoBuf.ProtoMember(23, IsRequired = true, Name=@"LightEffect", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int LightEffect { get{ return _light_effect; } set{ _light_effect=value; } }
    [global::ProtoBuf.ProtoMember(24, IsRequired = true, Name=@"Max", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Int64 Max { get{ return _max; } set{ _max=value; } }
    [global::ProtoBuf.ProtoMember(25, IsRequired = true, Name=@"MaxLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MaxLevel { get{ return _max_level; } set{ _max_level=value; } }
    [global::ProtoBuf.ProtoMember(26, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name { get{ return _name; } set{ _name=value; } }
    [global::ProtoBuf.ProtoMember(27, IsRequired = true, Name=@"NeedTaskCheck", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NeedTaskCheck { get{ return _needTaskCheck; } set{ _needTaskCheck=value; } }
    [global::ProtoBuf.ProtoMember(28, IsRequired = true, Name=@"NeedwingCheck", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NeedwingCheck { get{ return _needwingCheck; } set{ _needwingCheck=value; } }
    [global::ProtoBuf.ProtoMember(29, IsRequired = true, Name=@"Occupation", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Occupation { get{ return _occupation; } set{ _occupation=value; } }
    [global::ProtoBuf.ProtoMember(30, IsRequired = true, Name=@"Part", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Part { get{ return _part; } set{ _part=value; } }
    [global::ProtoBuf.ProtoMember(31, IsRequired = true, Name=@"SellNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SellNum { get{ return _sell_num; } set{ _sell_num=value; } }
    [global::ProtoBuf.ProtoMember(32, IsRequired = true, Name=@"SellType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SellType { get{ return _sell_type; } set{ _sell_type=value; } }
    [global::ProtoBuf.ProtoMember(33, IsRequired = true, Name=@"Sex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Sex { get{ return _sex; } set{ _sex=value; } }
    [global::ProtoBuf.ProtoMember(34, IsRequired = true, Name=@"ShowId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ShowId { get{ return _show_id; } set{ _show_id=value; } }
    [global::ProtoBuf.ProtoMember(35, IsRequired = true, Name=@"ShowType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ShowType { get{ return _show_type; } set{ _show_type=value; } }
    [global::ProtoBuf.ProtoMember(36, IsRequired = true, Name=@"SizeScale", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SizeScale { get{ return _size_scale; } set{ _size_scale=value; } }
    [global::ProtoBuf.ProtoMember(37, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type { get{ return _type; } set{ _type=value; } }
    [global::ProtoBuf.ProtoMember(38, IsRequired = true, Name=@"UesUIId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UesUIId { get{ return _ues_UI_id; } set{ _ues_UI_id=value; } }
    [global::ProtoBuf.ProtoMember(39, IsRequired = true, Name=@"UsePRI", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UsePRI { get{ return _use_PRI; } set{ _use_PRI=value; } }
    [global::ProtoBuf.ProtoMember(40, IsRequired = true, Name=@"UseSkill", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UseSkill { get{ return _use_skill; } set{ _use_skill=value; } }
    [global::ProtoBuf.ProtoMember(41, IsRequired = true, Name=@"WhetherBatch", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int WhetherBatch { get{ return _whether_batch; } set{ _whether_batch=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareItem Create( string in_auction_price, int in_bind, int in_color, int in_cooling_time, int in_cooling_time_id, string in_description, int in_diamond_Number, int in_drop_item_num, int in_drop_model, int in_effect, string in_effect_num, string in_get_text, int in_icon, int in_id, int in_if_auction, int in_if_confirm, int in_if_sell, int in_if_Split, int in_if_use, int in_if_use_info, int in_item_Price, int in_level, int in_light_effect, Int64 in_max, int in_max_level, string in_name, int in_needTaskCheck, int in_needwingCheck, int in_occupation, string in_part, int in_sell_num, int in_sell_type, int in_sex, string in_show_id, int in_show_type, int in_size_scale, int in_type, int in_ues_UI_id, int in_use_PRI, int in_use_skill, int in_whether_batch )
    {
      DeclareItem tmp = new DeclareItem();
      tmp._auction_price = in_auction_price;
      tmp._bind = in_bind;
      tmp._color = in_color;
      tmp._cooling_time = in_cooling_time;
      tmp._cooling_time_id = in_cooling_time_id;
      tmp._description = in_description;
      tmp._diamond_Number = in_diamond_Number;
      tmp._drop_item_num = in_drop_item_num;
      tmp._drop_model = in_drop_model;
      tmp._effect = in_effect;
      tmp._effect_num = in_effect_num;
      tmp._get_text = in_get_text;
      tmp._icon = in_icon;
      tmp._id = in_id;
      tmp._if_auction = in_if_auction;
      tmp._if_confirm = in_if_confirm;
      tmp._if_sell = in_if_sell;
      tmp._if_Split = in_if_Split;
      tmp._if_use = in_if_use;
      tmp._if_use_info = in_if_use_info;
      tmp._item_Price = in_item_Price;
      tmp._level = in_level;
      tmp._light_effect = in_light_effect;
      tmp._max = in_max;
      tmp._max_level = in_max_level;
      tmp._name = in_name;
      tmp._needTaskCheck = in_needTaskCheck;
      tmp._needwingCheck = in_needwingCheck;
      tmp._occupation = in_occupation;
      tmp._part = in_part;
      tmp._sell_num = in_sell_num;
      tmp._sell_type = in_sell_type;
      tmp._sex = in_sex;
      tmp._show_id = in_show_id;
      tmp._show_type = in_show_type;
      tmp._size_scale = in_size_scale;
      tmp._type = in_type;
      tmp._ues_UI_id = in_ues_UI_id;
      tmp._use_PRI = in_use_PRI;
      tmp._use_skill = in_use_skill;
      tmp._whether_batch = in_whether_batch;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareItem> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareItem> _dataCaches = null;
    public static Dictionary<int, DeclareItem> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataItem");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataItem = require 'Lua/Config/DataItem'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataItem");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareItem>(1543);
                     foreach (var item in dic)
                     {
                         DeclareItem tmp = new DeclareItem();
                       tmp.AuctionPrice = CfgStringLua.Get(item.Value[0]);
                       tmp.Bind = item.Value[1];
                       tmp.Color = item.Value[2];
                       tmp.CoolingTime = item.Value[3];
                       tmp.CoolingTimeId = item.Value[4];
                       tmp.Description = CfgStringLua.Get(item.Value[5]);
                       tmp.DiamondNumber = item.Value[6];
                       tmp.DropItemNum = item.Value[7];
                       tmp.DropModel = item.Value[8];
                       tmp.Effect = item.Value[9];
                       tmp.EffectNum = CfgStringLua.Get(item.Value[10]);
                       tmp.GetText = CfgStringLua.Get(item.Value[11]);
                       tmp.Icon = item.Value[12];
                       tmp.Id = item.Value[13];
                       tmp.IfAuction = item.Value[14];
                       tmp.IfConfirm = item.Value[15];
                       tmp.IfSell = item.Value[16];
                       tmp.IfSplit = item.Value[17];
                       tmp.IfUse = item.Value[18];
                       tmp.IfUseInfo = item.Value[19];
                       tmp.ItemPrice = item.Value[20];
                       tmp.Level = item.Value[21];
                       tmp.LightEffect = item.Value[22];
                       tmp.Max = item.Value[23];
                       tmp.MaxLevel = item.Value[24];
                       tmp.Name = CfgStringLua.Get(item.Value[25]);
                       tmp.NeedTaskCheck = item.Value[26];
                       tmp.NeedwingCheck = item.Value[27];
                       tmp.Occupation = item.Value[28];
                       tmp.Part = CfgStringLua.Get(item.Value[29]);
                       tmp.SellNum = item.Value[30];
                       tmp.SellType = item.Value[31];
                       tmp.Sex = item.Value[32];
                       tmp.ShowId = CfgStringLua.Get(item.Value[33]);
                       tmp.ShowType = item.Value[34];
                       tmp.SizeScale = item.Value[35];
                       tmp.Type = item.Value[36];
                       tmp.UesUIId = item.Value[37];
                       tmp.UsePRI = item.Value[38];
                       tmp.UseSkill = item.Value[39];
                       tmp.WhetherBatch = item.Value[40];

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"Item");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareItem>(1543);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"Item");
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
    public static DeclareItem Get(int id)
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
    public static void Transform(Dictionary<int, DeclareItem> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
