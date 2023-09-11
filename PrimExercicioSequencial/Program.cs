using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PrimExercicioSequencial
{
    public class Program
    {
        public static int Soma(int a,int b)
        {
           return a + b;
        }
        static void Main(string[] args)
        {
            Console.Write("Digie um valor :");
            int v1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro valor :");
            int v2 = int.Parse(Console.ReadLine());
            Console.Write("A soma dos valores é {0}:",Soma(v1,v2));
        }
    }
}
