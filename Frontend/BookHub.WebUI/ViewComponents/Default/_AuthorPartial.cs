using BookHub.WebUI.Dtos.ResultDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Drawing.Text;

namespace BookHub.WebUI.ViewComponents.Default
{
	public class _AuthorPartial : ViewComponent
	{

		private readonly IHttpClientFactory _httpClientFactory;
		public _AuthorPartial(IHttpClientFactory httpClientFactory)
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
				var values = JsonConvert.DeserializeObject<List<ResultHikayeDto>>(jsonData);
				return View(values);
			}
			return View();


		}
	}
}
