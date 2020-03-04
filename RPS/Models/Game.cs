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
      return player1;
    }
  }
}