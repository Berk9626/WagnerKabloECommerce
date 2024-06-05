//using AutoMapper;
using ECommerce.BusinessLayer.Abstract;

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



        public AboutController(IAboutService aboutService /*IMapper mapper*/)
        {
            _aboutService = aboutService;
            //_mapper = mapper;
        }

        //[HttpGet]
        //public IActionResult AboutList()
        //{
        //    try
        //    {
        //        var values = _aboutService.TGetList();
        //       _mapper.Map<AboutDto>(values);
           
        //        return Ok(values);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex);
        //    }
        //}
        //---------------------------------------------------------
        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            try
            {
                var model = _aboutService.TGetById(id);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        //---------------------------------------------------------
        [HttpPost]
        public IActionResult AddAbout(About About)
        {
            try
            {
                _aboutService.TInsert(About);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        //---------------------------------------------------------
        [HttpPut]
        public IActionResult UpdateAbout(About About)
        {
            try
            {
                _aboutService.TUpdate(About);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
