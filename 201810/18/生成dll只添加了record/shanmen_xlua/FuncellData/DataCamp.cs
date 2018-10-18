//文件是自动生成,请勿手动修改.来自数据文件:Camp
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataCamp
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareCamp> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(0,DeclareCamp.Create(998, 0, StringDefines.Key_20473));
          data.Add(1,DeclareCamp.Create(101, 1, StringDefines.Key_20474));
          data.Add(2,DeclareCamp.Create(101, 2, StringDefines.Key_20475));
          data.Add(3,DeclareCamp.Create(0, 3, StringDefines.Key_20476));
          data.Add(4,DeclareCamp.Create(0, 4, StringDefines.Key_20477));
      }
      #endregion
  }
}
