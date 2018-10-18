//文件是自动生成,请勿手动修改.来自数据文件:SZZQScoreAward
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataSZZQScoreAward
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareSZZQScoreAward> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(500,DeclareSZZQScoreAward.Create(StringDefines.Key_42268, 500, 0));
          data.Add(1200,DeclareSZZQScoreAward.Create(StringDefines.Key_42269, 1200, 1));
          data.Add(1700,DeclareSZZQScoreAward.Create(StringDefines.Key_42270, 1700, 2));
          data.Add(2300,DeclareSZZQScoreAward.Create(StringDefines.Key_42271, 2300, 3));
          data.Add(3000,DeclareSZZQScoreAward.Create(StringDefines.Key_42272, 3000, 4));
      }
      #endregion
  }
}
