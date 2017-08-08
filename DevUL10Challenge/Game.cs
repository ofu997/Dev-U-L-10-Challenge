using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClassLibrary1;

namespace DevUL10Challenge
{
	public class Game
	{
		private Player player1;
		private Player player2;

		private Random gameRandom;

		public Game(string pname, string p2name)
		{
			player1 = new Player();
			player2 = new Player();
			player1.name = pname;
			player2.name = p2name;
			gameRandom = new Random();
		}

		public string  Play()
		{
			while (player1.Score < 300 && player2.Score < 300)
			playRound(player1);
			playRound(player2);
			return displayResults();
		}

		private string displayResults()
		{
			string result = String.Format("{0}:{1}<br>{2}:{3}<br>",
				player1.name,
				player1.Score, 
				player2.name, 
				player2.Score);
			return result += "The winner is: " + 
				(player1.Score > player2.Score ?
				player1.name : player2.name);
		}

		private void playRound(Player player)
		{
			for (int i = 0; i < 3; i++)
			{
				Dart ourDart = new Dart(gameRandom);
				ourDart.Throw();
				Score.ScoreDart(player, ourDart);
			}
		}
	}
}