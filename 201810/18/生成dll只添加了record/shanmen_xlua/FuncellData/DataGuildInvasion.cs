//文件是自动生成,请勿手动修改.来自数据文件:guild_invasion
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataGuildInvasion
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareGuildInvasion> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(1,DeclareGuildInvasion.Create(1, StringDefines.Key_19970));
          data.Add(5,DeclareGuildInvasion.Create(5, StringDefines.Key_19971));
          data.Add(20,DeclareGuildInvasion.Create(20, StringDefines.Key_19972));
          data.Add(1000,DeclareGuildInvasion.Create(1000, StringDefines.Key_19973));
      }
      #endregion
  }
}
