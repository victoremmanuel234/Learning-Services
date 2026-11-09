using Microsoft.AspNetCore.Mvc;
using LearningServicesClassLib;
using LearningServices;
using ServiceContracts;

namespace LearningServices.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICitiesService _citieServices;

        public HomeController(ICitiesService citiesService)
        {
            _citieServices = citiesService;
        }

        public ICitiesService CitiesService
        {
            get{return _citieServices;}
        }

        [Route("/")] 
        // GET: HomeController
        public ActionResult Index()
        {
            return View(CitiesService.Cities);
        }

    }
}
