using System;
using System.Collections.Generic;
using Xamarin.Forms;
using EPMRepositories;
using EPMServices;
using System.Windows.Input;

namespace EPM
{
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
			App.Navigator = this.Navigation;

			GetOptions ();
		}

		private void GetOptions ()
		{
			var mock = new AppMetadataRepositoryMockup ();	
			List<EPMServices.MainMenuOption> options = new List<EPMServices.MainMenuOption> ();
			mock.setOptions (ref options);
			List<Cell> cells = new List<Cell> ();
			foreach (var option in options) {
					
				ImageCell cell = new ImageCell () { 
					Text = option.Title,
					ImageSource = option.Img,
					CommandParameter = option.ContainerId,
					Command = GoToMenuOptionCommand,
					TextColor = Color.Black
				};

				cells.Add (cell);

			}

			TableSection table = this.FindByName<TableSection> ("mainTableSection");
			table.Add (cells);		
		}

		public ICommand GoToMenuOptionCommand {
			get { return new Command<string> (GoToMenuOption); }
		}

		private async void GoToMenuOption (string option)
		{
				
			switch (option) {
			case "RequestVacation":
				await Navigation.PushAsync (new VacationRequest ());
				break;
			case "VacationApproval":
				await Navigation.PushAsync (new VacationApproval ());
				break;
			}
		}
	}
}
