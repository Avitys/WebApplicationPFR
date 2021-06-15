using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationPFR.Domain;

namespace WebApplicationPFR.Areas.Admin.Controlers
{
    public class ServicesController : Controller
    {
        private readonly DataManager dataManager;

        public ServicesController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.Employes.GetEmployesById(id));
            }

            ViewBag.Employes = dataManager.Employes.GetEmployesById(id);
            return View(dataManager.Monitors.GetMonitorsById(id));
        }
    }
}
