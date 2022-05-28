using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turma853
{
    public class Correcoes_Eleicao
    {
        public static void MainEleicao()
        {
            /*
             * Sabendo que somente os municípios que possuem mais de 20000 eleitores aptos
             * têm segundo turno nas eleições para prefeito caso o primeiro colocado não tenha
             * mais do que 50% dos votos, fazendo um algoritmo que leia o nome do município,
             * a quantidade de eleitores aptos, o número de votos do candidato mais votado e
             * informar se ele terá ou não segundo turno em sua eleição municipal.
             * Caso não tenha segundo turno, detalhe o motivo.
             */
            const long minimoEleitores = 20000;

            Console.WriteLine("Informe o município: ");
            string municipio = Console.ReadLine();

            Console.WriteLine("Informe a quantidade de eleitores: ");
            long eleitores = long.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de votos do candidato mais votado: ");
            long votosTotais = long.Parse(Console.ReadLine());

            if (eleitores < minimoEleitores)
            {
                Console.WriteLine($"Não haverá segundo turno em {municipio} " +
                                   "devido quantidade de eleitores. Candidato eleito.");
            }
            else if (votosTotais < eleitores / 2)
            {
                Console.WriteLine($"Haverá segundo turno em {municipio}. " +
                                   "Quantidade mínima de votos não atingida para o candidato.");
            }
            else
            {
                Console.WriteLine($"Não haverá segundo turno em {municipio}. " +
                                   "Candidato eleito em primeiro turno acima de 50% dos votos.");
            }
        }
    }
}
