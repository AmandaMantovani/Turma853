using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turma853
{
    public class Correcoes_Mercado
    {
        public static void MainMercado()
        {
            /*
             * Faça um programa para um caixa de mercado que imprima um recibo de compras.
             * O programa deve receber a compra de 6 itens,
             * sendo informado o nome do produto e a quantidade de cada um.
             * Exiba o valor total de cada produto comprado e
             * o valor total das compras de todos os produtos.
             */
            const int itensTotal = 6;

            Dictionary<string, decimal> tabelaItens = new Dictionary<string, decimal>()
            {
                { "Banana", 1.6M },
                { "Maçã", 1.9M },
                { "Pipoca", 4.2M },
                { "Pão Francês", 1.2M },
                { "Coca-Cola", 10M },
                { "Iogurte 1L", 6.3M },
                { "Caixa de Chocolate", 8M },
                { "Amendoim", 3.75M },
            };

            Dictionary<string, decimal> compra = new Dictionary<string, decimal>();
            decimal totalCompra = 0;
            for (int i = 0; i < itensTotal; i++)
            {
                string item;
                decimal valor = 0;
                do
                {
                    Console.WriteLine("Informe o item ");
                    item = Console.ReadLine()!;
                } while (!tabelaItens.TryGetValue(item, out valor));

                Console.WriteLine("Informe a quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());
                decimal valorTotalItem = quantidade * valor;
                compra.Add(item, valorTotalItem);
                totalCompra += valorTotalItem;
            }

            Console.Clear();
            Console.WriteLine("Compra realizada: ");
            foreach (var item in compra)
            {
                Console.WriteLine($"Item {item.Key} Valor Total {item.Value}");
            }
            Console.WriteLine("\nValor total da compra: " + totalCompra);

        }
    }
}
