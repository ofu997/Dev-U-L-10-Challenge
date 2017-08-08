using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
	public class Dart
	{

		private Random random;
		private int score { get; set; }
		private bool isTriple { get; set; }
		private bool isDouble { get; set; }

		public Dart(Random random)
		{
			random = this.random; 
		}

		public void Throw()
		{
			int multiplier = this.random.Next(1, 101);
			if (multiplier > 95) isTriple = true;
			else if (multiplier > 90) isDouble = true;
		}

	}
}
