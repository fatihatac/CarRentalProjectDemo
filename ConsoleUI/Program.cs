using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICarService carService = new CarManager(new EfCarDal());

            //carService.Add(new Car {BrandId=6,ColorId=5,DailyPrice=350,ModelYear=2022,Description="jip araba " });


            //Console.WriteLine(carService.GetById(2).Description);
            //Console.WriteLine(carService.GetCarsByBrandId(2));

            //foreach (var car in carService.GetCarsByBrandId(2))
            //{
            //    Console.WriteLine(car.Description);
            //}

            //foreach (var car in carService.GetCarsByColorId(2))
            //{
            //    Console.WriteLine(car.Description);
            //}

            foreach (var car in carService.GetAll())
            {
                Console.WriteLine(car.Description);
            }



        }
    }
}
