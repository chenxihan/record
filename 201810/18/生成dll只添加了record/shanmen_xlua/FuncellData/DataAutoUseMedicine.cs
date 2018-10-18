//文件是自动生成,请勿手动修改.来自数据文件:AutoUseMedicine
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataAutoUseMedicine
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareAutoUseMedicine> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(1,DeclareAutoUseMedicine.Create(1, 49, 1, 205001, 1100));
          data.Add(2,DeclareAutoUseMedicine.Create(2, 149, 50, 205002, 1101));
          data.Add(3,DeclareAutoUseMedicine.Create(3, 179, 150, 205003, 1102));
          data.Add(4,DeclareAutoUseMedicine.Create(4, 219, 180, 205004, 1103));
          data.Add(5,DeclareAutoUseMedicine.Create(5, 299, 220, 205005, 1104));
          data.Add(6,DeclareAutoUseMedicine.Create(6, 999, 300, 205006, 1105));
          data.Add(7,DeclareAutoUseMedicine.Create(7, 0, 0, 0, 0));
      }
      #endregion
  }
}
