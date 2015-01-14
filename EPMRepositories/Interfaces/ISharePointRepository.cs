using System;
using System.Collections.Generic;

namespace EPMServices
{
	public interface ISharePointRepository{
		bool SaveVacationRequest(VacationRequest v);
		bool DeleteVacationRequest(int id);
		bool UpdateVacationRequest(VacationRequest v);
		List<VacationRequest> GetVacationRequests(long ManagerId);
		VacationRequest GetVacationRequestById(int id);
	}
}