//文件是自动生成,请勿手动修改.来自数据文件:diamondinvest_level
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataDiamondinvestLevel
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareDiamondinvestLevel> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(1,DeclareDiamondinvestLevel.Create(680, 1, 2, 2));
          data.Add(2,DeclareDiamondinvestLevel.Create(1280, 2, 2, 2));
          data.Add(3,DeclareDiamondinvestLevel.Create(1880, 3, 2, 2));
      }
      #endregion
  }
}
