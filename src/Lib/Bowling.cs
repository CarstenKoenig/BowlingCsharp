using System;
using System.Collections.Generic;

namespace Bowling
{
   public class Bowling
   {
      private List<int> _scores;

      public Bowling()
      {
         _scores = new List<int>();
      }
      public void Roll(int pins)
      {
         _scores.Add(pins);
      }
      public int CalculateScore()
      {
         var totalScore = 0;
         var frame = 0;
         for (var index = 0; index < _scores.Count && frame < 10;)
         {
            frame++;
            var roll1 = GetScore(index++);
            totalScore += roll1;

            if (roll1 == 10)
            {
               // Bonus bei Strike
               totalScore += GetScore(index) + GetScore(index + 1);
               // Frame ist damit beendet (nur ein Roll bei Strike)
               continue;
            }

            var roll2 = GetScore(index++);
            totalScore += roll2;

            if (roll1 + roll2 == 10)
            {
               // Bonus bei Spare
               totalScore += GetScore(index);
            }
         }

         return totalScore;
      }

      int GetScore(int index)
      {
         if (index < 0 || index >= _scores.Count)
            return 0;
         return Math.Min(10, Math.Max(0, _scores[index]));
      }
   }

}
