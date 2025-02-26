/*APRENDENDO A MONTAR UMA CLASSE E INSTANCIAR UM OBJETO 

EXERCÍCIO 01: Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha. 

 Exemplo: Dados da primeira pessoa:  
Nome: Maria  
Idade: 17  
Dados da segunda pessoa: 
 Nome: Joao 
 Idade: 16  
Pessoa mais velha: Maria  */

using System;
using System.Diagnostics.Eventing.Reader;

namespace PessoaMaisVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa a = new Pessoa();
            Pessoa b = new Pessoa();
            double area;
            Console.WriteLine("Entre com o nome da primeira pessoa:");
            a.Nome = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a idade da primeira pessoa:");
            a.Idade = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o nome da segunda pessoa:");
            b.Nome = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a idade da primeira pessoa:");
            b.Idade = double.Parse(Console.ReadLine());
            if (a.Idade - b.Idade > 0)
                Console.WriteLine("Pessoa mais velha: " + a.Nome);
            else if (a.Idade = b.Idade)
                Console.WriteLine("Ambos têm a mesma idade.");
            else
                Console.WriteLine("Pessoa mais velha: " + b.Nome);
            Console.ReadLine();
            Console.ReadKey();
        }

    }
}
