using Application.Commands;
using Application.Queries;
using Domain.Entities;
using Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using WebCar.Models;

namespace WebCar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediator;

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        public async Task<ActionResult> Index()
        {
            var res = new Domain.Entities.CarBrand()
            {
                Name = "BMW",
                Description = "BMW",
                LogoUrl = ""
            };

            var carModel = new CreateCarBrandCommand(res);
             await _mediator.Send(carModel);




            var listDataView = new ListDataView();
            await PopulateDropdownsAsync(listDataView);
            return View(listDataView);
        }

        private async Task PopulateDropdownsAsync(ListDataView listDataView)
        {
            var getAllCarBrandQuery = new GetAllCarBrandQuery();
            var getAllCarModelQuery = new GetAllCarModelQuery();
            var getAllTireTypeQuery = new GetAllTireTypeQuery();

            var carBrands = await _mediator.Send(getAllCarBrandQuery);
            var carModels = await _mediator.Send(getAllCarModelQuery);
            var tireTypes = await _mediator.Send(getAllTireTypeQuery);

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