using System;
using System.Linq;

namespace Data
{
	public class MembershipRepository : Repository<Models.Membership>, IMembershipRepository
	{
		internal MembershipRepository(DatabaseContext databaseContext) : base(databaseContext)
		{
		}

		public System.Collections.Generic.List<Models.ApplicationGroup> GetUserApplicationGroupsByUserId(Guid id)
		{
			var result =
				DbSet
				.Where(current => current.UserId == id)
				.Select(current => current.ApplicationGroup)
				.ToList()
				;

			return result;
		}

		public System.Collections.Generic.List<Models.User> GetApplicationGroupUsersByApplicationGroupId(Guid id)
		{
			var result =
				DbSet
				.Where(current => current.ApplicationGroupId == id)
				.Select(current => current.User)
				.ToList()
				;

			return result;
		}
	}
}
