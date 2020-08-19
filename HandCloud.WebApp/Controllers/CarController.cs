using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using HandCloud.Repository;
using Microsoft.Extensions.Logging;
using HandCloud.WebApp.Models;
using HandCloud.WebApp.Services;

namespace HandCloud.WebApp.Controllers
{

    public class CarController : Controller
    {
        private readonly ILogger<CarController> _logger;
        private readonly ICarServices _carServices;
        //ICarsRepository _carsRepository;


        public CarController(ICarServices carServices, ILogger<CarController> logger)
        {
            _carServices = carServices;
            //_carsRepository = carsRepository;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var cars = _carServices.GetAll();
            return View(cars);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Car car)
        {
            _carServices.Add(car);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPut]
        public IActionResult Edit(Car car)
        {
            _carServices.Update(car);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }

        [HttpDelete]
        public IActionResult Delete(Car car)
        {
            _carServices.Remove(car.Id);
            return RedirectToAction("Index");
        }

    }
}
