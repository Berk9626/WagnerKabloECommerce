
using AutoMapper;
using ECommerce.DTOs.DTO.About;
using ECommerce.Entity;

namespace ECommerce.DTOs.Mapping
{
    public class AutoMapperConfig: Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<AboutDto, About>().ReverseMap();
           
        }
    }
}
