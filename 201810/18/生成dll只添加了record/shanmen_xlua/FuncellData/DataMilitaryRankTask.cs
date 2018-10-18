//文件是自动生成,请勿手动修改.来自数据文件:MilitaryRankTask
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataMilitaryRankTask
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareMilitaryRankTask> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(1,DeclareMilitaryRankTask.Create(StringDefines.Key_38183, 1, 5));
          data.Add(2,DeclareMilitaryRankTask.Create(StringDefines.Key_38184, 2, 15));
          data.Add(3,DeclareMilitaryRankTask.Create(StringDefines.Key_38185, 3, 25));
          data.Add(4,DeclareMilitaryRankTask.Create(StringDefines.Key_38186, 4, 50));
          data.Add(5,DeclareMilitaryRankTask.Create(StringDefines.Key_38187, 5, 100));
          data.Add(6,DeclareMilitaryRankTask.Create(StringDefines.Key_38188, 6, 200));
          data.Add(7,DeclareMilitaryRankTask.Create(StringDefines.Key_38189, 7, 500));
          data.Add(8,DeclareMilitaryRankTask.Create(StringDefines.Key_38190, 8, 700));
          data.Add(9,DeclareMilitaryRankTask.Create(StringDefines.Key_38191, 9, 1000));
          data.Add(10,DeclareMilitaryRankTask.Create(StringDefines.Key_38194, 10, 2000));
      }
      #endregion
  }
}
