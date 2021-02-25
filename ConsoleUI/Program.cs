using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetAllTest();
            GetCarDetailsTest();
        }

        private static void GetCarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Delete(new Car { Id = 4, BrandId = 3, ColorId = 2, ModelYear = 2020, DailyPrice = 500, Description = "Dizel" });
            //carManager.Add(new Car { BrandId = 2, ColorId = 3, DailyPrice = 398, ModelYear = 2020, Description = "Benzinli" });
            //carManager.Update(new Car { Id = 1, BrandId = 3, ColorId = 1, ModelYear = 2019, DailyPrice = 495, Description = "Benzinli" });
            var result = carManager.CarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetAllTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine("BrandId : {0}", car.BrandId);
                Console.WriteLine("ColorId : {0}", car.ColorId);
                Console.WriteLine("Model Year : {0}", car.ModelYear);
                Console.WriteLine("Daily Price : {0}", car.DailyPrice);
                Console.WriteLine("Description : {0}", car.Description);
                Console.WriteLine(" ");
            }
        }
    }
}
