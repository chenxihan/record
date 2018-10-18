//文件是自动生成,请勿手动修改.来自数据文件:recharge_daily_total
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataRechargeDailyTotal
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareRechargeDailyTotal> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(1,DeclareRechargeDailyTotal.Create(StringDefines.Key_20281, 1, 1, 60, 1));
          data.Add(2,DeclareRechargeDailyTotal.Create(StringDefines.Key_20282, 1, 2, 300, 1));
          data.Add(3,DeclareRechargeDailyTotal.Create(StringDefines.Key_20283, 1, 3, 680, 1));
          data.Add(4,DeclareRechargeDailyTotal.Create(StringDefines.Key_20284, 1, 4, 300, 2));
          data.Add(5,DeclareRechargeDailyTotal.Create(StringDefines.Key_20285, 2, 5, 300, 2));
          data.Add(6,DeclareRechargeDailyTotal.Create(StringDefines.Key_20286, 3, 6, 300, 2));
      }
      #endregion
  }
}
