using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej20._CalcularSumaSerieN
{
    class Operacion
    {
        public double AddSum(double n)
        {
            double a = 0;

            for (double i = 1; i < n; i++)
            {
                if (i % 1 == 0)
                {
                    a += i / Math.Pow(2,i);
                }
            }
            return a;
        }
    }
}
