using System;
using Xamarin.Forms;

namespace EPM
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			//return new NavigationPage (new MainPage ());
			return new NavigationPage (new VacationApproval ());
		}

		public static INavigation Navigator { get; set; }
	}
}

