using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turma853
{
    public class Aula3_SomaAlgarismos
    {
        public static void MainAlga()
        {
            /*
             * Escreva um programa que leia um número inteiro maior do que zero
             * e devolva, na tela, a soma de todos os seus algarismos.
             * Por exemplo, ao número 251 corresponderá o valor 8 (2 + 5 + 1).
             * Se o número lido não for maior do que zero,
             * o programa terminará com a mensagem “Número inválido”.
             * */

            Console.WriteLine("Digite um número inteiro positivo: ");
            int numeroDigitado = int.Parse(Console.ReadLine());

            if (numeroDigitado > 0)
            {
                double soma = 0;
                foreach(char caracter in numeroDigitado.ToString())
                {
                    soma += char.GetNumericValue(caracter);
                    //soma += int.Parse(caracter.ToString());
                }
                Console.WriteLine(soma);
            }
            else
            {
                Console.WriteLine("Número inválido");
            }
        }
    }
}
