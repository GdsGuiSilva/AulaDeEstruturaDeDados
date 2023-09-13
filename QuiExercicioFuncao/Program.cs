using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiExercicioFuncao
{
    public class Program
    {
        static void Main(string[] args)
        {
            const int TAM = 10;
            int[] v = new int[TAM];
            Random rand = new Random();
            for (int i = 0; i < TAM; i++)
            {
                v[i] = rand.Next(1, 50);
            }
            Console.WriteLine("O MAIOR VALOR DO VETOR É {0}:", Maior(v));
        }
        static int Maior(int[] vet)
        {
            int maior = vet[0];
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] > maior)
                {
                    maior = vet[i];
                }
            }
            return maior;
        }
    }
}