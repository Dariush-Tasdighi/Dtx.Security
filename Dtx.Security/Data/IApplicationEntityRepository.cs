using Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data
{
	public interface IApplicationEntityRepository
	{
		List<ApplicationEntity> GetActive();
		Task<ApplicationEntity> GetByNameAsync(string name);
		IList<CheckPermissionLog> GetCheckPermissionLogList(Guid id);
		List<ApplicationEntity> GetIsSynced();
		IList<Permission> GetPermissionList(Guid id);
	}
}