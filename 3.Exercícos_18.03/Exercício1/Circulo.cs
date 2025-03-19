using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício1
{
    class Circulo: FiguraGeometrica
    {
        public double CalculaArea() 
        {
            return (Math.PI * Raio * Raio);
        }
    }
}
