using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Data
{
	public class UserRepository : Repository<Models.User>, IUserRepository
	{
		internal UserRepository(DatabaseContext databaseContext) : base(databaseContext)
		{
		}

		/// <summary>
		/// فراخوانی کاربر برحسب نام کاربر
		/// </summary>
		/// <param name="username"></param>
		/// <returns></returns>
		public Models.User GetByUsername(string username)
		{
			if (string.IsNullOrWhiteSpace(username))
			{
				return null;
			}
			//var result =
			//	DbSet
			//	.Where(current => string.Compare(current.Username, username, true) == 0)
			//	.FirstOrDefault();
			var result =
				DbSet
				.Where(current => current.IsDeleted == false &&
								  current.Username.ToLower() == username.ToLower())
				.FirstOrDefault();

			return result;
		}

		/// <summary>
		/// فراخوانی کاربر برحسب نام کاربر
		/// </summary>
		/// <param name="username"></param>
		/// <returns></returns>
		public System.Threading.Tasks.Task<Models.User> GetByUsernameAsync(string username)
		{
			if (string.IsNullOrWhiteSpace(username))
			{
				return null;
			}

			var result =
				DbSet
				.Where(current => current.IsDeleted == false &&
								  current.Username.ToLower() == username.ToLower())
				.FirstOrDefaultAsync();

			return result;
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public System.Collections.Generic.List<Models.User> GetActive()
		{
			var result =
				DbSet
				.Where(current => current.IsDeleted == false &&
								  current.IsActive)
				.ToList()
				;

			return result;
		}

		/// <summary>
		/// فراخوانی کاربر برحسب ایمیل آدرس
		/// </summary>
		/// <param name="emailAddress"></param>
		/// <returns></returns>
		public Models.User GetByEmailAddress(string emailAddress)
		{
			if (string.IsNullOrWhiteSpace(emailAddress))
			{
				return null;
			}

			//var result =
			//	DbSet
			//	.Where(current => string.Compare(current.EmailAddress, EmailAddress, true) == 0)
			//	.FirstOrDefault();

			var result =
				DbSet
				.Where(current => current.IsDeleted == false &&
								  current.EmailAddress.ToLower() == emailAddress.ToLower())
				.FirstOrDefault();

			return result;
		}

		/// <summary>
		/// فراخوانی کاربر برحسب ایمیل آدرس
		/// </summary>
		/// <param name="emailAddress"></param>
		/// <returns></returns>
		public System.Threading.Tasks.Task<Models.User> GetByEmailAddressAsync(string emailAddress)
		{
			if (string.IsNullOrWhiteSpace(emailAddress))
			{
				return null;
			}

			var result =
				DbSet
				.Where(current => current.IsDeleted == false &&
								  current.EmailAddress.ToLower() == emailAddress.ToLower())
				.FirstOrDefaultAsync();

			return result;
		}

		/// <summary>
		/// فراخوانی کاربر برحسب کد ملی
		/// </summary>
		/// <param name="nationalCode"></param>
		/// <returns></returns>
		public Models.User GetByNationalCode(string nationalCode)
		{
			if (string.IsNullOrWhiteSpace(nationalCode))
			{
				return null;
			}

			//var result =
			//	DbSet
			//	.Where(current => string.Compare(current.NationalCode, NationalCode, true) == 0)
			//	.FirstOrDefault();

			var result =
				DbSet
				.Where(current => current.IsDeleted == false &&
								  current.NationalCode.ToLower() == nationalCode.ToLower())
				.FirstOrDefault();

			return result;
		}

		/// <summary>
		/// فراخوانی کاربر برحسب کد ملی
		/// </summary>
		/// <param name="nationalCode"></param>
		/// <returns></returns>
		public System.Threading.Tasks.Task<Models.User> GetByNationalCodeAsync(string nationalCode)
		{
			if (string.IsNullOrWhiteSpace(nationalCode))
			{
				return null;
			}

			var result =
				DbSet
				.Where(current => current.IsDeleted == false &&
								  current.NationalCode.ToLower() == nationalCode.ToLower())
				.FirstOrDefaultAsync();

			return result;
		}

	}
}
