/* APRENDENDO A MONTAR UMA CLASSE E INSTANCIAR UM OBJETO 

EXERCÍCIO 01: Fazer um programa para ler os dados de duas pessoas, 
depois mostrar o nome da pessoa mais velha. 
 Exemplo: Dados da primeira pessoa:  
Nome: Maria  
Idade: 17  
Dados da segunda pessoa: 
 Nome: Joao 
 Idade: 16  
Pessoa mais velha: Maria  */

using System;

namespace Exercício1
{
    class Program
    {
        static void Main()
        {
            /*Criando os objetos e preenchendo os atributos*/
            Pessoa a = new Pessoa();
            Pessoa b = new Pessoa();
            Console.WriteLine("Entre com o nome da primeira pessoa:");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Entre com a idade da primeira pessoa:");
            a.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora, entre com o nome da segunda pessoa:");
            b.Nome = (Console.ReadLine());
            Console.WriteLine("Entre com a idade da segunda pessoa:");
            b.Idade = int.Parse(Console.ReadLine());

            /*Calculando a diferença de idade*/
            if (a.Idade == b.Idade)
            {
                Console.WriteLine("Ambos " + a.Nome + " e " + b.Nome + " têm a mesma idade.");
            }
            else if (a.Idade > b.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + a.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + b.Nome);
            }


        }
    }
}