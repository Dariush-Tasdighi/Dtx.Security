
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Data
{
    /// <summary>
    /// This class implement from IApplicationValidUrlRepository interface and generic base repository
    /// </summary>
    /// <remarks>
    /// This class Contains all methods for performing fetch data 
    /// </remarks>
    public class ApplicationValidUrlRepository : Repository<Models.ApplicationValidUrl>, IApplicationValidUrlRepository
    {
        /// <summary>
        /// the constructor of class
        /// </summary>
        /// <param name="databaseContext"></param>
        internal ApplicationValidUrlRepository(DatabaseContext databaseContext)
            : base(databaseContext)
        {
        }

        /// <summary>
        /// This method get application record by pass url parameter synchronously
        /// </summary>
        /// <param name="url"></param>
        /// <returns>
        /// Return null or one record of application that url field is equal to passed parameter
        /// </returns>
        public Models.Application GetApplicationByURL(string url)
        {
            if (string.IsNullOrWhiteSpace(url) == true)
            {
                return null;
            }

            Models.Application application =
                DbSet
                .Where(current => current.Url == url)
                .FirstOrDefault()
                .Application
                ;

            return application;
        }

        /// <summary>
        /// This method get application record by pass url parameter asynchronously
        /// </summary>
        /// <param name="url"></param>
        /// <returns>
        /// Return null or one record of application that url field is equal to passed parameter
        /// </returns>
        public virtual async System.Threading.Tasks.Task<Models.Application> GetApplicationByURLAsync(string url)
        {
            if (string.IsNullOrWhiteSpace(url) == true)
            {
                return null;
            }

            Models.Application application = null;
            await System.Threading.Tasks.Task.Run(() =>
            {
                application =
                    DbSet
                    .Where(current => current.Url == url)
                    .FirstOrDefault()
                    .Application
                    ;
            });

            return application;
        }

        /// <summary>
        /// this method get URL List  By applicationId field from database synchronously
        /// </summary>

        /// <param name="applicationId"></param>

        /// <returns>
        /// Return a list of URLs of application that applicationId field is equal to passed parameter 
        /// </returns>
        public System.Collections.Generic.List<string> GetURLsByApplicationId(System.Guid applicationId)
        {
            System.Collections.Generic.List<string> lstURLs = new System.Collections.Generic.List<string>();
            var result =
               DbSet
               .Where(current => current.ApplicationId == applicationId)
               .ToList()
               ;

            foreach (Models.ApplicationValidUrl item in result)
            {
                lstURLs.Add(item.Url);
            }
            return lstURLs;
        }


        /// <summary>
        /// this method get URL List  By applicationId field from database asynchronously
        /// </summary>

        /// <param name="applicationId"></param>

        /// <returns>
        /// Return a list of URLs of application that applicationId field is equal to passed parameter 
        /// </returns>
        public virtual async System.Threading.Tasks.Task<System.Collections.Generic.List<string>> GetURLsByApplicationIdAsync(System.Guid applicationId)
        {
            System.Collections.Generic.List<string> lstURLs = new System.Collections.Generic.List<string>();
            var result =
               await
               DbSet
               .Where(current => current.ApplicationId == applicationId)
               .ToListAsync()
               ;

            foreach (Models.ApplicationValidUrl item in result)
            {
                lstURLs.Add(item.Url);
            }
            return lstURLs;
        }
    }
}
