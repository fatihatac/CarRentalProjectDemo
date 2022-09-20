using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCar : ICarDal
    {
        List<Car> _cars; 

        public InMemoryCar()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=200,Description="Sarı Ford",ModelYear=2000},
                new Car{Id=2,BrandId=2,ColorId=2,DailyPrice=500,Description="Siyah Mustang",ModelYear=2012},
                new Car{Id=3,BrandId=3,ColorId=3,DailyPrice=400,Description="Beyaz Tosbağa",ModelYear=2020},
                new Car{Id=4,BrandId=4,ColorId=1,DailyPrice=600,Description="Yeşil Nissan",ModelYear=2008},
                new Car{Id=5,BrandId=5,ColorId=1,DailyPrice=1000,Description="Kırmızı Ferrari",ModelYear=2005},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var carToDelete = _cars.SingleOrDefault(p=>p.Id == car.Id);
            _cars.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            return _cars.Find(p => p.Id == id);
            
            
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            var carToUpdate = _cars.SingleOrDefault(p=>p.Id == car.Id);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
        }
    }
}
