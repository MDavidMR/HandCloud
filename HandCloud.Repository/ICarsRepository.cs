using System;
using System.Collections.Generic;
using System.Text;
using HandCloud.Domain;

namespace HandCloud.Repository
{
    public interface ICarsRepository
    {
        Car Get(int id);
        
        List<Car> GetAll();

        void Add(Car car);

        void Update(Car car);

        void Remove(int id);
        
    }
}
