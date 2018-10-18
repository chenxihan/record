//文件是自动生成,请勿手动修改.来自数据文件:guild_fight_reward
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataGuildFightReward
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareGuildFightReward> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(1,DeclareGuildFightReward.Create(1, StringDefines.Key_50135, 1, 1, StringDefines.Key_50136, 14));
          data.Add(2,DeclareGuildFightReward.Create(1, StringDefines.Key_50137, 2, 2, StringDefines.Key_50138, 13));
          data.Add(3,DeclareGuildFightReward.Create(2, StringDefines.Key_20, 3, 1, StringDefines.Key_50138, 12));
          data.Add(4,DeclareGuildFightReward.Create(2, StringDefines.Key_20, 4, 2, StringDefines.Key_16865, 0));
          data.Add(5,DeclareGuildFightReward.Create(3, StringDefines.Key_20, 5, 1, StringDefines.Key_16865, 0));
          data.Add(6,DeclareGuildFightReward.Create(3, StringDefines.Key_20, 6, 2, StringDefines.Key_12611, 0));
          data.Add(7,DeclareGuildFightReward.Create(10, StringDefines.Key_50139, 7, 1, StringDefines.Key_50136, 0));
          data.Add(8,DeclareGuildFightReward.Create(10, StringDefines.Key_50140, 8, 2, StringDefines.Key_50138, 0));
      }
      #endregion
  }
}
