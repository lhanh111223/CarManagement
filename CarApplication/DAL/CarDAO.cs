using CarApplication.Model;
using CarApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication.DAL
{
    public class CarDAO
    {
        private CarRepository _carRepository;
        public CarDAO()
        {
            _carRepository = new CarRepository();
        }
        public List<Car> GetAllCars()
        {
            return _carRepository.GetAll();
        }
        public Car GetCarById(int id)
        {
            return _carRepository.GetById(id);
        }
        public void AddCar(Car car)
        {
            _carRepository.AddCar(car);
        }
        public void UpdateCar(Car car)
        {
            _carRepository.UpdateCar(car);  
        }
        public void DeleteCar(Car car)
        {
            _carRepository.DeleteCar(car);
        }
    }
}
