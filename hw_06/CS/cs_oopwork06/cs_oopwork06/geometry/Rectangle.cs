using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cs_oopwork06
{
    public class Rectangle
    {
        private double width;
        private double height;

        public Rectangle(): this(1.0, 1.0) {}

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double GetWidth()
        {
            return width;
        }

        public void SetWidth(double width)
        {
            this.width = width;
        }

        public double GetHeight()
        {
            return height;
        }

        public void SetHeight(double height)
        {
            this.height = height;
        }

        public double area()
        {
            return width * height;
        }

        public void RecInfo()
        {
            System.Console.WriteLine($"Rectangle: Width = {width:N2}, Height = {height:N2}, Area = {area():N2}");
        }
    }
}