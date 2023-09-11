using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaExercicioFuncao
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("DIGITE UM VALOR :");
            int n = int.Parse(Console.ReadLine());
            Console.Write("O FATORIAL DE {0} É {1} :",n,Fatorial(n));
        }
        static int Fatorial(int num)
        {
            int fat = 1;
            for (int i =1;i <= num;i++)
            {
               fat = fat * i;
            }
            return fat;
        }
    }
}
