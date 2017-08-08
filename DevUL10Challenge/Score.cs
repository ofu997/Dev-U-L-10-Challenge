using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClassLibrary1;

namespace DevUL10Challenge
{
	public class Score
	{
		public static void ScoreDart(Player player, Dart ourDart)
		{
			int score = 0;

			if (ourDart.isTriple) score = ourDart.Score * 3;
			else if (ourDart.isDouble) score = ourDart.Score * 2;
			else score = ourDart.Score;

			if (ourDart.isTriple && ourDart.Score == 0) score = 50;
			else if (ourDart.Score == 0) score = 25;

			player.Score += score;
		}
	}
}