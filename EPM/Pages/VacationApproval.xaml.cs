using System;
using System.Collections.Generic;
using Xamarin.Forms;
using EPMServices;
using System.Windows.Input;

namespace EPM
{	
	public partial class VacationApproval : ContentPage
	{	
		ISharePointRepository SPRepository;
		public VacationApproval ()
		{
			InitializeComponent ();

			var SPRepository = new SharePointRepositoryMockup ();
			var requestList = SPRepository.GetVacationRequests (1);

			List<Cell> cells = new List<Cell> ();
			foreach (var r in requestList) {
				cells.Add (new ImageCell{ Text = r.User.Name,
					TextColor = Color.Black,
					DetailColor = Color.Black,
					Detail = r.InitialDate.ToShortDateString() + " - " + r.EndDate.ToShortDateString(),
					CommandParameter = r.Id,
					Command = GoToRequestCommand
				});
			}

			TableSection mainTable = this.FindByName<TableSection> ("mainTableSection");
			mainTable.Add (cells);
		}

		public ICommand GoToRequestCommand{
			get{ return new Command<int> (GoToRequestForm); }
		}

		private async void GoToRequestForm(int id)
		{
			await Navigation.PushAsync (new VacationApprovalDetails ());
		}
	}
}