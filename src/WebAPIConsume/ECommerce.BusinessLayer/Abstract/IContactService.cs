using ECommerce.BusinessLayer.DTOs.AboutDto;
using ECommerce.BusinessLayer.DTOs.ContactDto;
using ECommerce.Entity;
using Portal.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BusinessLayer.Abstract
{
    public interface IContactService 
    {
        List<ResultContactDto> GetAll();
        void Add(CreateContactDto contactDto);
        void Update(UpdateContactDto contactDto);
        void Delete(int id);
        GetByIdContactDto GetById(int id);
    }
}
