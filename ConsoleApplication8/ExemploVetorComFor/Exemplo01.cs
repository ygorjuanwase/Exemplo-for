using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploVetorComFor
{
    class Exemplo01
    {
        public Exemplo01()
        {
            string[] mortesDoFilme = new string[5];
            //FORMA OLD
            //morteDoFilme[0] = "Tony Stark";

            // ARMAZENAR AS INFORMAÇOES NO VETOR
            for (int i = 0; i < mortesDoFilme.Length; i++)
            {
                Console.Write("Digite o Nome da Pessoa: ");
                mortesDoFilme[i] = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Pessoas Cadastradas: ");
            //APRESENTAR AS INFORMAÇOES DO VETOR
            for (int i = 0; i < mortesDoFilme.Length; i++)
            {
                Console.WriteLine("Nome: " + mortesDoFilme[i]);
            }
        }
    }
}
