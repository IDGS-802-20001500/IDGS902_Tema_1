using IDGS902_Tema1.Models;
using IDGS902_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS902_Tema1.Controllers
{
    public class TrianguloController : Controller
    {
        // GET: Triangulo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PuntosTri()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PuntosTri(Triangulos tr)
        {
            CalculosServices caltri = new CalculosServices();
            caltri.calcularDistancias(tr.X1, tr.X2, tr.X3, tr.Y1, tr.Y2, tr.Y3);


            ViewBag.Triangulo = caltri.Triangulo;
            ViewBag.Perimetro = caltri.Perimetro;
            ViewBag.Area = caltri.Area;

            return View(tr);
        }

    }
}