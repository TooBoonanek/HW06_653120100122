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

        public double diamater()
        {
            return 2 * radius;
        }

        public double circumference()
        {
            return 2 * Math.PI * radius;
        }

        public void cirInfo()
        {
            System.Console.WriteLine($"Circle: Radius = {radius:N2}, Area = {area():N2}, Diameter = {diamater():N2}, Circumference = {circumference():N2}");
        }
    }
}