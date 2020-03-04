using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS.Models;

namespace RPS.Tests
{
  [TestClass]
  public class GameTests
  {
    
    [TestMethod]
    public void GameConstructor_CreateInstanceOfGame_Game()
    {
      Game newGame = new Game("player1", "player2");
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }

    [TestMethod]
    public void CheckDraw_CheckIsDraw_True()
    {
      Game newGame = new Game("r", "r");
      bool result = newGame.CheckDraw("r", "r");
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void CheckWin_CheckWinner_Player()
    {
      Game newGame = new Game("r", "p");
      string result = newGame.CheckWin("r", "p");
      Assert.AreEqual("p", result);
    }
  }
}