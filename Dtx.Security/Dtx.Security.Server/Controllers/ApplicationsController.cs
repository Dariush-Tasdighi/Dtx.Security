using System.Linq;

namespace Dtx.Security.Server.Controllers
{
	[Microsoft.AspNetCore.Mvc.Route("[controller]")]
	public class ApplicationsController : Infrastructure.BaseApiControllerWithDatabase
	{
		public ApplicationsController(Data.DatabaseContext databaseContext) : base(databaseContext)
		{
		}

		[Microsoft.AspNetCore.Mvc.HttpGet]
		public Microsoft.AspNetCore.Mvc.ActionResult
			<System.Collections.Generic.IEnumerable<Models.Application>> Get()
		{
			var result =
				MyDatabaseContext.Applications
				.ToList()
				;

			return Ok(value: result);
		}

		[Microsoft.AspNetCore.Mvc.HttpGet("{0}")]
		public Microsoft.AspNetCore.Mvc.ActionResult<Models.Application> Get(System.Guid id)
		{
			var foundedEntity =
				MyDatabaseContext.Applications
				.Where(current => current.Id == id)
				.FirstOrDefault();

			return Ok(value: foundedEntity);
		}

		[Microsoft.AspNetCore.Mvc.HttpPost]
		public Microsoft.AspNetCore.Mvc.ActionResult
			<Models.Application> Post(ViewModels.Applications.CreateViewModel viewModel)
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

			MyDatabaseContext.Applications.Add(newEntity);

			MyDatabaseContext.SaveChangesAsync();

			return Ok(value: newEntity);
		}
	}
}
