using HandCloud.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandCloud.WebApp.Services
{
    public interface ICarServices
    {
        Task<Car> Get(int id);

        Task<List<Car>> GetAll();

        Task Add(Car car);

        Task Update(Car car);

        Task Remove(int id);
    }
}
