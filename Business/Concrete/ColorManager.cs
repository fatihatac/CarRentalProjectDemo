using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        EfColorDal _efColorDal;

        public ColorManager(EfColorDal efColorDal)
        {
            _efColorDal = efColorDal;
        }

        public IResult Add(Color color)
        {
            _efColorDal.Add(color);
            return new SuccessResult();
        }

        public IResult Delete(Color color)
        {
            _efColorDal?.Delete(color);
            return new SuccessResult();
        }

        public IDataResult<Color> Get(int id)
        {
            return new SuccessDataResult<Color>(_efColorDal.GetById(c => c.ColorId == id));
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_efColorDal.GetAll());
        }

        public IResult Update(Color color)
        {
            _efColorDal.Update(color);
            return new SuccessResult();
        }
    }
}
