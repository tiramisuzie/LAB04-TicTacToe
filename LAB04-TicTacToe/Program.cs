using Lab04_TicTacToe.Classes;
using System;

namespace Lab04_TicTacToe
{
	class Program
	{
		static void Main(string[] args)
		{
            PlayGame();
		}

		static void PlayGame()
		{
            // DONE: Instantiate your players
            Player x = new Player();
            x.Name = "player 1";
            x.Marker = "X";
            x.IsTurn = true;
            Player o = new Player();
            o.Name = "player 2";
            o.Marker = "O";

            // Create the Game
            Board TicTacToe = new Board();
            TicTacToe.DisplayBoard();
			// Play the Game
			// Output the winner
		}
	}
}
