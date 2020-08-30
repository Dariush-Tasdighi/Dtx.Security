using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

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

		public static Microsoft.Extensions.Hosting.IHostBuilder CreateHostBuilder(string[] args) =>
			Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				});
	}
}
