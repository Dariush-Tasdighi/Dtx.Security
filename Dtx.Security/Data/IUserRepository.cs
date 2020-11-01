namespace Data
{
	public interface IUserRepository : Base.IRepository<Models.User>
	{
		/// <summary>
		/// فراخوانی کاربر برحسب نام کاربر
		/// </summary>
		/// <param name="username"></param>
		/// <returns></returns>
		Models.User GetByUsername(string username);

		/// <summary>
		/// فراخوانی کاربر برحسب نام کاربر
		/// </summary>
		/// <param name="username"></param>
		/// <returns></returns>
		System.Threading.Tasks.Task<Models.User> GetByUsernameAsync(string username);

		/// <summary>
		/// لیست کاربران فعال
		/// </summary>
		/// <returns></returns>
		System.Collections.Generic.List<Models.User> GetActive();

		/// <summary>
		/// فراخوانی کاربر برحسب ایمیل آدرس
		/// </summary>
		/// <param name="emailAddress"></param>
		/// <returns></returns>
		Models.User GetByEmailAddress(string emailAddress);

		/// <summary>
		/// فراخوانی کاربر برحسب ایمیل آدرس
		/// </summary>
		/// <param name="emailAddress"></param>
		/// <returns></returns>
		System.Threading.Tasks.Task<Models.User> GetByEmailAddressAsync(string emailAddress);

		/// <summary>
		/// فراخوانی کاربر برحسب کد ملی
		/// </summary>
		/// <param name="nationalCode"></param>
		/// <returns></returns>
		Models.User GetByNationalCode(string nationalCode);

		/// <summary>
		/// فراخوانی کاربر برحسب کد ملی
		/// </summary>
		/// <param name="nationalCode"></param>
		/// <returns></returns>
		System.Threading.Tasks.Task<Models.User> GetByNationalCodeAsync(string nationalCode);
}
}
