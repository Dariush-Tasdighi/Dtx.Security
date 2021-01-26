
namespace Data
{
    /// <summary>
    ///  In this interface, the methods required to create applicationValidIP repository are defined
    /// </summary>
    public interface IApplicationValidIPRepository : Base.IRepository<Models.ApplicationValidIP>
    {
        /// <summary>
        /// this method get Applications By ip field from database synchronously
        /// </summary>

        /// <param name="ip"></param>

        /// <returns>
        /// Return a record of application that ip field is equal to passed parameter 
        /// </returns>
        Models.Application GetApplicationByIP(string ip);

        /// <summary>
        /// this method get Applications By ip field from database asynchronously
        /// </summary>

        /// <param name="ip"></param>

        /// <returns>
        /// Return a record of application that ip field is equal to passed parameter 
        /// </returns>
        System.Threading.Tasks.Task<Models.Application> GetApplicationByIPAsync(string ip);

        /// <summary>
        /// this method get IP List  By applicationId field from database synchronously
        /// </summary>

        /// <param name="applicationId"></param>

        /// <returns>
        /// Return a list of IPs of application that applicationId field is equal to passed parameter 
        /// </returns>

        System.Collections.Generic.List<string> GetIPsByApplicationId(System.Guid applicationId);

        /// <summary>
        /// this method get IP List  By applicationId field from database asynchronously
        /// </summary>

        /// <param name="applicationId"></param>

        /// <returns>
        /// Return a list of IPs of application that applicationId field is equal to passed parameter 
        /// </returns>
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> GetIPsByApplicationIdAsync(System.Guid applicationId);
    }
}
