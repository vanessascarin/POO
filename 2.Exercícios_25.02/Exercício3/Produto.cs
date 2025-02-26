using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício3
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Qtde_Estoque;

        public void Status_Produto()
        {
            Console.WriteLine(Nome + ", R$" + Preco + ", " + Qtde_Estoque + " unidades,  Total R$" + (Preco*Qtde_Estoque));
        }

        public void Adicionar_Estoque()
        {
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque:");
            int x = int.Parse(Console.ReadLine());
            Qtde_Estoque += x;
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(Nome + ", R$" + Preco + ", " +  Qtde_Estoque + " unidades,  Total R$" + (Preco*Qtde_Estoque));
        }

        public void Remover_Estoque()
        {
            Console.WriteLine("Digite o número de produtos a ser removido do estoque:");
            int x = int.Parse(Console.ReadLine());
            Qtde_Estoque -= x;
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(Nome + ", R$" + Preco + ", " +Qtde_Estoque + " unidades,  Total R$" + (Preco*Qtde_Estoque));
        }

    }
}
