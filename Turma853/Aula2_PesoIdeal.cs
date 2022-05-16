using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turma853
{
    public class Aula2_PesoIdeal
    {
        public static void Main2()
        {

            /*
             * Faça um programa que recebe a altura e o sexo de uma pessoa e
             * que calcule o seu peso ideal,
             * utilizando a seguinte formula (h = altura)
             *  Para homens: (72.7 * h) - 58
             *  Para mulheres: (62.1 * h) - 44.7
            */


            Console.WriteLine("*Peso ideal*");

            Console.WriteLine("Informe a altura: ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o sexo: ");
            string sexo = Console.ReadLine();

            double resultado = 0;

            /*
            if (sexo.ToUpper() == "F")
            {
                resultado = (62.1D * altura) - 44.7D;
            }
            else if (sexo.ToUpper() == "M")
            {
                resultado = (72.7D * altura) - 58;
            }

            if (sexo.ToUpper() == "F" || sexo.ToUpper() == "M")
            {
                    Console.WriteLine("Peso ideal seria: " + resultado);
            }
            else
            {
                Console.WriteLine("Sexo não registrado");
            }
            */

            switch (sexo.ToUpper())
            {
                case "F":
                    resultado = (62.1D * altura) - 44.7D;
                    Console.WriteLine("Peso ideal seria: " + resultado);
                    break;
                case "M":
                    resultado = (72.7D * altura) - 58;
                    Console.WriteLine("Peso ideal seria: " + resultado);
                    break;
                default:
                    Console.WriteLine("Sexo não registrado");
                    break;
            }

            resultado = sexo.ToUpper() == "F" ? (62.1D * altura) - 44.7D : (72.7D * altura) - 58;


        }
    }
}
