using ECommerce.BusinessLayer.Abstract;
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

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Contact TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Contact t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}
