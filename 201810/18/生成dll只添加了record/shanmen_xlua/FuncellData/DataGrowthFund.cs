//文件是自动生成,请勿手动修改.来自数据文件:growthFund
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataGrowthFund
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareGrowthFund> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(50,DeclareGrowthFund.Create(StringDefines.Key_58316, 50));
          data.Add(100,DeclareGrowthFund.Create(StringDefines.Key_58317, 100));
          data.Add(150,DeclareGrowthFund.Create(StringDefines.Key_58318, 150));
          data.Add(180,DeclareGrowthFund.Create(StringDefines.Key_58319, 180));
          data.Add(220,DeclareGrowthFund.Create(StringDefines.Key_58320, 220));
          data.Add(260,DeclareGrowthFund.Create(StringDefines.Key_58321, 260));
          data.Add(300,DeclareGrowthFund.Create(StringDefines.Key_58322, 300));
      }
      #endregion
  }
}
