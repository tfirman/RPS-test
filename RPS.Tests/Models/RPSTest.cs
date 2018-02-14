using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;
using System.Collections.Generic;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class RPSGameTest
  {
    [TestMethod]
    public void RPSResult_TwoRocks_Draw()
    {
      RPSGame testRPSGame = new RPSGame();
      Assert.AreEqual("Draw", testRPSGame.GameResult(1,1));
    }
  }
}
