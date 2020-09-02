using Microsoft.Extensions.DependencyInjection;

namespace Dtx.Security.Client
{
	public static class Program
	{
		static Program()
		{
		}

		public static async System.Threading.Tasks.Task Main(string[] args)
		{
			var builder =
				Microsoft.AspNetCore.Components.WebAssembly
				.Hosting.WebAssemblyHostBuilder.CreateDefault(args);

			builder.RootComponents.Add<App>("app");

			builder.Services.AddScoped
				(sp => new System.Net.Http.HttpClient
				{
					BaseAddress = new System.Uri(builder.HostEnvironment.BaseAddress)
				});

			builder.Services.AddTransient<Services.ApplicationService>();

			await builder.Build().RunAsync();
		}
	}
}
