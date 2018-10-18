//文件是自动生成,请勿手动修改.来自数据文件:guild_trial_reward
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataGuildTrialReward
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareGuildTrialReward> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(1,DeclareGuildTrialReward.Create(1, 1, 1, StringDefines.Key_31284));
          data.Add(2,DeclareGuildTrialReward.Create(2, 5, 2, StringDefines.Key_31285));
          data.Add(3,DeclareGuildTrialReward.Create(3, 20, 6, StringDefines.Key_31286));
          data.Add(4,DeclareGuildTrialReward.Create(4, 1000, 21, StringDefines.Key_31287));
      }
      #endregion
  }
}
