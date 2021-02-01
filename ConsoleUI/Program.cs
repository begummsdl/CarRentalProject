using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();
            CarManager carManager = new CarManager(inMemoryCarDal);
            int stock = 0;
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("BrandId : {0}",car.BrandId);
                Console.WriteLine("ColorId : {0}", car.ColorId);
                Console.WriteLine("Model Year : {0}",car.ModelYear);
                Console.WriteLine("Daily Price : {0}", car.DailyPrice);
                Console.WriteLine("Description : {0}", car.Description);
                Console.WriteLine(" ");
                stock++;
            }
            Console.WriteLine("Stock quantity : {0}",stock);
            Console.WriteLine("----------------------------------");
            stock = 0;


            
            inMemoryCarDal.Add(new Car { Id = 6, BrandId = 4, ColorId = 4, ModelYear = 2011, DailyPrice = 444, Description = "Benzinli" });
            inMemoryCarDal.Update(new Car { Id = 6, BrandId = 4, ColorId = 4, ModelYear = 2011, DailyPrice = 444, Description = "Dizel" });
            inMemoryCarDal.Delete(new Car { Id = 3, BrandId = 2, ColorId = 2, ModelYear = 2020, DailyPrice = 450, Description = "Dizel" });
            inMemoryCarDal.Add(new Car { Id = 7, BrandId = 3, ColorId = 3, ModelYear = 2008, DailyPrice = 333, Description = "Benzinli" });

            Console.WriteLine("--------------NEW LİST--------------");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("BrandId : {0}", car.BrandId);
                Console.WriteLine("ColorId : {0}", car.ColorId);
                Console.WriteLine("Model Year : {0}", car.ModelYear);
                Console.WriteLine("Daily Price : {0}", car.DailyPrice);
                Console.WriteLine("Description : {0}", car.Description);
                Console.WriteLine(" ");
                stock++;
            }
            Console.WriteLine("Stock quantity : {0}", stock);
            Console.WriteLine("----------------------------------");
            stock = 0;

        }
    }
}
