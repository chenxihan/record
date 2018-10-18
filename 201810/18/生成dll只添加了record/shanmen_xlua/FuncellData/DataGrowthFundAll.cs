//文件是自动生成,请勿手动修改.来自数据文件:growthFund_all
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataGrowthFundAll
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareGrowthFundAll> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(50,DeclareGrowthFundAll.Create(StringDefines.Key_13613, 50, 0, 0));
          data.Add(100,DeclareGrowthFundAll.Create(StringDefines.Key_13614, 100, 100, 24));
          data.Add(200,DeclareGrowthFundAll.Create(StringDefines.Key_13615, 200, 0, 0));
          data.Add(300,DeclareGrowthFundAll.Create(StringDefines.Key_13616, 300, 300, 96));
          data.Add(400,DeclareGrowthFundAll.Create(StringDefines.Key_13617, 400, 0, 0));
          data.Add(500,DeclareGrowthFundAll.Create(StringDefines.Key_13618, 500, 0, 0));
      }
      #endregion
  }
}
