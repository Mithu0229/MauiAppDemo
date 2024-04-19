using MauiAppDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppDemo.Services
{
    public class CarService
    {
        public List<Car> GetCars()
        {
            return new List<Car>
            { new Car { Id = 1, Make = "123", Model = "dm01", Vin = "13" }, new Car { Id = 1, Make = "123", Model = "dm01", Vin = "13" }

            };
        }
    }
}

