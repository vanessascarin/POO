/*EXERCÍCIO 03:  

Fazer um programa para ler os dados de um produto em estoque (nome, preço e quantidade no estoque). 
Em seguida:   
- Mostrar os dados do produto (nome, preço, quantidade no estoque, valor total no estoque)  
- Realizar uma entrada no estoque e mostrar novamente os dados do produto 
- Realizar uma saída no estoque e mostrar novamente os dados do produto  
Para resolver este problema, você deve criar uma CLASSE conforme projeto explicado em aula.

EXEMPLO DE UM PRODUTO INSTANCIADO: 
Entre os dados do produto:  
Nome: TV  
Preço: 900.00  
Quantidade no estoque: 10  
Dados do produto: TV, $ 900.00, 10 unidades, Total: $ 9000.00 
 Digite o número de produtos a ser adicionado ao estoque:  
5  
Dados atualizados: TV, $ 900.00, 15 unidades, Total: $ 13500.00  
Digite o número de produtos a ser removido do estoque: 
 3  
Dados atualizados: TV, $ 900.00, 12 unidades, Total: $ 10800.0 */

using System;

namespace Exercício3
{
    class Program
    {
        static void Main()
        {
            /*Criando o objeto e preenchendo os atributos*/
            Produto produto1 = new Produto();
            Console.WriteLine("Entre com os dados do produto:");
            Console.WriteLine("Nome:");
            produto1.Nome = Console.ReadLine();
            Console.WriteLine("Preço:");
            produto1.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade no estoque:");
            produto1.Qtde_Estoque = int.Parse(Console.ReadLine());

            /*Mostrar estado do objeto instanciado*/
            produto1.Status_Produto();

            /*Adicionar produto no estoque*/
            produto1.Adicionar_Estoque();

            /*Remover produto do estoque*/
            produto1.Remover_Estoque();

        }
    }
}
