//文件是自动生成,请勿手动修改.来自数据文件:update_reward
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataUpdateReward
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareUpdateReward> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(1,DeclareUpdateReward.Create(0, 1, StringDefines.Key_11640, StringDefines.Key_11641));
      }
      #endregion
  }
}
