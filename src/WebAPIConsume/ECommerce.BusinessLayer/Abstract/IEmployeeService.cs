using ECommerce.BusinessLayer.DTOs.AboutDto;
using ECommerce.BusinessLayer.DTOs.EmployeeDto;
using ECommerce.Entity;
using Portal.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BusinessLayer.Abstract
{
    public interface IEmployeeService 
    {
        List<ResultEmployeeDto> GetAll();
        void Add(CreateEmployeeDto aboutDto);
        void Update(UpdateEmployeeDto aboutDto);
        void Delete(int id);
        GetByIdEmployeeDto GetById(int id);
    }
}
