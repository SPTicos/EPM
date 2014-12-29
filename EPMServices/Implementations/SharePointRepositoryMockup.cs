using System;
using System.Collections.Generic;

namespace EPMServices
{
	public class SharePointRepositoryMockup : ISharePointRepository
	{
		public SharePointRepositoryMockup ()
		{
		}

		public void setOptions(ref List<MainMenuOption> options){
			int x = 4;
			for (int c = 0; c < x; c++) {
				var menuOption = new MainMenuOption { Title = "Option " + c, ContainerId = "Id " + c };
				options.Add (menuOption);
			}
		}
	}
}

