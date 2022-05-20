using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turma853
{
    public class Aula3_Senha
    {

        public static void Mainsenha()
        {
            /*
             * Solicite o nome completo, a data de nascimento e uma senha.
             * Realize uma validação na senha, a mesma não pode conter nome,
             * sobrenomes e/ou da data de nascimento.
             * Peça uma nova senha até que ela seja válida.
             */

            Console.WriteLine("Digite seu nome completo: ");
            string nomeCompleto = Console.ReadLine();

            Console.WriteLine("Digite sua data de nascimento (dd/mm/yyyy): ");
            string dataNascimento = Console.ReadLine();

            bool senhaPermitida;

            do
            {
                senhaPermitida = true;

                Console.WriteLine("Informe uma senha: ");
                string senha = Console.ReadLine();

                string[] nomes = nomeCompleto.Split(" ");
                foreach (string nome in nomes)
                {
                    if (senha.ToUpper().Contains(nome.ToUpper()))
                    {
                        Console.Clear();
                        Console.WriteLine("\nSenha não pode conter nome");
                        senhaPermitida = false;
                        break;
                    }
                }

                if (!senhaPermitida)
                {
                    continue;
                }

                string[] datas = dataNascimento.Split("/");
                foreach (string data in datas)
                {
                    if (senha.ToUpper().Contains(data.ToUpper()))
                    {
                        Console.Clear();
                        Console.WriteLine("\nSenha não pode conter a data de nascimento");
                        senhaPermitida = false;
                        break;
                    }
                }

            } while (!senhaPermitida);

            // Fora do while, proximos códigos.
            Console.WriteLine("Senha cadastrada corretamente.");
            
        }
    }
}
