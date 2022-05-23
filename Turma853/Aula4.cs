using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turma853
{
    public class Aula4
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Digite uma nota");
                float nota = float.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exceção: " + ex.GetType().Name);

                Console.WriteLine("Mensagem de exceção: " + ex.Message);

                Console.WriteLine("Local do erro: " + ex.StackTrace);
            }
            //try
            //{
            //    Console.WriteLine("Informe um número: ");
            //    int numero = int.Parse(Console.ReadLine());

            //    int resultado = 100 / numero;

            //    Console.WriteLine(resultado);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Valor digitado inválido!");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Numero não pode ser zero!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Exceção: " + ex.GetType().Name);

            //    Console.WriteLine("Mensagem de exceção: " + ex.Message);

            //    Console.WriteLine("Local do erro: " + ex.StackTrace);
            //}

            //int[] vetor = new int[5];
            //try
            //{
            //    while (true)
            //    {
            //        Console.WriteLine("Informe a posição do vetor ou -1 para sair");
            //        int posicao = int.Parse(Console.ReadLine());
            //        if (posicao == -1) break;

            //        Console.WriteLine("Informe o valor desejado: ");
            //        int valor = int.Parse(Console.ReadLine());

            //        vetor[posicao] = valor;
            //    }
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("O vetor não possui a posição informada.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Exceção: " + ex.GetType().Name);

            //    Console.WriteLine("Mensagem de exceção: " + ex.Message);

            //    Console.WriteLine("Local do erro: " + ex.StackTrace);
            //}
            //try
            //{
            //    try
            //    {
            //        string nome = null;
            //        int? idade = null;

            //        if (nome == null)
            //            throw new ArgumentNullException("nome");

            //        if (idade == null)
            //            throw new ArgumentNullException("idade");

            //        nome.Trim();
            //        nome.Replace(",", "");
            //    }
            //    catch (ArgumentNullException e)
            //    {
            //        Console.WriteLine($"O {e.ParamName} não pode ser nulo");
            //        throw e;
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Exceção: " + ex.GetType().Name);

            //        Console.WriteLine("Mensagem de exceção: " + ex.Message);

            //        Console.WriteLine("Local do erro: " + ex.StackTrace);
            //    }
            //    finally
            //    {
            //        Console.WriteLine("Finally");
            //    }
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("exceção fora");
            //}
            /// Código
        }
    }
}
