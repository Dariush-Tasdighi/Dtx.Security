using System.Linq;
using Microsoft.EntityFrameworkCore;
using Models;
namespace Data
{
	public class ApplicationEntityRepository : Repository<Models.ApplicationEntity>, IApplicationEntityRepository
	{
		internal ApplicationEntityRepository(DatabaseContext databaseContext) : base(databaseContext)
		{
		}

		/// <summary>
		/// دریافت لیست رکوردهای همگام سازی شده 
		/// </summary>
		/// <returns></returns>
		public System.Collections.Generic.List<ApplicationEntity> GetIsSynced()
		{
			var result =
				DbSet
				.Where(current => current.IsSynced)
				.ToList();

			return result;
		}

		/// <summary>
		/// دریافت لیست رکوردهای همگام سازی شده 
		/// </summary>
		/// <returns></returns>
		public System.Threading.Tasks.Task<System.Collections.Generic.List<ApplicationEntity>> GetIsSyncedAsync()
		{
			var result =
				DbSet
				.Where(current => current.IsSynced)
				.ToListAsync();

			return result;
		}

		/// <summary>
		/// دریافت لیست رکوردهای فعال 
		/// </summary>
		/// <returns></returns>
		public System.Collections.Generic.List<ApplicationEntity> GetActive()
		{
			var result =
				DbSet
				.Where(current => current.IsActive)
				.ToList();

			return result;
		}

		/// <summary>
		/// دریافت لیست رکوردهای فعال 
		/// </summary>
		/// <returns></returns>
		public System.Threading.Tasks.Task<System.Collections.Generic.List<ApplicationEntity>> GetActiveAsync()
		{
			var result =
				DbSet
				.Where(current => current.IsActive)
				.ToListAsync();

			return result;
		}

		/// <summary>
		/// جستجو بر اساس نام 
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public Models.ApplicationEntity GetByName(string name)
		{
			if (string.IsNullOrWhiteSpace(name))
			{
				return null;
			}

			var result =
				DbSet
				.Where(current => current.Name.ToLower() == name.ToLower())
				.FirstOrDefault();

			return result;
		}

		/// <summary>
		/// جستجو بر اساس نام 
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public System.Threading.Tasks.Task<Models.ApplicationEntity> GetByNameAsync(string name)
		{
			if (string.IsNullOrWhiteSpace(name))
			{
				return null;
			}

			var result =
				DbSet
				.Where(current => current.Name.ToLower() == name.ToLower())
				.FirstOrDefaultAsync();

			return result;
		}

		/// <summary>
		/// جیتجو بر اساس سطح دسترسی 
		/// </summary>
		/// <param name="accessType"></param>
		/// <returns></returns>
		public System.Collections.Generic.List<ApplicationEntity> GetByAccessType(Models.Enums.AccessType accessType)
		{
			var result =
				DbSet
				.Where(current => current.AccessType == accessType)
				.ToList();

			return result;
		}

		/// <summary>
		/// جستجو بر اساس نوع 
		/// </summary>
		/// <param name="entityType"></param>
		/// <returns></returns>
		public System.Collections.Generic.List<ApplicationEntity> GetByApplicationEntityType(Models.Enums.ApplicationEntityType entityType)
		{
			var result =
				DbSet
				.Where(current => current.Type == entityType)
				.ToList();

			return result;
		}

		/// <summary>
		/// دریافت لیست CheckPermissionLog
		/// بنا به ApplicationEntity
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public System.Collections.Generic.IList<CheckPermissionLog> GetCheckPermissionLogList(System.Guid id)
		{
			var result =
				DbSet
				.Where(current => current.Id == id)
				.Select(current => current.CheckPermissionLogs)
				.FirstOrDefault();

			return result;
		}

		/// <summary>
		/// دریافت لیست CheckPermissionLog
		/// بنا به ApplicationEntity
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public System.Threading.Tasks.Task<System.Collections.Generic.IList<Models.CheckPermissionLog>> GetCheckPermissionLogListAsync(System.Guid id)
		{
			var result =
				DbSet
				.Where(current => current.Id == id)
				.Select(current => current.CheckPermissionLogs)
				.FirstOrDefaultAsync();

			return result;
		}

		/// <summary>
		/// دریافت لیست دسترسی ها
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public System.Collections.Generic.IList<Models.Permission> GetPermissionList(System.Guid id)
		{
			var result =
				  DbSet
				  .Where(current => current.Id == id)
				  .Select(current => current.Permissions)
				  .FirstOrDefault();

			return result;
		}

		/// <summary>
		/// دریافت لیست دسترسی ها
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public System.Threading.Tasks.Task<System.Collections.Generic.IList<Models.Permission>> GetPermissionListAsync(System.Guid id)
		{

			var result =
				  DbSet
				  .Where(current => current.Id == id)
				  .Select(current => current.Permissions)
				  .FirstOrDefaultAsync();

			return result;
		}
	}
}