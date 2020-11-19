using Models;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Data
{
	public interface IApplicationEntityRepository
	{
		/// <summary>
		/// دریافت لیست رکوردهای فعال 
		/// </summary>
		/// <returns></returns>
		List<ApplicationEntity> GetActive();

		/// <summary>
		/// دریافت لیست رکوردهای فعال 
		/// </summary>
		/// <returns></returns>
		Task<List<ApplicationEntity>> GetActiveAsync();

		/// <summary>
		/// جیتجو بر اساس سطح دسترسی 
		/// </summary>
		/// <param name="accessType"></param>
		/// <returns></returns>
		List<ApplicationEntity> GetByAccessType(AccessType accessType);

		/// <summary>
		/// جستجو بر اساس نوع 
		/// </summary>
		/// <param name="entityType"></param>
		/// <returns></returns>
		List<ApplicationEntity> GetByApplicationEntityType(ApplicationEntityType entityType);

		/// <summary>
		/// جستجو بر اساس نام 
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		ApplicationEntity GetByName(string name);

		/// <summary>
		/// جستجو بر اساس نام 
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		Task<ApplicationEntity> GetByNameAsync(string name);

		/// <summary>
		/// دریافت لیست CheckPermissionLog
		/// بنا به ApplicationEntity
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		IList<CheckPermissionLog> GetCheckPermissionLogList(Guid id);

		/// <summary>
		/// دریافت لیست CheckPermissionLog
		/// بنا به ApplicationEntity
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		Task<IList<CheckPermissionLog>> GetCheckPermissionLogListAsync(Guid id);

		/// <summary>
		/// دریافت لیست رکوردهای همگام سازی شده 
		/// </summary>
		/// <returns></returns>
		List<ApplicationEntity> GetIsSynced();

		/// <summary>
		/// دریافت لیست رکوردهای همگام سازی شده 
		/// </summary>
		/// <returns></returns>
		Task<List<ApplicationEntity>> GetIsSyncedAsync();

		/// <summary>
		/// دریافت لیست دسترسی ها
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		IList<Permission> GetPermissionList(Guid id);

		/// <summary>
		/// دریافت لیست دسترسی ها
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		Task<IList<Permission>> GetPermissionListAsync(Guid id);
	}
}