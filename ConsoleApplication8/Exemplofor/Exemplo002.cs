using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplofor
{
    class Exemplo002
    {
        public Exemplo002()
        {
            /*string nome1 = Console.ReadLine();
            string nome2 = Console.ReadLine();
            string nome3 = Console.ReadLine();
            string nome4 = Console.ReadLine();*/
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Console.WriteLine(\"Digite o Nome" + i + ": |);)");
                Console.WriteLine("string nome" + i + " = Console.ReadLine();");
            }
        }
    }
}
