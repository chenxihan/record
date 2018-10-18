//文件是自动生成,请勿手动修改.来自数据文件:Jump
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataJump
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareJump> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(1,DeclareJump.Create(StringDefines.Key_42278, 0, 0, 0, 0, 400, 1, StringDefines.Key_20, 800, 1300));
          data.Add(2,DeclareJump.Create(StringDefines.Key_42279, 400, 500, 300, 1, 500, 2, StringDefines.Key_42280, 600, 600));
          data.Add(3,DeclareJump.Create(StringDefines.Key_42281, 400, 600, 300, 1, 100, 3, StringDefines.Key_42282, 1800, 1000));
      }
      #endregion
  }
}
