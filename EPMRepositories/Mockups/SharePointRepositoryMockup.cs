using System;
using System.Collections.Generic;

namespace EPMServices
{
	public class SharePointRepositoryMockup : ISharePointRepository
	{
		Dictionary<int, VacationRequest> vList;

		public SharePointRepositoryMockup ()
		{
			var userRepo = new UsersMockupRepository ();

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
				if(e.Value.User.Manager.Id.Equals( ManagerId) )
					l.Add (e.Value);
			}
			return l;
		}

		public VacationRequest GetVacationRequestById (int id)
		{
			return vList [id];
		}
	}
}

