//文件是自动生成,请勿手动修改.来自数据文件:guild_fight_ranking
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataGuildFightRanking
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareGuildFightRanking> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(5,DeclareGuildFightRanking.Create(5, StringDefines.Key_18732));
          data.Add(15,DeclareGuildFightRanking.Create(15, StringDefines.Key_18733));
          data.Add(50,DeclareGuildFightRanking.Create(50, StringDefines.Key_18734));
          data.Add(150,DeclareGuildFightRanking.Create(150, StringDefines.Key_18735));
          data.Add(500,DeclareGuildFightRanking.Create(500, StringDefines.Key_18736));
          data.Add(1000,DeclareGuildFightRanking.Create(1000, StringDefines.Key_18737));
          data.Add(1500,DeclareGuildFightRanking.Create(1500, StringDefines.Key_18738));
          data.Add(2000,DeclareGuildFightRanking.Create(2000, StringDefines.Key_18739));
          data.Add(3000,DeclareGuildFightRanking.Create(3000, StringDefines.Key_18740));
          data.Add(5000,DeclareGuildFightRanking.Create(5000, StringDefines.Key_18741));
      }
      #endregion
  }
}
