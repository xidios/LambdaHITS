using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaHITS
{
    class Flow
    {
        Random rand = new Random();
        public int lambda { get; set; }
        public int[] currentFlow { get; set; } = new int[20];


        public void CreateCurrentFlow(double T)
        {
            int count = 0;
            for (double currentTime = SetTime(); currentTime <= T; currentTime += SetTime())
            {
                count++;
            }

            if (currentFlow.Length - 1 < count)
            {
                int[] f = new int[count + 3];

                for (int i = 0; i < currentFlow.Length; i++)
                {
                    f[i] = currentFlow[i];
                }
                currentFlow = f;
            }
            currentFlow[count]++;
        }
        private double SetTime()
        {
            double a;
            a = rand.NextDouble();
            while (a == 0)
            {
                a = rand.NextDouble();
            }
            return -Math.Log(a) / lambda;
        }
    }

    class DoubleFlow : Flow
    {
        Random rand = new Random();
        public new int[] lambda { get; set; } = new int[2];

        public new void CreateCurrentFlow(double T)
        {
            int count = 0;
            for (double currentTime = -SetTime(1); currentTime <= T; currentTime -= SetTime(1))
            {
                count++;
            }
            for (double currentTime = -SetTime(0); currentTime <= T; currentTime -= SetTime(0))
            {
                count++;
            }

            if (currentFlow.Length - 1 < count)
            {
                int[] f = new int[count + 3];

                for (int i = 0; i < currentFlow.Length; i++)
                {
                    f[i] = currentFlow[i];
                }
                currentFlow = f;
            }
            currentFlow[count]++;
        }
        private double SetTime(int i)
        {
            double a;
            a = rand.NextDouble();
            while (a == 0)
            {
                a = rand.NextDouble();
            }
            return Math.Log(a) / lambda[i];
        }
    }
}
