//文件是自动生成,请勿手动修改.来自数据文件:friend_item
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataFriendItem
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareFriendItem> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(50034,DeclareFriendItem.Create(50034, 1));
          data.Add(50035,DeclareFriendItem.Create(50035, 10));
          data.Add(50036,DeclareFriendItem.Create(50036, 100));
      }
      #endregion
  }
}
