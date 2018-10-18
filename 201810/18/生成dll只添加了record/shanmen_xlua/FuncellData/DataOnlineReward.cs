//文件是自动生成,请勿手动修改.来自数据文件:online_reward
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataOnlineReward
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareOnlineReward> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(180,DeclareOnlineReward.Create(80013, 180, StringDefines.Key_19935));
          data.Add(600,DeclareOnlineReward.Create(50040, 600, StringDefines.Key_19936));
          data.Add(1200,DeclareOnlineReward.Create(50034, 1200, StringDefines.Key_19937));
          data.Add(2400,DeclareOnlineReward.Create(50035, 2400, StringDefines.Key_19938));
          data.Add(3600,DeclareOnlineReward.Create(50075, 3600, StringDefines.Key_19939));
      }
      #endregion
  }
}
