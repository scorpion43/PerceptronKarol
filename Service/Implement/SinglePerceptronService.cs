using System;
using WindowsFormsApp1.DataAccess.Interface;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Service.Interface;

namespace WindowsFormsApp1.Service.Implement
{
    internal class SinglePerceptronService : ISinglePerceptronService
    {
        private readonly IPointsDataAccess _pointsDataAccess;

        public SinglePerceptronService(IPointsDataAccess pointsDataAccess)
        {
            _pointsDataAccess = pointsDataAccess;
        }

        public ResultOfTraining GetResultOfTraining(ref float[][] dataSet)
        {
            var xResult =
                GetWeight(ref dataSet, RungeKuttaService.ValuesEnum.X);
            var yResult =
                GetWeight(ref dataSet, RungeKuttaService.ValuesEnum.Y);
            var zResult =
                GetWeight(ref dataSet, RungeKuttaService.ValuesEnum.Z);

            var resultGroup =
                new ResultOfTraining
                {
                    XResult = xResult,
                    YResult = yResult,
                    ZResult = zResult
                };

            return resultGroup;
        }

        public Weight GetWeight(ref float[][] dataSet, RungeKuttaService.ValuesEnum value)
        {
            var random = new Random();

            var weight = new Weight
            {
                Weight1 = (float) random.NextDouble(),
                Weight2 = (float) random.NextDouble(),
                Weight3 = (float) random.NextDouble(),
                Threshold = (float) random.NextDouble()
            };


            float output;
            float desireValue;

            var maxError = _pointsDataAccess.GetMaxError();

            for (var e = 0; e < _pointsDataAccess.GetEpochs(); e++)
            {
                float x;
                float y;
                float z;


                for (var i = 0; i < dataSet.GetLength(0)-1; i++)
                {
                   
                    desireValue = dataSet[i + 1][(int) value];

                    x = dataSet[i][0];
                    y = dataSet[i][1];
                    z = dataSet[i][2];

                    float learningRate =(float) (1.0d / (1 + Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2)));

                    output = x * weight.Weight1 + y * weight.Weight2 + z * weight.Weight3 - weight.Threshold;

                    while (Math.Abs(desireValue - output) > maxError)
                    {
                        weight.Weight1 -= learningRate * (output - desireValue) * x;
                        weight.Weight2 -= learningRate * (output - desireValue) * y;
                        weight.Weight3 -= learningRate * (output - desireValue) * z;
                        weight.Threshold += learningRate * (output - desireValue);


                        output = x * weight.Weight1 + y * weight.Weight2 + z * weight.Weight3 - weight.Threshold;
                    }
                }
            }

            return weight;
        }
    }
}