using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using try_dropdown.Models;

namespace try_dropdown.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            //Create a select list item which needs to be bound in
            //dropdown list.
            List<SelectListItem> cityList = new List<SelectListItem>();

            //Add city names in city list.
            cityList.Add(new SelectListItem
            {
                Text = "Allahabad",
                Value = "Allahabad"
            });

            cityList.Add(new SelectListItem
            {
                Text = "Agra",
                Value = "Agra"
            });

            cityList.Add(new SelectListItem
            {
                Text = "Lucknow",
                Value = "Lucknow"
            });

            cityList.Add(new SelectListItem
            {
                Text = "Kanpur",
                Value = "Kanpur"
            });

            cityList.Add(new SelectListItem
            {
                Text = "Noida",
                Value = "Noida"
            });

            //Add city list in ViewBag object.
            ViewBag.CityList = cityList;


            return View();
        }

        [HttpPost]
        public string Index(CityModel model)
        {
            //Return city name which is selected from dropdownlist
            return model.CityName;
        }

    }
}
