//文件是自动生成,请勿手动修改.来自数据文件:PlayerOccupation
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataPlayerOccupation
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclarePlayerOccupation> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(0,DeclarePlayerOccupation.Create(1, StringDefines.Key_10476, 0));
          data.Add(1,DeclarePlayerOccupation.Create(0, StringDefines.Key_10517, 1));
          data.Add(2,DeclarePlayerOccupation.Create(0, StringDefines.Key_10544, 2));
          data.Add(3,DeclarePlayerOccupation.Create(0, StringDefines.Key_10569, 3));
          data.Add(4,DeclarePlayerOccupation.Create(1, StringDefines.Key_10596, 4));
          data.Add(5,DeclarePlayerOccupation.Create(0, StringDefines.Key_58333, 5));
      }
      #endregion
  }
}
