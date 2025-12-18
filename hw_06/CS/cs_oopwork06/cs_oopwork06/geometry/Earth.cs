using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cs_oopwork06
{
    public class Earth
    {
        public double G = 6.673e-11;
        public double Radius = 6.3781e6;

        public double Mass = 5.67e24;

        public void EarthInfo()
        {
            System.Console.WriteLine($"Earth: G = {G}, Radius = {Radius}, Mass = {Mass}");
        }
    }
}