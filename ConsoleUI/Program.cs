using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Linq;
using System.Net.WebSockets;
using System.Threading;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICarService carService = new CarManager(new EfCarDal());
            IColorService colorService = new ColorManager(new EfColorDal());
            IBrandService brandService = new BrandManager(new EfBrandDal());
            ICustomerService customerService = new CustomerManager(new EfCustomerDal());
            IRentalService rentalService = new RentalManager(new EfRentalDal());


            //var result =  brandService.Add(new Brand { BrandName = "Toyota" });

            //Console.WriteLine(result.Message);


            //GetRentalDetails(brandService, rentalService);

            //CustomerAdd(customerService);
            //CustomerUpdate(customerService);

            RentalAdd(rentalService);

            //CarAdd(carService);
            //CarDelete(carService);
            //CarUpdate(carService);
            //GetAll(carService);
            //GetCarsByBrandId(carService);
            //GetCarById(carService);

            //ColorAdd(colorService);
            //ColorUpdate(colorService);
            //ColorDelete(colorService);
            //GetColor(colorService);
            //GetAllColors(colorService);

            //AddBrand(brandService);
            //UpdateBrand(brandService);
            //BrandDelete(brandService);
            //GetBrand(brandService);
            //GetAllBrands(brandService);

            //var result = carService.GetCarDetails();
            //if (result.Success==true)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine(car.BrandName);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}



        }

        private static void GetRentalDetails(IBrandService brandService, IRentalService rentalService)
        {
            var result = rentalService.GetRentalDetails();

            foreach (var rentalDetail in result.Data)
            {
                Console.WriteLine("Kullanıcı Bilgileri : İsim :{0} ,{1} Email : {2}   ", rentalDetail.FirstName, rentalDetail.LastName, rentalDetail.Email);
                Console.WriteLine("Araba bilgileri : Marka : {0}, Renk : {1}, Günlük fiyat : {2}, Özellik : {3}, Model yılı :  {4} ", rentalDetail.BrandName, rentalDetail.ColorName, rentalDetail.DailyPrice, rentalDetail.Description, rentalDetail.ModelYear);
                Console.WriteLine("Kiralandığı tarih :  {0} ", rentalDetail.RentDate);
                Console.WriteLine("----------------------------------------------------------------------------------");
            }

        }

        private static void CustomerUpdate(ICustomerService customerService)
        {
            customerService.Update(new Customer { Id = 3, CompanyName = "Akdoğan Company" });
        }

        private static void CustomerAdd(ICustomerService customerService)
        {
            customerService.Add(new Customer { UserId = 7, CompanyName = "Çatal A.Ş." });
        }

        private static void RentalAdd(IRentalService rentalService)
        {
            var result = rentalService.Add(new Rental { CarId = 5, CustomerId = 2, RentDate = DateTime.Now });

            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetAllBrands(IBrandService brandService)
        {
            foreach (var brand in brandService.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void GetBrand(IBrandService brandService)
        {
            Console.WriteLine((brandService.Get(1)).Data.BrandName);
        }

        private static void BrandDelete(IBrandService brandService)
        {
            brandService.Delete(new Brand { Id = 1016 });
        }

        private static void UpdateBrand(IBrandService brandService)
        {
            brandService.Update(new Brand { Id = 1016, BrandName = "Kartal" });
        }

        private static void AddBrand(IBrandService brandService)
        {
            brandService.Add(new Brand { BrandName = "Serçe" });
        }

        private static void GetAllColors(IColorService colorService)
        {
            foreach (var color in colorService.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void GetColor(IColorService colorService)
        {
            Console.WriteLine((colorService.Get(1)).Data.ColorName);
        }

        private static void ColorDelete(IColorService colorService)
        {
            colorService.Delete(new Color { Id = 1002 });
        }

        private static void ColorUpdate(IColorService colorService)
        {
            colorService.Update(new Color { Id = 1002, ColorName = "Morcivert" });
        }

        private static void ColorAdd(IColorService colorService)
        {
            colorService.Add(new Color { ColorName = "Mercan" });
        }

        private static void GetCarById(ICarService carService)
        {
            Console.WriteLine((carService.GetById(1)).Data.Description);
        }

        private static void GetAll(ICarService carService)
        {
            foreach (var car in carService.GetAll().Data)
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void GetCarsByBrandId(ICarService carService)
        {
            foreach (var car in carService.GetCarsByBrandId(20).Data)
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void CarUpdate(ICarService carService)
        {
            carService.Update(new Car { Id = 11, BrandId = 19, ColorId = 5, DailyPrice = 500, Description = "spor araba 2 ", ModelYear = 2007 });
        }

        private static void CarDelete(ICarService carService)
        {
            carService.Delete(new Car { Id = 1008 });
        }

        private static void CarAdd(ICarService carService)
        {
            carService.Add(new Car { BrandId = 18, ColorId = 4, DailyPrice = 600, ModelYear = 2003, Description = "spor araba" });
        }
    }
}
