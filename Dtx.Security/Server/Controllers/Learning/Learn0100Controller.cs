namespace Dtx.Security.Server.Controllers.Learning
{
	//public class Learn0100Controller : Microsoft.AspNetCore.Mvc.Controller

	[Microsoft.AspNetCore.Mvc.ApiController]
	[Microsoft.AspNetCore.Mvc.Route("learning/[controller]")]
	public class Learn0100Controller : Microsoft.AspNetCore.Mvc.ControllerBase
	{
		public Learn0100Controller() : base()
		{
		}

		public string Get()
		{
			return "Hello, World (1)!";
		}

		public string Post()
		{
			return "Hello, World (2)!";
		}
	}
}
