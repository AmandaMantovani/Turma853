using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turma853
{
    public class Correcoes_Danceteria
    {
        public static void MainDance()
        {
            /*
             * Em uma danceteria o preço da entrada sofre variações.
             * Segundas, Terças e Quintas, ela oferece um desconto de 25% do preço normal de entrada.
             * Nos dias de músicas ao vivo, o preço da entrada ainda é
             * acrescido em 15% em relação ao preço normal da entrada.
             * Faça um programa que leia o preço normal da entrada,
             * o dia da semana,e se é dia de música ao vivo (“Sim”) ou não (“Não”).
             * Calcular e imprimir o preço final que deverá ser pago pela entrada.
             */

            const decimal desconto = 0.25M;
            const decimal acrescimo = 0.15M;

            Console.WriteLine("******DANCETERIA******");
            Console.WriteLine("Informe o preço normal da entrada: ");
            decimal precoNormal = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe o dia da semana entre 1 (Domingo) e 7 (Sábado): ");
            int diaSemana = int.Parse(Console.ReadLine());

            Console.WriteLine("Terá música ao vivo? S - Sim / N - Não ");
            bool musicaAoVivo = Console.ReadLine().ToUpper() == "S";

            decimal precoFinal = precoNormal;
            if (diaSemana == 2 || diaSemana == 3 || diaSemana == 5)
            {
                precoFinal -= precoNormal * desconto;
            }

            if (musicaAoVivo)
            {
                precoFinal += precoNormal * acrescimo;
            }

            Console.WriteLine("Valor da entrada: " + precoFinal);



        }
    }
}
