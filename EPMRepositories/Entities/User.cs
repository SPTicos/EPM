using System;

namespace EPMServices
{
	public class User
	{
		public long Id {
			get;
			set;
		}
		public string Name {
			get;
			set;
		}

		public int VacationDays {
			get;
			set;
		}

		public string Account {
			get;
			set;
		}

		public string Password {
			get;
			set;
		}

		public User Manager {
			get;
			set;
		}
	}
}

