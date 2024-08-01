using ECommerce.BusinessLayer.Abstract;
using ECommerce.BusinessLayer.DTOs.ContactDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _ContactService;
        // private readonly IMapper _mapper;



        public ContactController(IContactService ContactService)
        {
            _ContactService = ContactService;

        }

        [HttpGet]
        public IActionResult ContactList()
        {
            try
            {
                var values = _ContactService.GetAll();


                return Ok(values);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            try
            {
                var model = _ContactService.GetById(id);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        // ---------------------------------------------------------
        [HttpPost]
        public IActionResult AddContact(CreateContactDto createContactdto)
        {
            try
            {
                _ContactService.Add(createContactdto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        //---------------------------------------------------------
        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            try
            {
                _ContactService.Update(updateContactDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
