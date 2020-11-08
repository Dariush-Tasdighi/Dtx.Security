using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Data
{
	public class PermissionRepository : Repository<Models.Permission>, IPermissionRepository
	{
		internal PermissionRepository(DatabaseContext databaseContext) : base(databaseContext)
		{

		}

		/// <summary>
		/// لیستی از دسترسی ها بر اساس آیدی ApplicationGroup
		/// </summary>
		/// <param name="applicationGroupdId"></param>
		/// <returns></returns>
		public System.Collections.Generic.List<Models.Permission> GetByApplicationGroupId(System.Guid applicationGroupdId)
		{
			var result =
				DbSet
				.Where(current => current.ApplicationGroupId == applicationGroupdId)
				.ToList()
				;

			return result;
		}

		/// <summary>
		/// لیستی از دسترسی ها بر اساس آیدی ApplicationGroup
		/// </summary>
		/// <param name="applicationGroupId"></param>
		/// <returns></returns>
		public async System.Threading.Tasks.Task<System.Collections.Generic.List<Models.Permission>> GetByApplicationGroupIdAsync(System.Guid applicationGroupId)
		{
			var result =
			  await DbSet
			  .Where(current => current.ApplicationGroupId == applicationGroupId)
			  .ToListAsync()
			  ;

			return result;
		}


		/// <summary>
		/// لیستی از دسترسی ها بر اساس آیدی ApplicationEntity
		/// </summary>
		/// <param name="applicationEntityId"></param>
		/// <returns></returns>
		public System.Collections.Generic.List<Models.Permission> GetByApplicationEntityId(System.Guid applicationEntityId)
		{
			var result =
				DbSet
				.Where(current => current.ApplicationEntityId == applicationEntityId)
				.ToList()
				;

			return result;
		}


		/// <summary>
		/// لیستی از دسترسی ها بر اساس آیدی ApplicationEntity
		/// </summary>
		/// <param name="applicationEntityId"></param>
		/// <returns></returns>
		public async System.Threading.Tasks.Task<System.Collections.Generic.List<Models.Permission>> GetByApplicationEntityIdAsync(System.Guid applicationEntityId)
		{
			var result =
				await DbSet
				.Where(current => current.ApplicationEntityId == applicationEntityId)
				.ToListAsync()
				;

			return result;
		}
	}
}
