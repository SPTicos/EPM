using System;
using Xamarin.Forms;

namespace EPM
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new EPM.VacationRequest ();
		}
	}
}

