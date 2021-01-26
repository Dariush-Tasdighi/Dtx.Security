

using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Data
{ /// <summary>
  /// This class implement from IApplicationValidIPRepository interface and generic base repository
  /// </summary>
  /// <remarks>
  /// This class Contains all methods for performing fetch data 
  /// </remarks>

    public class ApplicationValidIPRepository : Repository<Models.ApplicationValidIP>, IApplicationValidIPRepository
    {
        /// <summary>
        /// the constructor of class
        /// </summary>
        /// <param name="databaseContext"></param>
        internal ApplicationValidIPRepository(DatabaseContext databaseContext)
            : base(databaseContext: databaseContext)
        {
        }

        /// <summary>
        /// This method get application record by pass ip parameter synchronously
        /// </summary>
        /// <param name="ip"></param>
        /// <returns>
        /// Return null or one record of application that IP field is equal to passed parameter
        /// </returns>
        public Models.Application GetApplicationByIP(string ip)
        {
            if (string.IsNullOrWhiteSpace(ip) == true)
            {
                return null;
            }

            Models.Application application =
                DbSet
                .Where(current => current.IP == ip)
                .FirstOrDefault()
                .Application
                ;

            return application;
        }

        /// <summary>
        /// This method get application record by pass ip parameter asynchronously
        /// </summary>
        /// <param name="ip"></param>
        /// <returns>
        /// Return null or one record of application that IP field is equal to passed parameter
        /// </returns>
        public virtual async System.Threading.Tasks.Task<Models.Application> GetApplicationByIPAsync(string ip)
        {
            if (string.IsNullOrWhiteSpace(ip) == true)
            {
                return null;
            }

            Models.Application application = null;
            await System.Threading.Tasks.Task.Run(() =>
            {
                application =
                    DbSet
                    .Where(current => current.IP == ip)
                    .FirstOrDefault()
                    .Application
                    ;
            });

            return application;
        }

        /// <summary>
        /// this method get IP List  By applicationId field from database synchronously
        /// </summary>

        /// <param name="applicationId"></param>

        /// <returns>
        /// Return a list of IPs of application that applicationId field is equal to passed parameter 
        /// </returns>
        public System.Collections.Generic.List<string> GetIPsByApplicationId(System.Guid applicationId)
        {
            System.Collections.Generic.List<string> lstIPs = new System.Collections.Generic.List<string>();
            var result =
               DbSet
               .Where(current => current.ApplicationId == applicationId)
               .ToList()
               ;

            foreach (Models.ApplicationValidIP item in result)
            {
                lstIPs.Add(item.IP);
            }
            return lstIPs;
        }

        /// <summary>
        /// this method get IP List  By applicationId field from database asynchronously
        /// </summary>

        /// <param name="applicationId"></param>

        /// <returns>
        /// Return a list of IPs of application that applicationId field is equal to passed parameter 
        /// </returns>
        public virtual async System.Threading.Tasks.Task<System.Collections.Generic.List<string>> GetIPsByApplicationIdAsync(System.Guid applicationId)
        {
            System.Collections.Generic.List<string> lstIPs = new System.Collections.Generic.List<string>();
            var result =
                await
               DbSet
               .Where(current => current.ApplicationId == applicationId)
               .ToListAsync()
               ;

            foreach (Models.ApplicationValidIP item in result)
            {
                lstIPs.Add(item.IP);
            }
            return lstIPs;
        }
    }
}
