using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVetor
{
    class Exemplo01
    {
        public Exemplo01()
        {
            // 6 pôneis
            // Cor
            // nome
            // fofimho
            // corCrista

            string[] cores = new string[6];
            string[] nomes = new string[6];
            bool[] fofinhos = new bool[6];
            string[] coresCristas = new string[6];

            Console.WriteLine("Ponei 01\ncor: ");
            cores[0] = Console.ReadLine();
            Console.Write("Nome: ");
            nomes[0] = Console.ReadLine();
            Console.Write("Fofinho?: ");
            string fofinho = Console.ReadLine().ToLower();
            /*if (fofinho == "sim")
            {
                fofinho[0] = true;
            }
            else
            {
                fofinho[0] = false;
            }*/

            fofinhos[0] = fofinho == "sim";
            Console.Write("Cor Da Crista: ");
            coresCristas[0] = Console.ReadLine();

            Console.Clear();


            Console.Write("ponei 01\nCor: ");
            cores[1] = Console.ReadLine();
            Console.Write("Nome: ");
            nomes[1] = Console.ReadLine().ToLower();
            Console.Write("Fofinho?: ");
            fofinho = Console.ReadLine();
            fofinhos[1] = fofinho == "Sim";
            Console.Write("Cor Da Crista: ");
            coresCristas[1] = Console.ReadLine();

            Console.Clear();
            Console.Write("Ponei 02\nCor: ");
            cores[2] = Console.ReadLine();
            Console.Write("Nome: ");
            nomes[2] = Console.ReadLine();
            Console.Write("Fofinho?: ");
            fofinho = Console.ReadLine().ToLower();
            fofinhos[2] = fofinho == "Sim";
            Console.Write("Cor Da Crista: ");
            coresCristas[2] = Console.ReadLine();

            Console.Write("ponei 03\nCor: ");
            cores[3] = Console.ReadLine();
            Console.Write("Nome: ");
            nomes[3] = Console.ReadLine().ToLower();
            Console.Write("Fofinho?: ");
            fofinho = Console.ReadLine();
            fofinhos[3] = fofinho == "Sim";
            Console.Write("Cor Da Crista: ");
            coresCristas[3] = Console.ReadLine();

            Console.Clear();
            Console.Write("Ponei 04\nCor: ");
            cores[4] = Console.ReadLine();
            Console.Write("Nome: ");
            nomes[4] = Console.ReadLine();
            Console.Write("Fofinho?: ");
            fofinho = Console.ReadLine().ToLower();
            fofinhos[4] = fofinho == "Sim";
            Console.Write("Cor Da Crista: ");
            coresCristas[4] = Console.ReadLine();

        }
    }
}
