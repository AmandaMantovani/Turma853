using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turma853
{
    public class Correcoes_Banco
    {

        public static void MainBanco()
        {
            /*
             * Faça um programa que apresente quatro opções:
             * (a) consulta saldo, (b) saque, (c) depósito e (d) sair.
             * O saldo deve iniciar em R$ 0,00.
             * A cada saque ou depósito o valor do saldo deve ser atualizado e apresentado na tela.
             */

            Console.WriteLine("Bem-vindo ao Banco: ");
            decimal saldo = 0;
            do
            {
                Console.WriteLine("\n Escolha uma opção: ");
                Console.WriteLine("a -> Consultar Saldo ");
                Console.WriteLine("b -> Realizar Saque ");
                Console.WriteLine("c -> Realizar Depósito ");
                Console.WriteLine("d -> Sair ");
                string opcao = Console.ReadLine();

                bool mostraSaldo = false;
                switch (opcao.ToLower())
                {
                    case "a":
                        mostraSaldo = true;
                        break;
                    case "b":
                        Console.WriteLine("Informe o valor do saque: ");
                        decimal saque = decimal.Parse(Console.ReadLine());
                        if (saldo < saque)
                        {
                            Console.WriteLine("Não há saldo para este saque");
                        }
                        else
                        {
                            saldo -= saque;
                        }
                        mostraSaldo = true;
                        break;
                    case "c":
                        Console.WriteLine("Informe o valor do depósito: ");
                        saldo += decimal.Parse(Console.ReadLine());
                        mostraSaldo = true;
                        break;
                }

                if (mostraSaldo)
                {
                    Console.WriteLine($"Seu saldo atual é {saldo}");
                }
                else
                {
                    break;
                }

            } while (true);

        }
    }
}
