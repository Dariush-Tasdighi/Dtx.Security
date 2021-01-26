namespace Data
{
    /// <summary>
    ///  In this interface, the methods required to create application repository are defined
    /// </summary>
    public interface IApplicationRepository : Base.IRepository<Models.Application>
    {
        /// <summary>
        /// this method get Applications By IsIPRestricted field from database synchronously
        /// </summary>

        /// <param name="isIPRestricted"></param>

        /// <returns>
        /// Return List of application records that isIPRestricted field is true or false
        /// </returns>

        System.Collections.Generic.List<Models.Application> GetApplicationsByIsIPRestricted(bool isIPRestricted);

        /// <summary>
        /// this method get Applications By IsIPRestricted field from database asynchronously
        /// </summary>

        /// <param name="isIPRestricted"></param>

        /// <returns>
        /// Return List of application records that isIPRestricted field is true or false
        /// </returns>
        System.Threading.Tasks.Task<System.Collections.Generic.List<Models.Application>> GetApplicationsByIsIPRestrictedAsync(bool isIPRestricted);

        /// <summary>
        /// this method get Applications By isURLRestricted field from database synchronously
        /// </summary>

        /// <param name="isURLRestricted"></param>

        /// <returns>
        ///  Return List of application records that isURLRestricted field is true or false
        /// </returns>
        System.Collections.Generic.List<Models.Application> GetApplicationsByIsURLRestricted(bool isURLRestricted);

        /// <summary>
        /// this method get Applications By isURLRestricted field from database asynchronously
        /// </summary>

        /// <param name="isURLRestricted"></param>

        /// <returns>
        ///  Return List of application records that isURLRestricted field is true or false
        /// </returns>
        System.Threading.Tasks.Task<System.Collections.Generic.List<Models.Application>> GetApplicationsByIsURLRestrictedAsync(bool isURLRestricted);

        /// <summary>
        /// this method get users that is vefied from database synchronously
        /// </summary>

        /// <param name="applicationId"></param>

        /// <returns>
        ///  Return a record of user record that by applicationId
        /// </returns>

        Models.User GetVerifierUser(System.Guid applicationId);

        /// <summary>
        /// this method get users that is vefied from database asynchronously
        /// </summary>

        /// <param name="applicationId"></param>

        /// <returns>
        ///  Return a record of user record that by applicationId
        /// </returns>
        System.Threading.Tasks.Task<Models.User> GetVerifierUserAsuync(System.Guid applicationId);
    }
}
