using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turma853
{
    public class Aula3_PlanetasSwitch
    {
        public static void Mainplan()
        {
            /*
             * Escreva um programa que leia um peso na Terra e o número de um planeta.
             * Imprima o valor do seu peso neste planeta.
                {1, 0.37}, //Mercúrio
                {2, 0.88}, //Vênus
                {3, 0.38}, //Marte
                {4, 2.64}, //Júpiter
                {5, 1.15}, //Saturno
                {6, 1.17}  //Urano
             * */

            Console.WriteLine("Insira o número do planeta desejado: ");
            Console.WriteLine("\n1. Mercúrio");
            Console.WriteLine("2. Vênus");
            Console.WriteLine("3. Marte");
            Console.WriteLine("4. Júpiter");
            Console.WriteLine("5. Saturno");
            Console.WriteLine("6. Urano");

            int numeroPlaneta = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o peso para conversão: ");
            double peso = double.Parse(Console.ReadLine());

            double gravidade = 0;
            string nomePlaneta = "Planeta inválido";
            switch(numeroPlaneta)
            {
                case 1:
                    gravidade = 0.37;
                    nomePlaneta = "Mercúrio";
                    break;
                case 2:
                    gravidade = 0.88;
                    nomePlaneta = "Vênus";
                    break;
                case 3:
                    gravidade = 0.38;
                    nomePlaneta = "Marte";
                    break;
                case 4:
                    gravidade = 2.64;
                    nomePlaneta = "Júpiter";
                    break;
                case 5:
                    gravidade = 1.15;
                    nomePlaneta = "Saturno";
                    break;
                case 6:
                    gravidade = 1.17;
                    nomePlaneta = "Urano";
                    break;
            }

            Console.WriteLine($"Peso convertido no planeta {nomePlaneta}: {peso * gravidade}");

        }
    }
}
