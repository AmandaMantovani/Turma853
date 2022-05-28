using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turma853
{
    public class Correcoes_AnoBissexto
    {

        public static void MainAno()
        {
            /*
             * Determine se um determinado ano lido é bissexto.
             * Aplique as regras abaixo conforme exemplificado pela Microsoft:

                1 Se o ano for uniformemente divisível por 4, vá para a etapa 2. Caso contrário, vá para a etapa 5.
                2 Se o ano for uniformemente divisível por 100, vá para a etapa 3. Caso contrário, vá para a etapa 4.
                3 Se o ano for uniformemente divisível por 400, vá para a etapa 4. Caso contrário, vá para a etapa 5.
                4 O ano é bissexto (tem 366 dias).
                5 O ano não é um ano bissexto (tem 365 dias).
             */

            /*
             * Console.WriteLine("Digite um ano: ");
             * int ano = int.Parse(Console.ReadLine());
             * 
             * As opções abaixo foram feitas para validar o código
            */

            List<int> anosBissextos = new List<int>()
            {
                1988, 1992, 1996, 2000, 2004, 2008, 2012, 2016, 2020, 2024, 2028
            };
            foreach (var ano in anosBissextos)
            {
                bool divisivel4 = ano % 4 == 0;
                bool divisivel100 = ano % 100 == 0;
                bool divisivel400 = ano % 400 == 0;

                if ((divisivel4 && divisivel100 && divisivel400) ||
                    (divisivel4 && !divisivel100))
                {
                    Console.WriteLine("Ano bissexto");
                }
                else
                {
                    Console.WriteLine("Ano não é bissexto");
                }
            }
            Console.WriteLine("");
            List<int> anosNBissextos = new List<int>()
            {
                1989, 1991, 1997, 2002, 2006, 2009, 2011, 2013, 2017
            };
            foreach (var ano in anosNBissextos)
            {
                bool divisivel4 = ano % 4 == 0;
                bool divisivel100 = ano % 100 == 0;
                bool divisivel400 = ano % 400 == 0;

                if ((divisivel4 && divisivel100 && divisivel400) ||
                    (divisivel4 && !divisivel100))
                {
                    Console.WriteLine("Ano bissexto");
                }
                else
                {
                    Console.WriteLine("Ano não é bissexto");
                }
            }

        }
    }
}
