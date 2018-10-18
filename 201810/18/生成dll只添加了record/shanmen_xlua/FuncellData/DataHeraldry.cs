//文件是自动生成,请勿手动修改.来自数据文件:heraldry
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataHeraldry
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareHeraldry> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(1,DeclareHeraldry.Create(StringDefines.Key_18035, StringDefines.Key_50188, StringDefines.Key_50189, StringDefines.Key_50190, 0, 2592000, 9, 726, 1, 54001, StringDefines.Key_1953, 8, 2592000, StringDefines.Key_50191, 1));
          data.Add(2,DeclareHeraldry.Create(StringDefines.Key_18035, StringDefines.Key_50188, StringDefines.Key_50189, StringDefines.Key_50190, 0, 2592000, 9, 726, 2, 54002, StringDefines.Key_1953, 8, 6600, StringDefines.Key_50191, 1));
          data.Add(3,DeclareHeraldry.Create(StringDefines.Key_50192, StringDefines.Key_50188, StringDefines.Key_50189, StringDefines.Key_50190, 0, 604800, 9, 725, 3, 54003, StringDefines.Key_1954, 8, 604800, StringDefines.Key_50191, 2));
      }
      #endregion
  }
}
