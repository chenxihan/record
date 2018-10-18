//文件是自动生成,请勿手动修改.来自数据文件:marriage_dinner
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataMarriageDinner
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareMarriageDinner> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(1,DeclareMarriageDinner.Create(10000, StringDefines.Key_13607, 5000, 839, 20, 1, StringDefines.Key_13608, 1, StringDefines.Key_20));
          data.Add(2,DeclareMarriageDinner.Create(20000, StringDefines.Key_13609, 10000, 840, 20, 2, StringDefines.Key_13610, 1, StringDefines.Key_20));
          data.Add(3,DeclareMarriageDinner.Create(30000, StringDefines.Key_13611, 15000, 841, 20, 3, StringDefines.Key_13612, 1, StringDefines.Key_20));
      }
      #endregion
  }
}
