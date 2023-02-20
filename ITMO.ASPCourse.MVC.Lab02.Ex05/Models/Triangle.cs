using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITMO.ASPCourse.MVC.Lab02.Ex05.Models
{
    public class Triangle: Shape, IComparable<Triangle>
    {
        public int CompareTo(Triangle other)
        {
            if (this.Perimeter == other.Perimeter) return 0;
            else if (this.Perimeter > other.Perimeter) return 1;
            else return -1;
        }
        public double Stb { get; set; }
        public double Stc { get; set; }

        public override string Name
        {
            get { return String.Format("\"Треугольник  со сторонами {0}, {1} и {2}\"", St, Stb, Stc); }
        }
        public double Perimeter => Math.Round(St + Stb + Stc);
        public double Area
        {
            get
            {
                double sq = Math.Sqrt(Perimeter/2 * (Perimeter/2 - St) * (Perimeter/2 - Stb) * (Perimeter/2 - Stc));
                return sq;
            }
        }
        public Triangle (double a, double b, double c)
        {
            this.St = a;
            this.Stb = b;
            this.Stc = c;
        }
    }
}