using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turma853
{
    public class Aula3_Planetas
    {
        public static void Mainplan()
        {
            /*
             * Escreva um programa que leia um peso na Terra e o número de um planeta.
             * Imprima o valor do seu peso neste planeta.
             * */

            Dictionary<int, double> gravidadePlanetas = new Dictionary<int, double>();
            gravidadePlanetas.Add(1, 0.37); // Mercúrio
            gravidadePlanetas.Add(2, 0.88); // Vênus
            gravidadePlanetas.Add(3, 0.38); // Marte
            gravidadePlanetas.Add(4, 2.64); // Jupiter
            gravidadePlanetas.Add(5, 1.15); // Saturno
            gravidadePlanetas.Add(6, 1.17); // Urano

            Console.WriteLine("Insira o número do planeta desejado: ");
            Console.WriteLine("\n1. Mercúrio");
            Console.WriteLine("2. Vênus");
            Console.WriteLine("3. Marte");
            Console.WriteLine("4. Júpiter");
            Console.WriteLine("5. Saturno");
            Console.WriteLine("6. Urano");

            int numeroPlaneta = int.Parse(Console.ReadLine());

            if (!gravidadePlanetas.TryGetValue(numeroPlaneta, out double gravidade))
            {
                Console.WriteLine("Planeta inválido");
                //Environment.Exit(0);
                return;
            }

            Console.WriteLine("Insira o peso para conversão: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine($"Peso convertido no planeta {numeroPlaneta}: {peso * gravidade}");

        }
    }
}
