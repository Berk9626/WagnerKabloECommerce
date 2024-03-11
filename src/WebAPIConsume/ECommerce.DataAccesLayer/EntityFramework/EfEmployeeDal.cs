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
    public class EfEmployeeDal : GenericRepository<Employee>, IEmployeeDal
    {
        public EfEmployeeDal(Context context) : base(context)
        {
        }
    }
}
