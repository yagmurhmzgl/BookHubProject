using AutoMapper;
using BookHub.BussinessLayer.Abstract;
using BookHub.DtoLayer.Dtos.HikayeDto;
using BookHub.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Text;

namespace BookHub.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Hikaye2Controller : ControllerBase
    {
        private readonly IHikayeService _hikayeService;
        private readonly IMapper _mapper;
        public Hikaye2Controller(IHikayeService hikayeService, IMapper mapper)
        {
            _hikayeService = hikayeService;
            _mapper = mapper;
        }
        [HttpGet]
        public  IActionResult Index()
        {
            var values = _hikayeService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddHikaye(HikayeAddDto hikayeAddDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Hikaye>(hikayeAddDto);
            _hikayeService.TInsert(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateHikaye(UpdateHikayeDto updateHikayeDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Hikaye>(updateHikayeDto);
            _hikayeService.TUpdate(values);
            return Ok("Başarıyla Güncellendi");
        }
    }
}
