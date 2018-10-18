//文件是自动生成,请勿手动修改.来自数据文件:temple
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataTemple
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareTemple> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(1,DeclareTemple.Create(1003, StringDefines.Key_50181, 432000, 0, 5501, 3, StringDefines.Key_50182, 1, StringDefines.Key_50183, 1004, StringDefines.Key_14344, 1, 864000, 600, 480, StringDefines.Key_50184, 0));
          data.Add(2,DeclareTemple.Create(1005, StringDefines.Key_50185, 432000, 1, 5502, 3, StringDefines.Key_50186, 1, StringDefines.Key_50183, 1006, StringDefines.Key_14350, 2, 864000, 600, 480, StringDefines.Key_50187, 0));
      }
      #endregion
  }
}
