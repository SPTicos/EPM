using System;
using System.Collections.Generic;
using EPMServices;

namespace EPMRepositories
{
	public class UsersMockupRepository : IUserRepository
	{
		List<User> _users;

		public IUsersMockupRepository ()
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
			_users.Add (new User{ Id = 2, Name = "Leonel Messi", VacationDays = 6, Account = "lmessi", Password = "Password", Manager = sandro });
		}

		User GetUserById (long Id){
			foreach (var u in _users) {
				if (u.Id.Equals (Id))
					return u;
			}
			return null;
		}

		long IsLoginValid(string acc, string pass){
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

		IEnumerable<User> users(){
			return _users;
		}
	}
}

