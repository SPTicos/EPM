using System;
using System.Collections.Generic;
using EPMServices;

namespace EPMRepositories
{
	public interface IUserRepository
	{
		IEnumerable<User> users();
		User GetUserById (long Id);
		long IsLoginValid (string Account, string Password);
	}
}

