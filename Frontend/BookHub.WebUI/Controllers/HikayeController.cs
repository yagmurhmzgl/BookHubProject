using BookHub.WebUI.Models;
using BookHub.WebUI.Models.Hikaye;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace BookHub.WebUI.Controllers
{
    public class HikayeController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;
		public HikayeController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

        public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();//istemci oluştur
			var responseMessage = await client.GetAsync("https://localhost:44367/api/Hikaye");
			if(responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<HikayeViwModel>>(jsonData);
				return View(values);
			}
			return View();
		}

      
        [HttpGet]
		public IActionResult AddHikaye()
		{
			return View();
		}
		[HttpPost]
        public async Task<IActionResult> AddHikaye(AddHikayeViwModel model)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData=JsonConvert.SerializeObject(model);//biz bir data göndereceğiz ve bu data json a dönüşcek parametreden gelen değeri serelazie ettim
            StringContent stringcontent = new StringContent(jsonData, Encoding.UTF8,"aplication/json");
            var responseMessage = await client.PostAsync("https://localhost:7135/api/Hikaye", stringcontent);//Listelemek için post async kullqnıcaz
			if (responseMessage.IsSuccessStatusCode) //herhangi başarılı şekilde önerse
			{
				return RedirectToAction("Index");
			}
			return View();
        }
        public async Task<IActionResult> DeleteHikaye(int id)
		{
            var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.DeleteAsync($"https://localhost:7135/api/Hikaye/{id}");
            if (responseMessage.IsSuccessStatusCode) //herhangi başarılı şekilde önerse
            {
                return RedirectToAction("Index");
            }
            return View();
        }
		[HttpGet]
		public async Task<IActionResult>UpdateHikaye(int id)
		{
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7135/api/Hikaye/");
            if (responseMessage.IsSuccessStatusCode) //herhangi başarılı şekilde önerse
            {
               var jsonData = await responseMessage.Content.ReadAsStringAsync();
			   var values= JsonConvert.DeserializeObject<UpdateHikayeViwModel>(jsonData);
				return View(values);
            }
            return View();
        }
		[HttpPost]
		public async Task<IActionResult>UpdateHikaye(UpdateHikayeViwModel model )
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData=JsonConvert.SerializeObject(model);
			StringContent stringcontent = new StringContent(jsonData, Encoding.UTF8, "application/json");
		    var responseMessage = await client.PutAsync($"https://localhost:7135/api/Hikaye",stringcontent);//güncelleyeceğim verileri getirmek istiyorum
            if(responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
        }
    }
}
