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
           
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
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
