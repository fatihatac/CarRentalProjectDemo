using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICarService carService = new CarManager(new InMemoryCar());

            //foreach (var car in carService.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}

            Console.WriteLine(carService.GetById(1).Description);

            carService.Add(new Entities.Concrete.Car { Description="Spor Araba Kırmız"});
            foreach (var car in carService.GetAll())
            {
                Console.WriteLine(car.Description);
            }

        }
    }
}
