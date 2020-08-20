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

        public async Task Add(Car car)
        {
            await _carsRepository.Add(_mapper.Map<Domain.Car>(car));
        }

        public async Task<Car> Get(int id)
        {
            return _mapper.Map<Car>(await _carsRepository.Get(id));
        }

        public async Task<List<Car>> GetAll()
        {
            var cars = await _carsRepository.GetAll();
            return _mapper.Map<List<Car>>(cars);

        }

        public async Task Remove(int id)
        {
            await _carsRepository.Remove(id);
        }

        public async Task Update(Car car)
        {
            await _carsRepository.Update(_mapper.Map<Domain.Car>(car));
        }
    }
}
