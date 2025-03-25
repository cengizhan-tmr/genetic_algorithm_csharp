using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Genetik_Algoritma
{
    public partial class Form1 : Form
    {
        private GeneticAlgorithm ga;
        private List<double> bestFitnesses = new List<double>(); 
        public Form1()
        {
            InitializeComponent();
        }

       
        private void chartConvergence_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int populationSize = int.Parse(txtPopulationSize.Text);
            double crossoverRate = double.Parse(txtCrossoverRate.Text);
            double mutationRate = double.Parse(txtMutationRate.Text);
            int elitismCount = int.Parse(txtElitismCount.Text);
            int generations = int.Parse(txtGenerations.Text);

            ga = new GeneticAlgorithm(populationSize, crossoverRate, mutationRate, elitismCount);
            bestFitnesses.Clear();

            for (int i = 0; i < generations; i++)
            {
                ga.Evolve();
                var best = ga.CurrentPopulation.Individuals.OrderBy(ind => ind.Fitness).First();
                bestFitnesses.Add(best.Fitness); // En iyi sonucu kaydet
            }

            var bestIndividual = ga.CurrentPopulation.Individuals.OrderBy(ind => ind.Fitness).First();
            lblResult.Text = $"En iyi çözüm: \n " +
                             $"X = {bestIndividual.X} \n " +
                             $"Y = {bestIndividual.Y} \n " +
                             $"Fonksiyon Değeri = {bestIndividual.Fitness}";

            chartConvergence.Series[0].Points.Clear();
            for (int i = 0; i < bestFitnesses.Count; i++)
            {
                chartConvergence.Series[0].Points.AddXY(i, bestFitnesses[i]);
            }
            chartConvergence.Titles.Clear();
            chartConvergence.Titles.Add("GA Yakınsama Grafiği");
            chartConvergence.ChartAreas[0].AxisX.Title = "Jenerasyon";
            chartConvergence.ChartAreas[0].AxisY.Title = "En İyi Fonksiyon Değeri";

            chartConvergence.Series[0].Color = Color.Red;
            chartConvergence.Series[0].MarkerStyle = MarkerStyle.Circle;
            chartConvergence.Series[0].MarkerSize = 5;

            chartConvergence.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chartConvergence.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            chartConvergence.ChartAreas[0].RecalculateAxesScale();

            
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
