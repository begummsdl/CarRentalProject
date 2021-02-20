using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=3, ModelYear=2001, DailyPrice=300, Description="Benzinli"},
                new Car{Id=2, BrandId=1, ColorId=2, ModelYear=2012, DailyPrice=400, Description="Dizel"},
                new Car{Id=3, BrandId=2, ColorId=2, ModelYear=2020, DailyPrice=450, Description="Dizel"},
                new Car{Id=4, BrandId=2, ColorId=1, ModelYear=2019, DailyPrice=350, Description="Dizel"},
                new Car{Id=5, BrandId=3, ColorId=3, ModelYear=2010, DailyPrice=320, Description="Benzinli"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //Id yalnızca 1 tane olabileceğinden SingleOrDefault kullandım. First veya FirstOfDefault da kullanılabilirdi.
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            //Gönderdiğim arabayla aynı id'ye sahip olan listedeki arabayı bul.
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            //Güncelleme işlemleri
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
