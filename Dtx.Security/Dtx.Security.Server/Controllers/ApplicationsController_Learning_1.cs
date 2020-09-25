//using System.Linq;
//using Microsoft.EntityFrameworkCore;

//namespace Dtx.Security.Server.Controllers
//{
//	//[Microsoft.AspNetCore.Mvc.Route("applications")]
//	[Microsoft.AspNetCore.Mvc.Route("[controller]")]
//	//[Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
//	//[Microsoft.AspNetCore.Mvc.Route("api/applications")]
//	//[Microsoft.AspNetCore.Mvc.Route("crm/[controller]")]
//	//[Microsoft.AspNetCore.Mvc.Route(RouterConstants.Crm + "/[controller]")]
//	//public class ApplicationsController : Microsoft.AspNetCore.Mvc.Controller
//	//public class ApplicationsController : Microsoft.AspNetCore.Mvc.ControllerBase
//	public class ApplicationsController : Infrastructure.BaseApiControllerWithDatabase
//	{
//		public ApplicationsController(Data.DatabaseContext databaseContext) : base(databaseContext)
//		{
//		}

//		//[Microsoft.AspNetCore.Mvc.HttpGet]
//		//public System.Collections.Generic.IEnumerable<Models.Application>
//		//	Get()
//		//{
//		//	var result =
//		//		MyDatabaseContext.Applications
//		//		.ToList()
//		//		;

//		//	return result;
//		//}

//		//[Microsoft.AspNetCore.Mvc.HttpGet]
//		//public Microsoft.AspNetCore.Mvc.IActionResult
//		//	Get()
//		//{
//		//	var result =
//		//		MyDatabaseContext.Applications
//		//		.ToList()
//		//		;

//		//	return Ok(value: result);
//		//}

//		//[Microsoft.AspNetCore.Mvc.HttpGet]
//		//public Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.IEnumerable<Models.Application>>
//		//	Get()
//		//{
//		//	var result =
//		//		MyDatabaseContext.Applications
//		//		.ToList()
//		//		;

//		//	//return Ok(value: result);
//		//	// Compile OK - Runtime Error!
//		//	return Ok(value: new Models.User());
//		//}

//		[Microsoft.AspNetCore.Mvc.HttpGet]
//		public
//			async
//			System.Threading.Tasks.Task
//			<Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.IEnumerable<Models.Application>>>
//			GetAsync()
//		{
//			//var result =
//			//	MyDatabaseContext.Applications
//			//	.ToListAsync().Result
//			//	;

//			var result =
//				await MyDatabaseContext.Applications
//				.ToListAsync()
//				;

//			return Ok(value: result);
//		}

//		[Microsoft.AspNetCore.Mvc.HttpGet(template: "{0}")]
//		public async System.Threading.Tasks.Task
//			<Microsoft.AspNetCore.Mvc.ActionResult<Models.Application>>
//			GetAsync(System.Guid id)
//		{
//			var foundedEntity =
//				await MyDatabaseContext.Applications
//				.Where(current => current.Id == id)
//				.FirstOrDefaultAsync();

//			return Ok(value: foundedEntity);
//		}

//		[Microsoft.AspNetCore.Mvc.HttpPost]
//		public async System.Threading.Tasks.Task
//			<Microsoft.AspNetCore.Mvc.ActionResult<Models.Application>>
//			PostAsync(ViewModels.Applications.CreateViewModel viewModel)
//		{
//			var newEntity =
//				new Models.Application
//				{
//					Name = viewModel.Name,
//					Title = viewModel.Title,
//					IsActive = viewModel.IsActive,
//					Description = viewModel.Description,
//					IsIPRestricted = viewModel.IsIPRestricted,
//					IsUrlRestricted = viewModel.IsUrlRestricted,

//					//IsVerified = true,
//					//VerifierUserId = ...,
//					//VerifyDateTime = Models.Utility.Now,
//				};

//			await MyDatabaseContext.Applications.AddAsync(newEntity);

//			await MyDatabaseContext.SaveChangesAsync();

//			return Ok(value: newEntity);
//		}
//	}
//}
