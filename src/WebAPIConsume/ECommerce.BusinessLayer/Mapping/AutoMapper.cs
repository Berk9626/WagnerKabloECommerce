
using AutoMapper;
using ECommerce.BusinessLayer.DTOs.AboutDto;
using ECommerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BusinessLayer.Mapping
{
    public class AutoMapper: Profile
    {
        public AutoMapper()
        {
            CreateMap<About, CreateAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, GetByIdAboutDto>().ReverseMap();
        }
    }
}
