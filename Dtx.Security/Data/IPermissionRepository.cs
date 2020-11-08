using Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data
{
	public interface IPermissionRepository
	{
        /// <summary>
        /// لیستی از دسترسی ها بر اساس آیدی ApplicationGroup
        /// </summary>
        /// <param name="applicationGroupId"></param>
        /// <returns></returns>
        System.Collections.Generic.List<Models.Permission> GetByApplicationGroupId(System.Guid applicationGroupId);

        /// <summary>
        /// لیستی از دسترسی ها بر اساس آیدی ApplicationGroup
        /// </summary>
        /// <param name="applicationGroupId"></param>
        /// <returns></returns>
        System.Threading.Tasks.Task<System.Collections.Generic.List<Models.Permission>> GetByApplicationGroupIdAsync(System.Guid applicationGroupId);

        /// <summary>
        /// لیستی از دسترسی ها بر اساس آیدی ApplicationEntity
        /// </summary>
        /// <param name="applicationEntityId"></param>
        /// <returns></returns>
        System.Collections.Generic.List<Models.Permission> GetByApplicationEntityId(System.Guid applicationEntityId);

        /// <summary>
        /// لیستی از دسترسی ها بر اساس آیدی ApplicationEntity
        /// </summary>
        /// <param name="applicationEntityId"></param>
        /// <returns></returns>
        System.Threading.Tasks.Task<System.Collections.Generic.List<Models.Permission>> GetByApplicationEntityIdAsync(System.Guid applicationEntityId);
    }
}