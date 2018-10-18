//文件是自动生成,请勿手动修改.来自数据文件:level_reward
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataLevelReward
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareLevelReward> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(30,DeclareLevelReward.Create(-1, 1, 30, StringDefines.Key_20374, StringDefines.Key_20375));
          data.Add(50,DeclareLevelReward.Create(-1, 1, 50, StringDefines.Key_20376, StringDefines.Key_20375));
          data.Add(70,DeclareLevelReward.Create(-1, 1, 70, StringDefines.Key_20377, StringDefines.Key_20378));
          data.Add(110,DeclareLevelReward.Create(-1, 1, 110, StringDefines.Key_20, StringDefines.Key_20379));
          data.Add(130,DeclareLevelReward.Create(-1, 1, 130, StringDefines.Key_20, StringDefines.Key_20380));
          data.Add(160,DeclareLevelReward.Create(-1, 1, 160, StringDefines.Key_20381, StringDefines.Key_20382));
          data.Add(180,DeclareLevelReward.Create(-1, 0, 180, StringDefines.Key_20, StringDefines.Key_20383));
          data.Add(200,DeclareLevelReward.Create(-1, 0, 200, StringDefines.Key_20, StringDefines.Key_20384));
          data.Add(220,DeclareLevelReward.Create(200, 0, 220, StringDefines.Key_20385, StringDefines.Key_20386));
          data.Add(240,DeclareLevelReward.Create(50, 0, 240, StringDefines.Key_20, StringDefines.Key_20387));
          data.Add(260,DeclareLevelReward.Create(20, 0, 260, StringDefines.Key_20388, StringDefines.Key_20389));
          data.Add(300,DeclareLevelReward.Create(3, 0, 300, StringDefines.Key_20390, StringDefines.Key_20391));
      }
      #endregion
  }
}
