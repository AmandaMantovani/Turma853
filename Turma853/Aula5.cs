using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turma853
{
    public class Aula5
    {
        static void Main(string[] args)
        {
            //1)
            //Estruturas de Repetição
            // Exemplo: Lançamentos que compõem o mês.
            // Preciso varrer esses lançamentos.
            // A grande questão que fica é: 
            // Quando usar o For ou quando usar While ou Do-While?
            // Se eu souber, a priori, quantas vezes eu preciso repetir a
            // a operação, isso me leva para o FOR.
            // Se eu não souber exatamente quantas vezes eu preciso
            // repetir a operação, então neste caso, a gente segue
            // para o WHILE ou DO-WHILE. Então a ideia não é a quantidade
            // de vezes mas a CONDIÇÃO DE PARADA.
            //for
            //sintaxe: contador: contar o número de iterações
            /*int i = 0;
            for(i=0; i<=10; i+=2) //repetir 100 vezes o que estiver dentro do for
            {
                Console.WriteLine(i.ToString());
            }
            */
            /*int i = 0;
            for (i = 10; i > 0; i--) //repetir 100 vezes o que estiver dentro do for
            {
                Console.WriteLine(i.ToString());
            }*/
            //Exemplo: Receba 5 valores e calcule a média
            /*
            int N = 5;
            double soma = 0;
            double media = 0;
            for(int i=0; i<N; i++) //eu já sei quantas notas esperar
            {
                double nota = 0; //recebe a nota
                //tentativa de conversão
                bool ret = double.TryParse(Console.ReadLine(), out nota);
                if(ret) //caso a conversão tenha sido feito com sucesso
                {
                    soma += nota;
                }
            }
            media = soma / N;
            Console.WriteLine("Média: " + media.ToString());
            */
            //Exemplo: Receba 5 valores inteiros positivos e retorno o maior valor informado
            //int N = 5;
            //encontrar o maior valor é fazendo comparações a cada valor recebido
            //se o valor lido agora é maior que o máximo valor, troque o valor do 
            //máximo pelo valor lido
            //int maiorValor = -1; //armazena o máximo valor encontrado na sequência
            //for(int i=0; i<N; i++)
            //{
            //    int valor = 0;
            //    bool ret = int.TryParse(Console.ReadLine(), out valor);
            //    if(ret) //se conseguiu converter
            //    {
            //        //se o valor presente for maior que o maior atual, faça a troca
            //        if (valor > maiorValor) 
            //        {
            //            maiorValor = valor;
            //        }
            //    }
            //}
            //Console.WriteLine("O maior valor é: " + maiorValor.ToString());


            //while: testa a condição e executa o código
            //sintaxe do while
            //exemplo: limite máximo de gastos no mês: R$ 1000,00
            //então, toda vez que eu for fazer uma compra, quero saber
            //se posso comprar ou não. se eu não tiver mais dinheiro, 
            //então, não faço nenhuma compra mais.
            //int valorMax = 100;
            //int valorMin = 10;
            //int valorTotal = 0;
            ////a condição do while está testando se eu ainda tenho dinheiro suficiente
            ////para comprar pelo menos um item de acordo com seu valor mínimo
            //while(valorTotal+valorMin < valorMax)
            //{
            //    int valor = 0;
            //    bool ret = int.TryParse(Console.ReadLine(), out valor);
            //    if(ret)
            //    {
            //        //verificando se eu tenho dinheiro suficiente para realizar a compra desejada
            //        if (valorTotal + valor <= valorMax)
            //            valorTotal += valor; //se conseguimos comprar, aumentamos o valor total
            //        else
            //            Console.WriteLine("Não temos dinheiro suficiente para comprar");
            //    }
            //    Console.WriteLine("Valor total no momento: " + valorTotal.ToString());
            //}
            //Console.WriteLine("Não posso mais comprar. Valor Total: " + valorTotal.ToString());

            //do-while: executar o código e depois testar a condição
            //exemplo: número secreto: 42, perguntar para o usuário um número até que ele
            //acerte o valor secreto
            //int numero = 0;
            //int secreto = 42;
            //do
            //{
            //    Console.WriteLine("Entre com um numero da sorte");
            //    bool ret = int.TryParse(Console.ReadLine(), out numero);
            //    if(numero != secreto)
            //    {
            //        Console.WriteLine("Errou!");
            //    }

            //} while (numero != secreto);
            //Console.WriteLine("Acertou!");

            //Exemplo: usuário precisa entrar com um número válido inteiro
            //int nroMinParaSerValido = 10;
            //while(true) //laço infinito: ele sempre vai rodar independente de qualquer coisa
            //{
            //    int numero = 0;
            //    bool ret = int.TryParse(Console.ReadLine(), out numero);
            //    if(ret) //foi possível converter a entrada para um número
            //    {
            //        if(numero > nroMinParaSerValido) //estou testando a validade final
            //        {
            //            Console.WriteLine("Ok, número válido!"); //ok, está válido!
            //            break; //forçando o laço while a encerrar!
            //        }
            //        else
            //        {
            //            Console.WriteLine("O valor mínimo a ser informado é 10. Por favor, entre com outro número");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Por favor, entre com um número");
            //    }
            //}


            //2)
            //Arrays
            //Arrays unidimensionais: vetor
            //[0, 1, 2, 3, 4, 5]
            //Analogia: Rua com casas e cada casa possui o seu endereço
            //inicialização
            //int[] valor; //declaração sem atribuição | vazia | identificação que "valor" é um vetor
            //int[] valor2 = new int[4]; //declaração com inicialização, já determinando o número de valores armazenados
            //int[] valor3 = new int[3] { 0, 1, 2 }; //declaração com inicialização, sinalizando os valores iniciais
            ////acesso
            ////posições inicializam no index = 0.
            //int valor4 = valor3[1]; //posição 0 (primeira posição) do vetor valor3
            //int valor5 = valor3[1]; //posição 1 (segunda posição) do vetor valor3
            //valor3[2] = 100; //atribuir um novo valor para o vetor
            ////montar uma estrutura de repetição para printar os valores dentro do vetor
            ////FOR possui uma sinergia muito grande com arrays
            ////propriedade Length: boa para evitar reescrever código por conta de alteração no tamanho do vetor
            //for (int i = 0; i < valor3.Length; i++) //for(int i=0; i<3; i++)
            //{
            //    Console.WriteLine(valor3[i].ToString());
            //}
            //Erros Comuns
            //Index out of range: tomar cuidado com o índice passado para acesso ao vetor
            //limites
            //limite inferior: índice = 0
            //limite superior: índice = Length
            //int valor6 = valor3[10];
            //Caso nulo
            //int valor7 = valor[1];

            //Arrays bidimensionais: matriz
            //Analogia: Várias ruas, cada rua com a sua casa e o endereço é dado por: Rua, Posição na Rua
            //[ 0 1 2 ]
            //[ 3 4 5 ]
            //[ 6 7 8 ]
            //no caso da matriz, os índices correspodem a [linha, coluna]
            //criar a matriz com tamanho definido
            //int[,] matriz = new int[3, 3];
            //matriz[0, 0] = 0;
            //matriz[0, 1] = 1;
            //matriz[0, 2] = 2;
            //matriz[2, 2] = 100;
            ////varrer a matriz para imprimir os valores
            //for (int i = 0; i < matriz.GetLength(0); i++)//for(int i=0; i<3; i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)//for(int j=0; j<3; j++)
            //    {
            //        Console.Write(matriz[i, j].ToString() + " ");
            //    }
            //    Console.Write("\n");
            //}


            //Exemplo: array com 5 valores, quero encontrar o máximo
            //int[] vetor = new int[5] { -10, -4, -12, -40, -100 };
            //int maximo = int.MinValue;
            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    if (vetor[i] > maximo)
            //        maximo = vetor[i];
            //}
            //Console.WriteLine("O máximo dentro do vetor é: " + maximo.ToString());


            //3)
            //Dicionário
            //Estrutura de dados
            //Útil sempre que for identificada a relação 1x1 entre um dado e outro
            //Dicionário funciona com base em Chave e Valor
            //Criar um dicionário
            //Dictionary<int, double> myDict = new Dictionary<int, double>(); //inicialização
            //myDict.Add(10, -10.0); //adicionando um valor baseado na chave
            //myDict.Add(20, -30.0); //adicionando um valor baseado na chave
            //myDict[10] = 100;
            ////acesso
            //Console.WriteLine(myDict[20]);
            ////fazer um teste para verificar se a chave já existe no dicionário
            //int chaveProcurada = 100;
            //bool ret = myDict.ContainsKey(chaveProcurada);
            //if (ret)
            //    Console.WriteLine("A chave " + chaveProcurada.ToString() + " existe!");
            //else
            //    Console.WriteLine("A chave " + chaveProcurada.ToString() + " não existe!");

            ////varrer as chaves para recuperar os valores
            //foreach (int vchave in myDict.Keys)
            //{
            //    Console.WriteLine(vchave.ToString() + " " + myDict[vchave].ToString());
            //}

            //EXEMPLO
            //Você possui uma carteira de ações e você vai receber uma sequência de transações
            //Ao final das transações, printe o conteúdo da carteira
            Dictionary<string, int> carteiraAcoes = new Dictionary<string, int>();
            //chave: PETR4, ITUB4, MGLU3, ITSA4
            //valor: número de ações acumuladas daquele ticker
            //transações (string): Ticker  C/V  int (número de ações)
            while (true)
            {
                string transacao = Console.ReadLine();
                if (transacao == "fim") //encerrar operação
                    break;

                string[] dadosTransacao = transacao.Split(" ");
                string ticker = dadosTransacao[0];
                string compra_venda = dadosTransacao[1];
                string numeroAcoes = dadosTransacao[2];

                //primeira coisa é verificar: a empresa já existe dentro da carteira?
                bool ret = carteiraAcoes.ContainsKey(ticker);
                if (!ret) //se não existe a chave, vamos criar este item na carteira
                {
                    carteiraAcoes.Add(ticker, Convert.ToInt32(numeroAcoes));
                }
                else //atualizar o número de ações
                {
                    if (compra_venda == "C") //indica compra, então vamos adicionar o número
                    {
                        carteiraAcoes[ticker] += Convert.ToInt32(numeroAcoes); //somar as ações compradas
                    }
                    else if (compra_venda == "V") // indica venda, então vamos subtrair o número
                    {
                        carteiraAcoes[ticker] -= Convert.ToInt32(numeroAcoes); //subtrair as ações compradas
                    }
                }
            }

            //vamos printar o conteúdo da nossa carteira
            foreach (string chaveTicker in carteiraAcoes.Keys)
            {
                Console.WriteLine(chaveTicker.ToString() + ": " + carteiraAcoes[chaveTicker].ToString());
            }

        }
    }
}
