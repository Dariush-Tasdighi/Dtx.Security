using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Dtx.Security.Server
{
	public class Startup : object
	{
		public const string AdminCorsPolicy = "_ADMIN_CORS_POLICY";
		public const string OthersCorsPolicy = "_OTHERS_CORS_POLICY";

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddCors(options =>
			{
				options.AddPolicy(AdminCorsPolicy,
					builder =>
					{
						builder
							.WithOrigins("http://localhost:1202")
							.AllowAnyHeader()
							.AllowAnyMethod()
							//.AllowCredentials()
							;
					});

				options.AddPolicy(OthersCorsPolicy,
					builder =>
					{
						builder
							.AllowAnyOrigin()
							.AllowAnyHeader()
							.AllowAnyMethod()
							//.AllowCredentials()
							;
					});
			});

			services.AddControllers();

			services.AddDbContext<Data.DatabaseContext>(options =>
			{
				options.UseSqlServer
				(connectionString: "Password=1234512345;Persist Security Info=True;User ID=SA;Initial Catalog=DtxSecurity;Data Source=.");
			});
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			//if (env.IsDevelopment())
			//{
			//	app.UseDeveloperExceptionPage();
			//}
			//else
			//{
			//	app.UseExceptionHandler("/Error");
			//	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
			//	app.UseHsts();
			//}

			//app.UseHttpsRedirection();

			app.UseCors(policyName: AdminCorsPolicy);

			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
