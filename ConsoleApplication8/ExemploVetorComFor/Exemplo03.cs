using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploVetorComFor
{
    class Exemplo03
    {
        public Exemplo03()
        {
            Console.Write("Digite a Quantidade de Registros Que Deseja Cadastrar: ");
            int quantidadeRegistros = Convert.ToInt32(Console.ReadLine());
            
            string[] fazendas = new string[quantidadeRegistros];
            int[] quantidadePorcos = new int[quantidadeRegistros];
            
            for (int i = 0; i < fazendas.Length; i++)
            {

            }
            for (int i = 0; i < fazendas.Length; i++)
            {
                Console.Write("Nome Da Fazenda: ");
                fazendas[i] = Console.ReadLine();
                Console.Write("Quantidade de Suinos: ");
                quantidadePorcos[i] = Convert.ToInt32(Console.ReadLine());
            }
                // Fazenda com maior quantidade de suinos
                
                int maiorQuantidadedeSuinos = int.MinValue;
                string fazendaMaiorQuantidadedePorcos = "";
                for (int i = 0; i < quantidadePorcos.Length; i++)
                {
                    if (quantidadePorcos[i] > maiorQuantidadedeSuinos)
                    {
                        maiorQuantidadedeSuinos = quantidadePorcos[i];
                        fazendaMaiorQuantidadedePorcos = fazendas[i];
                    }

                }
                Console.WriteLine("Fazenda com Maior Quantidade De suinos: " + fazendaMaiorQuantidadedePorcos + "Contém " +maiorQuantidadedeSuinos);
                
                // Fazenda com menor nome
                string menorNome = "";
                for (int i = 0; i < 1000; i++)
                {
                    if (i % 2 == 0)
                    {
                        menorNome = menorNome + "a";
                    }
                    else
                    {
                        menorNome = menorNome + "e";
                    }

                }


                    for (int i = 0; i < fazendas.Length; i++)
                    {
                        if(fazendas[i].Length < menorNome.Length)
                        {
                            menorNome = fazendas[i];
                        }
                    }
                    Console.WriteLine("Fazenda Com Menor Nome" + menorNome);

                }

                    


            }

            
        }
    }
}
