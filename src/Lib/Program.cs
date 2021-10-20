using System;

namespace Bowling
{
   public class Bowling
   {
      private int _score;
      public void AddThrow(int pin)
      {
         _score += pin;
      }

      public int CalculateScore()
      {
         return _score;
      }
   }

}
