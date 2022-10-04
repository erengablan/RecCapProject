using Entitiy.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Abstrack
{
    public interface ICarService
    {
        List<Car> GetAll(Car car);
    }
}
