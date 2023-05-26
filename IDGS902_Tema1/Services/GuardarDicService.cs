using IDGS902_Tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS902_Tema1.Services
{
    public class GuardarDicService
    {
        public void GuardarPalabras(Diccionario dic)
        {
            var ingles = dic.Ingles;
            var espanol = dic.Espanol;

            var datos = ingles.ToLower()+":"+espanol.ToLower()+Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/diccionario.txt");
            File.AppendAllText(archivo, datos);


        }
    }
}