//文件是自动生成,请勿手动修改.来自数据文件:Equip_fuse
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataEquipFuse
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareEquipFuse> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(1,DeclareEquipFuse.Create(1000, 4000, StringDefines.Key_3990, 50, StringDefines.Key_20361, 1, StringDefines.Key_20361, StringDefines.Key_20362, 1, 1, 1, StringDefines.Key_20363, 2500));
          data.Add(2,DeclareEquipFuse.Create(700, 3500, StringDefines.Key_20364, 40, StringDefines.Key_20365, 50, StringDefines.Key_20365, StringDefines.Key_20366, 2, 50, 1, StringDefines.Key_20367, 1500));
          data.Add(3,DeclareEquipFuse.Create(500, 3300, StringDefines.Key_13607, 30, StringDefines.Key_20368, 70, StringDefines.Key_20368, StringDefines.Key_20369, 3, 70, 3, StringDefines.Key_20370, 500));
          data.Add(4,DeclareEquipFuse.Create(300, 3000, StringDefines.Key_19910, 20, StringDefines.Key_20371, 90, StringDefines.Key_20371, StringDefines.Key_20372, 4, 90, 5, StringDefines.Key_20373, 500));
      }
      #endregion
  }
}
