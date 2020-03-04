using System;

namespace RPS.Models
{
  public class Game
  {
    public string Player1 { get; set; }
    public string Player2 { get; set; }

    public Game(string player1, string player2)
    {
      Player1 = player1;
      Player2 = player2;
    }

    public bool CheckDraw(string player1, string player2)
    {
      if (player1 == player2)
      {
        return true;
      }
      return false;
    }

    public string CheckWin(string player1, string player2)
    {
      if (player1 != player2)  
      {
        if (player1 == "r")
        {
          if (player2 == "s")
          {
            return player1;
          }
          else if (player2 == "p")
          {
            return player2;
          }        
        }
        else if (player1 == "s")
        {
          if (player2 == "r")
          {
            return player2;
          }
          else if (player2 == "p")
          {
            return player1;
          }
        }  
        else if (player1 == "p")
        {
          if (player2 == "s")
          {
            return player2;
          }
          else if (player2 == "r")
          {
            return player1;
          }
        } 
      }
    CheckDraw(player1, player2);
    return "Draw";
    }  
  }
}