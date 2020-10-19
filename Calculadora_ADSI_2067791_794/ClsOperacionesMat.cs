using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_ADSI_2067791_794
{
    class ClsOperacionesMat
    {
        public double Sumar(double n1, double n2)
        {
            double Sum;
            Sum = n1 + n2;
            return Sum;
        }

        public double Restar(double n1, double n2)
        {
            double Res;
            Res = n1 - n2;
            return Res;
        }

        public double Multiplicar(double n1, double n2)
        {
            double Multi;
            Multi = n1 * n2;
            return Multi;
        }

        public double Dividir(double n1, double n2)
        {
            double Div;
            Div = n1 / n2;
            return Div;
        }

    }
}
