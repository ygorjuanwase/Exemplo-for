using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Exemplowhile04
    {
        static void Main2(string[] args)
        {
            int quantidade = 0;
            Console.Write("Deseja cadastrar: ");
            string continuar = Console.ReadLine().ToLower();
            continuar = continuar.ToLower();
            while (continuar =="sim")
            {
                Console.Write("Valor Hora: ");
                double valorhora = Convert.ToDouble(Console.ReadLine());
                Console.Write("Quantidade de Horas: ");
                int quantidadehoras = Convert.ToInt32(Console.ReadLine());
                double salario = valorhora * quantidadehoras;
                Console.WriteLine("Salário" + salario);
                Console.Write("Deseja Cadastrar Novamente: ");
                continuar = Console.ReadLine().ToLower();
                quantidade = quantidade + 1;   
            }
            Console.Write("Quantidade de Pessoas Cadastradas: " + quantidade);

        }
    }
}
