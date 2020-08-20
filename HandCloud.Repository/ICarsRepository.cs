using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HandCloud.Domain;

namespace HandCloud.Repository
{
    public interface ICarsRepository
    {
        Task<Car> Get(int id);

        Task<List<Car>> GetAll();

        Task Add(Car car);

        Task Update(Car car);

        Task Remove(int id);

    }
}
