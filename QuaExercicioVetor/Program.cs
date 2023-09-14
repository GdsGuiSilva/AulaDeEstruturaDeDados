using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaExercicioVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int TAM = 10;
            int[] vector = new int[TAM];
            Random rand = new Random();
            for(int i = 0; i < vector.Length; i++)
            {
                vector[i] = rand.Next(1,40);
            }
            int maior = vector[0];
            int menor = vector[0];
            for(int i = 0;i < vector.Length; i++)
            {
                if (vector[i] > maior)
                {
                    vector[i] = maior;
                }
                if (vector[i] < menor)
                {
                    menor = vector[i];
                }
            }
            Console.Write("O maior valor dentro do vetor é : {0}", maior);
            Console.Write("O menor valor dentro do vetor é : {0}", menor);
        }
    }
}
