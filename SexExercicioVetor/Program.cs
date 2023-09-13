using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SexExercicioVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int TAM = 5;
            int[] vector = new int[TAM];
            float media = 0;
            int soma = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("Digite os valores :");
                vector[i] = int.Parse(Console.ReadLine());
                soma = vector[i] + soma;
            }
            media = soma / TAM;
            Console.Write("A media é {0}", media);
        }
    }
}
