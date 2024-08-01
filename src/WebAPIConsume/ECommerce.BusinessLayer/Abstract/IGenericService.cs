using ECommerce.BusinessLayer.DTOs.EmployeeDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        List<T> GetAll();
        void Add(T t);
        void Update(T t);
        void Delete(int id);
        T GetById(int id);

    }
}
