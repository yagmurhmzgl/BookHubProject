using BookHub.BussinessLayer.Abstract;
using BookHub.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Runtime.ConstrainedExecution;


namespace BookHub.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HikayeController : ControllerBase
    {
        private readonly IHikayeService _hikayeService;

		public HikayeController(IHikayeService hikayeService)
        {
            _hikayeService = hikayeService;
        }

		[HttpGet]
        public IActionResult GettAllHikayeler()
        {
            var hikayeler = _hikayeService.TGetList();
            return Ok(hikayeler);
        }
        [HttpPost]
        public IActionResult AddHikaye(Hikaye hikaye)
        {
            _hikayeService.TInsert(hikaye);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteHikaye(int id)
        {
            var values = _hikayeService.TGetByID(id);
            _hikayeService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateHikaye(Hikaye hikaye)
        {
            _hikayeService.TUpdate(hikaye);
            return Ok();
        }
        [HttpGet("id")]
        public IActionResult GetHikaye(int id)
        {
            var values = _hikayeService.TGetByID(id);
            return Ok(values);
        }
		[HttpGet("HikayeListesiKategori/{kategoriId}")]
		public IActionResult HikayeListesiKategori(int kategoriId)
		{
			var hikayeler = _hikayeService.GetHikayelerByKategori(kategoriId);
			return Ok(hikayeler);
		}
		

	}
}
