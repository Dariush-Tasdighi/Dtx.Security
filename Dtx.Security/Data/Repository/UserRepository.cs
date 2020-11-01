using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class CheckPermissionLogRepository : Repository<Models.CheckPermissionLog>, Data.Repository.ICheckPermissionLogRepository
    {
        internal CheckPermissionLogRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }

        /// <summary>
        /// فراخوانی لیست لاگ های شده و نشده برحسب کاربر
        /// </summary>
        /// <param name="userId">شناسه کاربر</param>
        /// <param name="issuccessful">وضعیت موفقیت</param>
        /// <returns></returns>
        public System.Collections.Generic.List<Models.CheckPermissionLog> GetByUserId(System.Guid userId, bool? issuccessful = null)
        {
            //var result =
            //	DbSet
            //	.Where(current => string.Compare(current.UserId, UserId, true) == 0)
            //	.FirstOrDefault();
            var result =
                DbSet
                .Where(current => current.UserId == userId &&
                    (issuccessful == null || current.Issuccessful == issuccessful.GetValueOrDefault()))
                .ToList();

            return result;
        }

        /// <summary>
        /// فراخوانی لیست لاگ های شده و نشده برحسب کاربر
        /// </summary>
        /// <param name="userId">شناسه کاربر</param>
        /// <param name="issuccessful">وضعیت موفقیت</param>
        /// <returns></returns>
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Models.CheckPermissionLog>> GetByUserIdAsync(System.Guid userId, bool? issuccessful = null)
        {

            var result =
                DbSet
                .Where(current => current.UserId == userId &&
                    (issuccessful == null || current.Issuccessful == issuccessful.GetValueOrDefault()))
                .ToListAsync();

            return result;
        }

        /// <summary>
        /// فراخوانی لیست لاگ های شده و نشده برحسب کاربر
        /// </summary>
        /// <param name="userId">شناسه کاربر</param>
        /// <param name="entityPathName">مسیر اکشن</param>
        /// <returns></returns>
        public System.Collections.Generic.List<Models.CheckPermissionLog> GetByUserIdAndEEntityPathName(System.Guid userId, string entityPathName)
        {
            //var result =
            //	DbSet
            //	.Where(current => string.Compare(current.UserId, UserId, true) == 0)
            //	.FirstOrDefault();
            var result =
                DbSet
                .Where(current => current.UserId == userId &&
                    current.EntityPathName.ToLower() == entityPathName.ToLower())
                .ToList();

            return result;
        }

        /// <summary>
        /// فراخوانی لیست لاگ های شده و نشده برحسب کاربر
        /// </summary>
        /// <param name="userId">شناسه کاربر</param>
        /// <param name="entityPathName">مسیر اکشن</param>
        /// <returns></returns>
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Models.CheckPermissionLog>> GetByUserIdAndEEntityPathNameAsync(System.Guid userId, string entityPathName)
        {

            var result =
                DbSet
                .Where(current => current.UserId == userId &&
                    current.EntityPathName.ToLower() == entityPathName.ToLower())
                .ToListAsync();

            return result;
        }
    }
}
