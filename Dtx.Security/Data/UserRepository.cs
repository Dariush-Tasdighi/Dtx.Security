using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Data
{
	public class UserRepository : Repository<Models.User>, IUserRepository
	{
		internal UserRepository(DatabaseContext databaseContext) : base(databaseContext)
		{
		}

		public Models.User GetByUsername(string username)
		{
			//var result =
			//	DbSet
			//	.Where(current => string.Compare(current.Username, username, true) == 0)
			//	.FirstOrDefault();

			var result =
				DbSet
				.Where(current => current.Username.ToLower() == username.ToLower())
				.FirstOrDefault();

			return result;
		}

		public System.Threading.Tasks.Task<Models.User> GetByUsernameAsync(string username)
		{
			var result =
				DbSet
				.Where(current => current.Username.ToLower() == username.ToLower())
				.FirstOrDefaultAsync();

			return result;
		}
	}
}
