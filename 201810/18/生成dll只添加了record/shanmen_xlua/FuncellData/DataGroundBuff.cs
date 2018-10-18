//文件是自动生成,请勿手动修改.来自数据文件:GroundBuff
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataGroundBuff
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareGroundBuff> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(1,DeclareGroundBuff.Create(3000, 1, 5000, 5, 0, 1, 100, 39));
          data.Add(2,DeclareGroundBuff.Create(3000, 1, 5001, 0, 0, 2, 100, 40));
          data.Add(3,DeclareGroundBuff.Create(3000, 1, 5002, 0, 0, 3, 100, 41));
          data.Add(4,DeclareGroundBuff.Create(1000, 30, 5004, 8, -1, 4, 8000, 62));
          data.Add(5,DeclareGroundBuff.Create(3000, 1, 5005, 2, 0, 5, 100, 39));
          data.Add(6,DeclareGroundBuff.Create(3000, 1, 5006, 2, 0, 6, 100, 40));
          data.Add(7,DeclareGroundBuff.Create(3000, 1, 5007, 2, 0, 7, 100, 41));
          data.Add(8,DeclareGroundBuff.Create(3000, 9999, 80056, 8, -1, 8, 15000, 103));
      }
      #endregion
  }
}
