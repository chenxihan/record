//文件是自动生成,请勿手动修改.来自数据文件:question_warehouse
using System;
using System.Collections.Generic;
using XLua;
namespace Funcell.Cfg.Data
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeclareQuestionWarehouse")]
  public class DeclareQuestionWarehouse
  {
    #region //私有变量定义
    //正确答案
    private string _answer_1;
    //错误答案
    private string _answer_2;
    //错误答案
    private string _answer_3;
    //答题题面
    private string _describe;
    //ID编号
    private int _id;
    //排序
    private string _sort;
    #endregion

    #region //公共属性
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Answer1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Answer1 { get{ return _answer_1; } set{ _answer_1=value; } }
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Answer2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Answer2 { get{ return _answer_2; } set{ _answer_2=value; } }
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Answer3", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Answer3 { get{ return _answer_3; } set{ _answer_3=value; } }
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Describe", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Describe { get{ return _describe; } set{ _describe=value; } }
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id { get{ return _id; } set{ _id=value; } }
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Sort", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Sort { get{ return _sort; } set{ _sort=value; } }
    #endregion

    #region //Create函数的定义
    public static DeclareQuestionWarehouse Create( string in_answer_1, string in_answer_2, string in_answer_3, string in_describe, int in_id, string in_sort )
    {
      DeclareQuestionWarehouse tmp = new DeclareQuestionWarehouse();
      tmp._answer_1 = in_answer_1;
      tmp._answer_2 = in_answer_2;
      tmp._answer_3 = in_answer_3;
      tmp._describe = in_describe;
      tmp._id = in_id;
      tmp._sort = in_sort;

      return tmp;
    }
    #endregion

    #region //静态变量以及方法定义
    //线程锁对象
    private static object _lockObj = new object();
    //填充数据回调
    public delegate void OnFillDataHandler(Dictionary<int, DeclareQuestionWarehouse> data);
    private static OnFillDataHandler _fillDataCallBack = null;
    //数据存储字典
    private static Dictionary<int, DeclareQuestionWarehouse> _dataCaches = null;
    public static Dictionary<int, DeclareQuestionWarehouse> CacheData
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
                 Dictionary<int, int[]> dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataQuestionWarehouse");
                 if (dic == null)
                  {
                       LuaEnv.SharedLuaEnv.DoString("DataQuestionWarehouse = require 'Lua/Config/DataQuestionWarehouse'");
                       dic = LuaEnv.SharedLuaEnv.Global.Get<Dictionary<int, int[]>>("DataQuestionWarehouse");                  }

                 if (dic != null)
                 {
                             _dataCaches = new Dictionary<int, DeclareQuestionWarehouse>(79);
                     foreach (var item in dic)
                     {
                         DeclareQuestionWarehouse tmp = new DeclareQuestionWarehouse();
                       tmp.Answer1 = CfgStringLua.Get(item.Value[0]);
                       tmp.Answer2 = CfgStringLua.Get(item.Value[1]);
                       tmp.Answer3 = CfgStringLua.Get(item.Value[2]);
                       tmp.Describe = CfgStringLua.Get(item.Value[3]);
                       tmp.Id = item.Value[4];
                       tmp.Sort = CfgStringLua.Get(item.Value[5]);

                         _dataCaches.Add(item.Key, tmp);
                     }
                 }
                 Record(startTime, DateTime.Now.Ticks,"QuestionWarehouse");
             }
             if (_dataCaches == null && _fillDataCallBack != null)
             {
                 if (_dataCaches == null)
                 {
                     long startTime = DateTime.Now.Ticks;
                      _dataCaches = new Dictionary<int, DeclareQuestionWarehouse>(79);
                      _fillDataCallBack(_dataCaches); 
                      Record(startTime, DateTime.Now.Ticks,"QuestionWarehouse");
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
    public static DeclareQuestionWarehouse Get(int id)
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
    public static void Transform(Dictionary<int, DeclareQuestionWarehouse> data)
    {
        lock (_lockObj)
        {
            _dataCaches = data;
        }
    }
    #endregion
  }
}
