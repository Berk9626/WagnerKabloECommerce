using AutoMapper;
using ECommerce.BusinessLayer.Abstract;
using ECommerce.BusinessLayer.DTOs.AboutDto;
using ECommerce.DataAccesLayer.Abstract;
using ECommerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;
        private readonly IMapper _mapper;

        public AboutManager(IAboutDal aboutDal, IMapper mapper)
        {
            _aboutDal = aboutDal;
            _mapper = mapper;
        }

        public void Add(CreateAboutDto aboutDto)
        {
            var aboutEntity = _mapper.Map<About>(aboutDto);
            _aboutDal.Insert(aboutEntity);
        }

        public void Delete(int id)
        {
            var aboutEntity = _aboutDal.GetById(id);

            // Veritabanından silme işlemi
            _aboutDal.Delete(aboutEntity);
        }

        public List<ResultAboutDto> GetAll()
        {
            var aboutEntities = _aboutDal.GetList();

            // Varlıkları DTO'lara dönüştürün
            var resultAboutDtos = _mapper.Map<List<ResultAboutDto>>(aboutEntities);

            return resultAboutDtos;
        }

        public GetByIdAboutDto GetById(int id)
        {
            var aboutEntity = _aboutDal.GetById(id);

            // Varlığı DTO'ya dönüştürün
            var getByIdAboutDto = _mapper.Map<GetByIdAboutDto>(aboutEntity);

            return getByIdAboutDto;
        }

        public void Update(UpdateAboutDto aboutDto)
        {
            var aboutEntity = _mapper.Map<About>(aboutDto);

            // Veritabanında güncelleme işlemi
            _aboutDal.Update(aboutEntity);
        }



        //public void TDelete(About t)
        //{
        //    _aboutDal.Delete(t);
        //}

        //public About TGetById(int id)
        //{
        //    return _aboutDal.GetById(id);
        //}

        //public List<About> TGetList()
        //{
        //   return _aboutDal.GetList();
        //}

        //public void TInsert(About t)
        //{
        //    _aboutDal.Insert(t);
        //}

        //public void TUpdate(About t)
        //{
        //    _aboutDal.Update(t);
        //}
    }
}
