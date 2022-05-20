using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turma853
{
    public class Aula3_Emprestimo
    {
        public static void MainEmp()
        {
            /*
             * Leia o salario de um trabalhador e o valor da prestação de um empréstimo.
             * Se a prestação for maior que 20% do salário imprima: Empréstimo não concedido,
             * caso contrário imprima: Empréstimo concedido.
             * */

            Console.WriteLine("Digite seu salário:");
            decimal salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a prestação de um empréstimo: ");
            decimal prestacao = decimal.Parse(Console.ReadLine());


            string emprestimo = prestacao > salario * 0.2M ? "não " : "";
            Console.WriteLine($"Empréstimo {emprestimo}concedido");

            
        }
    }
}
