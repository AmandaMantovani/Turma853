using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turma853
{
    public class Aula2_ValorVenda
    {
        public static void Main3()
        {

            /*
             * Um comerciante comprou um produto e quer vende-lo com um lucro de 45%
             * se o valor da compra for menor que R$20,00;
             * caso contrário, o lucro será de 30%.
             * Entrar como valor do produto e imprimir o valor da venda.
            */


            Console.WriteLine("Valor venda");

            Console.WriteLine("Informe o valor do produto: ");
            double valorProduto = double.Parse(Console.ReadLine());

            //(condicao ? verdadeiro : falso)
            
            double percentualLucro = valorProduto < 20 ? 45 : 30;
            /*
            if (valorProduto < 20)
            {
                percentualLucro = 45;
            }
            else
            {
                percentualLucro = 30;
            }
            */

            double valorVenda = valorProduto + (valorProduto * percentualLucro / 100);

            Console.WriteLine("Valor da venda do produto: " + valorVenda);

        }
    }
}
