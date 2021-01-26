using System.Linq;

namespace Data
{
	public class UserPasswordHistoryRepository : Repository<Models.UserPasswordHistory>, IUserPasswordHistoryRepository
	{
		internal UserPasswordHistoryRepository(DatabaseContext databaseContext) : base(databaseContext)
		{
		}

		public bool IsPasswordAlreadyUsed(System.Guid id, string password)
		{
			if (string.IsNullOrWhiteSpace(password))
			{
				return false;
			}

			var result =
				DbSet
				.Where(current => current.UserId == id)
				.Where(current => current.Password == password)
				.Count();

			if (result == 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	}
}
