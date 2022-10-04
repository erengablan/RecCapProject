using DataAcses.Abstrack;
using Entitiy.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAcses.Concreate
{
    public class InMemoryCarDal : ICarDal
    {
        // GetById, GetAll, Add, Update, Delete
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice="25500",ModelYear="2015",Description="sedan"},
                new Car{Id=2,BrandId=2,ColorId=2,DailyPrice="32000",ModelYear="2019",Description="hatcback" }
            };
        }
        public void Add(Car car)
        {
            new Car { };
        }

        public void Delete(Car car)
        {
            Car cartoDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(cartoDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {

            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
           Car cartoupdate=_cars.SingleOrDefault(c=> c.Id == car.Id);
            cartoupdate.ModelYear = car.ModelYear;
            cartoupdate.Description = car.Description;
            cartoupdate.ColorId = car.ColorId;
            cartoupdate.BrandId = car.BrandId;
        }
    }
}
