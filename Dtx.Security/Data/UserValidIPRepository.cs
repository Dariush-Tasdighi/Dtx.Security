using System.Linq;

namespace Data
{
	public class UserValidIPRepository : Repository<Models.UserValidIP>, IUserValidIPRepository
	{
		internal UserValidIPRepository(DatabaseContext databaseContext) : base(databaseContext)
		{
		}

		public System.Collections.Generic.List<Models.UserValidIP> GetActive()
		{
			var result =
				DbSet
				.Where(current => current.IsActive)
				.ToList()
				;

			return result;
		}

		public System.Collections.Generic.List<Models.UserValidIP> GetByUserId(System.Guid id)
		{
			var result =
				DbSet
				.Where(current => current.UserId == id)
				.ToList()
				;

			return result;
		}

		public System.Collections.Generic.List<Models.UserValidIP> GetByUsername(string username)
		{
			if (string.IsNullOrWhiteSpace(username))
			{
				return null;
			}

			var result =
				DbSet
				.Where(current => current.User.Username.ToLower() == username.ToLower())
				.ToList()
				;

			return result;
		}

		public System.Collections.Generic.List<Models.UserValidIP> GetActiveByUserId(System.Guid id)
		{
			var result =
				DbSet
				.Where(current => current.UserId == id)
				.Where(current => current.IsActive)
				.ToList()
				;

			return result;
		}

		public System.Collections.Generic.List<Models.UserValidIP> GetActiveByUsername(string username)
		{
			if (string.IsNullOrWhiteSpace(username))
			{
				return null;
			}

			var result =
				DbSet
				.Where(current => current.User.Username.ToLower() == username.ToLower())
				.Where(current => current.IsActive)
				.ToList()
				;

			return result;
		}
	}
}
