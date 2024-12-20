using BookHub.BussinessLayer.Abstract;
using BookHub.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookHub.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BultenController : ControllerBase
	{

		private readonly IBultenService _bultenService;
		public BultenController(IBultenService bultenService)
		{
			_bultenService = bultenService;
		}

		[HttpGet]
		public IActionResult GettAllHikayeler()
		{
			var hikayeler = _bultenService.TGetList();
			return Ok(hikayeler);
		}
		[HttpPost]
		public IActionResult AddBulten(Bulten bulten)
		{
			_bultenService.TInsert(bulten);
			return Ok();
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteBulten(int id)
		{
			var values = _bultenService.TGetByID(id);
			_bultenService.TDelete(values);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateBulten(Bulten bulten)
		{
			_bultenService.TUpdate(bulten);
			return Ok();
		}
		[HttpGet("id")]
		public IActionResult GetBulten(int id)
		{
			var values = _bultenService.TGetByID(id);
			return Ok(values);
		}

	}
}

