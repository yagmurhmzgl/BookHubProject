using BookHub.BussinessLayer.Abstract;
using BookHub.DataAccesLayer.Abstract;
using BookHub.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookHub.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KategoriController : ControllerBase
    {
        private readonly IKategoriService _kategoriService;
        public KategoriController(IKategoriService kategoriService)
        {
            _kategoriService = kategoriService;
        }

        [HttpGet]
        public IActionResult KategoriList()
        {
            var values = _kategoriService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddKategori(Kategori kategori)
        {
            _kategoriService.TInsert(kategori);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteKategori(int id)
        {
           var values= _kategoriService.TGetByID(id);
           _kategoriService.TDelete(values);
           return Ok();
        }

        [HttpPut]
        public IActionResult UpdateKategori(Kategori kategori)
        {
           _kategoriService.TUpdate(kategori);
            return Ok();
        }

        [HttpGet("id")]
        public IActionResult GetKategori(int id)
        {
            var values = _kategoriService.TGetByID(id);
            return Ok();
        }
    }
}
