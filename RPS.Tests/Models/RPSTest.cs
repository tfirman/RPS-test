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
    [TestMethod]
    public void RPSResult_RockScissors_Player1()
    {
      RPSGame testRPSGame = new RPSGame();
      Assert.AreEqual("Player 1", testRPSGame.GameResult(1,3));
    }
    [TestMethod]
    public void RPSResult_ScissorsRock_Player2()
    {
      RPSGame testRPSGame = new RPSGame();
      Assert.AreEqual("Player 2", testRPSGame.GameResult(3,1));
    }
    [TestMethod]
    public void RPSResult_RockPaper_Player2()
    {
      RPSGame testRPSGame = new RPSGame();
      Assert.AreEqual("Player 2", testRPSGame.GameResult(1,2));
    }
    [TestMethod]
    public void RPSResult_PaperRock_Player1()
    {
      RPSGame testRPSGame = new RPSGame();
      Assert.AreEqual("Player 1", testRPSGame.GameResult(2,1));
    }
    [TestMethod]
    public void RPSResult_ScissorsPaper_Player1()
    {
      RPSGame testRPSGame = new RPSGame();
      Assert.AreEqual("Player 1", testRPSGame.GameResult(3,2));
    }
    [TestMethod]
    public void RPSResult_PaperScissors_Player2()
    {
      RPSGame testRPSGame = new RPSGame();
      Assert.AreEqual("Player 2", testRPSGame.GameResult(2,3));
    }
  }
}
