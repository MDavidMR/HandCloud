using AutoMapper;
using HandCloud.Repository;
using HandCloud.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandCloud.WebApp.Services
{
    public class CarServices : ICarServices
    {
        ICarsRepository _carsRepository;
        IMapper _mapper;

        public CarServices(ICarsRepository carsRepository, IMapper mapper)
        {
            _carsRepository = carsRepository;
            _mapper = mapper;
        }

        public void Add(Car car)
        {
            _carsRepository.Add(_mapper.Map<Domain.Car>(car));
        }

        public Car Get(int id)
        {
            return _mapper.Map<Car>(_carsRepository.Get(id));
        }

        public List<Car> GetAll()
        {
            var cars = _carsRepository.GetAll();
            return _mapper.Map<List<Car>>(cars);

        }

        public void Remove(int id)
        {
            _carsRepository.Remove(id);
        }

        public void Update(Car car)
        {
            _carsRepository.Update(_mapper.Map<Domain.Car>(car));
        }
    }
}
