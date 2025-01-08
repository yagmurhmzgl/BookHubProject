using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;
using System.Net.Http.Headers;

namespace RapidApiConsume.Controllers
{
	public class KitapController : Controller
	{
		public async Task<IActionResult> Index()
		{
			List<ApiKitapViewModel> apiKitapViewModels = new List<ApiKitapViewModel>();
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://all-books-api.p.rapidapi.com/getBooks"),
				Headers =
	{
		{ "x-rapidapi-key", "0a99faa161mshe1103a2dc158074p102c89jsndc07b51a75a0" },
		{ "x-rapidapi-host", "all-books-api.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				apiKitapViewModels=JsonConvert.DeserializeObject<List<ApiKitapViewModel>>(body);
				return View(apiKitapViewModels);
			}
			
		}
	}
}
