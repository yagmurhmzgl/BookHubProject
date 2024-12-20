using BookHub.WebUI.Dtos.BultenDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace BookHub.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory= httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult _BultenPartial()
        {
            return PartialView();
        }
       [HttpPost]
		public async Task<IActionResult> _BultenPartial(CreateBultenDto createBultenDto)
        {
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(createBultenDto);
			StringContent stringcontent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			await client.PutAsync($"https://localhost:7135/api/Bulten", stringcontent);//güncelleyeceğim verileri getirmek istiyorum
		    return RedirectToAction("Index","Default");
			
		}
    }
}
