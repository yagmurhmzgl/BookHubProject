﻿
using BookHub.WebUI.Dtos.HikayeListKategoriDto;
using BookHub.WebUI.Dtos.ResultDto;
using BookHub.WebUI.Models.Hikaye;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BookHub.WebUI.Controllers
{
	public class KategoriController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;
		public KategoriController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();//istemci oluştur
			var responseMessage = await client.GetAsync("https://localhost:44367/api/Hikaye");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();

				var values = JsonConvert.DeserializeObject<List<ResultHikayeListKategoriDto>>(jsonData);

				return View(values);
			}
			return View();
		}
	}
}
