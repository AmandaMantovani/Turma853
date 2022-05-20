using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turma853
{
    public class Aula3_InserirFormatacao
    {
        public static void Mainis()
        {
            /*
             * Crie um programa que receba um CPF/CNPJ somente numéricos.
             * A partir do valor lido, identifique se este valor se encaixa em um CPF ou em um CNPJ.
             * Realiza a formatação adicionando os caracteres especiais e exiba na tela.
             */
            Console.WriteLine("Insira um CPF/CNPJ somente númerico: ");
            string doc = Console.ReadLine();

            if (doc.Length <= 11)
            {
                doc = doc.PadLeft(11, '0')
                         .Insert(3, ".")
                         .Insert(7, ".")
                         .Insert(11, "-");

                Console.WriteLine($"CPF formatado: {doc}");
            }
            else
            {
                doc = doc.PadLeft(14, '0')
                         .Insert(2, ".")
                         .Insert(6, ".")
                         .Insert(10, "/")
                         .Insert(15, "-");

                Console.WriteLine($"CNPJ formatado: {doc}");
            }

        }
    }
}
