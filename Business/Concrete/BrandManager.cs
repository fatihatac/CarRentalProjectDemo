using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager:IBrandService
    {
        EfBrandDal _efBrandDal;

        public BrandManager(EfBrandDal efBrandDal)
        {
            _efBrandDal = efBrandDal;
        }

        public void Add(Brand brand)
        {
            _efBrandDal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _efBrandDal.Delete(brand);
        }

        public Brand Get(int id)
        {
            return _efBrandDal.GetById(b=>b.BrandId==id);
        }

        public List<Brand> GetAll()
        {
            return _efBrandDal.GetAll();
        }

        public void Update(Brand brand)
        {
            _efBrandDal.Update(brand);
        }
    }
}
