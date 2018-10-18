//文件是自动生成,请勿手动修改.来自数据文件:guild_official
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataGuildOfficial
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareGuildOfficial> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(0,DeclareGuildOfficial.Create(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1000, 0, 0));
          data.Add(1,DeclareGuildOfficial.Create(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 1000, 0, 0));
          data.Add(2,DeclareGuildOfficial.Create(1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 2, 1, 3, 0, 0));
          data.Add(3,DeclareGuildOfficial.Create(1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 3, 1, 3, 1, 0));
          data.Add(4,DeclareGuildOfficial.Create(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 4, 1, 1, 1, 0));
      }
      #endregion
  }
}
