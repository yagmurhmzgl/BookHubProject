using BookHub.BussinessLayer.Abstract;
using BookHub.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookHub.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class YazarController : ControllerBase
	{
		private readonly IYazarService _yazarService;
		public YazarController(IYazarService yazarService)
		{
			_yazarService = yazarService;
		}

		[HttpGet]
		public IActionResult GettAllYazarlar()
		{
			var yazarlar = _yazarService.TGetList();
			return Ok(yazarlar);
		}
		[HttpPost]
		public IActionResult AddYazar(Yazar yazar)
		{
			_yazarService.TInsert(yazar);
			return Ok();
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteYazar(int id)
		{
			var values = _yazarService.TGetByID(id);
			_yazarService.TDelete(values);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateYazar(Yazar yazar)
		{
			_yazarService.TUpdate(yazar);
			return Ok();
		}
		[HttpGet("id")]
		public IActionResult GetYazar(int id)
		{
			var values = _yazarService.TGetByID(id);
			return Ok(values);
		}

	}
}

