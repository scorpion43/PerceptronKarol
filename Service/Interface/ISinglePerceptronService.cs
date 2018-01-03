using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Service.Implement;

namespace WindowsFormsApp1.Service.Interface
{
    public interface ISinglePerceptronService
    {
        Weight GetWeight(ref float[][] dataSet, RungeKuttaService.ValuesEnum value);
        ResultOfTraining GetResultOfTraining(ref float[][] dataSet);
    }
}