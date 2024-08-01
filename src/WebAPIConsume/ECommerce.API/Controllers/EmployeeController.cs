using ECommerce.BusinessLayer.Abstract;
using ECommerce.BusinessLayer.DTOs.EmployeeDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _EmployeeService;
        // private readonly IMapper _mapper;



        public EmployeeController(IEmployeeService EmployeeService)
        {
            _EmployeeService = EmployeeService;

        }

        [HttpGet]
        public IActionResult EmployeeList()
        {
            try
            {
                var values = _EmployeeService.GetAll();


                return Ok(values);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            try
            {
                var model = _EmployeeService.GetById(id);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        // ---------------------------------------------------------
        [HttpPost]
        public IActionResult AddEmployee(CreateEmployeeDto createEmployeedto)
        {
            try
            {
                _EmployeeService.Add(createEmployeedto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        //---------------------------------------------------------
        [HttpPut]
        public IActionResult UpdateEmployee(UpdateEmployeeDto updateEmployeeDto)
        {
            try
            {
                _EmployeeService.Update(updateEmployeeDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
