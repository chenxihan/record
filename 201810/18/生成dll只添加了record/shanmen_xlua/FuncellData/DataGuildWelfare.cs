//文件是自动生成,请勿手动修改.来自数据文件:guild_welfare
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataGuildWelfare
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareGuildWelfare> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(7,DeclareGuildWelfare.Create(StringDefines.Key_18361, StringDefines.Key_18362, StringDefines.Key_18363, StringDefines.Key_10474, StringDefines.Key_18364, 7));
          data.Add(2,DeclareGuildWelfare.Create(StringDefines.Key_18365, StringDefines.Key_18366, StringDefines.Key_18367, StringDefines.Key_18368, StringDefines.Key_18369, 2));
          data.Add(1,DeclareGuildWelfare.Create(StringDefines.Key_18365, StringDefines.Key_18370, StringDefines.Key_18367, StringDefines.Key_18371, StringDefines.Key_3966, 1));
          data.Add(4,DeclareGuildWelfare.Create(StringDefines.Key_18372, StringDefines.Key_18373, StringDefines.Key_18374, StringDefines.Key_18375, StringDefines.Key_14476, 4));
          data.Add(5,DeclareGuildWelfare.Create(StringDefines.Key_18376, StringDefines.Key_18377, StringDefines.Key_18378, StringDefines.Key_10474, StringDefines.Key_14474, 5));
      }
      #endregion
  }
}
