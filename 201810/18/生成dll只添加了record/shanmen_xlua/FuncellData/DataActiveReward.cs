//文件是自动生成,请勿手动修改.来自数据文件:active_reward
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataActiveReward
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareActiveReward> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(20,DeclareActiveReward.Create(20, StringDefines.Key_20469, StringDefines.Key_20));
          data.Add(40,DeclareActiveReward.Create(40, StringDefines.Key_20470, StringDefines.Key_20));
          data.Add(60,DeclareActiveReward.Create(60, StringDefines.Key_20471, StringDefines.Key_20));
          data.Add(80,DeclareActiveReward.Create(80, StringDefines.Key_20470, StringDefines.Key_20));
          data.Add(100,DeclareActiveReward.Create(100, StringDefines.Key_20472, StringDefines.Key_20));
      }
      #endregion
  }
}
