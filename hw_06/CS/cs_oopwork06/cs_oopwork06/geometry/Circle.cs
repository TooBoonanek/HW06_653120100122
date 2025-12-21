using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

namespace cs_oopwork06
{
    public class Circle
    {
        private double radius;

        public double GetRadius()
        {
            return radius;
        }

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle(): this(1.0){}

        public double area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public void cirInfo()
        {
            System.Console.WriteLine($"Circle: Radius = {radius:N2}, Area = {area():N2}");
        }
    }

}
