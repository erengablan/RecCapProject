using Entitiy.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcses.Abstrack
{
    public interface ICarDal
    {
        // GetById, GetAll, Add, Update, Delete
        List<Car> GetAll(Car car);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<Car> GetById(int Id);
        
    }
}
