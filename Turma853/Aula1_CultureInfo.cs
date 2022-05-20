using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turma853
{
    public class Aula1_CultureInfo
    {
        public static void Mainc()
        {
            decimal valor = 1.74M;
            Console.WriteLine("Cultura padrão {0}.", CultureInfo.CurrentCulture.Name);
            Console.WriteLine(valor);

            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);


            Console.WriteLine("Nova cultura padrão {0}.", CultureInfo.CurrentCulture.Name);
            Console.WriteLine(valor);
        }
    }
}
