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
		public Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.IEnumerable<Models.Application>> Get()
		{
			var result =
				MyDatabaseContext.Applications
				.ToList()
				;

			return Ok(value: result);
		}

		//[Microsoft.AspNetCore.Mvc.HttpGet("{0}")]
		//public Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.IEnumerable<Models.Application>> Get(long id)
		//{
		//	var result =
		//		MyDatabaseContext.Applications
		//		.ToList()
		//		;

		//	return Ok(value: result);
		//}

		[Microsoft.AspNetCore.Mvc.HttpPost]
		public Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.IEnumerable<Models.Application>> Post(ViewModels.Applications.CreateViewModel viewModel)
		{
			Models.Application application =
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

			MyDatabaseContext.Applications.Add(application);

			MyDatabaseContext.SaveChangesAsync();

			return Ok(value: application);
		}
	}
}
