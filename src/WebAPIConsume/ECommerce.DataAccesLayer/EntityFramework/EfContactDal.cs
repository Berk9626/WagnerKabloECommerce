using ECommerce.DataAccesLayer.Abstract;
using ECommerce.DataAccesLayer.Concrete;
using ECommerce.Entity;
using Portal.DataAccessLayer.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccesLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public EfContactDal(Context context) : base(context)
        {
        }
    }
}
