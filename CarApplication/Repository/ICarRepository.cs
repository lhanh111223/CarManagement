using CarApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication.Repository
{
    public interface ICarRepository
    {
        List<Car> GetAll();
        Car GetById(int id);
        void AddCar(Car car);
        void UpdateCar(Car car);
        void DeleteCar(Car car);
    }
}
