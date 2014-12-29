using System;
using System.Collections.Generic;

namespace EPMServices
{
	public interface IAppMetadataRepository
	{
		void setOptions(ref List<MainMenuOption> options);
	}
}

