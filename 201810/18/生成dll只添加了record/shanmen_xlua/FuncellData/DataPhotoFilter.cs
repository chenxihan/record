//文件是自动生成,请勿手动修改.来自数据文件:photoFilter
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataPhotoFilter
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclarePhotoFilter> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(1,DeclarePhotoFilter.Create(1, 100, 4, 1, 90, StringDefines.Key_56717, 30));
          data.Add(2,DeclarePhotoFilter.Create(1, 300, 4, 2, 75, StringDefines.Key_56718, 3));
          data.Add(3,DeclarePhotoFilter.Create(1, 352, 4, 3, 44, StringDefines.Key_56719, 15));
          data.Add(4,DeclarePhotoFilter.Create(1, 219, 4, 4, 114, StringDefines.Key_56720, 45));
          data.Add(5,DeclarePhotoFilter.Create(1, 300, 4, 5, 245, StringDefines.Key_56721, 55));
      }
      #endregion
  }
}
