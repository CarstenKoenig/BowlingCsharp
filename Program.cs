using System;
using NUnit.Framework;

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

   [NUnit.Framework.TestFixture]
   public class Tests
   {
      [NUnit.Framework.Test]
      public void GrünerTest()
      {
         Assert.AreEqual(4, 2 + 2);
      }

      [NUnit.Framework.Test]
      public void Score_bei_Start_ist_Null()
      {
         // Arrange
         var game = new Bowling();

         // Act
         var score = game.CalculateScore();

         // Assert
         Assert.AreEqual(0, score);
      }

      [NUnit.Framework.Test]
      public void Score_bei_einem_Wurf_mit_5_Pins_ist_5()
      {
         // Arrange
         var game = new Bowling();

         // Act
         game.AddThrow(5);
         var score = game.CalculateScore();

         // Assert
         Assert.AreEqual(5, score);
      }
   }
}
