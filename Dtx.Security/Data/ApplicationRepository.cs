using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    /// <summary>
    /// This class implement from IApplicationRepository interface and generic base repository
    /// </summary>
    /// <remarks>
    /// This class Contains all methods for performing fetch data 
    /// </remarks>
    public class ApplicationRepository : Repository<Models.Application>, IApplicationRepository
    {
        /// <summary>
        /// the constructor of class
        /// </summary>
        /// <param name="databaseContext"></param>
		internal ApplicationRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }

        /// <summary>
        /// This method get application records by pass isIPRestricted parameter synchronously
        /// </summary>
        /// <param name="isIPRestricted"></param>
        /// <returns>
        /// Return List of application records that isIPRestricted field is true or false
        /// </returns>
        public System.Collections.Generic.List<Models.Application> GetApplicationsByIsIPRestricted(bool isIPRestricted)
        {
            var result =
                DbSet
                .Where(current => current.IsIPRestricted == isIPRestricted)
                .ToList()
                ;

            return result;
        }

        /// <summary>
        /// This method get application records by pass isIPRestricted parameter asynchronously
        /// </summary>
        /// <param name="isIPRestricted"></param>
        /// <returns>
        /// Return List of application records that isIPRestricted field is true or false
        /// </returns>
        public virtual async System.Threading.Tasks.Task<System.Collections.Generic.List<Models.Application>> GetApplicationsByIsIPRestrictedAsync(bool isIPRestricted)
        {
            var result =
                await
                DbSet
                .Where(current => current.IsIPRestricted == isIPRestricted)
                .ToListAsync()
                ;

            return result;
        }

        /// <summary>
        /// This method get application records by pass isURLRestricted parameter synchronously
        /// </summary>
        /// <param name="isURLRestricted"></param>
        /// <returns>
        /// Return List of application records that isURLRestricted field is true or false
        /// </returns>

        public System.Collections.Generic.List<Models.Application> GetApplicationsByIsURLRestricted(bool isURLRestricted)
        {
            var result =
                DbSet
                .Where(current => current.IsUrlRestricted == isURLRestricted)
                .ToList()
                ;

            return result;
        }

        /// <summary>
        /// This method get application records by pass isURLRestricted parameter asynchronously
        /// </summary>
        /// <param name="isURLRestricted"></param>
        /// <returns>
        /// Return List of application records that isURLRestricted field is true or false
        /// </returns>
        public virtual async System.Threading.Tasks.Task<System.Collections.Generic.List<Models.Application>> GetApplicationsByIsURLRestrictedAsync(bool isURLRestricted)
        {
            var result =
                       await
                       DbSet
                       .Where(current => current.IsUrlRestricted == isURLRestricted)
                       .ToListAsync()
                       ;

            return result;
        }

        /// <summary>
        /// This method get user records by pass applicationId parameter synchronously
        /// </summary>
        /// <param name="applicationId"></param>
        /// <returns>
        /// Return a record of user by applicationId
        /// </returns>
        public Models.User GetVerifierUser(System.Guid applicationId)
        {
            var result =
                DbSet
                .Where(current => current.Id == applicationId)
                .FirstOrDefault()
                ;
            if (result == null)
            {
                return null;
            }
            Models.User user = result.VerifierUser;

            return user;
        }

        /// <summary>
        /// This method get user records by pass applicationId parameter asynchronously
        /// </summary>
        /// <param name="applicationId"></param>
        /// <returns>
        /// Return a record of user by applicationId
        /// </returns>
        public virtual async System.Threading.Tasks.Task<Models.User> GetVerifierUserAsuync(System.Guid applicationId)
        {
            var result =
                await
                DbSet
                .Where(current => current.Id == applicationId)
                .FirstOrDefaultAsync()
                ;
            if (result == null)
            {
                return null;
            }
            Models.User user = result.VerifierUser;

            return user;
        }
    }
}
