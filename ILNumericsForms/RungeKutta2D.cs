﻿using System;
using System.Drawing;
using System.Windows.Forms;
using ILNumerics;
using ILNumerics.Drawing;
using ILNumerics.Drawing.Plotting;

namespace WindowsFormsApp1.ILNumericsForms
{
    public partial class RungeKutta2D : Form
    {
        public ILArray<float> Points;
        public ILArray<float> PointsPerceptron;

        public RungeKutta2D()
        {
            InitializeComponent();
        }

        // Initial plot setup, modify this as needed
        private void ilPanel1_Load(object sender, EventArgs e)
        {

            // setup the plot (modify as needed)
            ilPanel1.Scene.Add(new ILPlotCube(twoDMode: false) {
                new ILLinePlot(Points, tag: "points") {
                    Line = {
                        Width = 2,
                        Color = Color.Red,
                        Antialiasing = true,
                        DashStyle = DashStyle.Dotted
                    }
                },
                 new ILLinePlot(PointsPerceptron, tag: "points") {
                    Line = {
                        Width = 2,
                        Color = Color.Blue,
                        Antialiasing = true,
                        DashStyle = DashStyle.Dotted
                    }
                }

            });
            // register event handler for allowing updates on right mouse click:
            ilPanel1.Scene.First<ILLinePlot>().MouseClick += (_s, _a) =>
            {
                if (_a.Button == MouseButtons.Right)
                    Update(ILMath.rand(3, 30));
            };
        }

        /// <summary>
        /// Example update function used for dynamic updates to the plot
        /// </summary>
        /// <param name="A">New data, matching the requirements of your plot</param>
        public void Update(ILInArray<double> A)
        {
            using (ILScope.Enter(A))
            {

                // fetch a reference to the plot
                var plot = ilPanel1.Scene.First<ILLinePlot>(tag: "mylineplot");
                if (plot != null)
                {
                    // make sure, to convert elements to float
                    plot.Update(ILMath.tosingle(A));
                    //
                    // ... do more manipulations here ...

                    // finished with updates? -> Call Configure() on the changes 
                    plot.Configure();

                    // cause immediate redraw of the scene
                    ilPanel1.Refresh();
                }

            }
        }

        /// <summary>
        /// Example computing module as private class 
        /// </summary>
        private class Computation : ILMath
        {
            /// <summary>
            /// Create some test data for plotting
            /// </summary>
            /// <param name="ang">end angle for a spiral</param>
            /// <param name="resolution">number of points to plot</param>
            /// <returns>3d data matrix for plotting, points in columns</returns>
            public static ILRetArray<float> CreateData(int ang, int resolution)
            {
                using (ILScope.Enter())
                {
                    ILArray<float> A = linspace<float>(0, ang * pi, resolution);
                    ILArray<float> Pos = zeros<float>(3, A.S[1]);
                    Pos["0;:"] = sin(A);
                    Pos["1;:"] = cos(A);
                    Pos["2;:"] = A;
                    return Pos;
                }
            }

        }
    }
}
