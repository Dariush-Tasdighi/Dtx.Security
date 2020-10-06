namespace Dtx.Security.Server.Controllers
{
	public class ApplicationsController : Infrastructure.BaseApiControllerWithDatabase
	{
		public ApplicationsController(Data.IUnitOfWork unitOfWork) : base(unitOfWork)
		{
		}

		[Microsoft.AspNetCore.Mvc.HttpGet]
		public
			async
			System.Threading.Tasks.Task
			<Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.IEnumerable<Models.Application>>>
			GetAsync()
		{
			System.Threading.Thread.Sleep(2000);

			var result =
				await UnitOfWork.ApplicationRepository.GetAllAsync();

			return Ok(value: result);
		}

		//[Microsoft.AspNetCore.Mvc.HttpGet(template: "{0}")]
		//public
		//	async
		//	System.Threading.Tasks.Task
		//	<Microsoft.AspNetCore.Mvc.ActionResult<Models.Application>>
		//	GetAsync(System.Guid id)
		//{
		//	var foundedEntity =
		//		await UnitOfWork.ApplicationRepository.GetByIdAsync(id);

		//	return Ok(value: foundedEntity);
		//}

		[Microsoft.AspNetCore.Mvc.HttpGet(template: "{0}")]
		public
			async
			System.Threading.Tasks.Task
			<Microsoft.AspNetCore.Mvc.ActionResult<Result<Models.Application>>>
			GetAsync(System.Guid id)
		{
			Result<Models.Application> result = new Result<Models.Application>();

			var foundedEntity =
				await UnitOfWork.ApplicationRepository.GetByIdAsync(id);

			if (foundedEntity == null)
			{
				result.Data = null;
				result.IsSuccessful = false;

				result.AddErrorMessage
					("اطلاعاتی با این مشخصه یافت نشد!");
			}
			else
			{
				if (foundedEntity.IsActive == false)
				{
					result.Data = null;
					result.IsSuccessful = false;

					result.AddErrorMessage
						("دسترسی به این اطلاعات مقدور نمی‌باشد!");
				}
				else
				{
					result.Data = foundedEntity;
					result.IsSuccessful = true;
				}
			}

			return Ok(value: result);
		}

		[Microsoft.AspNetCore.Mvc.HttpPost]
		public
			async
			System.Threading.Tasks.Task
			<Microsoft.AspNetCore.Mvc.ActionResult<Models.Application>>
			PostAsync(ViewModels.Applications.CreateViewModel viewModel)
		{
			var newEntity =
				new Models.Application
				{
					Name = viewModel.Name,
					Title = viewModel.Title,
					IsActive = viewModel.IsActive,
					Description = viewModel.Description,
					IsIPRestricted = viewModel.IsIPRestricted,
					IsUrlRestricted = viewModel.IsUrlRestricted,

					//IsVerified = true,
					//VerifierUserId = ...,
					//VerifyDateTime = Models.Utility.Now,
				};

			await UnitOfWork.ApplicationRepository.InsertAsync(newEntity);

			await UnitOfWork.SaveAsync();

			return Ok(value: newEntity);
		}
	}
}
