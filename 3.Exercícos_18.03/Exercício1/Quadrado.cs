using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício1
{
    class Quadrado: Retangulo
    {
        public void InformarValores()
        {
            Console.WriteLine("\n Insira o comprimento das laterais do quadrado: ");
            A = double.Parse(Console.ReadLine());
            B = A;
            CalculaArea();
        }
    }
}
