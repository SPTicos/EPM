using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Threading;

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
			//Long operation running here
			activity.IsVisible = false;
			activity.IsRunning = false;
			this.DisplayAlert ("Error", "Error loading data. Please check connectivity and try again.", "OK", "NO");
		}
	}
}

