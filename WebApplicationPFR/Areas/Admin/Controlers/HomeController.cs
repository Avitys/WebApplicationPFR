using Microsoft.AspNetCore.Mvc;
using WebApplicationPFR.Domain;

namespace WebApplicationPFR.Areas.Admin.Controlers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public ActionResult Index()
        {
            return View(dataManager.Employes.GetEmployesByCodeWord("PageIndex"));

        }
        public ActionResult Contacts()
        {
            return View(dataManager.Employes.GetEmployesByCodeWord("PageContacts"));
        }
    }
}