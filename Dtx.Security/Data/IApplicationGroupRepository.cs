using Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Data
{
	public interface IApplicationGroupRepository
	{
		/// <summary>
		/// رکورددهای فعال 
		/// </summary>
		/// <returns></returns>
		Task<List<ApplicationGroup>> GetAciveAsync();

		/// <summary>
		/// رکورددهای فعال 
		/// </summary>
		/// <returns></returns>
		IList<ApplicationGroup> GetActive();

		/// <summary>
		/// دریافت ApplicationGroup با شناسه 
		/// applicationId
		/// </summary>
		/// <param name="applicationId"></param>
		/// <returns></returns>
		ApplicationGroup GetByApplicationId(Guid applicationId);

		/// <summary>
		/// دریافت ApplicationGroup با شناسه 
		/// applicationId
		/// </summary>
		/// <param name="applicationId"></param>
		/// <returns></returns>
		Task<ApplicationGroup> GetByApplicationIdAsync(Guid applicationId);

		/// <summary>
		/// جستجو بر اساس نام 
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		ApplicationGroup GetByName(string name);

		/// <summary>
		/// جستجو بر اساس نام 
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		Task<ApplicationGroup> GetByNameAsync(string name);

		/// <summary>
		/// دریافت لیست اعضا
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		IList<Membership> GetMemberships(Guid id);

		/// <summary>
		/// دریافت لیست اعضا
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		Task<IList<Membership>> GetMembershipsAsync(Guid id);

		/// دریافت لیست Permission
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		IList<Permission> GetPermissions(Guid id);

		/// <summary>
		/// دریافت لیست Permission
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		Task<IList<Permission>> GetPermissionsAsync(Guid id);
	}
}