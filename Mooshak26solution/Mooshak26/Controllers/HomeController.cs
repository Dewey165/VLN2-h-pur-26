using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mooshak26.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AdminMainPage()
        {
           
            return View();
        }

        public ActionResult StudentMainPage()
        {

            return View();
        }

        public ActionResult TeacherMainPage()
        {

            return View();
        }
    }
}