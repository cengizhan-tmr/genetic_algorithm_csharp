using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetik_Algoritma
{
    public class Individual
    {
        public double X { get; set; }
        public double Y { get; set; } 
        public double Fitness { get; set; } 

        public Individual(double x, double y)
        {
            X = x;
            Y = y;
            Fitness = CalculateFitness(); 
        }

        //0.26(x^2 + y^2) - 0.48xy
        public double CalculateFitness()
        {
            return 0.26 * (X * X + Y * Y) - 0.48 * X * Y;
        }
    }
}
