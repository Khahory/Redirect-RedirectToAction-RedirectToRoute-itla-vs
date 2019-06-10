using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Redirect_RedirectToAction__RedirectToRoute.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //retorna la direccion de una web
            return Redirect("https://orbi.edu.do/orbi/#");
            return View();
        }

        public RedirectToRouteResult About()
        {
            //retornar otra accion y otro controlador
            ViewBag.Message = "Your application description page.";

            return RedirectToAction("Contact","Home");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}