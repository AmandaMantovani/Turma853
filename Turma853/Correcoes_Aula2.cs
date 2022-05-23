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
            Dictionary<string, string> gentilicos = new Dictionary<string, string>();
            gentilicos.Add("SP", "Paulista");
            gentilicos.Add("PB", "Pernambucano");

            var teste = gentilicos["SP"];

        }

    }
}
