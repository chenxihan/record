//文件是自动生成,请勿手动修改.来自数据文件:ScuffleWinAward
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataScuffleWinAward
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareScuffleWinAward> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(1,DeclareScuffleWinAward.Create(StringDefines.Key_19951, 1));
          data.Add(2,DeclareScuffleWinAward.Create(StringDefines.Key_19952, 2));
          data.Add(3,DeclareScuffleWinAward.Create(StringDefines.Key_19953, 3));
      }
      #endregion
  }
}
