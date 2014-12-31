using System;

namespace EPMServices
{
	public class MainMenuOption
	{
		//Menu Title
		public string Title {get;set;}

		//The Id of the application container that the user will be taken to
		public string ContainerId {get;set;}

		//The image path for the menu option
		public string Img{ get; set;}

		public MainMenuOption ()
		{
		}
	}
}