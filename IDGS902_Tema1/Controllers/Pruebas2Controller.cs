using IDGS902_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS902_Tema1.Controllers
{
    public class Pruebas2Controller : Controller
    {
        // GET: Pruebas2
        public ActionResult Index()
        {
            var alumno = new Alumnos()
            {
                Name = "Jimena",
                Edad = 28,
                Email = "jlopez@gmail.com",
                Activo = true,
                Inscripcion = new DateTime(2023, 4, 20)
            };

            ViewBag.Alumnos = alumno;

            return View(alumno);
        }

        public ActionResult Escuela()
        {
            var alumno = new Alumnos()
            {
                Name = "Jimena",
                Edad = 28,
                Email = "jlopez@gmail.com",
                Activo = true,
                Inscripcion = new DateTime(2023, 4, 20)
            };

            ViewBag.Alumnos = alumno;

            return View(alumno);
        }

        public ActionResult CajasInput(int? cantidad)
        {

            if(cantidad == null)
            {
                ViewBag.cajas = null;
            }
            else
            {
                ViewBag.cajas = cantidad;
            }

            return View();
        }

        public ActionResult Promedio(int[] num)
        {
            List<int> numeros = num.ToList();


            

            if(numeros.Count > 0)
            {
                double prom = numeros.Average();
                ViewBag.Promedio = prom;

                int repetido = numeros.GroupBy(x => x)
                            .Where(g => g.Count() > 1)
                            .Select(g => g.Key)
                            .FirstOrDefault();

                ViewBag.Repetido = repetido;
            }
            else
            {
                ViewBag.Promedio = "No se insertaron datos"; 
                ViewBag.Repetido = "No se insertaron datos";
            }

            

            return View();
        }
        


    }
}