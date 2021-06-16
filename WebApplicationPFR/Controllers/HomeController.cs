using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using WebApplicationPFR.Domain;
using WebApplicationPFR.Models;

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
