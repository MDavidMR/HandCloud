using HandCloud.Repository.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HandCloud.Domain;

namespace HandCloud.Repository
{
    public class CarsRepository : ICarsRepository
    {
        private IJsonHelper _jsonHelper;

        public CarsRepository(IJsonHelper jsonHelper)
        {
            _jsonHelper = jsonHelper;
        }

        public void Add(Car car)
        {
            var carList = _jsonHelper.GetData<Car>();
            if (carList == null)
                carList = new List<Car>();

            carList.Add(car);

            _jsonHelper.SaveData(carList);
        }

        public Car Get(int id)
        {
            var carList = _jsonHelper.GetData<Car>();
            return carList.Where(i => i.Id.Equals(id)).FirstOrDefault();
        }

        public List<Car> GetAll()
        {
            return _jsonHelper.GetData<Car>();
        }

        public void Remove(int id)
        {
            var carList = _jsonHelper.GetData<Car>();
            
            if (carList == null)
                return;

            var car = carList.Where(i => i.Id.Equals(id)).FirstOrDefault();
            carList.Remove(car);
            _jsonHelper.SaveData(carList);
        }

        public void Update(Car car)
        {
            
        }
    }
}
