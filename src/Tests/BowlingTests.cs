using NUnit.Framework;

namespace Bowling.Tests
{
   public class BowlingTests
   {
      [Test]
      public void Score_bei_Start_ist_Null()
      {
         // Arrange
         var game = new Bowling();

         // Act
         var score = game.CalculateScore();

         // Assert
         Assert.AreEqual(0, score);
      }

      [Test]
      public void Score_bei_einem_Wurf_mit_5_Pins_ist_5()
      {
         // Arrange
         var game = new Bowling();

         // Act
         game.Roll(5);
         var score = game.CalculateScore();

         // Assert
         Assert.AreEqual(5, score);
      }

      [Test]
      public void Perfektes_Spiel_hat_300_Punkte()
      {
         // Arrange
         var game = new Bowling();

         // Act
         Rolls(game, copies: 12, 10);
         var score = game.CalculateScore();

         // Assert
         Assert.AreEqual(300, score);
      }

      [Test]
      public void Lauter_5er_sind_150_Punkte()
      {
         // Arrange
         var game = new Bowling();

         // Act
         Rolls(game, copies: 21, 5);
         var score = game.CalculateScore();

         // Assert
         Assert.AreEqual(150, score);
      }

      [Test]
      public void Lauter_9er_und_Nix_Sind_90_Punkte()
      {
         // Arrange
         var game = new Bowling();

         // Act
         Rolls(game, copies: 10, 9, 0);
         var score = game.CalculateScore();

         // Assert
         Assert.AreEqual(90, score);
      }

      static void Rolls(Bowling game, int copies, params int[] pins)
      {
         for (int i = 0; i < copies; i++)
         {
            foreach (var ps in pins)
               game.Roll(ps);
         }
      }
   }
}