using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EPM
{
	public partial class VacationApprovalDetails : ContentPage
	{
		public VacationApprovalDetails ()
		{
			InitializeComponent ();
			this.FindByName<Label> ("startDate").Text = DateTime.Now.AddDays (2).ToString();
			this.FindByName<Label> ("endDate").Text = DateTime.Now.AddDays (4).ToString();
			this.FindByName<Label> ("comments").Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod";
			this.FindByName<Button> ("btnApprove").Clicked += btnApprove_Clicked;
			this.FindByName<Button> ("btnReject").Clicked += btnReject_Clicked;
		}

		private void btnApprove_Clicked(object sender, EventArgs e)
		{
			this.DisplayAlert ("Success!", "Request Approved", "Ok", null);
			Navigation.PushAsync (new MainPage ());
		}

		private void btnReject_Clicked(object sender, EventArgs e)
		{
			this.DisplayAlert ("Success!", "Request Rejected", "Ok", null);
			Navigation.PushAsync (new MainPage ());
		}

	}
}

