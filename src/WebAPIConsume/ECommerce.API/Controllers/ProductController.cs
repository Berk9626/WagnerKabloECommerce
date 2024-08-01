using ECommerce.BusinessLayer.Abstract;
using ECommerce.BusinessLayer.DTOs.ProductDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _ProductService;
        // private readonly IMapper _mapper;



        public ProductController(IProductService ProductService)
        {
            _ProductService = ProductService;

        }

        [HttpGet]
        public IActionResult ProductList()
        {
            try
            {
                var values = _ProductService.GetAll();


                return Ok(values);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            try
            {
                var model = _ProductService.GetById(id);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        // ---------------------------------------------------------
        [HttpPost]
        public IActionResult AddProduct(CreateProductDto createProductdto)
        {
            try
            {
                _ProductService.Add(createProductdto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        //---------------------------------------------------------
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            try
            {
                _ProductService.Update(updateProductDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
