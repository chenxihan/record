//文件是自动生成,请勿手动修改.来自数据文件:CityWar
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataCityWar
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareCityWar> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(1,DeclareCityWar.Create(64503, 1, StringDefines.Key_14420, StringDefines.Key_38291, 0));
          data.Add(2,DeclareCityWar.Create(64500, 2, StringDefines.Key_38292, StringDefines.Key_38293, 1));
          data.Add(3,DeclareCityWar.Create(64501, 3, StringDefines.Key_38295, StringDefines.Key_38293, 1));
          data.Add(4,DeclareCityWar.Create(64502, 4, StringDefines.Key_38296, StringDefines.Key_38293, 1));
      }
      #endregion
  }
}
