using System.Net.Http.Json;

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

		public async System.Threading.Tasks.Task
			<System.Collections.Generic.IList<Models.Application>>
			GetAsync()
		{
			var result =
				await Client.GetFromJsonAsync
				<System.Collections.Generic.IList<Models.Application>>
				(requestUri: RequestUri);

			return result;
		}

		public async System.Threading.Tasks.Task
			<Models.Application>
			PostAsync(ViewModels.Applications.CreateViewModel viewModel)
		{
			var response =
				await Client.PostAsJsonAsync
				(requestUri: RequestUri, value: viewModel);

			//var result =
			//	response.Content.ReadFromJsonAsync<Models.Application>().Result;

			Models.Application result =
				await response.Content.ReadFromJsonAsync<Models.Application>();

			return result;
		}
	}
}
