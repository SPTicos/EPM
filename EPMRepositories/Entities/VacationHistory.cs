using System;

namespace EPMServices
{
	public class VacationHistory
	{

		public User User {
			get;
			set;
		}

		public DateTime InitialDate {
			get;
			set;
		}

		public DateTime EndDate {
			get;
			set;
		}

		public string Duration {
			get;
			set;
		}

		public string DateRange {
			get;
			set;
		}

		public VacationHistory ()
		{
		}
	}
}

