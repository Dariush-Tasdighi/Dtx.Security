namespace Dtx.Security.Client.Services
{
	public class ApplicationService : Infrastructure.BaseService
	{
		public ApplicationService(System.Net.Http.HttpClient client) : base(client)
		{
		}

		protected override string GetApiUrl()
		{
			return "applications";
		}

		public
			async
			System.Threading.Tasks.Task
			<System.Collections.Generic.IList<Models.Application>>
			GetAsync()
		{
			//var result =
			//	new System.Collections.Generic.List<Models.Application>();

			//await
			//System.Threading.Tasks.Task.Run(() =>
			//{
			//	for (int index = 1; index <= 10; index++)
			//	{
			//		var entity =
			//			new Models.Application
			//			{
			//				Name = $"Name { index }",
			//				IsActive = index % 2 == 0,
			//			};

			//		result.Add(entity);
			//	}
			//});

			//var result =
			//	await
			//	Http.GetFromJsonAsync
			//	<System.Collections.Generic.IList<Models.Application>>
			//	(requestUri: RequestUri);

			var result =
				await
				GetAsync
				<System.Collections.Generic.IList<Models.Application>>
				();

			return result;
		}

		public async
			System.Threading.Tasks.Task
			<Models.Application>
			PostAsync(ViewModels.Applications.CreateViewModel viewModel)
		{
			var result =
				await
				PostAsync
				<ViewModels.Applications.CreateViewModel, Models.Application>
				(viewModel);

			return result;
		}
	}
}
