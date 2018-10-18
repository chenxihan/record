//文件是自动生成,请勿手动修改.来自数据文件:ScreenEffect
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataScreenEffect
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareScreenEffect> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(1,DeclareScreenEffect.Create(1, 1, 15));
          data.Add(2,DeclareScreenEffect.Create(2, 1, 16));
          data.Add(3,DeclareScreenEffect.Create(3, 1, 17));
          data.Add(4,DeclareScreenEffect.Create(4, 1, 75));
      }
      #endregion
  }
}
