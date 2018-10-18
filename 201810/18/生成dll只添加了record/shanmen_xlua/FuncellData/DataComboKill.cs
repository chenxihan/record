//文件是自动生成,请勿手动修改.来自数据文件:comboKill
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataComboKill
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareComboKill> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(1,DeclareComboKill.Create(0, 1, 0, StringDefines.Key_13622));
          data.Add(3,DeclareComboKill.Create(0, 3, 0, StringDefines.Key_13623));
          data.Add(5,DeclareComboKill.Create(1, 5, 3, StringDefines.Key_13624));
          data.Add(10,DeclareComboKill.Create(2, 10, 5, StringDefines.Key_13625));
          data.Add(15,DeclareComboKill.Create(3, 15, 10, StringDefines.Key_13626));
          data.Add(20,DeclareComboKill.Create(5, 20, 15, StringDefines.Key_13627));
          data.Add(30,DeclareComboKill.Create(10, 30, 20, StringDefines.Key_13628));
      }
      #endregion
  }
}
