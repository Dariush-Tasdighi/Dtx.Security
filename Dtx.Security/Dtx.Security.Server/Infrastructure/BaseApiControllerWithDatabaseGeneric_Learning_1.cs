//using System.Linq;
//using Microsoft.EntityFrameworkCore;

//namespace Infrastructure
//{
//	public class BaseApiControllerWithDatabaseGeneric<T> : BaseApiControllerWithDatabase where T : Models.Base.Entity
//	{
//		public BaseApiControllerWithDatabaseGeneric(Data.DatabaseContext databaseContext) : base(databaseContext)
//		{
//		}

//		[Microsoft.AspNetCore.Mvc.HttpGet]
//		public virtual async System.Threading.Tasks.Task
//			<Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.IEnumerable<T>>>
//			GetAsync()
//		{
//			var result =
//				await MyDatabaseContext.Set<T>()
//				.ToListAsync()
//				;

//			return Ok(value: result);
//		}

//		[Microsoft.AspNetCore.Mvc.HttpGet(template: "{0}")]
//		public virtual async System.Threading.Tasks.Task
//			<Microsoft.AspNetCore.Mvc.ActionResult<T>>
//			GetAsync(System.Guid id)
//		{
//			var foundedEntity =
//				await MyDatabaseContext.Set<T>()
//				.Where(current => current.Id == id)
//				.FirstOrDefaultAsync();

//			return Ok(value: foundedEntity);
//		}

//		[Microsoft.AspNetCore.Mvc.HttpPost]
//		public virtual async System.Threading.Tasks.Task
//			<Microsoft.AspNetCore.Mvc.ActionResult<T>>
//			PostAsync(T entity)
//		{
//			await MyDatabaseContext.AddAsync<T>(entity);

//			await MyDatabaseContext.SaveChangesAsync();

//			return Ok(value: entity);
//		}
//	}
//}
