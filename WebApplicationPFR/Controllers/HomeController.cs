using Microsoft.AspNetCore.Mvc;
using WebApplicationPFR.Domain;

namespace WebApplicationPFR.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
