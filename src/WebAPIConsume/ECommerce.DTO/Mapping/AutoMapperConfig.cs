using AutoMapper;
using ECommerce.Entity;
using ECommerce.WEBUI.DTOs.About;

namespace Portal.WEBUI.Mapping
{
    public class AutoMapperConfig: Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<AboutDto, About>().ReverseMap();
           
        }
    }
}
