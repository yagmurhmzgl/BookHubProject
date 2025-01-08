using AutoMapper;
using BookHub.EntityLayer.Concrete;
using BookHub.WebUI.Dtos.AdmYazarDto;
using BookHub.WebUI.Dtos.BultenDto;
using BookHub.WebUI.Dtos.CategoryDto;
using BookHub.WebUI.Dtos.LoginDto;
using BookHub.WebUI.Dtos.RegisterDto;
using BookHub.WebUI.Dtos.ResultDto;
using BookHub.WebUI.Models.Hikaye;
using BookHub.WebUI.Models.Yazar;
using Microsoft.PowerBI.Api.Models;
using AppUser = BookHub.EntityLayer.Concrete.AppUser;


namespace BookHub.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig() 
        {

            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();
            CreateMap<ResultCategoryDto, Kategori>().ReverseMap();
            CreateMap<CreateBultenDto, Bulten>().ReverseMap();
			CreateMap<ResultCategoryDto, HikayeListCategoryViewModel>();
            CreateMap<ResultAdmYazarDto, Yazar>().ReverseMap();
            CreateMap<UpdateAdmYazarDto, Yazar>().ReverseMap();
            CreateMap<CreateAdmYazarDto, Yazar>().ReverseMap();
            

		}




    }
}
