using System;
using RPS.Models;

namespace RPS
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Let's play the game Rock, Paper, Scissors.");
      Console.WriteLine("Enter a player1 [R/P/S]");
      string player1 = Console.ReadLine().ToLower();
      Console.WriteLine("Enter a player2 [R/P/S]");
      string player2 = Console.ReadLine().ToLower();

      Game newGame = new Game(player1, player2);
      if(newGame.CheckDraw(player1, player2) == true)
      {
        Console.WriteLine("It's a draw! Play again.");
        Main();
      }
      else
      {
        Console.WriteLine($"Whoever played {newGame.CheckWin(player1, player2)} is WIN!");
      }
    }
  }
}