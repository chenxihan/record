//文件是自动生成,请勿手动修改.来自数据文件:master_graduate
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataMasterGraduate
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareMasterGraduate> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(0,DeclareMasterGraduate.Create(0, StringDefines.Key_20458, 0, 0, 0, StringDefines.Key_20, StringDefines.Key_20, 0));
          data.Add(1,DeclareMasterGraduate.Create(0, StringDefines.Key_20458, 2500, 0, 0, StringDefines.Key_20, StringDefines.Key_20, 1));
          data.Add(2,DeclareMasterGraduate.Create(0, StringDefines.Key_20459, 5000, 0, 0, StringDefines.Key_20, StringDefines.Key_20, 2));
          data.Add(3,DeclareMasterGraduate.Create(1, StringDefines.Key_20460, 7500, 100, 0, StringDefines.Key_20461, StringDefines.Key_20462, 3));
          data.Add(4,DeclareMasterGraduate.Create(1, StringDefines.Key_20463, 10000, 100, 0, StringDefines.Key_20464, StringDefines.Key_20465, 4));
          data.Add(5,DeclareMasterGraduate.Create(1, StringDefines.Key_20466, 12500, 100, 1, StringDefines.Key_20467, StringDefines.Key_20468, 5));
      }
      #endregion
  }
}
