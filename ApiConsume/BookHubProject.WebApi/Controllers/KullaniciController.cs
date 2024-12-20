using BookHub.BussinessLayer.Abstract;
using BookHub.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookHub.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KullaniciController : ControllerBase
    {
        public readonly IKullaniciService _kullaniciService;
        public KullaniciController(IKullaniciService kullaniciService)
        {
            _kullaniciService = kullaniciService;
        }

        [HttpGet]
        public IActionResult KullaniciList()
        {
            var values = _kullaniciService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddKullanici(Kullanici kullanici)
        {
            _kullaniciService.TInsert(kullanici);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteKullanici(int id)
        {
            var values = _kullaniciService.TGetByID(id);
            _kullaniciService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateKullanici(Kullanici kullanici)
        {
            _kullaniciService.TUpdate(kullanici);
            return Ok();
        }
        [HttpGet("id")]
        public IActionResult GetKullanici(int id)
        {
            var values = _kullaniciService.TGetByID(id);
            return Ok(values);
        }
    }
}
