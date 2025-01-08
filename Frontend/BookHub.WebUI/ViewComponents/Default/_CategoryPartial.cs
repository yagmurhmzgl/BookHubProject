using BookHub.WebUI.Dtos.CategoryDto;
using BookHub.WebUI.Dtos.ResultDto;
using BookHub.WebUI.Models.Hikaye;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BookHub.WebUI.ViewComponents.Default
{
	public class _CategoryPartial:ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;
		public _CategoryPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();//istemci oluştur
			var responseMessage = await client.GetAsync("https://localhost:44367/api/Hikaye");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<HikayeListCategoryViewModel>>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}
