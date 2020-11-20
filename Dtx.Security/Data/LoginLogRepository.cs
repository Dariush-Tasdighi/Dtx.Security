using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Data
{
	public class LoginLogRepository : Repository<Models.LoginLog>, ILoginLogRepository
	{
		internal LoginLogRepository(DatabaseContext databaseContext) : base(databaseContext)
		{
		}

		/// <summary>
		/// This method gets LoginLog(s) of an user by userId parameter, synchronously
		/// </summary>
		/// <param name="userId"></param>
		/// <returns>
		/// Generic List of Models.LoginLog for specific user
		/// </returns>
		public System.Collections.Generic.List<Models.LoginLog> GetByUserId(System.Guid userId)
		{
			var result =
				DbSet
				.Where(current => current.UserId == userId)
				.ToList()
				;

			return result;
		}

		/// <summary>
		/// This method gets LoginLog(s) of an user by userId parameter, asynchronously
		/// </summary>
		/// <param name="userId"></param>
		/// <returns>
		/// Generic Task of Generic List of Models.LoginLog for specific user
		/// </returns>
		public async System.Threading.Tasks.Task<System.Collections.Generic.List<Models.LoginLog>> GetByUserIdAsync(System.Guid userId)
		{
			var result =
				await DbSet
				.Where(current => current.UserId == userId)
				.ToListAsync()
				;

			return result;
		}

		/// <summary>
		/// This method gets last LoginLog(s) order by insert time of LoginLog by count parameter, synchronously
		/// </summary>
		/// <param name="count"></param>
		/// <returns>
		/// Generic List of Models.LoginLog order by insert time 
		/// </returns>
		public System.Collections.Generic.List<Models.LoginLog> GetLast(int count)
		{
			var result =
				DbSet
				.OrderByDescending(current => current.InsertDateTime)
				.Take(count)
				.ToList()
				;

			return result;
		}

		/// <summary>
		/// This method gets last LoginLog(s) order by insert time of LoginLog by count parameter, asynchronously
		/// </summary>
		/// <param name="count"></param>
		/// <returns>
		/// Generic Task of Generic List of Models.LoginLog order by insert time 
		/// </returns>
		public async System.Threading.Tasks.Task<System.Collections.Generic.List<Models.LoginLog>> GetLastAsync(int count)
		{
			var result =
				await DbSet
				.OrderByDescending(current => current.InsertDateTime)
				.Take(count)
				.ToListAsync()
				;

			return result;
		}

		/// <summary>
		/// This method gets last LoginLog(s) of specefic user order by insert time of LoginLog by userId and count parameter, synchronously
		/// </summary>
		/// <param name="userId"></param>
		/// <param name="count"></param>
		/// <returns>
		/// Generic List of Models.LoginLog order by insert time for specefic user
		/// </returns>
		public System.Collections.Generic.List<Models.LoginLog> GetLastOfUser(System.Guid userId, int count)
		{
			var result =
				DbSet
				.Where(current => current.UserId == userId)
				.OrderByDescending(current => current.InsertDateTime)
				.Take(count)
				.ToList()
				;

			return result;
		}

		/// <summary>
		/// This method gets last LoginLog(s) of specefic user order by insert time of LoginLog by userId and count parameter, asynchronously
		/// </summary>
		/// <param name="count"></param>
		/// <returns>
		/// Generic Task of Generic List of Models.LoginLog order by insert time for specefic user
		/// </returns>
		public async System.Threading.Tasks.Task<System.Collections.Generic.List<Models.LoginLog>> GetLastOfUserAsync(System.Guid userId, int count)
		{
			var result =
				await DbSet
				.Where(current => current.UserId == userId)
				.OrderByDescending(current => current.InsertDateTime)
				.Take(count)
				.ToListAsync()
				;

			return result;
		}
	}
}
