using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turma853
{
    public class Correcoes_Prestacoes
    {

        public static void MainPrestacoes()
        {
            /*
             * A loja Mamão com Açúcar está vendendo seus produtos em cinco prestações sem juros,
             * para compras até R$ 500,00 e em oito prestações sem juros, para compras acima de R$500,00.
             * Faça um programa que receba um valor de uma compra e mostre o valor das prestações.
             */

            Console.WriteLine("Bem vindo a loja mamão com açúcar");
            Console.WriteLine("Informe o valor total da compra: ");
            decimal valorCompra = decimal.Parse(Console.ReadLine());

            int prestacoes = valorCompra < 500 ? 5 : 8;

            Console.WriteLine($"Compra parcelada em {prestacoes}x de {valorCompra / prestacoes}.");
        }
    }
}
