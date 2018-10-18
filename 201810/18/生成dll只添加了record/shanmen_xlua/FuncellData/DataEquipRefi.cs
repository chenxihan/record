//文件是自动生成,请勿手动修改.来自数据文件:Equip_refi
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataEquipRefi
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareEquipRefi> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(1,DeclareEquipRefi.Create(StringDefines.Key_36766, 5000, StringDefines.Key_36766, 3000, 1, 50, StringDefines.Key_36766));
          data.Add(2,DeclareEquipRefi.Create(StringDefines.Key_36767, 5000, StringDefines.Key_36767, 3000, 2, 70, StringDefines.Key_36767));
          data.Add(3,DeclareEquipRefi.Create(StringDefines.Key_36768, 5000, StringDefines.Key_36768, 3000, 3, 90, StringDefines.Key_36768));
      }
      #endregion
  }
}
