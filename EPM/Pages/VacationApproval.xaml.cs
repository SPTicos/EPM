﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;
using EPMServices;

namespace EPM
{	
	public partial class VacationApproval : ContentPage
	{	
		public VacationApproval ()
		{
			InitializeComponent ();

			var SPRepository = new SharePointRepositoryMockup ();
			var requestList = SPRepository.GetVacationRequests (1);

			List<Cell> cells = new List<Cell> ();
			foreach (var r in requestList) {
				cells.Add (new ImageCell{ Text = r.User.Name, TextColor = Color.Black });
			}

			TableSection mainTable = this.FindByName<TableSection> ("mainTableSection");
			mainTable.Add (cells);
		}
	}
}

