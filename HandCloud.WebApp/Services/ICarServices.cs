using HandCloud.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandCloud.WebApp.Services
{
    public interface ICarServices
    {
        Car Get(int id);

        List<Car> GetAll();

        void Add(Car car);

        void Update(Car car);

        void Remove(int id);
    }
}
