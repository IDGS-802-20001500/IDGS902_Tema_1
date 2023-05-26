using IDGS902_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS902_Tema1.Controllers
{
    public class PruebasController : Controller
    {
        // GET: Pruebas
        public JsonResult Index()
        {
            var idgs902 = new Alumnos() { Name = "Mario", Email = "mar@gmail.com", Edad = 23 };
            return Json(idgs902, JsonRequestBehavior.AllowGet);
            //return View();
        }

        public RedirectResult Index2()
        {
            return Redirect("http://google.com.mx");
        }

        public RedirectToRouteResult Index3()
        {
            return RedirectToAction("OperaBas2", "Nuevo");
        }

        public ActionResult Index4()
        {
            ViewBag.Grupo = "IDGS902";
            ViewBag.Numero = 20;
            ViewBag.FechaInicio = new DateTime(2023,2,5);
            ViewData["Nombre"] = "Mario";

            return View();
        }

    }
}