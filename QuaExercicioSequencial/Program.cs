using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaExercicioSequencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor : ");
            int v1 = int.Parse(Console.ReadLine());
            v1 = v1 * v1;
            Console.Write("O valor é : {0} ", v1);
        }
    }
}
