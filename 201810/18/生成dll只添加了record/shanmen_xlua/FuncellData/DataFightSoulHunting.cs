//文件是自动生成,请勿手动修改.来自数据文件:FightSoulHunting
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataFightSoulHunting
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareFightSoulHunting> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(1,DeclareFightSoulHunting.Create(StringDefines.Key_20, 8000, StringDefines.Key_37775, 0, 1, StringDefines.Key_37776, 4000, 67));
          data.Add(2,DeclareFightSoulHunting.Create(StringDefines.Key_20, 10000, StringDefines.Key_37777, 0, 2, StringDefines.Key_37778, 4000, 68));
          data.Add(3,DeclareFightSoulHunting.Create(StringDefines.Key_20, 20000, StringDefines.Key_37779, 0, 3, StringDefines.Key_37780, 3000, 69));
          data.Add(4,DeclareFightSoulHunting.Create(StringDefines.Key_37781, 40000, StringDefines.Key_37782, 0, 4, StringDefines.Key_37783, 4000, 70));
          data.Add(5,DeclareFightSoulHunting.Create(StringDefines.Key_20, 80000, StringDefines.Key_37785, 0, 5, StringDefines.Key_37786, 0, 71));
      }
      #endregion
  }
}
