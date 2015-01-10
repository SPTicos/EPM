using System;
using System.Collections.Generic;

namespace EPMServices
{
	public class UsersMockupRepository : IUserRepository
	{
		List<User> _users;

		public UsersMockupRepository ()
		{
			_users = new List<User> ();
			User sandro = new User {
				Id = 1,
				Name = "Sandro Rossel",
				VacationDays = 8,
				Account = "srosell",
				Password = "Password"
			};
			_users.Add (sandro);
			_users.Add (new User {
				Id = 2,
				Name = "Leonel Messi",
				VacationDays = 6,
				Account = "lmessi",
				Password = "Password",
				Manager = sandro
			});
			_users.Add (new User {
				Id = 3,
				Name = "Xavi Hernandez",
				VacationDays = 6,
				Account = "xhernandez",
				Password = "Password",
				Manager = sandro
			});
		}

		public User GetUserById (Int32 Id)
		{
			foreach (var u in _users) {
				if (u.Id.Equals (Id))
					return u;
			}
			return null;
		}

		public long IsLoginValid (string acc, string pass)
		{
			foreach (var u in _users) {
				if (u.Account.Equals (acc)) {
					if (u.Password.Equals (pass))
						return u.Id;
					else
						return -1;
				}
			}
			return -1;
		}

		public IEnumerable<User> users ()
		{
			return _users;
		}
	}
}

