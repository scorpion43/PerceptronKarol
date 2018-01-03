using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataAccess.Implement;
using WindowsFormsApp1.DataAccess.Interface;
using WindowsFormsApp1.Service;
using WindowsFormsApp1.Service.Implement;
using WindowsFormsApp1.Service.Interface;
using SimpleInjector;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = Bootstarp();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.GetInstance<MainFormView>());
        }

        public static Container Bootstarp()
        {
            var currentContainer = new Container();
            currentContainer.Register<MainFormView>();
            //currentContainer.RegisterDecorator(typeof(IMainFormView), typeof(PointsDataAccess));
            //currentContainer.Register<IMainFormView, MainFormView>(Lifestyle.Singleton);
            currentContainer.Register<IPointsDataAccess, PointsDataAccess>(Lifestyle.Singleton);
            currentContainer.Register<IRungeKuttaService, RungeKuttaService>(Lifestyle.Singleton);
            currentContainer.Register<ISinglePerceptronService, SinglePerceptronService>(Lifestyle.Singleton);
            
            return currentContainer;
        }
    }
}
