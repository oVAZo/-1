using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR
{
 
    abstract class Figure
    {
        public abstract double Area();
    }

    class Triangle : Figure
    {
        public float height { get; set; }
        public float bottomWidth { get; set; }

        public override double Area()
        {
            return (0.5) * (height) * bottomWidth;
        }

        public double Perimeter()
        {
            return ((Math.Sqrt(Math.Pow(height, 2) + Math.Pow(bottomWidth * 0.5, 2)) * 2) + (bottomWidth));
        }

    }

    class Rhomb : Figure
    {
        public float diagonal_1 { get; set; }
        public float diagonal_2 { get; set; }
        public override double Area()
        {

            return (diagonal_1 * diagonal_2) / 2;
        }

        public double Perimeter()
        {
            double a = Math.Pow(diagonal_1, 2) + Math.Pow(diagonal_2, 2);
            return 4 * Math.Sqrt(a);
        }
    }
    class PentagonalPyramid : Figure
    {
        public float height { get; set; }
        public float Width { get; set; }

        public override double Area()
        {
            return 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * Math.Pow(Width, 2);
        }

        public double Volume()
        {
            return 0.33 * Area() * height;
        }
    }

    class Cylinder : Figure
    {
        public float radius { get; set; }
        public float height { get; set; }

        public override double Area()
        {
            return 2 * Math.PI * Math.Pow(radius, 2) + 2 * Math.PI * radius * height;
        }

        public double Volume()
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }
    }

    class Cone : Figure
    {
        public float L { get; set; }
        public float radius { get; set; }
        public float height { get; set; }

        public double Volume()
        {
            return 0.33 * Math.PI * Math.Pow(radius, 2) * height;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2) + Math.PI * radius * L;
        }
    }

}
