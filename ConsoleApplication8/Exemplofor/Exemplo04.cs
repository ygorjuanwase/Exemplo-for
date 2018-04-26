using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplofor
{
    class Exemplo04
    {
        public Exemplo04()
        {
            for (int i = 0; i <=10; i++)
            {
                for (int numero = 0; numero <= 10; numero++ )
                {
                    int multiplicacao = numero * i;
                    Console.WriteLine(String.Format("{0} x {1} = {2}", numero, i, multiplicacao));
                }
                
              

            }
        }
    }
}
