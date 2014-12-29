using System;
using System.Collections.Generic;

namespace EPMServices
{
	interface ISharePointRepository{
		void setOptions(ref List<MainMenuOption> options);
	}
}

