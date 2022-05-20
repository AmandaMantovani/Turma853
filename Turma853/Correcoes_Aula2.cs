using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turma853
{
    public class Correcoes_Aula2
    {

        public static void Maincc()
        {
            try
            {

                string nome = Console.ReadLine();
                
                if (nome == null)
                    throw new ArgumentNullException("nome");

                nome.Trim();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"O {ex.ParamName} não pode ser nulo");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exceção: " + ex.GetType().Name);

                Console.WriteLine("Mensagem de exceção: " + ex.Message);

                Console.WriteLine("Local do erro: " + ex.StackTrace);
            }
        }

    }
}
