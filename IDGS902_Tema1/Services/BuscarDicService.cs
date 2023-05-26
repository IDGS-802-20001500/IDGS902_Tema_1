using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS902_Tema1.Services
{
    public class BuscarDicService
    {
        public string BuscarDiccionario(string palabraBuscar, string idioma)
        {
            List<(string, string)> diccDatos = new List<(string, string)>();
            try
            {
                var datos = HttpContext.Current.Server.MapPath("~/App_Data/diccionario.txt");
                if (File.Exists(datos))
                {
                    string[] palabras = File.ReadAllLines(datos);

                    foreach (string palabra in palabras)
                    {
                        string[] separar = palabra.Split(':');

                        if (separar.Length == 2)
                        {
                            string ingles = separar[0].Trim();
                            string espanol = separar[1].Trim();
                            diccDatos.Add((ingles, espanol));
                        }
                    }

                    (string, string) traductor = default;

                    if (palabraBuscar != null)
                    {
                        if (idioma == "en")
                        {
                            traductor = diccDatos.FirstOrDefault(item => item.Item2 == palabraBuscar);
                        }
                        
                        if (idioma == "esp")
                        {
                            traductor = diccDatos.FirstOrDefault(item => item.Item1 == palabraBuscar);
                        }
                    }

                    if (traductor != default)
                    {
                        if (idioma == "esp")
                        {
                            return traductor.Item2;
                        }
                        else if (idioma == "en")
                        {
                            return traductor.Item1;
                        }
                    }
                    else
                    {
                        return "No existe";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return string.Empty;

        }
    }
}