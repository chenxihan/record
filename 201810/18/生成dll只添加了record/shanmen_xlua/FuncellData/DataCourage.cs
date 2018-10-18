//文件是自动生成,请勿手动修改.来自数据文件:courage
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataCourage
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareCourage> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(1,DeclareCourage.Create(5, 0, StringDefines.Key_17915, 962, 1, 0, 1051000, 0, 10, 0, 0, 0, StringDefines.Key_14464));
          data.Add(2,DeclareCourage.Create(21, 0, StringDefines.Key_17916, 963, 2, 10000, 1055000, 0, 0, 0, 0, 0, StringDefines.Key_3989));
          data.Add(3,DeclareCourage.Create(22, 0, StringDefines.Key_17917, 974, 3, 30000, 1056000, 0, 0, 0, 0, 0, StringDefines.Key_3987));
      }
      #endregion
  }
}
