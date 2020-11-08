using System.Linq;
using Microsoft.EntityFrameworkCore;
using Models;
namespace Data
{
	public class ApplicationGroupRepository : Repository<Models.ApplicationGroup>, IApplicationGroupRepository
	{
		internal ApplicationGroupRepository(DatabaseContext databaseContext) : base(databaseContext)
		{

		}
		public Models.ApplicationGroup GetByName(string name)
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

		public System.Threading.Tasks.Task<Models.ApplicationGroup> GetByNameAsync(string name)
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

		//public System.Threading.Tasks.Task<Models.ApplicationGroup> GetByApplicationId()
		//{
		//	var result=

		//}

		//public GetByApplicationName()
		//{

		//}

		/// <summary>
		/// دریافت ApplicationGroup های فعال 
		/// </summary>
		/// <returns></returns>
		public System.Collections.Generic.IList<Models.ApplicationGroup> GetActive()
		{
			var result =
				DbSet
				.Where(current => current.IsActive)
				.ToList();

			return result;
		}

		/// <summary>
		/// دریافت ApplicationGroup های فعال 
		/// </summary>
		/// <returns></returns>
		public System.Threading.Tasks.Task<System.Collections.Generic.List<Models.ApplicationGroup>> GetAciveAsync()
		{
			var result =
				DbSet
				.Where(current => current.IsActive)
				.ToListAsync();

			return result;
		}

		/// <summary>
		/// دریافت لیست اعضا
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public System.Collections.Generic.IList<Models.Membership> GetMemberships(System.Guid id)
		{
			var result =
				DbSet
				.Where(current => current.Id == id)
				.Select(current => current.Memberships)
				.FirstOrDefault();

			return result;
		}

		/// <summary>
		/// دریافت لیست اعضا
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public System.Threading.Tasks.Task<System.Collections.Generic.IList<Models.Membership>> GetMembershipsAsync(System.Guid id)
		{
			var result =
				DbSet
				.Where(current => current.Id == id)
				.Select(current => current.Memberships)
				.FirstOrDefaultAsync();

			return result;
		}

		public ApplicationGroup GetByApplicationId(System.Guid applicationId)
		{
			var result =
				DbSet
				.Where(current => current.ApplicationId == applicationId)
				.FirstOrDefault();

			return result;
		}
		public System.Threading.Tasks.Task<Models.ApplicationGroup> GetByApplicationIdAsync(System.Guid applicationId)
		{
			var result =
				 DbSet
				 .Where(current => current.ApplicationId == applicationId)
				 .FirstOrDefaultAsync();

			return result;
		}

		/// <summary>
		/// دریافت لیست Permission
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public System.Collections.Generic.IList<Permission> GetPermissions(System.Guid id)
		{
			var result =
				DbSet
				.Where(current => current.Id == id)
				.Select(current => current.Permissions)
				.FirstOrDefault();

			return result;
		}

		/// <summary>
		/// دریافت لیست Permission
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public System.Threading.Tasks.Task<System.Collections.Generic.IList<Models.Permission>> GetPermissionsAsync(System.Guid id)
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

