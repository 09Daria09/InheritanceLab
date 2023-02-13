using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class Figure
    {
        public abstract double Square(double a, double b);
    }

    class Rectangle : Figure
    {
        public override double Square(double a, double b)
        {
            return a * b;
        }
    }
    class Circle : Figure
    {
        public override double Square(double a, double b)
        {
            return 3.14 * Math.Pow(a, 2);
        }
    }
    class RightTriangle : Figure
    {
        public override double Square(double a, double b)
        {
            return (a*b)/2;
        }
    }
    class Trapezion : Figure
    {
        public override double Square(double m, double h)
        {
            return m*h;
        }
    }
}
