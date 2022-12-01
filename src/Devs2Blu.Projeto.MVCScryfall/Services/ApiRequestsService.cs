using System.Net.Http;

namespace Devs2Blu.Projeto.MVCScryfall.Services
{
	public class ApiRequestsService
	{
		private readonly HttpClient _httpClient;

		public ApiRequestsService()
		{
			_httpClient = new HttpClient();
		}

		public async Task<T> Get<T>(string url)
		{
			var objHttp = await GetAsync(url);

			if (!objHttp.IsSuccessStatusCode)
				return (T)(object)url;

			return await objHttp.Content.ReadFromJsonAsync<T>();

		}

		public async Task<List<T>> GetList<T>(string url)
		{
			var listHttp = await GetAsync(url);

			if (!listHttp.IsSuccessStatusCode)
				return new List<T>();

			return await listHttp.Content.ReadFromJsonAsync<List<T>>();
		}

		public async Task<HttpResponseMessage> GetAsync(string url)
		{
			var getRequest = new HttpRequestMessage()
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri(url)
			};
			return await _httpClient.SendAsync(getRequest);
		}
	}
}
