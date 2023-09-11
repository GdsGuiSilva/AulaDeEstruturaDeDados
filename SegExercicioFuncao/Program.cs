using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegExercicioFuncao
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero : ");
            int n = int.Parse(Console.ReadLine());
            if(Primo(n) == true)
            {
                Console.Write("É PRIMO");
            }
            else
            {
                Console.WriteLine("NÃO É PRIMO");
            }
        }
        static bool Primo(int num)
        {
            int cont = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    cont++;
                }
            }
            if (cont == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
