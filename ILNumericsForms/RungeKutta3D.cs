using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ILNumerics;
using ILNumerics.Drawing;
using ILNumerics.Drawing.Plotting;

namespace WindowsFormsApp1.ILNumericsForms
{
    public partial class RungeKutta3D : Form
    {
        public List<float[]> Points;
        public List<float[]> PointsPerceptron;

        public RungeKutta3D()
        {
            InitializeComponent();
        }

        private void ilPanel1_Load(object sender, EventArgs e)
        {
            float[,] floatPoints = new float[1500, 3];
            float[,] floatPointsPerceptron = new float[1500, 3];

            for (int i = 0; i < 1500; i++)
            {
                floatPoints[i, 0] = Points[i][0];
                floatPoints[i, 1] = Points[i][1];
                floatPoints[i, 2] = Points[i][2];

                floatPointsPerceptron[i, 0] = PointsPerceptron[i][0];
                floatPointsPerceptron[i, 1] = PointsPerceptron[i][1];
                floatPointsPerceptron[i, 2] = PointsPerceptron[i][2];
            }


            ILArray<float> point = floatPoints;


            ilPanel1.Scene.Add(new ILPlotCube(twoDMode: false)
            {
                new ILLinePlot(point, tag: "points")
                {
                    Line =
                    {
                        Width = 2,
                        Color = Color.Red,
                        Antialiasing = true,
                        DashStyle = DashStyle.PointDash
                    }
                },
                new ILLinePlot(floatPointsPerceptron, tag: "points")
                {
                    Line =
                    {
                        Width = 2,
                        Color = Color.Blue,
                        Antialiasing = true,
                        DashStyle = DashStyle.PointDash
                    }
                }
            });

        }

        public void Update(ILInArray<double> A)
        {
            using (ILScope.Enter(A))
            {
                var plot = ilPanel1.Scene.First<ILLinePlot>(tag: "mylineplot");
                if (plot != null)
                {

                    plot.Update(ILMath.tosingle(A));

                    plot.Configure();
                    
                    ilPanel1.Refresh();
                }

            }
        }
    }
}
