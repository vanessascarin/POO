using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício1
{
    class Triangulo: FiguraGeometrica
    {
        public double CalculaArea()
        {
            double p = (A + B + C) / 2;
            return (Math.Sqrt(p*(p-A)*(p-B)*(p-C)));
        }
    }
}
