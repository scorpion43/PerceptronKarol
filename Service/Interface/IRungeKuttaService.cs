using System.Collections.Generic;
using WindowsFormsApp1.Service.Implement;

namespace WindowsFormsApp1.Service.Interface
{
    public interface IRungeKuttaService
    {
        List<float[]> GeneratePointsByRungeKutta4K();
        float[] GenerateOneDimension(float[][] point, RungeKuttaService.ValuesEnum value);
    }
}