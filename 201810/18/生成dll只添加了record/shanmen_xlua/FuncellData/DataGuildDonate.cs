//文件是自动生成,请勿手动修改.来自数据文件:guild_donate
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataGuildDonate
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareGuildDonate> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(1,DeclareGuildDonate.Create(StringDefines.Key_3990, StringDefines.Key_31380, 1, StringDefines.Key_31381, StringDefines.Key_31382));
          data.Add(2,DeclareGuildDonate.Create(StringDefines.Key_12422, StringDefines.Key_31383, 2, StringDefines.Key_31384, StringDefines.Key_31385));
          data.Add(3,DeclareGuildDonate.Create(StringDefines.Key_28, StringDefines.Key_31386, 3, StringDefines.Key_31387, StringDefines.Key_31388));
          data.Add(4,DeclareGuildDonate.Create(StringDefines.Key_13611, StringDefines.Key_31389, 4, StringDefines.Key_31390, StringDefines.Key_31391));
      }
      #endregion
  }
}
