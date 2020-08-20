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
using Newtonsoft.Json;
using Microsoft.AspNetCore.Routing;
using System.Text.RegularExpressions;
using System.Net;

namespace HandCloud.WebApp.Controllers
{

    public class CarController : Controller
    {
        private readonly ILogger<CarController> _logger;
        private readonly ICarServices _carServices;


        public CarController(ICarServices carServices, ILogger<CarController> logger)
        {
            _carServices = carServices;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("cars/getcars")]
        public async Task<JsonResult> GetCars()
        {
            var cars = await _carServices.GetAll();
            return Json(cars);
        }

        [HttpGet]
        [Route("cars/getcar")]
        public async Task<JsonResult> GetCar(int id)
        {
            var car = await _carServices.Get(id);
            return Json(car);
        }



        [HttpGet]
        public IActionResult Modal()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("cars/add")]
        public async Task<IActionResult> Add(Car car)
        {

            try
            {

                if (!ModelState.IsValid)
                    return StatusCode((int)HttpStatusCode.BadRequest);

                await _carServices.Add(car);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var car = await _carServices.Get(id);

            return View(car);
        }

        [HttpPost]
        [Route("cars/update")]
        public async Task<IActionResult> Update(Car car)
        {
            try
            {
                if (!ModelState.IsValid)
                    return StatusCode((int)HttpStatusCode.BadRequest);

                await _carServices.Update(car);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }


        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var car = await _carServices.Get(id);
            return View(car);
        }

        [HttpPost]
        [Route("cars/remove")]
        public async Task<IActionResult> Remove(int id)
        {
            try
            {
                await _carServices.Remove(id);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }

        }

    }
}
