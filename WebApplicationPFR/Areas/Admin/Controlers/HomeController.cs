using Microsoft.AspNetCore.Mvc;
using WebApplicationPFR.Domain;
using WebApplicationPFR.Models;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System;
using WebApplicationPFR.Domain.Entities;
using System.Collections.Generic;

namespace WebApplicationPFR.Areas.Admin.Controlers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        SqlConnection con = new SqlConnection();
        List<Employes> employes = new List<Employes>();
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
            con.ConnectionString = WebApplicationPFR.Properties.Resources.ConnectionString;
        }
        public ActionResult Index()
        {
            return View();
            //return View(dataManager.Employes.GetEmployesById("PageIndex"));

        }
        private void FetchData()
        {
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "SELECT TOP (1000) [Id],[FIO],[otdel],[Room],[mon],[pc],[printer],[PC_ID],[PCId],[Mon_ID],[MonitorsId],[Printer_ID],[PrintersId] FROM[DataBase_PFR].[dbo].[Employes]";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    employes.Add(new Employes(){FIO = dr["FIO"].ToString()
                    ,otdel = dr["otdel"].ToString()
                    //,Room = dr["Room"].ToString()
                    ,mon = dr["Room"].ToString()
                    ,pc = dr["Room"].ToString()
                    ,printer = dr["Room"].ToString()
                    //,Room = dr["Room"].ToString()
                    //,Room = dr["Room"].ToString()
                    });
                }
                con.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public ActionResult Contacts()
        {
            return View();
            //return View(dataManager.Employes.GetEmployesByCodeWord("PageContacts"));
        }
    }
}