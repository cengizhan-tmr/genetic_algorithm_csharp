using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetik_Algoritma
{
    public class Population
    {
        public List<Individual> Individuals { get; set; } 

        public Population(int size)
        {
            Individuals = new List<Individual>();
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                double x = -10 + 20 * rand.NextDouble(); //max 10 min -10
                double y = -10 + 20 * rand.NextDouble(); 
                Individuals.Add(new Individual(x, y));
            }
        }
    }
}
