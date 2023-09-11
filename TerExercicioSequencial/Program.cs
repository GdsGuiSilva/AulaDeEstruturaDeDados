using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerExercicioSequencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor inteiro : ");
            String valor = Console.ReadLine();
            float v1 = float.Parse(valor);
            v1 = v1 * 2;
            Console.Write(v1);
        }
    }
}
