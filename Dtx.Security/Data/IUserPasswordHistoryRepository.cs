namespace Data
{
	public interface IUserPasswordHistoryRepository : Base.IRepository<Models.UserPasswordHistory>
	{
		bool IsPasswordAlreadyUsed(System.Guid id, string password);
	}
}