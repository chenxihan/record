//文件是自动生成,请勿手动修改.来自数据文件:vip
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataVip
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareVip> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(0,DeclareVip.Create(0, 0, StringDefines.Key_56711, 0, StringDefines.Key_10474, StringDefines.Key_10474, 0, 0, StringDefines.Key_10474, 0, 0));
          data.Add(99,DeclareVip.Create(1, 1, StringDefines.Key_56712, 0, StringDefines.Key_56713, StringDefines.Key_56714, 99, 60, StringDefines.Key_15157, 300, 30));
          data.Add(999,DeclareVip.Create(1, 1, StringDefines.Key_56715, 1006, StringDefines.Key_20, StringDefines.Key_56716, 999, 60, StringDefines.Key_1723, 0, -1));
      }
      #endregion
  }
}
