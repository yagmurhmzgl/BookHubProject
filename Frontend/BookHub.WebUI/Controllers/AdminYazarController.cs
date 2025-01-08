using BookHub.WebUI.Dtos.AdmYazarDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace BookHub.WebUI.Controllers
{
	public class AdminYazarController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;
		public AdminYazarController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:44367/api/Yazar");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultAdmYazarDto>>(jsonData);
				return View(values);
			}
			return View();
		}




		[HttpGet]
		public async Task<IActionResult> UpdateYazar(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"https://localhost:44367/api/Yazar/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<UpdateAdmYazarDto>(jsonData);
				return View(values);
			}
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> UpdateYazar(UpdateAdmYazarDto updateAdmYazarDto)
		{

			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(updateAdmYazarDto);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PutAsync("https://localhost:44367/api/Yazar/UpdateAdmYazarDto/", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
		public async Task<IActionResult> DeleteYazar(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.DeleteAsync($"https://localhost:44367/api/Yazar/{id}");
			if (responseMessage.IsSuccessStatusCode) //herhangi başarılı şekilde önerse
			{
				return RedirectToAction("Index");
			}
			var errorContent = await responseMessage.Content.ReadAsStringAsync();
			return View();
		}
	}
}
