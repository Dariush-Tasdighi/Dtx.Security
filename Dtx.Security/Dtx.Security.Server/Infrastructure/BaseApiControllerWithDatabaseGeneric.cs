namespace Infrastructure
{
	public class BaseApiControllerWithDatabaseGeneric<T> : BaseApiControllerWithDatabase where T : Models.Base.Entity
	{
		public BaseApiControllerWithDatabaseGeneric(Data.IUnitOfWork unitOfWork) : base(unitOfWork)
		{
		}

		[Microsoft.AspNetCore.Mvc.HttpGet]
		public virtual async System.Threading.Tasks.Task
			<Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.IEnumerable<T>>>
			GetAsync()
		{
			var result =
				await
				UnitOfWork.GetRepository<T>()
				.GetAllAsync()
				;

			return Ok(value: result);
		}

		[Microsoft.AspNetCore.Mvc.HttpGet(template: "{0}")]
		public virtual async System.Threading.Tasks.Task
			<Microsoft.AspNetCore.Mvc.ActionResult<T>>
			GetAsync(System.Guid id)
		{
			var foundedEntity =
				await
				UnitOfWork.GetRepository<T>()
				.GetByIdAsync(id);

			return Ok(value: foundedEntity);
		}

		[Microsoft.AspNetCore.Mvc.HttpPost]
		public virtual async System.Threading.Tasks.Task
			<Microsoft.AspNetCore.Mvc.ActionResult<T>>
			PostAsync(T entity)
		{
			await UnitOfWork.GetRepository<T>().InsertAsync(entity);

			await UnitOfWork.SaveAsync();

			return Ok(value: entity);
		}
	}
}
