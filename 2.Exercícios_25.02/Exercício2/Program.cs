/*EXERCÍCIO 02: Fazer um programa para ler nome e salário de dois funcionários. 
 Depois, mostrar o salário médio dos funcionários. 
 Exemplo:  
Dados do primeiro funcionário:  
Nome: Carlos Silva  
Salário: 6300.00  
Dados do segundo funcionário:  
Nome: Ana Marques 
 Salário: 6700.00 
 Salário médio = 6500.0 */

using System;

namespace Exercício2
{
    class Program
    {
        static void Main()
        {
            /*Criando os objetos e preenchendo os atributos*/
            Funcionario a = new Funcionario();
            Funcionario b = new Funcionario();
            Console.WriteLine("Dados do primeiro funcionário:");
            Console.WriteLine("Nome:");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Salário:");
            a.Salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados do segundo funcionário:");
            Console.WriteLine("Nome:");
            b.Nome = Console.ReadLine();
            Console.WriteLine("Salário:");
            b.Salario = double.Parse(Console.ReadLine());

            /*Calculando média salarial*/
            double media = (a.Salario + b.Salario) / 2;
            Console.WriteLine("Salário médio: " + media);
        }
    }
}