namespace Dtx.Security.Server.Controllers
{
	public class UsersController : Infrastructure.BaseApiControllerWithDatabase
	{
		public UsersController(Data.IUnitOfWork unitOfWork) : base(unitOfWork)
		{
		}

		[Microsoft.AspNetCore.Mvc.HttpGet("Login")]
		[Microsoft.AspNetCore.Cors.EnableCors(policyName: Startup.OTHERS_CORS_POLICY)]
		public
			async
			System.Threading.Tasks.Task
			<Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.IEnumerable<Models.Application>>>
			Login(ViewModels.Users.LoginViewModel viewModel)
		{
			var result =
				await UnitOfWork.ApplicationRepository.GetAllAsync();

			return Ok(value: result);
		}
	}
}
