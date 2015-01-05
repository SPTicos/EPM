﻿using System;
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
			numberOfMenuItems = 2;
			menuTitles = new string[numberOfMenuItems];
			menuImages = new string[numberOfMenuItems];
			menuContainerIds = new string[numberOfMenuItems];

			for (int a = 0; a < menuTitles.Length; a++) {
				menuTitles [a] = "Option " + a;
			}

			menuImages [0] = "airplane.png";
			menuImages [1] = "alarmmultiple.png";

			menuContainerIds [0] = "RequestVacation";
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

