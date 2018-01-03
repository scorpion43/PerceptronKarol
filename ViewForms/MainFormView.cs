using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataAccess.Interface;
using WindowsFormsApp1.ILNumericsForms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Service.Interface;

namespace WindowsFormsApp1.Service.Implement
{
    public partial class MainFormView : System.Windows.Forms.Form
    {
        private readonly IRungeKuttaService _rungeKuttaService;
        private ISinglePerceptronService _singlePerceptronService;
        private IPointsDataAccess _pointsDataAccess;

        public List<float[]> Points = new List<float[]>();
        public List<float[]> PointsAfterTraining = new List<float[]>();
        float[] inputPointsOneDimensionForX;
        float[] inputPointsOneDimensionForY;
        float[] inputPointsOneDimensionForZ;
        float[] trainingPointsOneDimensionForX;
        float[] trainingPointsOneDimensionForY;
        float[] trainingPointsOneDimensionForZ;




        public MainFormView(IRungeKuttaService rungeKuttaService, ISinglePerceptronService singlePerceptronService, IPointsDataAccess pointsDataAccess)
        {
            _rungeKuttaService = rungeKuttaService;
            _singlePerceptronService = singlePerceptronService;
            _pointsDataAccess = pointsDataAccess;
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Points = _rungeKuttaService.GeneratePointsByRungeKutta4K();

            AddValuesToListBoxes();

            inputPointsOneDimensionForX = _rungeKuttaService.GenerateOneDimension(Points.ToArray(), RungeKuttaService.ValuesEnum.X);
            inputPointsOneDimensionForY = _rungeKuttaService.GenerateOneDimension(Points.ToArray(), RungeKuttaService.ValuesEnum.Y);
            inputPointsOneDimensionForZ = _rungeKuttaService.GenerateOneDimension(Points.ToArray(), RungeKuttaService.ValuesEnum.Z);
        }

        private void AddValuesToListBoxes()
        {
            ListBoxVariableX.Items.Clear();
            ListBoxVariableY.Items.Clear();
            ListBoxVariableZ.Items.Clear();

            foreach (var point in Points)
            {
                ListBoxVariableX.Items.Add(point[0].ToString("0.0000"));
                ListBoxVariableY.Items.Add(point[1].ToString("0.0000"));
                ListBoxVariableZ.Items.Add(point[2].ToString("0.0000"));
            }
        }

        private void AddOutputValuesToListBoxes()
        {
            listBoxOutputX.Items.Clear();
            listBoxOutputY.Items.Clear();
            listBoxOutputZ.Items.Clear();

            foreach (var point in PointsAfterTraining)
            {
                listBoxOutputX.Items.Add(point[0].ToString("0.0000"));
                listBoxOutputY.Items.Add(point[1].ToString("0.0000"));
                listBoxOutputZ.Items.Add(point[2].ToString("0.0000"));
            }
        }

        private void learnButton_Click(object sender, EventArgs e)
        {
            int sampleCount = _pointsDataAccess.GetDataSetSize();
            float[][] dataSet = new float[sampleCount][];
            Array.Copy(Points.ToArray(), dataSet, sampleCount);

            ResultOfTraining resultOfTraining =_singlePerceptronService.GetResultOfTraining(ref dataSet);

            PointsAfterTraining.Add(new []{dataSet[0][0], dataSet[0][1], dataSet[0][2]});

            for (int i = 0; i < 1500; i++)
            {
                float generatedValueForX = PointsAfterTraining[i][0] * resultOfTraining.XResult.Weight1 +
                                           PointsAfterTraining[i][1] * resultOfTraining.XResult.Weight2 +
                                           PointsAfterTraining[i][2] * resultOfTraining.XResult.Weight3 -
                                           resultOfTraining.XResult.Threshold;

                float generatedValueForY = PointsAfterTraining[i][0] * resultOfTraining.YResult.Weight1 +
                                           PointsAfterTraining[i][1] * resultOfTraining.YResult.Weight2 +
                                           PointsAfterTraining[i][2] * resultOfTraining.YResult.Weight3 -
                                           resultOfTraining.YResult.Threshold;

                float generatedValueForZ = PointsAfterTraining[i][0] * resultOfTraining.ZResult.Weight1 +
                                           PointsAfterTraining[i][1] * resultOfTraining.ZResult.Weight2 +
                                           PointsAfterTraining[i][2] * resultOfTraining.ZResult.Weight3 -
                                           resultOfTraining.ZResult.Threshold;

                PointsAfterTraining.Add(new[]
                {
                    generatedValueForX,
                    generatedValueForY,
                    generatedValueForZ
                });
            }

            AddOutputValuesToListBoxes();
            trainingPointsOneDimensionForX = _rungeKuttaService.GenerateOneDimension(PointsAfterTraining.ToArray(), RungeKuttaService.ValuesEnum.X);
            trainingPointsOneDimensionForY = _rungeKuttaService.GenerateOneDimension(PointsAfterTraining.ToArray(), RungeKuttaService.ValuesEnum.Y);
            trainingPointsOneDimensionForZ = _rungeKuttaService.GenerateOneDimension(PointsAfterTraining.ToArray(), RungeKuttaService.ValuesEnum.Z);

            
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            RungeKutta3D generated = new RungeKutta3D();
            generated.Text = "generated3D";
            generated.Points = Points;
            generated.PointsPerceptron = PointsAfterTraining;
            generated.Show();

            RungeKutta2D trainingRungeKutta2DForX = new RungeKutta2D();
            trainingRungeKutta2DForX.Text = "TrainingRungeKutta2DForX";
            trainingRungeKutta2DForX.Points = trainingPointsOneDimensionForX;
            trainingRungeKutta2DForX.PointsPerceptron = inputPointsOneDimensionForX;
            trainingRungeKutta2DForX.Show();

            RungeKutta2D trainingRungeKutta2DForY = new RungeKutta2D();
            trainingRungeKutta2DForY.Text = "TrainingRungeKutta2DForY";
            trainingRungeKutta2DForY.Points = trainingPointsOneDimensionForY;
            trainingRungeKutta2DForY.PointsPerceptron = inputPointsOneDimensionForY;
            trainingRungeKutta2DForY.Show();

            RungeKutta2D trainingRungeKutta2DForZ = new RungeKutta2D();
            trainingRungeKutta2DForZ.Text = "TrainingRungeKutta2DForZ";
            trainingRungeKutta2DForZ.Points = trainingPointsOneDimensionForZ;
            trainingRungeKutta2DForZ.PointsPerceptron = inputPointsOneDimensionForZ;
            trainingRungeKutta2DForZ.Show();
        }
    }
}
