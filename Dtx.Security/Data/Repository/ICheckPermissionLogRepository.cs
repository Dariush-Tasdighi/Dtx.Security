namespace Data.Repository
{
    public interface ICheckPermissionLogRepository : Base.IRepository<Models.CheckPermissionLog>
    {
        /// <summary>
        /// فراخوانی لیست لاگ های شده و نشده برحسب کاربر
        /// </summary>
        /// <param name="userId">شناسه کاربر</param>
        /// <param name="issuccessful">وضعیت موفقیت</param>
        /// <returns></returns>
        System.Collections.Generic.List<Models.CheckPermissionLog> GetByUserId(System.Guid userId, bool? issuccessful = null);

        /// <summary>
        /// فراخوانی لیست لاگ های شده و نشده برحسب کاربر
        /// </summary>
        /// <param name="userId">شناسه کاربر</param>
        /// <param name="issuccessful">وضعیت موفقیت</param>
        /// <returns></returns>
        System.Threading.Tasks.Task<System.Collections.Generic.List<Models.CheckPermissionLog>> GetByUserIdAsync(System.Guid userId, bool? issuccessful = null);

        /// <summary>
        /// فراخوانی لیست لاگ های شده و نشده برحسب کاربر
        /// </summary>
        /// <param name="userId">شناسه کاربر</param>
        /// <param name="entityPathName">مسیر اکشن</param>
        /// <returns></returns>
        System.Collections.Generic.List<Models.CheckPermissionLog> GetByUserIdAndEEntityPathName(System.Guid userId, string entityPathName);

        /// <summary>
        /// فراخوانی لیست لاگ های شده و نشده برحسب کاربر
        /// </summary>
        /// <param name="userId">شناسه کاربر</param>
        /// <param name="entityPathName">مسیر اکشن</param>
        /// <returns></returns>
        System.Threading.Tasks.Task<System.Collections.Generic.List<Models.CheckPermissionLog>> GetByUserIdAndEEntityPathNameAsync(System.Guid userId, string entityPathName);

    }
}