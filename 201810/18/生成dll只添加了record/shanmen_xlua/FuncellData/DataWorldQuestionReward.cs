//文件是自动生成,请勿手动修改.来自数据文件:world_question_reward
using System;
using System.Collections.Generic;
namespace Funcell.Cfg.Data
{
  public class DataWorldQuestionReward
  {
      #region //数据填充
      public static void Convert(Dictionary<int, DeclareWorldQuestionReward> data)
      {
          if(data == null) return;
          data.Clear();
          data.Add(1,DeclareWorldQuestionReward.Create(1, 1, 1, StringDefines.Key_57594));
          data.Add(2,DeclareWorldQuestionReward.Create(2, 2, 2, StringDefines.Key_57595));
          data.Add(3,DeclareWorldQuestionReward.Create(3, 5, 3, StringDefines.Key_57596));
          data.Add(4,DeclareWorldQuestionReward.Create(4, 10, 6, StringDefines.Key_57597));
          data.Add(5,DeclareWorldQuestionReward.Create(5, 50, 11, StringDefines.Key_57598));
          data.Add(6,DeclareWorldQuestionReward.Create(6, 100, 51, StringDefines.Key_57599));
          data.Add(7,DeclareWorldQuestionReward.Create(7, 1000, 101, StringDefines.Key_57600));
      }
      #endregion
  }
}
