using System;
using System.Collections.Generic;

namespace EPMServices
{
	public class SharePointRepositoryMockup : ISharePointRepository
	{
		Dictionary<int, VacationRequest> vList;
		List<VacationHistory> vacaionHistoryList;

		public SharePointRepositoryMockup ()
		{
			var userRepo = new UsersMockupRepository ();
			vacaionHistoryList = new List<VacationHistory> ();

			vacaionHistoryList.Add (
				new VacationHistory {
					User = userRepo.GetUserById (2),
					InitialDate = DateTime.Now.AddYears (-1),
					EndDate = DateTime.Now.AddYears (-1).AddDays (10),
					Duration = string.Concat (((int)((DateTime.Now.AddYears (-1).AddDays (10)) - (DateTime.Now.AddYears (-1))).TotalDays + 1).ToString (), " days")
				}
			);

			vacaionHistoryList.Add (
				new VacationHistory {
					User = userRepo.GetUserById (2),
					InitialDate = DateTime.Now.AddMonths (-1),
					EndDate = DateTime.Now.AddMonths (-1).AddDays (5),
					Duration = string.Concat (((int)((DateTime.Now.AddMonths (-1).AddDays (5)) - (DateTime.Now.AddMonths (-1))).TotalDays + 1).ToString (), " days")
				}
			);

			vacaionHistoryList.Add (
				new VacationHistory {
					User = userRepo.GetUserById (2),
					InitialDate = DateTime.Now.AddDays (-15),
					EndDate = DateTime.Now.AddDays (-1),
					Duration = string.Concat (((int)((DateTime.Now.AddDays (-1)) - (DateTime.Now.AddDays (-15))).TotalDays + 1).ToString (), " days")
				}
			);

			foreach (var request in vacaionHistoryList) {
				string shortInitialDate = string.Concat (request.InitialDate.Month, "/", request.InitialDate.Day, "/", request.InitialDate.Year);
				string shortEndDate = string.Concat (request.EndDate.Month, "/", request.EndDate.Day, "/", request.EndDate.Year);

				request.DateRange = string.Concat (shortInitialDate, " - ", shortEndDate); 
			}
			 


			vList = new Dictionary<int, VacationRequest> ();
			vList.Add (1, new VacationRequest {
				Id = 1,
				InitialDate = DateTime.Now,
				EndDate = DateTime.Now.AddDays (5),
				SubmissionDate = DateTime.Now,
				User = userRepo.GetUserById (2),
				Comments = "Want some PTO"
			});
			vList.Add (2, new VacationRequest {
				Id = 2,
				InitialDate = DateTime.Now,
				EndDate = DateTime.Now.AddDays (5),
				SubmissionDate = DateTime.Now,
				User = userRepo.GetUserById (3),
				Comments = "Want some PTO"
			});
		}



		public bool SaveVacationRequest (VacationRequest v)
		{
			vList.Add (v.Id, v);
			return true;
		}

		public bool DeleteVacationRequest (int id)
		{
			vList.Remove (id);
			return true;
		}

		public bool UpdateVacationRequest (VacationRequest v)
		{
			vList [v.Id] = v;
			return true;
		}

		public IEnumerable<VacationRequest> GetVacationRequests (long ManagerId)
		{
			List<VacationRequest> l = new List<VacationRequest> ();
			foreach (var e in vList) {
				if (e.Value.User.Manager.Id.Equals (ManagerId))
					l.Add (e.Value);
			}
			return l;
		}

		public VacationRequest GetVacationRequestById (int id)
		{
			return vList [id];
		}

		public List<VacationHistory> GetVacationHistory ()
		{
			return vacaionHistoryList;
		}
	}
}

