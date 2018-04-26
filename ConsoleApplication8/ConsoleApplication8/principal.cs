using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class exemplo04
    {
        public static void Main2(string[] args)
        {
            int soma = 0, maiornumero = int.MinValue, menornumero = int.MaxValue;
            Console.WriteLine(maiornumero);
            string historico = "";
            
            
            Console.WriteLine("Digite um Numero, Caso Queira sair Digite 8001");
            int numero = Convert.ToInt32(Console.ReadLine());
            
            int quantidade = 0, quantidadepositivo = 0,quantidadenegativo = 0, quantidadeneutro = 0;
            while (numero != 8001) 
            {
                soma = soma + numero;
                quantidade = quantidade + 1;

                historico = historico + numero + ",";

                
                
                if (numero > menornumero)
                {
                    maiornumero = numero;
                }
                if (numero < menornumero)
                {
                    menornumero = numero;
                }

                if (numero > 0)
                {
                    quantidadepositivo = quantidadepositivo + 1;
                }
                else if (numero != 0)
                {
                    quantidadenegativo = quantidadenegativo + 1;
                }
                else
                {
                    quantidadeneutro = quantidadeneutro + 1;
                }
                Console.Write("Digite um numero,para sair digite 8001: ");
                numero = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            double media = soma / quantidade;
            Console.WriteLine("soma: " + soma);
            Console.WriteLine("Média: " + media);
            Console.WriteLine("Menor Numero: " + menornumero);
            Console.WriteLine("Maior Numero: " + maiornumero);
            Console.WriteLine("Quantidade Positivos: " + quantidadepositivo);
            Console.WriteLine("Quantidade Negativos: " + quantidadenegativo);
            Console.WriteLine("Quantidade Neutro: " + quantidadeneutro);
            Console.WriteLine("historico: " + historico);

        }
        
    }
}
