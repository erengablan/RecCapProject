using Bussines.Abstrack;
using DataAcses.Abstrack;
using Entitiy.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Concreate
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager( ICarDal carDal)
        {
            _carDal = carDal;
        }
        public List<Car> GetAll(Car car)
        {
            return _carDal.GetAll(car);
        }
        
    }
}
