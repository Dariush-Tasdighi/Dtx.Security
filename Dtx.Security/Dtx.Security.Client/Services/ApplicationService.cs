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
			<System.Collections.Generic.IList<Models.Application>> GetAsync()
		{
			var response =
				await Client.GetFromJsonAsync
				<System.Collections.Generic.IList<Models.Application>>
				(requestUri: RequestUri);

			//response.EnsureSuccessStatusCode();

			//using var responseStream = await response.Content.ReadAsStreamAsync();
			//return await JsonSerializer.DeserializeAsync<TodoDto>(responseStream, _jsonOptions);

			return response;
		}
	}
}
