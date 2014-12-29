using System;

namespace EPMServices
{
	public class VacationRequest
	{
		public DateTime InitialDate {
			get;
			set;
		}

		public DateTime EndDate {
			get;
			set;
		}

		public DateTime SubmissionDate {
			get;
			set;
		}

		public User User {
			get;
			set;
		}

		public string Comments {
			get;
			set;
		}

		public VacationRequest ()
		{
		}
	}
}

