using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace EPM
{
	public partial class RequestHistory : ContentPage
	{
		public RequestHistory ()
		{
			InitializeComponent ();
			RenderControls ();
		}

		private void RenderControls ()
		{

			EPMServices.SharePointRepositoryMockup mock = new EPMServices.SharePointRepositoryMockup ();
			var vacationList = new ListView {
				ItemsSource = mock.GetVacationHistory (),
				RowHeight = 50,
				HasUnevenRows = true


			};

			//INFO A MOSTRAR -Rango de fechas y total de días
			var title = new Label{ Text = "Vacation History" };
			
 
			vacationList.ItemTemplate = new DataTemplate (typeof(TextCell));
			vacationList.ItemTemplate.SetBinding (TextCell.TextProperty, "DateRange");
			//vacationList.ItemTemplate.SetBinding (TextCell.DetailProperty, "InitialDate");
			//vacationList.ItemTemplate.SetBinding (TextCell.DetailProperty, "EndDate");
			vacationList.ItemTemplate.SetBinding (TextCell.DetailProperty, "Duration");


 
			this.Content = new StackLayout {
				VerticalOptions = LayoutOptions.FillAndExpand,
				Spacing = 20,
				Children = { title, vacationList }
			};
		}
	}
}


