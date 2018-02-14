using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissors.Models
{
  public class RPSGame
  {
    public string GameResult (int Player1, int Player2)
      {
          if (Player1 == Player2)
          {
              return "Draw";
          } else
          {
              return "Player 2";
          }
      }
  }
}
