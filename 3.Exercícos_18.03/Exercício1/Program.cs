// Escrever projeto em C# de acordo com Diagramas de Classe no slide.

using System;

namespace Exercício1
{
    class Program
    {
        static void Main()
        {
            Retangulo r = new Retangulo();
            Circulo c = new Circulo();
            Triangulo t = new Triangulo();
            Quadrado q = new Quadrado();

            //Inserindo os valores das figuras geométricas

            Console.WriteLine("\n Insira as medidas do retângulo: ");
            r.A = double.Parse(Console.ReadLine());
            r.B = double.Parse(Console.ReadLine());

            Console.WriteLine("\n Insira o raio do círculo: ");
            c.Raio = double.Parse(Console.ReadLine());

            Console.WriteLine("\n Insira as medidas do triângulo: ");
            t.A = double.Parse(Console.ReadLine());
            t.B = double.Parse(Console.ReadLine());
            t.C = double.Parse(Console.ReadLine());

            q.InformarValores();

            //Exibindo os valores inseridos
            Console.WriteLine("\n Medidas do retângulo: " + r.A + " e " + r.B);
            Console.WriteLine("\n Área do retângulo: " + r.CalculaArea() );

            Console.WriteLine("\n Raio do círculo: " + c.Raio);
            Console.WriteLine("\n Área do círculo: " + c.CalculaArea());

            Console.WriteLine($"\n Medidas do triângulo: {t.A}, {t.B} e {t.C}");
            Console.WriteLine("\n Área do triângulo: " + t.CalculaArea());

            Console.WriteLine($"\n Medida do quadrado: {q.A}");
            Console.WriteLine("\n Área do quadrado: " + q.CalculaArea());

        }
    }
}
