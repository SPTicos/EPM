using System;
using System.Collections.Generic;

namespace EPMServices
{
	public interface IUserRepository
	{
		IEnumerable<User> users();
		User GetUserById (long Id);
		long IsLoginValid (string Account, string Password);
	}
}

