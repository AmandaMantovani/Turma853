using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turma853
{
    public class Correcoes_Investimento
    {

        public static void Main()
        {
             /*

             * Enunciado do Problema

             * Um cliente realizou um investimento inicial de R$ 250.000,00 em um fundo de investimento.

             1) Receba o rendimento do fundo (em %) ao longo dos últimos 6 meses.

             2) Calcule para cada mês o valor em carteira (R$) de acordo com o rendimento. Imprima o valor da carteira, mês a mês, nos últimos 6 meses. Mês id: Valor Carteira (R$)

             3) Encontre o mês em que ocorreu o maior valor da carteira. Imprima mês e o valor.

             4) Encontre o mês em que ocorreu o menor valor da carteira. Imprima mês e o valor.

             5) Conte o número de meses em que o valor da carteira superou o aporte inicial.

            */

​

            //investimento inicial

            double investimentoInicial = 250000;

            int Nmeses = 6; //número de meses

​

​

            //1) receber o rendimento            

            double[] rendimentos = new double[Nmeses];

            //laço para ler o rendimento dos N meses

            for (int i = 0; i < Nmeses; i++)

            {

                double valRendimento = 0; //inicialização do rendimento

                bool ret = false; //variável para verificar se a entrada é válida

                while (ret == false) //enquanto a conversão não for bem sucedida, seguimos pedindo o rendimento

                {

                    //escrever mensagem no console

                    Console.Write("Entre com o rendimento do mês " + (i + 1).ToString() + ": ");

                    //ler valor do console e tentar converter para double

                    ret = double.TryParse(Console.ReadLine(), out valRendimento);

                    if (ret) //caso a conversão seja bem sucedida

                        rendimentos[i] = valRendimento; //salvar o rendimento no array

                }

            }

​

​

            //2) calcular o valor da carteira para cada mês e printar na tela

            double[] valorCarteira = new double[Nmeses];

            //laço para varrer os meses

            for (int i = 0; i < Nmeses; i++)

            {

                //encontrar o fator pelo qual o valor da carteira deve ser multiplicado

                //para encontrar o valor final da carteira

                //considerando que os rendimentos são em %

                double fatorRend = 1.0 + (rendimentos[i] / 100);

​

                if (i > 0) //se for para meses posteriores ao primeiro

                {

                    //neste caso, o rendimento se dá baseado no valor acumulado da carteira (do último mês)

                    valorCarteira[i] = valorCarteira[i - 1] * fatorRend;

                }

                else //para o primeiro mês

                {

                    //neste caso, o rendimento se dá baseado no valor do investimento inicial

                    valorCarteira[i] = investimentoInicial * fatorRend;

                }

​

                //printar o mês e o valor na carteira

                Console.WriteLine("Mês " + (i + 1).ToString() + " - Valor Carteira (R$): " + valorCarteira[i]);

            }

​

​

            //3) encontrar o mês de maior valor da carteira

            double maiorValor = double.MinValue; //inicializar uma variável para buscar o maior valor da carteira

            int mesMaiorValor = 0; //variável para armazenar o mês de maior valor

            //laço para varrer os meses

            for (int i = 0; i < Nmeses; i++)

            {

                //para cada valor mensal da carteira, vamos verificar se este valor é maior que o maior valor encontrado

                //até então

                if (valorCarteira[i] > maiorValor) //se for maior, então atualizamos as variáveis

                {

                    mesMaiorValor = (i + 1); //atualizar o mês

                    maiorValor = valorCarteira[i]; //atualizar o maior valor encontrado

                }

            }

            //printar o mês e o valor da carteira

            Console.WriteLine("Valor Máximo de R$ " + maiorValor.ToString() + " ocorreu no mês " + mesMaiorValor.ToString());

​

​

            //4) encontrar o mês de menor valor da carteira

            double menorValor = double.MaxValue; //inicializar uma variável para buscar o menor valor da carteira

            int mesMenorValor = 0; //variável para armazenar o mês de menor valor

            //laço para varrer os meses

            for (int i = 0; i < Nmeses; i++)

            {

                //para cada valor mensal da carteira, vamos verificar se este valor é menor que o menor valor encontrado

                //até então

                if (valorCarteira[i] < menorValor) //se for menor, então atualizamos as variáveis

                {

                    mesMenorValor = (i + 1); //atualizar o mês

                    menorValor = valorCarteira[i];  //atualizar o menor valor encontrado

                }

            }

            //printar o mês e o valor da carteira

            Console.WriteLine("Valor Mínimo R$ de " + menorValor.ToString() + " ocorreu no mês " + mesMenorValor.ToString());

​

​

            //5) contar número de vezes que a carteira foi superior ao valor inicial

            int nroMesesPositivo = 0; //variável para armazenar o número de meses positivos

            //laço para varrer os meses

            for (int i = 0; i < Nmeses; i++)

            {

                //para cada valor mensal da carteira, verificar se é maior que o valor inicial do investimento

                if (valorCarteira[i] > investimentoInicial) //se for maior, contamos como mês positivo

                    nroMesesPositivo++;

            }

            //printar a resposta

            Console.WriteLine("Número de meses positivos: " + nroMesesPositivo.ToString());

        }
    }
}
