namespace Dtx.Security.Server.Controllers
{
    public class TestController : Infrastructure.BaseApiController
    {

		public TestController()
        {
		}

		[Microsoft.AspNetCore.Mvc.HttpGet]
		public
			async
			System.Threading.Tasks.Task
			<Microsoft.AspNetCore.Mvc.ActionResult<string>> StringTest()
		{
			var result = Models.Utility.GetRandomString(5, false, true, false, true, true);

			result += "==========" + Models.Utility.GetRandomString(5, true, true, true, true, false);

			return Ok(value: result);
		}
	}
}
