
namespace Data
{
    /// <summary>
    ///  In this interface, the methods required to create ApplicationValidUrl repository are defined
    /// </summary>
    public interface IApplicationValidUrlRepository : Base.IRepository<Models.ApplicationValidUrl>
    {
        /// <summary>
        /// this method get Applications By url field from database synchronously
        /// </summary>

        /// <param name="url"></param>

        /// <returns>
        /// Return a record of application that url field is equal to passed parameter 
        /// </returns>
        Models.Application GetApplicationByURL(string url);

        /// <summary>
        /// this method get Applications By url field from database asynchronously
        /// </summary>

        /// <param name="url"></param>

        /// <returns>
        /// Return a record of application that url field is equal to passed parameter 
        /// </returns>
        System.Threading.Tasks.Task<Models.Application> GetApplicationByURLAsync(string url);

        /// <summary>
        /// this method get URL List  By applicationId field from database synchronously
        /// </summary>

        /// <param name="applicationId"></param>

        /// <returns>
        /// Return a list of URLs of application that applicationId field is equal to passed parameter 
        /// </returns>
        System.Collections.Generic.List<string> GetURLsByApplicationId(System.Guid applicationId);

        /// <summary>
        /// this method get URL List  By applicationId field from database asynchronously
        /// </summary>

        /// <param name="applicationId"></param>

        /// <returns>
        /// Return a list of URLs of application that applicationId field is equal to passed parameter 
        /// </returns>
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> GetURLsByApplicationIdAsync(System.Guid applicationId);
    }
}
