using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Linq;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICarService carService = new CarManager(new EfCarDal());
            IColorService colorService = new ColorManager(new EfColorDal());
            IBrandService brandService = new BrandManager(new EfBrandDal());




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

            brandService.Add(new Brand { BrandName="land rover"});


        }

        private static void GetAllBrands(IBrandService brandService)
        {
            foreach (var brand in brandService.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void GetBrand(IBrandService brandService)
        {
            Console.WriteLine((brandService.Get(1)).BrandName);
        }

        private static void BrandDelete(IBrandService brandService)
        {
            brandService.Delete(new Brand { BrandId = 1016 });
        }

        private static void UpdateBrand(IBrandService brandService)
        {
            brandService.Update(new Brand { BrandId = 1016, BrandName = "Kartal" });
        }

        private static void AddBrand(IBrandService brandService)
        {
            brandService.Add(new Brand { BrandName = "Serçe" });
        }

        private static void GetAllColors(IColorService colorService)
        {
            foreach (var color in colorService.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void GetColor(IColorService colorService)
        {
            Console.WriteLine((colorService.Get(1)).ColorName);
        }

        private static void ColorDelete(IColorService colorService)
        {
            colorService.Delete(new Color { ColorId = 1002 });
        }

        private static void ColorUpdate(IColorService colorService)
        {
            colorService.Update(new Color { ColorId = 1002, ColorName = "Morcivert" });
        }

        private static void ColorAdd(IColorService colorService)
        {
            colorService.Add(new Color { ColorName = "Mercan" });
        }

        private static void GetCarById(ICarService carService)
        {
            Console.WriteLine((carService.GetById(1)).Description);
        }

        private static void GetAll(ICarService carService)
        {
            foreach (var car in carService.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void GetCarsByBrandId(ICarService carService)
        {
            foreach (var car in carService.GetCarsByBrandId(20))
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void CarUpdate(ICarService carService)
        {
            carService.Update(new Car { CarId = 11, BrandId = 19, ColorId = 5, DailyPrice = 500, Description = "spor araba 2 ", ModelYear = 2007 });
        }

        private static void CarDelete(ICarService carService)
        {
            carService.Delete(new Car { CarId = 1008 });
        }

        private static void CarAdd(ICarService carService)
        {
            carService.Add(new Car { BrandId = 18, ColorId = 4, DailyPrice = 600, ModelYear = 2003, Description = "spor araba" });
        }
    }
}
