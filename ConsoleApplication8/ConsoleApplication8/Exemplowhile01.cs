using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Exemplowhile01
    {
        static void Main2(string[] args)
        {
            int alunoatual = 0;
            while(alunoatual  < 18)
            {
                Console.WriteLine("nome: ");
                string nome = Console.ReadLine();
                alunoatual = alunoatual + 1;
            }
        }
    }
}
