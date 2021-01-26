namespace Data
{
	public interface IUserValidIPRepository : Base.IRepository<Models.UserValidIP>
	{
		System.Collections.Generic.List<Models.UserValidIP> GetActive();

		System.Collections.Generic.List<Models.UserValidIP> GetByUserId(System.Guid id);

		System.Collections.Generic.List<Models.UserValidIP> GetByUsername(string username);

		System.Collections.Generic.List<Models.UserValidIP> GetActiveByUserId(System.Guid id);

		System.Collections.Generic.List<Models.UserValidIP> GetActiveByUsername(string username);
	}
}