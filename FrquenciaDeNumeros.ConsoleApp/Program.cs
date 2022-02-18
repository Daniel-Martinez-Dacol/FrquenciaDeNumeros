using System;

namespace FrquenciaDeNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite a quantidade de numeros analisados: ");
            int quantidadeDeNumeros = int.Parse(Console.ReadLine());

            int[] valoresAnalisados = new int[quantidadeDeNumeros];

            for (int i = 0; i < quantidadeDeNumeros; i++)
            {
                Console.Write("Digite o numero: ");
                valoresAnalisados[i] = int.Parse(Console.ReadLine());
               
            }
            
            for (int i = 0; i < valoresAnalisados.Length ; i++)
            {
                int contador = 0;
                for (int j = 0; j < valoresAnalisados.Length; j++)
                {
                    if (valoresAnalisados[i] == valoresAnalisados[j])
                    {
                        contador += 1;
                    }
                }
                Console.WriteLine($"{valoresAnalisados[i]} aparece {contador} vez(es)");
            }
           
            Console.ReadLine();

            //char[] valores = numerosAdicionados.ToCharArray
        }
    }
}
