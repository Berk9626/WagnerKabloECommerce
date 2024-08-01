using AutoMapper;
using ECommerce.BusinessLayer.Abstract;
using ECommerce.BusinessLayer.DTOs.ContactDto;
using ECommerce.BusinessLayer.DTOs.ProductDto;
using ECommerce.DataAccesLayer.Abstract;
using ECommerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;
        private readonly IMapper _mapper;
        public ContactManager(IContactDal contactDal, IMapper mapper)
        {
            _contactDal = contactDal;
            _mapper = mapper;
        }
        public void Add(CreateContactDto contactdto)
        {
            var addedcont = _mapper.Map<Contact>(contactdto);
            _contactDal.Insert(addedcont);
        }

        public void Delete(int id)
        {
            var deletedcontact = _contactDal.GetById(id);
            _contactDal.Delete(deletedcontact);
        }

        public List<ResultContactDto> GetAll()
        {
            var contactDto = _contactDal.GetList();
            var contactdto2 = _mapper.Map<List<ResultContactDto>>(contactDto);
            return contactdto2;

        }

        public GetByIdContactDto GetById(int id)
        {
            var contact = _contactDal.GetById(id);
            var contactDto = _mapper.Map<GetByIdContactDto>(contact);
            return contactDto;
        }

        public void Update(UpdateContactDto updatecontactdto)
        {
            var contactent = _mapper.Map<Contact>(updatecontactdto);

            // Veritabanında güncelleme işlemi
            _contactDal.Update(contactent);
        }
    }
}
