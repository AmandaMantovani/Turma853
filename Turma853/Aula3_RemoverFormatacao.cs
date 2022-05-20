using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turma853
{
    public class Aula3_RemoverFormatacao
    {
        public static void Mainfa()
        {
            /*
             * Crie um programa que receba um CPF / CNPJ com formatação.
             * Remova a formatação e exiba na tela somente os números.
             */

            Console.WriteLine("Insira um CPF/CNPJ completo: ");
            string doc = Console.ReadLine()!;

            doc = doc.Trim().Replace(".", "").Replace("-", "").Replace("/", "");

            if (doc.Length <= 11)
            {
                Console.WriteLine("CPF: " + doc.PadLeft(11, '0'));
            }
            else
            {
                Console.WriteLine("CNPJ: " + doc.PadLeft(14, '0'));
            }
        }
    }
}
