using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using WebApplicationPFR.Domain;
using WebApplicationPFR.Models;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;


namespace WebApplicationPFR.Areas.Admin.Controlers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        SqlConnection con = new SqlConnection();
        List<DataTable> dataTables = new List<DataTable>();
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            con.ConnectionString = WebApplicationPFR.Properties.Resources.ConnectionString;
        }


        private void FetchData()
        {
            if (dataTables.Count > 0)
            {
                dataTables.Clear();
            }
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "SELECT *  FROM [DataBase_PFR].[dbo].[Employes]";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    dataTables.Add(new DataTable(){ Id = dr["Id"].ToString(),
                        FIO = dr["FIO"].ToString(),
                        otdel = dr["otdel"].ToString(),
                        Room = dr["Room"].ToString(),
                        mon = dr["mon"].ToString(),
                        pc = dr["pc"].ToString(),
                        printer = dr["printer"].ToString(),
                        PC_ID = dr["PC_ID"].ToString(),
                        PCId = dr["PCId"].ToString(),
                        Mon_ID = dr["Mon_ID"].ToString(),
                        MonitorsId = dr["MonitorsId"].ToString(),
                        Printer_ID = dr["Printer_ID"].ToString(),
                        PrintersId = dr["PrintersId"].ToString()

                    });
                }
                con.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public ActionResult Index()
        {
            FetchData();
            return View(dataTables);
        }

        public ActionResult Contacts()
        {
            return View();
            //return View(dataManager.Employes.GetEmployesByCodeWord("PageContacts"));
        }
    }
}