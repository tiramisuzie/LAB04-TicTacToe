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
            Player x = new Player("player 1", "X");
           
            Player o = new Player("player 2", "O");
    

            // Create the Game
            Game game = new Game(x, o);
            game.Play();
			// Play the Game
			// Output the winner
		}
	}
}
