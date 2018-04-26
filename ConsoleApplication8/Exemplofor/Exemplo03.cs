using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exemplofor
{
    class Exemplo03
    {
        public Exemplo03()
        {
            Console.Write("Tabuada Do: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            
            
            for (int i = -100000; i <= 100000; i++ )
            {
                int multiplicacao = numero * i;
                Console.WriteLine(String.Format("{0} x {1} = {2}", numero, i, multiplicacao));
            }
        }
    }
}
