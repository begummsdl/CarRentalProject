using Core.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetCarsByBrandId(int id);
        IDataResult<Car> GetCarsByColorId(int id);
        IDataResult<List<CarDetailDto>> CarDetails();

        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
    }
}
