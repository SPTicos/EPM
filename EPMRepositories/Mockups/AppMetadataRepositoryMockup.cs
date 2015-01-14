using System;
using System.Collections.Generic;

namespace EPMServices
{
	public class AppMetadataRepositoryMockup
	{
		string[] menuTitles;
		string[] menuImages;
		string[] menuContainerIds;
		int numberOfMenuItems;

		public AppMetadataRepositoryMockup ()
		{
			numberOfMenuItems = 3;
			menuTitles = new string[numberOfMenuItems];
			menuImages = new string[numberOfMenuItems];
			menuContainerIds = new string[numberOfMenuItems];


			menuTitles [0] = "New Vacation Request";
			menuTitles [2] = "Vacation Approval";
			menuTitles [1] = "History";


			menuContainerIds [0] = "RequestVacation";
			menuContainerIds [2] = "VacationApproval";
			menuContainerIds [1] = "RequestHistory";

			menuImages [0] = "dayCalendar.png";
			menuImages [2] = "doc.png";
			menuImages [1] = "list.png";

		}

		public void setOptions (ref List<MainMenuOption> options)
		{
			for (int c = 0; c < numberOfMenuItems; c++) {
				var menuOption = new MainMenuOption {
					Title = menuTitles [c],
					ContainerId = menuContainerIds [c],
					Img = menuImages [c]
				};
				options.Add (menuOption);
			}
		}
	}
}

