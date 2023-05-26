using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace IDGS902_Tema1.Services
{
    public class CalculosServices
    {

        public double Area { get; set; }
        public double Perimetro { get; set; }
        public string Triangulo {get; set; }
        public void calcularDistancias(double x1, double x2, double x3, double y1, double y2, double y3)
        {
            string tipoTri="";
            if ((x1 == x2) && (y1 == y2) || (x2 == x3) && (y2 == y3) || (x1 == x3) && (y1 == y3))
            {
                tipoTri =  "No es un triangulo";
            }
            else if ((x1 == y1) && (x2 == y2) && (x3 == y3))
            {

                tipoTri = "No es un triangulo";
            }
            else
            {
                double AB = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)));

                double BC = Math.Sqrt((Math.Pow((x3 - x2), 2)) + (Math.Pow((y3 - y2), 2)));

                double CA = Math.Sqrt((Math.Pow((x1 - x3), 2)) + (Math.Pow((y1 - y3), 2)));

                if ((AB != 0) && (BC != 0) && (CA != 0))
                {
                    if (AB == BC && BC == CA && CA == AB)
                    {
                        tipoTri = "Equilatero";
                    }
                    else if (AB == BC || BC == CA || AB == CA)
                    {
                        tipoTri = "Isósceles";
                        
                    }
                    else if (AB != BC && BC != CA && AB != CA)
                    {
                        tipoTri = "Escaleno";
                    }

                    calcularPerimetro(AB, BC, CA);
                    calcularArea(x1, x2, x3, y1, y2, y3);

                }
                else
                {
                    tipoTri = "No es triangulo";
                    calcularPerimetro(0, 0, 0);
                    calcularArea(0, 0, 0, 0, 0, 0);
                }
            }

           this.Triangulo = tipoTri;


        }


        public void calcularArea(double x1, double x2, double x3, double y1, double y2, double y3)
        {

            double area = 0.5 * Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)));

           this.Area = area;

        }

        public void calcularPerimetro(double AB, double BC, double CA)
        {
            double perimetro = AB + BC + CA;

            this.Perimetro = Math.Round(perimetro,2);
        }


    }
}
