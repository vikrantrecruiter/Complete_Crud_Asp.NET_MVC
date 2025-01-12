using CompleteCrud_ASP.NET_MVC.DataAccessLayer;
using CompleteCrud_ASP.NET_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompleteCrud_ASP.NET_MVC.Controllers
{
    public class HomeController : Controller
    {
        AddressDbContext db = new AddressDbContext();

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

       //Create a View in ASP.NET MVC

        public ActionResult Create()
        {
            var list=db.GetCountry();
            ViewBag.Country =new SelectList(list,"CountryId","CountryName");
            return View();
        }

        
        public JsonResult GetState(int countryid)
        {
            var raw =db.GetStateByCountryId(countryid);
            return Json(raw);
        }

        public JsonResult GetCity(int stateid)
        {
            var row = db.GetCityByStateId(stateid);
            return Json(row);
        }

    }
}
