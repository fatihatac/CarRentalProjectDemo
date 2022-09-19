using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        EfBrandDal _efBrandDal;

        public BrandManager(EfBrandDal efBrandDal)
        {
            _efBrandDal = efBrandDal;
        }

        public IResult Add(Brand brand)
        {
            _efBrandDal.Add(brand);
            return new SuccessResult();
        }

        public IResult Delete(Brand brand)
        {
            _efBrandDal.Delete(brand);
            return new SuccessResult();
        }

        public IDataResult<Brand> Get(int id)
        {
            return new SuccessDataResult<Brand>(_efBrandDal.GetById(b => b.BrandId == id));
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_efBrandDal.GetAll()) ;
        }

        public IResult Update(Brand brand)
        {
            _efBrandDal.Update(brand);
            return new SuccessResult();
        }
    }
}
