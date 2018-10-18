//文件是自动生成,请勿手动修改.来自数据文件:CityWarAward
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataCityWarAward
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareCityWarAward> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(0,DeclareCityWarAward.Create(StringDefines.Key_13619, StringDefines.Key_13619, StringDefines.Key_13619, 0, StringDefines.Key_13619, StringDefines.Key_13619, 0, StringDefines.Key_13619, StringDefines.Key_13620, 0, 0, 0));
          data.Add(1,DeclareCityWarAward.Create(StringDefines.Key_13621, StringDefines.Key_13621, StringDefines.Key_13621, 1, StringDefines.Key_13621, StringDefines.Key_13621, 0, StringDefines.Key_13621, StringDefines.Key_20, 0, 20, 100));
      }
      #endregion
  }
}
