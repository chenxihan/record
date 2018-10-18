//文件是自动生成,请勿手动修改.来自数据文件:friend_intimacy
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataFriendIntimacy
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareFriendIntimacy> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(1000,DeclareFriendIntimacy.Create(1001, 1000));
          data.Add(2000,DeclareFriendIntimacy.Create(1002, 2000));
          data.Add(5000,DeclareFriendIntimacy.Create(1003, 5000));
          data.Add(7000,DeclareFriendIntimacy.Create(1004, 7000));
          data.Add(10000,DeclareFriendIntimacy.Create(1005, 10000));
      }
      #endregion
  }
}
