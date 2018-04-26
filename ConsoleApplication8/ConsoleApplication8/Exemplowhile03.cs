using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Exemplowhile03
    {
        static void Main2(string[] args)
        {
            int i = 1;
            while(i < 10)
            {
                if (i %2==0)
                {
                    Console.Write(i + ",");

                }
                i = i + 1;

            }
            Console.Write("Oba: ");

        }
    }
}
