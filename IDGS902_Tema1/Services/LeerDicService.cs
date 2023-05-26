using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS902_Tema1.Services
{
    public class LeerDicService
    {
        public List<(string, string)> LeerArchivoDicc()
        {
            List<(string, string)> diccDatos = new List<(string, string)>();

            var datos = HttpContext.Current.Server.MapPath("~/App_Data/diccionario.txt");
            if (File.Exists(datos))
            {
                string[] palabras = File.ReadAllLines(datos);

                foreach (string palabra in palabras)
                {
                    string[] separar = palabra.Split(':');
                    if  (separar.Length == 2)
                    {
                        string ingles = separar[0].Trim();
                        string espanol = separar[1].Trim();
                        diccDatos.Add((ingles, espanol));
                    }
                }


            }

            return diccDatos;
        }
    }
}