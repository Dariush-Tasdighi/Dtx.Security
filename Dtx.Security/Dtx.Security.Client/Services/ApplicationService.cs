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

			response.EnsureSuccessStatusCode();

			if (response.IsSuccessStatusCode)
			{
				// New Solution
				Models.Application result =
					await response.Content.ReadFromJsonAsync<Models.Application>();

				return result;
				// /New Solution

				// Old Solution
				//string data =
				//	await response.Content.ReadAsStringAsync();

				//Models.Application result =
				//	System.Text.Json.JsonSerializer.Deserialize<Models.Application>(data);
				// /Old Solution
			}

			return null;


			//try
			//{
			//	return await response.Content.ReadFromJsonAsync<User>();
			//}
			//catch (NotSupportedException) // When content type is not valid
			//{
			//	Console.WriteLine("The content type is not supported.");
			//}
			//catch (JsonException) // Invalid JSON
			//{
			//	Console.WriteLine("Invalid JSON.");
			//}



			//var result =
			//	response.Content.ReadFromJsonAsync<Models.Application>().Result;

			//Models.Application result =
			//	await response.Content.ReadFromJsonAsync<Models.Application>();

			//System.Text.Json.JsonSerializerOptions jsonSerializerOptions =
			//	new System.Text.Json.JsonSerializerOptions
			//	{
			//		MaxDepth = 5,
			//	};

			//Models.Application result =
			//	await response.Content.ReadFromJsonAsync<Models.Application>(options: jsonSerializerOptions);


			return null;
			//return result;

			//try
			//{
			//	// HTTP POST
			//	var response = await client.PostAsJsonAsync(requestUri, postValues);
			//	response.EnsureSuccessStatusCode(); // Throw if not a success code.
			//	if (response.IsSuccessStatusCode)
			//	{
			//		var result = await response.Content.ReadAsStringAsync();
			//		Debug.WriteLine(result);
			//	}
			//}
			//catch (HttpRequestException e)
			//{
			//	// Handle exception.
			//	Debug.WriteLine(e.ToString());
			//	throw;
			//}
		}
	}
}
