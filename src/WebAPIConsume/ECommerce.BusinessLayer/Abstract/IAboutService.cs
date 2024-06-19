using ECommerce.BusinessLayer.DTOs.AboutDto;
using ECommerce.Entity;
using Portal.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BusinessLayer.Abstract
{
    public interface IAboutService 
    {
        List<ResultAboutDto> GetAll();
        void Add(CreateAboutDto aboutDto);
        void Update(UpdateAboutDto aboutDto);
        void Delete(int id);
        GetByIdAboutDto GetById(int id);
    }
}
