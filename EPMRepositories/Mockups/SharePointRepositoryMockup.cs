using System;
using System.Collections.Generic;

namespace EPMServices
{
	public class SharePointRepositoryMockup : ISharePointRepository
	{
		Dictionary<int, VacationRequest> vList;

		public SharePointRepositoryMockup ()
		{
			vList = new Dictionary<int, VacationRequest> ();
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

		public IEnumerable<VacationRequest> GetVacationRequests ()
		{
			List<VacationRequest> l = new List<VacationRequest> ();
			foreach (var e in vList) {
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

