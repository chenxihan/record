//文件是自动生成,请勿手动修改.来自数据文件:marriage_cost
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataMarriageCost
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareMarriageCost> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(1,DeclareMarriageCost.Create(1, 1, StringDefines.Key_20, 200, StringDefines.Key_20054, StringDefines.Key_20055, StringDefines.Key_20056, StringDefines.Key_20, 1));
          data.Add(2,DeclareMarriageCost.Create(2, 2, StringDefines.Key_20, 200, StringDefines.Key_20054, StringDefines.Key_20057, StringDefines.Key_20058, StringDefines.Key_20059, 2));
          data.Add(3,DeclareMarriageCost.Create(3, 3, StringDefines.Key_20060, 200, StringDefines.Key_20061, StringDefines.Key_20062, StringDefines.Key_20063, StringDefines.Key_20059, 3));
      }
      #endregion
  }
}
