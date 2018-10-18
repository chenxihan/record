//文件是自动生成,请勿手动修改.来自数据文件:TaskSort
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataTaskSort
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareTaskSort> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(0,DeclareTaskSort.Create(10, 30, 0));
          data.Add(1,DeclareTaskSort.Create(40, 120, 1));
          data.Add(2,DeclareTaskSort.Create(50, 201, 2));
          data.Add(3,DeclareTaskSort.Create(60, 150, 3));
          data.Add(4,DeclareTaskSort.Create(90, 180, 4));
          data.Add(5,DeclareTaskSort.Create(100, 190, 5));
          data.Add(6,DeclareTaskSort.Create(70, 160, 6));
          data.Add(7,DeclareTaskSort.Create(80, 170, 7));
          data.Add(8,DeclareTaskSort.Create(9, 8, 8));
          data.Add(9,DeclareTaskSort.Create(110, 200, 9));
          data.Add(11,DeclareTaskSort.Create(59, 149, 11));
          data.Add(12,DeclareTaskSort.Create(2, 1, 12));
      }
      #endregion
  }
}
