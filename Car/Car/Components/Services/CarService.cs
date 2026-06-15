using Car.Models;
using Microsoft.EntityFrameworkCore;

namespace Car.Services
{
    public class CarService
    {
        public List<Car.Models.Car> GetCars()
        {
            using (var _db = new AutoContext())
            {
                try
                {
                    return _db.mps.ToList();
                }
                catch
                {
                    return new List<Car.Models.Car>();
                }
            }
        }

        public void AddCar(Car.Models.Car car)
        {
            using (var _db = new AutoContext())
            {
                if (car != null)
                {
                    _db.mps.Add(car);
                    _db.SaveChanges();
                }
            }
        }

        public void DeleteCar(Car.Models.Car car)
        {
            using (var _db = new AutoContext())
            {
                if (car != null)
                {
                    _db.mps.Remove(car);
                    _db.SaveChanges();
                }
            }
        }

        public void ClearAll()
        {
            using (var _db = new AutoContext())
            {
                var all = _db.mps.ToList();
                if (all.Count > 0)
                {
                    _db.mps.RemoveRange(all);
                    _db.SaveChanges();
                }
            }
        }
    }
}