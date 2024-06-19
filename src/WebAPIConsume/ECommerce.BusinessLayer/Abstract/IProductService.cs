using ECommerce.BusinessLayer.DTOs.AboutDto;
using ECommerce.BusinessLayer.DTOs.ProductDto;
using ECommerce.Entity;
using Portal.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BusinessLayer.Abstract
{
    public interface IProductService 
    {
        List<ResultProductDto> GetAll();
        void Add(CreateProductDto createproductdto);
        void Update(UpdateProductDto updateproductdto);
        void Delete(int id);
        GetByIdProductDto GetById(int id);
    }
}
