using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
	public class Dart
	{

		public int dartValue { get; set; }

		Random randomDart = new Random();
		public void Throw()
		{
			dartValue = randomDart.Next(20);
			//return dartValue;
		}

	}
}
