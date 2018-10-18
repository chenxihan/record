//文件是自动生成,请勿手动修改.来自数据文件:returnReward
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataReturnReward
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareReturnReward> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(1,DeclareReturnReward.Create(7, StringDefines.Key_20406, StringDefines.Key_20407, 1, StringDefines.Key_20408));
      }
      #endregion
  }
}
