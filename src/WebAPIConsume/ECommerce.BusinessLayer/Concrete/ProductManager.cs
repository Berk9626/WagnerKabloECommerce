using AutoMapper;
using ECommerce.BusinessLayer.Abstract;
using ECommerce.BusinessLayer.DTOs.EmployeeDto;
using ECommerce.BusinessLayer.DTOs.ProductDto;
using ECommerce.DataAccesLayer.Abstract;
using ECommerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        private readonly IMapper _mapper;
        public ProductManager(IProductDal productDal, IMapper mapper)
        {
            _productDal = productDal;
            _mapper = mapper;
        }
        public void Add(CreateProductDto createproductdto)
        {
            var addedproduct = _mapper.Map<Product>(createproductdto);
            _productDal.Insert(addedproduct);
        }

        public void Delete(int id)
        {
            var deletedproduct = _productDal.GetById(id);
            _productDal.Delete(deletedproduct);
        }

        public List<ResultProductDto> GetAll()
        {
            var productDto = _productDal.GetList();
            var productDto2 = _mapper.Map<List<ResultProductDto>>(productDto);
            return productDto2;

        }

        public GetByIdProductDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(UpdateProductDto updateproductdto)
        {
            throw new NotImplementedException();
        }
    }
}
