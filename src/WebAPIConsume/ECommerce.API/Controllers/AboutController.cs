//using AutoMapper;
using ECommerce.BusinessLayer.Abstract;
using ECommerce.BusinessLayer.DTOs.AboutDto;
using ECommerce.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;
       // private readonly IMapper _mapper;



        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
          
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            try
            {
                var values = _aboutService.GetAll();


                return Ok(values);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            try
            {
                var model = _aboutService.GetById(id);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
       // ---------------------------------------------------------
        [HttpPost]
        public IActionResult AddAbout(CreateAboutDto createaboutdto)
        {
            try
            {
                _aboutService.Add(createaboutdto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        //---------------------------------------------------------
        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            try
            {
                _aboutService.Update(updateAboutDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
