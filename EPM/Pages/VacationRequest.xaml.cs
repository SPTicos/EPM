using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace EPM
{
	public partial class VacationRequest : ContentPage
	{
		public VacationRequest ()
		{
			InitializeComponent ();

			Button buttonSubmit = this.FindByName<Button> ("btnSubmit");
			buttonSubmit.Clicked += buttonSubmit_Clicked;		
		}

		private void buttonSubmit_Clicked (object sender, EventArgs e)
		{
			ActivityIndicator activity = this.FindByName<ActivityIndicator> ("activity");
			activity.IsVisible = true;
			activity.IsRunning = true;
			SaveRequest ();
			activity.IsVisible = false;
			activity.IsRunning = false;
			this.DisplayAlert ("Success!", "Your request was submitted successfully", "OK", null);
			Navigation.PushAsync (new MainPage ());
		}


		public void SaveRequest ()
		{
			EPMServices.VacationRequest request = new EPMServices.VacationRequest ();

			request.InitialDate = this.FindByName<DatePicker> ("startDate").Date;
			request.EndDate = this.FindByName<DatePicker> ("endDate").Date;
			request.Comments = this.FindByName<Editor> ("comments").Text.Trim ();
			request.SubmissionDate = DateTime.Now;

			EPMServices.SharePointRepositoryMockup mock = new EPMServices.SharePointRepositoryMockup ();
			mock.SaveVacationRequest (request);

		}
	}
}

