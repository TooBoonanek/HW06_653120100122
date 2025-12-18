using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cs_oopwork06
{
    public class Cylinder
    {
        private double radius;
        private double height;

        public double GetRadius()
        {
            return radius;
        }

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public double GetHeight()
        {
            return height;
        }

        public void SetHeight(double height)
        {
            this.height = height;
        }

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public Cylinder():this(1.0, 1.0){}

        public double area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double volume()
        {
            return area() * height;
        }

        public void CyInfo()
        {
            System.Console.WriteLine($"Cylinder: Radius = {radius:N2}, Height = {height:N2}, Area = {area():N2}, Volume = {volume():N2}");
        }
    }
}