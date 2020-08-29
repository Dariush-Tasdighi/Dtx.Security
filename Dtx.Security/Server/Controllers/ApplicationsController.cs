using Microsoft.AspNetCore.Mvc;

namespace Dtx.Security.Server.Controllers
{
	[Microsoft.AspNetCore.Mvc.ApiController]
	[Route("[controller]")]
	public class ApplicationsController : Microsoft.AspNetCore.Mvc.ControllerBase
	{
		[Microsoft.AspNetCore.Mvc.HttpGet]
		public string Get()
		{
			return "Hello, World!";
		}
	}
}
