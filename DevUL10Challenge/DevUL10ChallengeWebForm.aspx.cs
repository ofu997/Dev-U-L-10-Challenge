using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevUL10Challenge
{
	public partial class DevUL10ChallengeWebForm : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			Dart ourDart = new Dart();
			ourDart.Throw();
			resultLabel.Text += ourDart.dartValue.ToString(); 
		}
			public class Dart
			{

			public int dartValue { get; set; }

				Random randomDart = new Random();
				public int Throw()
				{
					dartValue = randomDart.Next(20);
					return dartValue;
				}

			}
	}
}
