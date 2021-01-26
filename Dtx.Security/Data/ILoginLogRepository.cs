namespace Data
{
	public interface ILoginLogRepository : Base.IRepository<Models.LoginLog>
	{
		System.Collections.Generic.List<Models.LoginLog>
			GetByUserId(System.Guid userId);

		System.Threading.Tasks.Task<System.Collections.Generic.List<Models.LoginLog>>
			GetByUserIdAsync(System.Guid userId);

		System.Collections.Generic.List<Models.LoginLog>
			GetLast(int count);

		System.Threading.Tasks.Task<System.Collections.Generic.List<Models.LoginLog>>
			GetLastAsync(int count);

		System.Collections.Generic.List<Models.LoginLog>
			GetLastOfUser(System.Guid userId, int count);

		System.Threading.Tasks.Task<System.Collections.Generic.List<Models.LoginLog>>
			GetLastOfUserAsync(System.Guid userId, int count);
	}
}
