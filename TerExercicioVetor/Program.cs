using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerExercicioVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int TAM = 10;
            String[] nomes = new string[TAM];
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("DIGITE OS NOMES :");
                nomes[i] = Console.ReadLine();
            }
            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i].StartsWith("A",StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(nomes[i]);
                }
            }
        }
    }
}