using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITMO.ASPCourse.MVC.Lab02.Ex03.Models
{
    public class Triangle
    {
        public double Sta { get; set; }
        public double Stb { get; set; }
        public double Stc { get; set; }

        public string Name
        {
            get { return String.Format("\"Треугольник  со сторонами {0}, {1} и {2}\"", Sta, Stb, Stc); }
        }
        //Changing the sintax of Method Perimeter!

        //public double Perimeter
        //{
        //    get
        //    {
        //        double p = Sta + Stb + Stc;
        //        return p;
        //    }
        //}

        //Using version 6.0 it's possible to use the folowing sintax:
        public double Perimeter => Math.Round(Sta + Stb + Stc);
        public double Area
        {
            get
            {
                double sq = Math.Sqrt(Perimeter/2 * (Perimeter/2 - Sta) * (Perimeter/2 - Stb) * (Perimeter/2 - Stc));
                return sq;
            }
        }
        public Triangle (double a, double b, double c)
        {
            this.Sta = a;
            this.Stb = b;
            this.Stc = c;
        }
    }
}