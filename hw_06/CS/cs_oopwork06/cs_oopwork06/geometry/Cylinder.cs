using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cs_oopwork06
{
    public class Cylinder
    {
        private double radius;
        private double length;

        public double GetRadius()
        {
            return radius;
        }

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public double GetLength()
        {
            return length;
        }

        public void SetLength(double length)
        {
            this.length = length;
        }

        public Cylinder(double radius, double length)
        {
            this.radius = radius;
            this.length = length;
        }

        public Cylinder():this(1.0, 1.0){}

        public double area()
        {
            return Math.PI * Math.Pow(radius, 2) * (radius + length);
        }

        public double volume()
        {
            return area() * length;
        }

        public void CyInfo()
        {
            System.Console.WriteLine($"Cylinder: Radius = {radius:N2}, Length = {length:N2}, Area = {area():N2}, Volume = {volume():N2}");
        }
    }

}

