using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turma853
{
    public class Aula3_Media
    {
        public static void MainMedia()
        {
            /*
             * Faça um programa que leia 2 notas de um aluno,
             * verifique se as notas são válidas e exiba na tela a média destas notas.
             * Uma nota válida deve ser, obrigatoriamente, um valor entre 0.0 e 10.0,
             * onde caso a nota não possua um valor válido, este fato deve ser informado ao usuário
             * e o programa termina.
             * */

            const int NUM_NOTAS = 2;
            decimal soma = 0;
            bool notaValida = false;

            for (int i = 1; i <= NUM_NOTAS; i++)
            {
                Console.WriteLine($"Digite a nota {i}: ");
                notaValida = decimal.TryParse(Console.ReadLine(), out decimal nota);
                if (notaValida && nota >= 0 && nota <= 10)
                {
                    soma += nota;
                }
                else
                {
                    Console.Write("Nota inválida!");
                    return;
                }
            }

            Console.WriteLine($" Média final: { soma / NUM_NOTAS }");
        }
    }
}
