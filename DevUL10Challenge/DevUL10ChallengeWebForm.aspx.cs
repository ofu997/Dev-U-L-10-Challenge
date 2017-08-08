using System;
using ClassLibrary1;

namespace DevUL10Challenge
{
	public partial class DevUL10ChallengeWebForm : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			//Dart ourDart = new Dart();
			//ourDart.Throw();
			//resultLabel.Text += ourDart.dartValue.ToString(); 
		}
		

		protected void okButton_Click(object sender, EventArgs e)
		{
			Game ourGame = new Game("Player1", "Player2");
			string result = ourGame.Play();
			resultLabel.Text = result;

		}
	}
}
