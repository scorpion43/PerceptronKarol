using System;
using System.Collections.Generic;
using WindowsFormsApp1.DataAccess.Interface;
using WindowsFormsApp1.Service.Interface;

namespace WindowsFormsApp1.Service.Implement
{
    public class RungeKuttaService : IRungeKuttaService
    {
        private readonly IPointsDataAccess _pointsDataAccess;
        private float h;

        public enum ValuesEnum {X, Y, Z}

        public RungeKuttaService(IPointsDataAccess pointsDataAccess)
        {
            _pointsDataAccess = pointsDataAccess;
        }


        public List<float[]> GeneratePointsByRungeKutta4K()
        {
            float x = _pointsDataAccess.GetValueForX();
            float y = _pointsDataAccess.GetValueForY();
            float z = _pointsDataAccess.GetValueForZ();
            this.h = _pointsDataAccess.GetValueForH();

            List<float[]> points = new List<float[]>();

            points.Add(new []{x,y,z});

            for (int i = 1; i < 1500; i++)
            {
                float m1 = FunctionXPrim(z);
                float k1 = FunctionYPrim(x, y);
                float l1 = FunctionZPrim(x, z);

                float m2 = FunctionXPrim(z + 0.5f * l1);
                float k2 = FunctionYPrim(x + 0.5f * m1, y + 0.5f * k1);
                float l2 = FunctionZPrim(x + 0.5f * m1, z + 0.5f * l1);

                float m3 = FunctionXPrim(z + 0.5f * l2);
                float k3 = FunctionYPrim(x + 0.5f * m2, y + 0.5f * k2);
                float l3 = FunctionZPrim(x + 0.5f * m2, z + 0.5f * l2);

                float m4 = FunctionXPrim(z + 0.5f * l3);
                float k4 = FunctionYPrim(x + 0.5f * m3, y + 0.5f * k3);
                float l4 = FunctionZPrim(x + 0.5f * m3, z + 0.5f * l3);

                float nextX = GenerateNexValueOfTime(x, m1, m2, m3, m4);
                float nextY = GenerateNexValueOfTime(y, k1, k2, k3, k4);
                float nextZ = GenerateNexValueOfTime(z, l1, l2, l3, l4);

                x = nextX; 
                y = nextY;
                z = nextZ;

                points.Add(new[] { x, y, z });

            }

            return points;
        }

        public float[] GenerateOneDimension(float[][] point, ValuesEnum value)
        {
            List<float> oneDimensionList = new List<float>();

            foreach (float[] f in point)
            {
                switch (value)
                {
                    case ValuesEnum.X:
                        oneDimensionList.Add(f[0]);
                        break;
                    case ValuesEnum.Y:
                        oneDimensionList.Add(f[1]);
                        break;
                    case ValuesEnum.Z:
                        oneDimensionList.Add(f[2]);
                        break;
                }
            }

            return oneDimensionList.ToArray();
        }

        private float FunctionXPrim(float z)
        {
            return h * -z;
        }

        private float FunctionYPrim(float x, float y)
        {
            return h * (float)(-Math.Pow(x,2) - y);
        }

        private float FunctionZPrim(float x, float y)
        {
            return h * (1.7f + 1.7f * x + y);
        }

        private float GenerateNexValueOfTime(float prevVal, float n1, float n2, float n3, float n4)
        {
            return prevVal + h / 6.0f * (n1 + 2 * n2 + 2 * n3 + n4);
        }
    }
}