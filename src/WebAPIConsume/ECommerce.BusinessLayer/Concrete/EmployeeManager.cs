using AutoMapper;
using ECommerce.BusinessLayer.Abstract;
using ECommerce.BusinessLayer.DTOs.AboutDto;
using ECommerce.BusinessLayer.DTOs.EmployeeDto;
using ECommerce.DataAccesLayer.Abstract;
using ECommerce.DataAccesLayer.EntityFramework;
using ECommerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BusinessLayer.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeDal _employeeDal;
        private readonly IMapper _mapper;
        public EmployeeManager(IEmployeeDal employeeDal, IMapper mapper)
        {
            _employeeDal = employeeDal;
            _mapper = mapper;
        }
        public void Add(CreateEmployeeDto aboutDto)
        {
            var aboutEntity = _mapper.Map<Employee>(aboutDto);
            _employeeDal.Insert(aboutEntity);
        }

        public void Delete(int id)
        {
            var employeeEntity = _employeeDal.GetById(id);
            _employeeDal.Delete(employeeEntity);

        }

        public List<ResultEmployeeDto> GetAll()
        {
            var employeeEntities = _employeeDal.GetList();

            // Varlıkları DTO'lara dönüştürün
            var employeeDtos = _mapper.Map<List<ResultEmployeeDto>>(employeeEntities);
            return employeeDtos;
        }

        public GetByIdEmployeeDto GetById(int id)
        {
            var employee = _employeeDal.GetById(id);
            var employeeDto = _mapper.Map<GetByIdEmployeeDto>(employee);
            return employeeDto;
        }

        public void Update(UpdateEmployeeDto employeeDto)
        {
            var employeeEntity = _mapper.Map<Employee>(employeeDto);

            // Veritabanında güncelleme işlemi
            _employeeDal.Update(employeeEntity);
        }
    }
}
