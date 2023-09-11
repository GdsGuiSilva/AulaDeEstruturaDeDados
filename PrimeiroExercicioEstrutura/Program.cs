using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroExercicioEstrutura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor : ");
            int v1 = int.Parse(Console.ReadLine());
            Console.Write("Digite um valor :");
            int v2 = int.Parse(Console.ReadLine());
            int soma = v1 + v2;
            Console.Write("O valor {0} somado com {1} é igual a {2}",v1,v2,soma);
        }
    }
}
