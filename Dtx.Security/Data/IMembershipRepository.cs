namespace Data
{
	public interface IMembershipRepository : Base.IRepository<Models.Membership>
	{
		System.Collections.Generic.List<Models.ApplicationGroup> GetUserApplicationGroupsByUserId(System.Guid id);
		System.Collections.Generic.List<Models.User> GetApplicationGroupUsersByApplicationGroupId(System.Guid id);
	}
}