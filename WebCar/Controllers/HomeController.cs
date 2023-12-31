﻿using Application.Services.Implementations;
using Application.Services.Interfaces;
using Domain.Entities;
using Domain.Enums;
using Infrastructure.Database.Repositories;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using System.Net.Http.Headers;
using WebCar.Models;

namespace WebCar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //  private readonly ICarModelService _carModelService;
        private readonly ICarBrandService _carBrandService;
        private readonly ITireService _tireService;
        CarRepository carRepository = new CarRepository("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=webcar-app-sqldb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public HomeController(ILogger<HomeController> logger, ICarBrandService carBrandService, ITireService tireService)
        {
            _logger = logger;
            //    _carModelService = carModelService;
            _carBrandService = carBrandService;
            _tireService = tireService;
        }

        public async Task<ActionResult> Index()
        {

            var listDataView = new ListDataView();
            await PopulateDropdownsAsync(listDataView);
            return View(listDataView);
        }

        [HttpPost()]
        public async Task<ActionResult> CarDetails(ListDataView model)
        {
            var result = await carRepository.GetByIdAsync(model.SelectedCarModelId);
            return View(result);
        }

        [HttpGet]
        public async Task<JsonResult> GetCarModelsByBrand(int carBrandId)
        {

            var result = await carRepository.GetAllByBrandIdAsync(carBrandId);
            return Json(result);

        }

        [HttpGet]
        public async Task<ActionResult> GetTireSizesByCarModel(int carModelId)
        {
            var result = await _tireService.GetByCarModelIdAsync(carModelId);

            return Json(result);
        }
        private async Task PopulateDropdownsAsync(ListDataView listDataView)
        {
            var carModels = await carRepository.GetAllCarModels();
            var carBrands = await carRepository.GetAllCarBrands();
            var tireSizes = await carRepository.GetAllTireSizes();

            listDataView.CarBrands = carBrands.Select(brand => new SelectListItem
            {
                Text = brand.Name,
                Value = brand.Id.ToString()
            }).ToList();


            listDataView.CarModels = carModels.Select(model => new SelectListItem
            {
                Text = model.Name,
                Value = model.Id.ToString()
            }).ToList();

            listDataView.TireSize = tireSizes.Select(model => new SelectListItem
            {
                Text = model.Diameter.ToString(),
                Value = model.Id.ToString()
            }).ToList();

            listDataView.TireType = Enum.GetValues(typeof(TireType))
                                                   .Cast<TireType>()
                                                   .Select(tt => new SelectListItem
                                                   {
                                                       Text = tt.ToString(),
                                                       Value = tt.ToString()
                                                   })
                                                   .ToList();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}