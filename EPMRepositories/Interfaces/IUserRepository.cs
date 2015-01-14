using System;
using System.Collections.Generic;

namespace EPMServices
{
	public interface IUserRepository
	{
		IEnumerable<User> users ();

		User GetUserById (Int32 Id);

		long IsLoginValid (string Account, string Password);
	}
}

