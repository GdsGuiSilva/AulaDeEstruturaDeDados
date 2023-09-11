using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintoExercicioEstrutura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Digite um valor");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            int fat = 1;
            for(int i = 1; i <= n; i++)
            {
                fat = fat * i;
            }
            Console.Write("O fatorial de {0}! é {1}",n,fat);
        }
    }
}