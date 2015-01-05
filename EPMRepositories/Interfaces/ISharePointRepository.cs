using System;
using System.Collections.Generic;

namespace EPMServices
{
	interface ISharePointRepository{
		bool SaveVacationRequest(VacationRequest v);
		bool DeleteVacationRequest(int id);
		bool UpdateVacationRequest(VacationRequest v);
		IEnumerable<VacationRequest> GetVacationRequests();
		VacationRequest GetVacationRequestById(int id);
	}
}