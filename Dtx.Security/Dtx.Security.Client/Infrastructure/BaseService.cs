using System.Net.Http.Json;

namespace Infrastructure
{
	public abstract class BaseService : object
	{
		public BaseService(System.Net.Http.HttpClient client) : base()
		{
			JsonOptions =
				new System.Text.Json.JsonSerializerOptions
				{
					PropertyNameCaseInsensitive = true,
				};

			Client = client;
			//Client.DefaultRequestHeaders

			BaseUrl = "http://localhost:5086";
			RequestUri = $"{ BaseUrl }/{ GetApiUrl() }";
		}

		protected abstract string GetApiUrl();

		protected string BaseUrl { get; set; }

		protected string RequestUri { get; set; }

		protected System.Net.Http.HttpClient Client { get; set; }

		protected System.Text.Json.JsonSerializerOptions JsonOptions { get; set; }
	}
}
