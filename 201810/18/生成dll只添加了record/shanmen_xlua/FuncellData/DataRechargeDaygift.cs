//文件是自动生成,请勿手动修改.来自数据文件:recharge_daygift
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataRechargeDaygift
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareRechargeDaygift> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(1,DeclareRechargeDaygift.Create(StringDefines.Key_2657, 10, 1, 80049, 2, 1, 1, StringDefines.Key_42275, 1));
          data.Add(3,DeclareRechargeDaygift.Create(StringDefines.Key_2659, 30, 3, 80050, 2, 3, 1, StringDefines.Key_42276, 2));
          data.Add(8,DeclareRechargeDaygift.Create(StringDefines.Key_2661, 80, 8, 80051, 2, 8, 1, StringDefines.Key_42277, 3));
      }
      #endregion
  }
}
