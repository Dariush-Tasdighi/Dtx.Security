using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Dtx.Security.Server
{
	public static class Program
	{
		static Program()
		{
		}

		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

		//public static Microsoft.Extensions.Hosting.IHostBuilder CreateHostBuilder(string[] args) =>
		//	Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder(args)
		//		.ConfigureWebHostDefaults(webBuilder =>
		//		{
		//			webBuilder.UseStartup<Startup>();
		//		});

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args).ConfigureLogging(logging =>
			{
				// using Microsoft.Extensions.Logging;
				logging.ClearProviders();

				// using Microsoft.Extensions.Logging;
				logging.AddConsole();

				//logging.AddFile("Logs/mylog-{Date}.txt");
			})
			.ConfigureWebHostDefaults(webBuilder =>
			{
				webBuilder.UseStartup<Startup>();
			});
	}
}
