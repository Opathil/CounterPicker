namespace CounterPicker.Web.Controllers
{
    using CounterPicker.Data.Models.Heroes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Newtonsoft.Json;
    using System.Web.Helpers;
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //[HttpGet]
        //public ActionResult Hero()
        //{
        //    var champion = GettinHeroes("");

        //    return View();
        //}

        //[HttpPost]
        //[ValidateInput(false)]
        //public Hero GettinHeroes(string boncho)
        //{
        //    var champion = JsonConvert.DeserializeObject<Hero>(boncho);

        //    return champion;
        //}
    }
}