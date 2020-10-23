namespace Data
{
	public interface IUserRepository : Base.IRepository<Models.User>
	{
		Models.User GetByUsername(string username);

		System.Threading.Tasks.Task<Models.User> GetByUsernameAsync(string username);

		System.Collections.Generic.List<Models.User> GetActive();
	}
}
