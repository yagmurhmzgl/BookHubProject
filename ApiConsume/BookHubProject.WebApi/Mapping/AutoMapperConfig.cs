using AutoMapper;
using BookHub.DtoLayer.Dtos.HikayeDto;
using BookHub.EntityLayer.Concrete;

namespace BookHub.WebApi.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<HikayeAddDto, Hikaye>();
            CreateMap<Hikaye,HikayeAddDto>();
            CreateMap<UpdateHikayeDto,Hikaye>().ReverseMap();

            
        }
    }
}
