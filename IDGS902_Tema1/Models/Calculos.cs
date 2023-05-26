using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace IDGS902_Tema1.Models
{
    public class Calculos
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public double Res { get; set; }

        public double x1 { get; set; }
        public double x2 { get; set; }

        public double y1 { get; set; }
        public double y2 { get; set; }

        public double Puntos(double x1, double x2, double y1, double y2) 
        {
            double d = 0;
            double xc = 0;
            double yc = 0;

            xc = Math.Pow((x2-x1), 2);
            yc = Math.Pow((y2 - y1), 2);

            d = Math.Sqrt((xc + yc));

            double Res = d;

            Console.WriteLine(Res);

            return Res;
        }

    }



}