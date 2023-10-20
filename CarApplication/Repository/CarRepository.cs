using CarApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication.Repository
{
    public class CarRepository : ICarRepository
    {
        static List<Car> cars = new List<Car>
            {
                new Car { Id = 1, Make = "BMW", Color = "red", Petname = "Dog" },
                new Car { Id = 2, Make = "BMW", Color = "green", Petname = "Dog" },
                new Car { Id = 3, Make = "BMW", Color = "blue", Petname = "Dog" }
            };
        public CarRepository() { }
        public List<Car> GetAll()
        {
            return cars;
        }
        public Car GetById(int id)
        {
            return cars.FirstOrDefault(c => c.Id == id);
        }

        public void AddCar(Car car)
        {
            // Set Car Id = maxId + 1
            car.Id = cars.Any() ? cars.Max(c => c.Id) + 1 : 1;

            // Add Car
            cars.Add(car);
        }

        public void UpdateCar(Car car)
        {
            if (car == null)
                throw new ArgumentNullException(nameof(car), "Update car cannot be null.");
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Id == car.Id)
                {
                    cars[i].Make = car.Make;
                    cars[i].Color = car.Color;
                    cars[i].Petname = car.Petname;
                }
            }
        }

        public void DeleteCar(Car car)
        {
            if (car == null)
                throw new ArgumentNullException(nameof(car), "Delete car cannot be null.");
            List<Car> newCars = new List<Car>();
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Id != car.Id)
                {
                    newCars.Add(cars[i]);
                }
            }
            cars = newCars;
        }

        
    }
}
