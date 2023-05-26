using IDGS902_Tema1.Models;
using IDGS902_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS902_Tema1.Controllers
{
    public class DiccionarioController : Controller
    {
        // GET: Diccionario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegistrarDiccionario() 
        {
            var read = new LeerDicService();
            List <(string, string)> palabras = read.LeerArchivoDicc();
            ViewBag.Palabras = palabras;

            return View();
        }

        [HttpPost]
        public ActionResult RegistrarDiccionario(Diccionario dicc)
        {

            var opel = new GuardarDicService();
            opel.GuardarPalabras(dicc);

            var read = new LeerDicService();
            List<(string, string)> palabras = read.LeerArchivoDicc();
            ViewBag.Palabras = palabras;

            return View(dicc);
        }


        public ActionResult BuscarDiccionario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BuscarDiccionario(string buscarPalabra, string rbtnIdioma)
        {
            var buscar = new BuscarDicService();
            
            ViewBag.Buscar = buscar.BuscarDiccionario(buscarPalabra.ToLower(), rbtnIdioma.ToLower());

            return View();
        }






    }
}