using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetik_Algoritma
{
    public class GeneticAlgorithm
    {
        public Population CurrentPopulation { get; set; } // popülasyon
        public int Generation { get; set; } // jenerasyon
        public double CrossoverRate { get; set; } // Çaprazlama oranı
        public double MutationRate { get; set; } // Mutasyon oranı
        public int ElitismCount { get; set; } // En iyi kaç birey korunacak

        private Random rand = new Random(); // Rastgele sayı için tek bir Random

        public GeneticAlgorithm(int populationSize, double crossoverRate, double mutationRate, int elitismCount)
        {
            CurrentPopulation = new Population(populationSize);
            CrossoverRate = crossoverRate;
            MutationRate = mutationRate;
            ElitismCount = elitismCount;
            Generation = 0;
        }

        public void Evolve()
        {
            var elites = CurrentPopulation.Individuals.OrderBy(a => a.Fitness).Take(ElitismCount).ToList();

            List<Individual> newPopulation = new List<Individual>();
            newPopulation.AddRange(elites);

            while (newPopulation.Count < CurrentPopulation.Individuals.Count)
            {
                Individual parent1 = TournamentSelection();
                Individual parent2 = TournamentSelection();

                if (rand.NextDouble() < CrossoverRate)
                {
                    var children = Crossover(parent1, parent2);
                    newPopulation.Add(children.Item1);
                    if (newPopulation.Count < CurrentPopulation.Individuals.Count)
                        newPopulation.Add(children.Item2);
                }
                else
                {
                    newPopulation.Add(parent1);
                    if (newPopulation.Count < CurrentPopulation.Individuals.Count)
                        newPopulation.Add(parent2);
                }
            }

            for (int i = ElitismCount; i < newPopulation.Count; i++)
            {
                if (rand.NextDouble() < MutationRate)
                {
                    Mutate(newPopulation[i]);
                }
            }

            CurrentPopulation.Individuals = newPopulation;
            Generation++;
        }

        private Individual TournamentSelection()
        {
            int tournamentSize = 3; 
            List<Individual> tournament = new List<Individual>();
            for (int i = 0; i < tournamentSize; i++)
            {
                int randomIndex = rand.Next(CurrentPopulation.Individuals.Count);
                tournament.Add(CurrentPopulation.Individuals[randomIndex]);
            }
            return tournament.OrderBy(ind => ind.Fitness).First(); 
        }

        private Tuple<Individual, Individual> Crossover(Individual parent1, Individual parent2)
        {
            double alpha = rand.NextDouble();
            double x1 = alpha * parent1.X + (1 - alpha) * parent2.X;
            double y1 = alpha * parent1.Y + (1 - alpha) * parent2.Y;
            double x2 = alpha * parent2.X + (1 - alpha) * parent1.X;
            double y2 = alpha * parent2.Y + (1 - alpha) * parent1.Y;

            x1 = Math.Max(-10, Math.Min(10, x1));
            y1 = Math.Max(-10, Math.Min(10, y1));
            x2 = Math.Max(-10, Math.Min(10, x2));
            y2 = Math.Max(-10, Math.Min(10, y2));

            return new Tuple<Individual, Individual>(new Individual(x1, y1), new Individual(x2, y2));
        }

        private void Mutate(Individual individual)
        {
            double step = 0.1;
            individual.X += (rand.NextDouble() - 0.5) * step;
            individual.Y += (rand.NextDouble() - 0.5) * step;

            individual.X = Math.Max(-10, Math.Min(10, individual.X));
            individual.Y = Math.Max(-10, Math.Min(10, individual.Y));
            individual.Fitness = individual.CalculateFitness(); 
        }
    }
}
