using Microsoft.AspNetCore.Mvc;
using ServiceStation.Web.Models;

namespace ServiceStation.Web.Controllers
{
    public class ServicesController : Controller
    {
        [ViewData]
        public string PageTitle { get; set; } //this is called as "Property"
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            PageTitle = "Service Details";

            var service = new VehicleService
            {
                Id = 1,
                Title = "Oil Change",
                Description = "Change the oil in your car",
                Cost = 19.99
            };

            //ViewBag & ViewData <- Data Passing styles

            //ViewData style
            //ViewData["Service"] = service; //View Data is a Dictionary Model
            

            //ViewBag Style
            //ViewBag.Service = service;



            return View(service);
        }
    }
}
